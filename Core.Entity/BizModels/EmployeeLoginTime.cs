using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity.BizModels
{
    [Table("V_GetEmployeeOperatorTime")]
    public class EmployeeLoginTime
    {
        [Key]
        public int UnifiedAccountId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeNum { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? LastLogoutTime { get; set; }
        public DateTime? LastLoginTime { get; set; }
    }
}