using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class UPhonedealHistory
    {
        public Guid Id { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? SourceId { get; set; }
        public int? ContactorId { get; set; }
        public int? ContactorType { get; set; }
        public int? UseType { get; set; }
        public int? RealtyType { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
