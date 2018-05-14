using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SRealtyFollowup
    {
        public int Id { get; set; }
        public int? AuditSourceId { get; set; }
        public int? BizoperationType { get; set; }
        public string BizoperationName { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Ip { get; set; }
        public string MachineName { get; set; }
        public string AccountId { get; set; }
        public string RoleName { get; set; }
        public string Message { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? SubbizType { get; set; }
        public bool? Flag { get; set; }
        public int BizopTypeCalc { get; set; }
    }
}
