using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class AttendanceDaily
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? LateTime { get; set; }
        public int? LeaveTime { get; set; }
        public bool? AbsenceFlag { get; set; }
        public string AttendanceStatus { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateTime? Date { get; set; }
        public string EmployeeNum { get; set; }
        public int? OldLateTime { get; set; }
        public int? OldLeaveTime { get; set; }
    }
}
