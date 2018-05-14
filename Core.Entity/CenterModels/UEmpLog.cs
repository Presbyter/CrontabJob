using System;
using System.Collections.Generic;

namespace Core.Entity.CenterModels
{
    public partial class UEmpLog
    {
        public long Id { get; set; }
        public Guid EmpId { get; set; }
        public string EmpCd { get; set; }
        public string EmpName { get; set; }
        public string Password { get; set; }
        public string AreaName { get; set; }
        public string DeptName { get; set; }
        public byte? EmpType { get; set; }
        public byte? SetType { get; set; }
    }
}
