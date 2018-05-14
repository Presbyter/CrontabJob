using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class UserCustom
    {
        public int EmployeeId { get; set; }
        public int Type { get; set; }
        public string Custom { get; set; }
        public DateTime? CustomVersion { get; set; }
    }
}
