using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace C21.SIS.Jobs
{
    public static class ConfigHelper
    {
        private static IConfiguration _config;
        private static IConfiguration Config
        {
            get
            {
                if (null == _config)
                {
                    _config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
                }

                return _config;
            }
        }
        public static string ConnectionString => Config.GetConnectionString("DefaultConnection");
        public static string HcisHrMqUri => Config.GetSection("AppSettings")["HcisHr_mq_uri"];
        public static string UnityAccountMqUri => Config.GetSection("AppSettings")["UnityAccount_mq_uri"];
        public static string HcisEmployeeMqUri => Config.GetSection("AppSettings")["HcisEmployee_mq_uri"];
        public static string TMSMqUri => Config.GetSection("AppSettings")["TMS_mq_uri"];
        public static string SISMqUri => Config.GetSection("AppSettings")["SIS_mq_uri"];
        public static string SMSMqUri => Config.GetSection("AppSettings")["SMS_mq_uri"];
        private static Dictionary<string, string> _areaConnStrDic;
        public static Dictionary<string, string> AreaConnStrDic
        {
            get
            {
                if (null == _areaConnStrDic)
                {
                    var optionsBuilder = new DbContextOptionsBuilder<CenterContext>();
                    optionsBuilder.UseSqlServer(ConnectionString);

                    using (var context = new CenterContext(optionsBuilder.Options))
                    {
                        _areaConnStrDic = new Dictionary<string, string>();
                        foreach (var item in context.AreasApp.ToList())
                        {
                            _areaConnStrDic.Add(item.AreaCode, item.AreaServerNameMore);
                        }
                    }
                }
                return _areaConnStrDic;
            }
        }
    }
}