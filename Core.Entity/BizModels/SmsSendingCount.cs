using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SmsSendingCount
    {
        public int EmployeeId { get; set; }
        public int Count { get; set; }
        public bool SendingFlag { get; set; }
        public bool Permission { get; set; }
        public string PermissionMemo { get; set; }
        public DateTime? Date { get; set; }
    }
}
