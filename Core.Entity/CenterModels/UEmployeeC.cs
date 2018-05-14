using System;
using System.Collections.Generic;

namespace Core.Entity.CenterModels
{
    public partial class UEmployeeC
    {
        public Guid EmpId { get; set; }
        public string EmpName { get; set; }
        public string EnglishName { get; set; }
        public string EmpCardNo { get; set; }
        public byte? EmpSex { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte? UseSis { get; set; }
        public Guid? RoleId { get; set; }
        public string Tel { get; set; }
        public string Fix { get; set; }
        public string EMail { get; set; }
        public string EmpAddr { get; set; }
        public string EmpPostZip { get; set; }
        public DateTime? EmpBirth { get; set; }
        public DateTime? EmpDeptTime { get; set; }
        public string Memo { get; set; }
        public byte? Deleted { get; set; }
    }
}
