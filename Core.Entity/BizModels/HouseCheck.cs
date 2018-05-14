using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class HouseCheck
    {
        public int Id { get; set; }
        public string HouseCheckNo { get; set; }
        public int Realtyid { get; set; }
        public int CheckEmployeeId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? DeleteFlag { get; set; }
        public string CheckEmployeeName { get; set; }
        public int CheckDepartmentId { get; set; }
        public string CheckDepartmentName { get; set; }
    }
}
