using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RemindingDailyBySystemBak
    {
        public int Id { get; set; }
        public int OriginalId { get; set; }
        public int? RecipientId { get; set; }
        public string RecipientName { get; set; }
        public DateTime? RemindingTime { get; set; }
        public bool? IsRead { get; set; }
        public string Content { get; set; }
        public int? SourceId { get; set; }
        public string SourceCode { get; set; }
        public int? SourceType { get; set; }
        public int? SourceSubType { get; set; }
    }
}
