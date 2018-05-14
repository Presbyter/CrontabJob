using C21.SIS.Jobs.Service.RpcClient;
using C21.SIS.Jobs.Unit.Log;
using C21.SIS.Jobs.Unit.RabbitMQ;
using Core.Entity;
using Core.Entity.BizModels;
using Microsoft.EntityFrameworkCore;
using NLog;
using Quartz;
using RabbitMQ.Client;
using RabbitMQ.Client.MessagePatterns;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace C21.SIS.Jobs.Unit.Jobs
{
    public class RefreshEmployeeStatus : IJob
    {
        private Log.ILogger _log;

        public RefreshEmployeeStatus()
        {
            _log = new NLogger(LogManager.GetCurrentClassLogger());
        }

        public async Task Execute(IJobExecutionContext context)
        {
            foreach (var item in ConfigHelper.AreaConnStrDic.Keys)
            {
                if ("B024" == item)
                    await Task.Run(async () =>
                    {
                        try
                        {
                            var connStr = ConfigHelper.AreaConnStrDic[item];

                            var optionsBuilder = new DbContextOptionsBuilder<BIZContext>();
                            optionsBuilder.UseSqlServer(connStr);
                            using (var bizContext = new BIZContext(optionsBuilder.Options))
                            {
                                // 读取用户最后登录事件视图
                                var employeeLoginTimes = bizContext.EmployeeLoginTime.FromSql("SELECT * FROM dbo.V_GetEmployeeOperatorTime")
                                    .Where(m => m.LastLoginTime.HasValue || m.LastLogoutTime.HasValue).Select(m => new EmployeeLoginTime
                                    {
                                        UnifiedAccountId = m.UnifiedAccountId,
                                        EmployeeName = m.EmployeeName,
                                        EmployeeId = m.EmployeeId,
                                        EmployeeNum = m.EmployeeNum,
                                        DepartmentId = m.DepartmentId,
                                        DepartmentName = m.DepartmentName,
                                        LastLogoutTime = m.LastLogoutTime.HasValue ? m.LastLogoutTime.Value : new DateTime(1970, 1, 1, 0, 0, 0),
                                        LastLoginTime = m.LastLoginTime.HasValue ? m.LastLoginTime.Value : new DateTime(1970, 1, 1, 0, 0, 0)
                                    }).ToList();
                                foreach (var eTime in employeeLoginTimes)
                                {
                                    var lastTime = eTime.LastLoginTime.Value > eTime.LastLogoutTime.Value ? eTime.LastLoginTime.Value : eTime.LastLogoutTime.Value;
                                    // 判断是否超出72小时
                                    // if (72 <= DateTime.Now.Subtract(lastTime).Hours)
                                    // 临时测试 10分钟冻结账号
                                    if (10 <= DateTime.Now.Subtract(lastTime).Minutes)
                                    {
                                        // 冻结此账号
                                        using (var channel = ConnectionHelper.GetConnection(SystemEnum.UnityAccount).CreateModel())
                                        {
                                            var client = new UnitAccountRpcClient(channel, "UnityAccount", ExchangeType.Topic, "UnityAccount.User");
                                            client.UserFreeze(eTime.UnifiedAccountId, UnitAccountRpcClient.UserStatusEnum.Block);
                                        }
                                        // 发送事务提醒给该经纪人的直属上级（分行经理）以及该加盟商的人事负责人
                                        var deptId = await bizContext.EmployeeInfo.FromSql($"SELECT * FROM V_GetEmployeeInfo WHERE UnifiedAccountID={eTime.UnifiedAccountId}")
                                            .Select(m => m.DepartmentId).FirstOrDefaultAsync();
                                        var theManager = await bizContext.EmployeeInfo.FromSql($"SELECT * FROM V_GetEmployeeInfo WHERE DepartmentID={deptId} AND IsManager=1")
                                        .FirstOrDefaultAsync();
                                        if (null != theManager)
                                        {
                                            var newRemind = new RemindingInTime
                                            {
                                                CreatorId = 0,
                                                CreatorName = "系统提醒",
                                                CreatorDepartmentName = "系统",
                                                RecipientId = theManager.EmployeeId,
                                                RecipientName = theManager.EmployeeName,
                                                RemindingTime = DateTime.Now,
                                                Status = 0,
                                                RemindingType = 0,
                                                Content = $"【{eTime.DepartmentName}】【{eTime.EmployeeName}】的账号已冻结，原因是：三日未登录系统。",
                                                SourceType = 0,
                                                SourceSubType = 0,
                                                SourceCode = eTime.EmployeeNum,
                                                SourceId = eTime.EmployeeId.ToString()
                                            };
                                            bizContext.RemindingInTime.Add(newRemind);
                                        }
                                        // 获取所有加盟商人事负责人
                                        var franchiseesManagers = await bizContext.EmployeeInfo.FromSql(
                                                $"SELECT c.* " +
                                                $"FROM FranchiseesManager a " +
                                                $"  INNER JOIN V_GetEmployeeInfo c ON a.Account_ID = c.UnifiedAccountID " +
                                                $"WHERE a.Frc_ID IN ( " +
                                                $"  SELECT DISTINCT b.FrcID " +
                                                $"  FROM V_GetEmployeeInfo b " +
                                                $"  WHERE b.DepartmentID = {eTime.DepartmentId} " +
                                                $") AND a.Deleted_flag <> 1 " +
                                                $"AND PositionType = 0").ToListAsync();
                                        foreach (var frcManager in franchiseesManagers)
                                        {
                                            // 为每个管理者设置提醒
                                            var newRemind = new RemindingInTime
                                            {
                                                CreatorId = 0,
                                                CreatorName = "系统提醒",
                                                CreatorDepartmentName = "系统",
                                                RecipientId = frcManager.EmployeeId,
                                                RecipientName = frcManager.EmployeeName,
                                                RemindingTime = DateTime.Now,
                                                Status = 0,
                                                RemindingType = 0,
                                                Content = $"【{eTime.DepartmentName}】【{eTime.EmployeeName}】的账号已冻结，原因是：三日未登录系统。",
                                                SourceType = 0,
                                                SourceSubType = 0,
                                                SourceCode = eTime.EmployeeNum,
                                                SourceId = eTime.EmployeeId.ToString()
                                            };
                                            bizContext.RemindingInTime.Add(newRemind);
                                        }
                                        // 提交数据
                                        await bizContext.SaveChangesAsync();
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            _log.Error(ex);
                            _log.Debug($"{item} - 刷新员工状态信息失败,失败原因参照上面内容");
                        }
                    });
            }
        }
    }
}