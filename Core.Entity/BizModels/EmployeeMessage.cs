using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class EmployeeMessage
    {
        public int Id { get; set; }
        public Guid? Guid { get; set; }
        public int? MsgCode { get; set; }
        public DateTime? MsgTime { get; set; }
        public int? MsgState { get; set; }
        public DateTime? RespTime { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public Guid? CisPosition { get; set; }
        public string CisPositionName { get; set; }
        public int? Sex { get; set; }
        public int? CertificationType { get; set; }
        public string CertificationId { get; set; }
        public int? Education { get; set; }
        public string University { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ResignDate { get; set; }
        public int? PositionStatus { get; set; }
        public DateTime? ValidDate { get; set; }
        public string DepartmentName { get; set; }
        public string Photo { get; set; }
        public string WorkPhone { get; set; }
        public string Memo { get; set; }
        public string ShopPhone { get; set; }
        public string ShopPhoneOpx { get; set; }
        public int? AccountId { get; set; }
        public string AccountCd { get; set; }
    }
}
