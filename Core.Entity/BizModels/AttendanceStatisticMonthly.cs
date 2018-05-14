using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class AttendanceStatisticMonthly
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeNum { get; set; }
        public string EmployeeName { get; set; }
        public int? Position { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ResignDate { get; set; }
        public string BizteamName { get; set; }
        public string RegionName { get; set; }
        public string BigregionName { get; set; }
        public string BizdepartmentName { get; set; }
        public string CisPositionName { get; set; }
        public string ShopName { get; set; }
        public decimal? ReqAttendanceDays { get; set; }
        public decimal? AttendanceDays { get; set; }
        public decimal? LeaveDays { get; set; }
        public byte? LateInQuarter { get; set; }
        public byte? LateInHalfhour { get; set; }
        public byte? LateOverHalfhour { get; set; }
        public byte? AbsenceDays { get; set; }
        public decimal? AbsenceSheetDays { get; set; }
        public decimal? SickAbsenceDays { get; set; }
        public DateTime Date { get; set; }
    }
}
