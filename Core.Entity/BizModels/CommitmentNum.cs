using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CommitmentNum
    {
        public int Id { get; set; }
        public string CommitmentNum1 { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? DeleteFlag { get; set; }
        public int? BizType { get; set; }
        public int? ContactId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
