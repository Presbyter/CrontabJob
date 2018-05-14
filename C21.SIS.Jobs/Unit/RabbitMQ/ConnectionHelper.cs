using System;
using RabbitMQ.Client;

namespace C21.SIS.Jobs.Unit.RabbitMQ
{
    public static class ConnectionHelper
    {
        private static IConnection HcisHrConn { get; set; }
        private static IConnection HcisEmployeeConn { get; set; }
        private static IConnection SisConn { get; set; }
        private static IConnection TmsConn { get; set; }
        private static IConnection SmsConn { get; set; }
        private static IConnection UnityAccountConn { get; set; }

        // 创建RabbitMQ连接
        private static IConnection CreateConnection(string uri)
        {
            var factory = new ConnectionFactory
            {
                Uri = new Uri(uri),
                RequestedHeartbeat = 60,
                AutomaticRecoveryEnabled = true
            };
            var conn = factory.CreateConnection("sis_crontab");
            conn.ConnectionShutdown += RabbitMqConnectionShutdownEvent;
            return conn;
        }

        // RabbitMQ断开连接事件
        private static void RabbitMqConnectionShutdownEvent(object sender, ShutdownEventArgs e)
        {
            throw new Exception("RabbitMQ connection was disconnected!");
        }

        // 获取连接字符串
        private static string GetConnectionString(SystemEnum systemEnum)
        {
            switch (systemEnum)
            {
                case SystemEnum.HCIS_HR:
                    return ConfigHelper.HcisHrMqUri;
                case SystemEnum.HCIS_Employee:
                    return ConfigHelper.HcisEmployeeMqUri;
                case SystemEnum.TMS:
                    return ConfigHelper.TMSMqUri;
                case SystemEnum.SIS:
                    return ConfigHelper.SISMqUri;
                case SystemEnum.UnityAccount:
                    return ConfigHelper.UnityAccountMqUri;
                case SystemEnum.SMS:
                    return ConfigHelper.SMSMqUri;
                default:
                    throw new ArgumentOutOfRangeException("systemEnum", "SystemEnum传入了不存在的值");
            }
        }

        // 获取RabbitMQ连接
        public static IConnection GetConnection(SystemEnum systemEnum)
        {
            var connUri = GetConnectionString(systemEnum);

            switch (systemEnum)
            {
                case SystemEnum.HCIS_HR:
                    if (null == HcisHrConn)
                    {
                        HcisHrConn = CreateConnection(connUri);
                    }
                    return HcisHrConn;
                case SystemEnum.HCIS_Employee:
                    if (null == HcisEmployeeConn)
                    {
                        HcisEmployeeConn = CreateConnection(connUri);
                    }
                    return HcisEmployeeConn;
                case SystemEnum.TMS:
                    if (null == TmsConn)
                    {
                        TmsConn = CreateConnection(connUri);
                    }
                    return TmsConn;
                case SystemEnum.SIS:
                    if (null == SisConn)
                    {
                        SisConn = CreateConnection(connUri);
                    }
                    return SisConn;
                case SystemEnum.UnityAccount:
                    if (null == UnityAccountConn)
                    {
                        UnityAccountConn = CreateConnection(connUri);
                    }
                    return UnityAccountConn;
                case SystemEnum.SMS:
                    if (null == SmsConn)
                    {
                        SmsConn = CreateConnection(connUri);
                    }
                    return SmsConn;
                default:
                    throw new ArgumentOutOfRangeException("systemEnum", "SystemEnum传入了不存在的值");
            }
        }
    }
}