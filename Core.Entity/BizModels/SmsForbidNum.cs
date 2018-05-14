using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SmsForbidNum
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public int EmployeeId { get; set; }
        public DateTime InputDatetime { get; set; }
    }
}
