using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RoleConfig
    {
        public Guid RoleId { get; set; }
        public int? SendingSmsDays { get; set; }
        public int? DailySendingSmsNum { get; set; }
        public int? SendingSmsNumEverytime { get; set; }
        public int? AllocatedSmsNum { get; set; }
        public string DefaultMenu { get; set; }
        public bool? IsPersonnelAttendance { get; set; }
        public bool? IsHaveCloseTeam { get; set; }
        public int? SmsdayRepeatRealty { get; set; }
        public int? SmsdayRepeatCustomer { get; set; }
        public bool? PerformanceFieldVisible { get; set; }
        public bool? IsInspectSpecialized { get; set; }
    }
}
