using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class ScheduleTimeDef
    {
        public int Id { get; set; }
        public string ScheduleTimeName { get; set; }
        public string ShowName { get; set; }
        public bool? Isvacation { get; set; }
    }
}
