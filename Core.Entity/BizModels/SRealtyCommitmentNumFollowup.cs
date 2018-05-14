using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SRealtyCommitmentNumFollowup
    {
        public int Id { get; set; }
        public int? AuditSourceId { get; set; }
        public int? SourceId { get; set; }
        public int? BizoperationType { get; set; }
        public string BizoperationName { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Message { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? SubbizType { get; set; }
    }
}
