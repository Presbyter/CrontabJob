using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class FranchiseesManager
    {
        public int Id { get; set; }
        public int FrcId { get; set; }
        public int AccountId { get; set; }
        public bool DeletedFlag { get; set; }
        public DateTime? CreateTime { get; set; }
        public int PositionType { get; set; }
        public string Memo { get; set; }
    }
}
