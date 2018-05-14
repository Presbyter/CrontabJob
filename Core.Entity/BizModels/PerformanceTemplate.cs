using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class PerformanceTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Values { get; set; }
        public bool? IsActive { get; set; }
        public int? CreateEmployeeId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Memo { get; set; }
    }
}
