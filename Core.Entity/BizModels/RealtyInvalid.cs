using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RealtyInvalid
    {
        public int Id { get; set; }
        public int? RealtyId { get; set; }
        public string RealtyNum { get; set; }
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
