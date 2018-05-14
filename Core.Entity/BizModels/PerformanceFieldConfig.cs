using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class PerformanceFieldConfig
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? FieldType { get; set; }
        public bool? IsDefault { get; set; }
        public string Name { get; set; }
        public string Config { get; set; }
    }
}
