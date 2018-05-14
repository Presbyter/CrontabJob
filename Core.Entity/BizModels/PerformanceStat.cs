using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class PerformanceStat
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? StatDate { get; set; }
        public int? BaseItemId { get; set; }
        public decimal? ItemValue { get; set; }
        public decimal? ItemValueScore { get; set; }
        public decimal? ItemScore { get; set; }
        public bool? ApproveStatus { get; set; }
    }
}
