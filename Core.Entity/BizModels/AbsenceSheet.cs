using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class AbsenceSheet
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeNum { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? StartFlag { get; set; }
        public int? EndFlag { get; set; }
        public int? CreateId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? SheetType { get; set; }
        public string Memo { get; set; }
    }
}
