using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class AttendantSheet
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeNum { get; set; }
        public int? ScheduleId { get; set; }
        public DateTime? Date { get; set; }
        public int? ScheduleTimeId { get; set; }
        public string EmployeeName { get; set; }
    }
}
