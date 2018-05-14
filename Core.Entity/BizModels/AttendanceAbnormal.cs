using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class AttendanceAbnormal
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public int? AbnormalType { get; set; }
        public string AbnormalTypeName { get; set; }
        public string Reason { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ApproverId { get; set; }
        public bool? IsApproved { get; set; }
        public int? AttendanceId { get; set; }
        public DateTime? ApprovedDatetime { get; set; }
        public bool? IsEnable { get; set; }
        public int? CreateId { get; set; }
    }
}
