using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RealtyToRemind
    {
        public int RealtyId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public int? Z { get; set; }
        public bool? ToPause { get; set; }
    }
}
