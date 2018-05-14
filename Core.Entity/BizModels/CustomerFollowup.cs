using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CustomerFollowup
    {
        public int Id { get; set; }
        public int AuditSourceId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? CustomerFollowupType { get; set; }
        public string CustomerFollowupName { get; set; }
        public int? TradeType { get; set; }
        public int? BusinessType { get; set; }
        public string Ip { get; set; }
        public string MachineName { get; set; }
        public string AccountId { get; set; }
        public string RoleName { get; set; }
        public string Message { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
