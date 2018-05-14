using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class TemplateItems
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public int BaseItemId { get; set; }
        public decimal? Values { get; set; }
        public bool? IsBaseItem { get; set; }
        public decimal? MaxValues { get; set; }
        public bool? IsActive { get; set; }
        public int? SourceType { get; set; }
        public string Memo { get; set; }
        public bool? IsInput { get; set; }
    }
}
