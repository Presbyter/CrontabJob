using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SmsTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int? DaySendLimit { get; set; }
        public int? GroupSendLimit { get; set; }
        public int? AddEmpInfo { get; set; }
        public int? Deleted { get; set; }
        public int? AllowEdit { get; set; }
        public int? OrderNo { get; set; }
    }
}
