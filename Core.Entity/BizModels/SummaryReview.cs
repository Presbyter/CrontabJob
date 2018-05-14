using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SummaryReview
    {
        public int Id { get; set; }
        public int? SummaryId { get; set; }
        public int? ReviewerId { get; set; }
        public string ReviewContent { get; set; }
        public DateTime? ReviewDate { get; set; }
        public bool? Deleted { get; set; }
    }
}
