using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Employee
    {
        public int Id { get; set; }
        public Guid? Guid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Pinyin { get; set; }
        public string Account { get; set; }
        public Guid? CisPosition { get; set; }
        public int? Position { get; set; }
        public string WorkLicense { get; set; }
        public byte? Sex { get; set; }
        public int? DepartmentId { get; set; }
        public Guid? AccountId { get; set; }
        public int? CertificationType { get; set; }
        public string CertificationId { get; set; }
        public int? Education { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string University { get; set; }
        public string Homepage { get; set; }
        public string Blog { get; set; }
        public string Introduction { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ResignDate { get; set; }
        public byte? PositionStatus { get; set; }
        public int? SisPermission { get; set; }
        public int? Nation { get; set; }
        public bool? IsPublic { get; set; }
        public byte? DepartmentType { get; set; }
        public bool? IsManager { get; set; }
        public Guid? RoleId { get; set; }
        public string CisPositionName { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? CisEntryDate { get; set; }
        public DateTime? CisResignDate { get; set; }
        public string Photo { get; set; }
        public string WorkPhone { get; set; }
        public string Memo { get; set; }
        public string Phonecode { get; set; }
        public string ShopPhone { get; set; }
        public string ShopPhoneOpx { get; set; }
        public int? UnifiedAccountId { get; set; }
    }
}
