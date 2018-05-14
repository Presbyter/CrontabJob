using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class ScheduleDef
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ShowName { get; set; }
        public DateTime? EffectiveDate { get; set; }
    }
}
