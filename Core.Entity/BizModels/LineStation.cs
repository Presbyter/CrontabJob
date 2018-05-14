using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class LineStation
    {
        public int LineId { get; set; }
        public int StationId { get; set; }
        public int? Index { get; set; }
    }
}
