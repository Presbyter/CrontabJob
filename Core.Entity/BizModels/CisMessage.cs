using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CisMessage
    {
        public int Id { get; set; }
        public Guid? DataId { get; set; }
        public byte? MsgType { get; set; }
        public DateTime? MsgTime { get; set; }
        public byte? MsgState { get; set; }
        public DateTime? RespTime { get; set; }
        public int? MsgKind { get; set; }
    }
}
