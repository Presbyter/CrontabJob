using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class EmployeeLogin
    {
        public int EmployeeId { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
}
