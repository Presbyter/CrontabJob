using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SmsEmployeeLog
    {
        public int Id { get; set; }
        public int? SenderDepartment { get; set; }
        public string SenderDepartmentName { get; set; }
        public int? Sender { get; set; }
        public string SenderName { get; set; }
        public DateTime? SenderTime { get; set; }
        public string RecieverId { get; set; }
        public int? SendNum { get; set; }
        public string Msg { get; set; }
        public int? SendMessageCount { get; set; }
    }
}
