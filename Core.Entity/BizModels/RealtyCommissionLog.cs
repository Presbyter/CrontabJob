using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RealtyCommissionLog
    {
        public int Id { get; set; }
        public int? RealtyId { get; set; }
        public byte? CommissionType { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
