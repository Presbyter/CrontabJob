using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class BambooRealty
    {
        public int Id { get; set; }
        public int? RealtyId { get; set; }
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public string ApplyContent { get; set; }
        public DateTime? ApplicationDatetime { get; set; }
        public int? ApprovedId { get; set; }
        public DateTime? ApprovedDatetime { get; set; }
        public int? ApprovedStatus { get; set; }
    }
}
