using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Department
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? SuperDepartmentId { get; set; }
        public int? Level { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int? ManagerId { get; set; }
        public string Pinyin { get; set; }
        public string Memo { get; set; }
        public int Deleted { get; set; }
        public int? QueryCode { get; set; }
        public int? DeptIndex { get; set; }
    }
}
