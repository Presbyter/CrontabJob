using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CustomerTrade
    {
        public int CustomerId { get; set; }
        public byte TradeCode { get; set; }
    }
}
