using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SRealtyReadLog
    {
        public int Id { get; set; }
        public int? AuditSourceId { get; set; }
        public int? ReadType { get; set; }
        public string ReadTypeName { get; set; }
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
        public bool? D { get; set; }
    }
}
