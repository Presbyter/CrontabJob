using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SmsActualLogDetail
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string Code { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string RoleName { get; set; }
        public int? ContactorId { get; set; }
        public string Tel { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? SmsOrder { get; set; }
        public string SmsContent { get; set; }
        public int? SmstemplateId { get; set; }
        public string SmsResult { get; set; }
    }
}
