using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SubwayLines
    {
        public int LineId { get; set; }
        public string LineName { get; set; }
        public string Pinyin { get; set; }
        public int? Index { get; set; }
        public bool? DeleteFlag { get; set; }
    }
}
