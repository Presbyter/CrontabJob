using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class DictionaryItem
    {
        public int RuleId { get; set; }
        public int ItemNum { get; set; }
        public string Prefix { get; set; }
        public string Postfix { get; set; }
        public int? CustomSeriesId { get; set; }
        public int? SeriesType { get; set; }
    }
}
