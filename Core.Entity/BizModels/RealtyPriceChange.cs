using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RealtyPriceChange
    {
        public int RealtyId { get; set; }
        public bool RentOrSale { get; set; }
        public double? Price { get; set; }
        public DateTime CreateTime { get; set; }
        public int? Days { get; set; }
        public byte UpOrDown { get; set; }
    }
}
