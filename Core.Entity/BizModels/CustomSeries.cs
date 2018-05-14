using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CustomSeries
    {
        public int SeriesId { get; set; }
        public string SeriesName { get; set; }
        public string SeriesContent { get; set; }
        public string Example { get; set; }
    }
}
