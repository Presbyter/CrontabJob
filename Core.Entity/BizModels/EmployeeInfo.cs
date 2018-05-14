using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity.BizModels
{
    [Table("V_GetEmployeeInfo")]
    public class EmployeeInfo
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeNum { get; set; }
        public byte DepartmentType { get; set; }
        public string Phone { get; set; }
        public int Position { get; set; }
        public int PositionLevel { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ResignDate { get; set; }
        public string EmployeeName { get; set; }
        public string Account { get; set; }
        public Guid AccountId { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? ShopId { get; set; }
        public string ShopPhone { get; set; }
        public int? FrcId { get; set; }
        public string PinYin { get; set; }
        public byte PositionStatus { get; set; }
        public bool IsPublic { get; set; }
        public Guid RoleId { get; set; }
        public string CISPositionName { get; set; }
        public bool IsManager { get; set; }
        public int SISPermission { get; set; }
        public Guid Guid { get; set; }
        public int? UnifiedAccountId { get; set; }
        [Column("sis_permission")]
        public int SisPermission { get; set; }
    }
}