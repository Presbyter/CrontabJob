using System;
using System.Collections.Generic;

namespace Core.Entity.CenterModels
{
    public partial class UAreaCount
    {
        public int Tid { get; set; }
        public Guid AreaId { get; set; }
        public int? RecordCount { get; set; }
        public int? AreaCount { get; set; }
        public double? FldCount { get; set; }
        public string AgentCode { get; set; }
        public int? GfzCount { get; set; }
        public int? KbCount { get; set; }
        public long? KbAll { get; set; }
    }
}
