using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Blacklist
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public string CertificationId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? InputDatetime { get; set; }
        public byte? IsPhone { get; set; }
    }
}
