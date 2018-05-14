using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class BusinessShop
    {
        public int Id { get; set; }
        public Guid? Guid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int? Status { get; set; }
        public int? Funds { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Pinyin { get; set; }
        public int? AuditStatus { get; set; }
        public int Deleted { get; set; }
        public string LicenceName { get; set; }
        public int? DeptIndex { get; set; }
    }
}
