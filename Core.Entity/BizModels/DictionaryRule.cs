using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class DictionaryRule
    {
        public int RuleId { get; set; }
        public string RuleName { get; set; }
        public byte? RuleType { get; set; }
        public int? KeyNum { get; set; }
        public string ApprovalStatus { get; set; }
        public string Example { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
