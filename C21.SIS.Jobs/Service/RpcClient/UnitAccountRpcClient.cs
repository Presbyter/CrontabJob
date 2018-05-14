using System.Collections.Generic;
using System.Text;
using C21.SIS.Jobs.Unit.Log;
using Newtonsoft.Json;
using NLog;
using RabbitMQ.Client;
using RabbitMQ.Client.Framing;
using RabbitMQ.Client.MessagePatterns;

namespace C21.SIS.Jobs.Service.RpcClient
{
    public class UnitAccountRpcClient : SimpleRpcClient
    {
        private static Unit.Log.ILogger _log = new NLogger(LogManager.GetCurrentClassLogger());

        public UnitAccountRpcClient(IModel model) : base(model)
        {
        }

        public UnitAccountRpcClient(IModel model, string queueName) : base(model, queueName)
        {
        }

        public UnitAccountRpcClient(IModel model, PublicationAddress address) : base(model, address)
        {
        }

        public UnitAccountRpcClient(IModel model, string exchange, string exchangeType, string routingKey) : base(model, exchange, exchangeType, routingKey)
        {
        }

        // 冻结或者解冻用户账号
        public void UserFreeze(int unifiedAccountId, UserStatusEnum userStatus)
        {
            try
            {
                var paramDic = new Dictionary<string, object>
                {
                    {"FunctionName", "UserFreeze"},
                    {"Parameters", new Dictionary<string, object>
                        {
                            {"id", unifiedAccountId},
                            {"UserStatus", userStatus}
                        }
                    }
                };
                var paramJson = JsonConvert.SerializeObject(paramDic);
                var msgBytes = Encoding.UTF8.GetBytes(paramJson);
                var prop = new BasicProperties();
                prop.ContentType = "application/json";
                prop.ContentEncoding = "UTF-8";

                IBasicProperties replyProp = new BasicProperties();
                var responseBytes = this.Call(prop, msgBytes, out replyProp);

                var responseStr = Encoding.UTF8.GetString(responseBytes);
                // 记录日志
                _log.Debug($"冻结或者解冻用户账号\n\trequest parameter: {paramJson} \n\tresponse message: {responseStr}");
            }
            catch (System.Exception ex)
            {
                _log.Error(ex);
            }

        }

        public enum UserStatusEnum
        {
            /// <summary>
            /// 解冻
            /// </summary>
            Deblock = 0,
            /// <summary>
            /// 冻结
            /// </summary>
            Block = 2
        }
    }
}