using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class ContactReadCount
    {
        public int EmployeeId { get; set; }
        public int? Count { get; set; }
        public int? OtherCount { get; set; }
        public DateTime Date { get; set; }
    }
}
