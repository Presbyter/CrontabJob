using System;
using System.Linq;
using System.Threading.Tasks;
using C21.SIS.Jobs.Unit.Log;
using Core.Entity;
using Core.Entity.BizModels;
using Microsoft.EntityFrameworkCore;
using NLog;
using Quartz;

namespace C21.SIS.Jobs.Unit.Jobs
{
    public class RefreshRealtyStationsJob : IJob
    {
        private Log.ILogger _log;

        public RefreshRealtyStationsJob()
        {
            _log = new NLogger(LogManager.GetCurrentClassLogger());
        }

        public async Task Execute(IJobExecutionContext context)
        {
            foreach (var item in ConfigHelper.AreaConnStrDic.Keys)
            {
                // await Task.Run(async () =>
                // {
                try
                {
                    var connStr = ConfigHelper.AreaConnStrDic[item];

                    var optionsBuilder = new DbContextOptionsBuilder<BIZContext>();
                    optionsBuilder.UseSqlServer(connStr);
                    using (var bizContext = new BIZContext(optionsBuilder.Options))
                    {
                        var realtyList = bizContext.Realty.Where(m => m.RealtyStatus == 0 && m.CommunityId.HasValue)
                                        .Select(m => new
                                        {
                                            m.RealtyId,
                                            m.CommunityId
                                        }).ToList();
                        var communityIds = realtyList.Select(m => m.CommunityId).Distinct();
                        var communityList = bizContext.Community.Where(m => communityIds.Contains(m.CommunityId)).Select(m => new { m.CommunityId, m.SubwayLine }).ToList();
                        foreach (var rItem in realtyList)
                        {
                            var realty = new Realty { RealtyId = rItem.RealtyId };
                            realty.Stations = communityList.Where(m => m.CommunityId == rItem.CommunityId).Select(m => m.SubwayLine).FirstOrDefault();
                            bizContext.Entry(realty).Property("Stations").IsModified = true;
                            await bizContext.SaveChangesAsync();
                            _log.Debug($"{item} RealtyId:{realty.RealtyId} Stations:{realty.Stations} updated");
                        }
                        _log.Debug($"{item} - 刷新房源地铁信息完成");
                    }
                }
                catch (Exception ex)
                {
                    _log.Error(ex);
                    _log.Debug($"{item} - 刷新房源地铁信息失败,失败原因参照上面内容");
                }
                // });
            }
        }
    }
}