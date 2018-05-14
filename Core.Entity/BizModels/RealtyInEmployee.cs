using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RealtyInEmployee
    {
        public int EmployeeId { get; set; }
        public int RealtyId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
