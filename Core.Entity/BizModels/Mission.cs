using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Mission
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public int? BizType { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? EmployeeDepartmentId { get; set; }
        public string EmployeeDepartmentName { get; set; }
        public int? ApproveEmployeeId { get; set; }
        public string ApproveEmployeeName { get; set; }
        public int? ApproveDepartmentId { get; set; }
        public string ApproveDepartmentName { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public DateTime? ExpectedApprovedDatetime { get; set; }
        public string MissionDescription { get; set; }
        public string TradeType { get; set; }
        public int? ToTradeType { get; set; }
        public string TradeStatus { get; set; }
        public int? ToTradeStatus { get; set; }
        public int? PublicCustomerType { get; set; }
        public int? ToPublicCustomerType { get; set; }
        public string EmployeeType { get; set; }
        public string OldEmployeeName { get; set; }
        public int? ToEmployeeId { get; set; }
        public string ToEmployeeName { get; set; }
        public int? ToEmployeeDepartmentId { get; set; }
        public string ToEmployeeDepartmentName { get; set; }
        public string CompletedMemo { get; set; }
        public int? SourceId { get; set; }
        public string SourceNum { get; set; }
        public int? SourceSubType { get; set; }
        public byte? Completed { get; set; }
        public DateTime? CompletedDatetime { get; set; }
    }
}
