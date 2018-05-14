using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RemindingInTime
    {
        public int Id { get; set; }
        public int? CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string CreatorDepartmentName { get; set; }
        public int? RecipientId { get; set; }
        public byte? RecipientType { get; set; }
        public string RecipientName { get; set; }
        public DateTime? RemindingTime { get; set; }
        public int? Status { get; set; }
        public int? RemindingType { get; set; }
        public string Content { get; set; }
        public string SourceId { get; set; }
        public string SourceCode { get; set; }
        public int? SourceType { get; set; }
        public int? SourceSubType { get; set; }
        public string SourceIdCode { get; set; }
    }
}
