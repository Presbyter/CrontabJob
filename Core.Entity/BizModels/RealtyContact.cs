using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RealtyContact
    {
        public int Id { get; set; }
        public int? RealtyId { get; set; }
        public string Name { get; set; }
        public byte[] Phone { get; set; }
        public byte[] PhonePre { get; set; }
        public byte[] PhonePost { get; set; }
        public byte[] PhoneCompare { get; set; }
        public string Fax { get; set; }
        public byte? Relation { get; set; }
        public string Email { get; set; }
        public int? Appellation { get; set; }
        public int? NativePlace { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? DeleteFlag { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string CommitmentNum { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public byte? PhoneType { get; set; }
        public int? PhoneStatus { get; set; }
        public DateTime? CheckPhoneTime { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
