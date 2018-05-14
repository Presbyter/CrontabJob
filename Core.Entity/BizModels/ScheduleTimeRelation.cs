using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class ScheduleTimeRelation
    {
        public int ScheduleId { get; set; }
        public int ScheduleTimeId { get; set; }
        public TimeSpan CheckinTime { get; set; }
        public TimeSpan CheckoutTime { get; set; }
    }
}
