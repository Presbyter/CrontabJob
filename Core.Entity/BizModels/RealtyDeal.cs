using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RealtyDeal
    {
        public int Id { get; set; }
        public Guid? DealId { get; set; }
        public int? CommunityId { get; set; }
        public string RealtyNum { get; set; }
        public string CommunityAddress { get; set; }
        public int? TradeType { get; set; }
        public decimal? ConstructionArea { get; set; }
        public DateTime? FixtureDate { get; set; }
        public decimal? Turnover { get; set; }
        public string UnitPrice { get; set; }
        public string Extend1 { get; set; }
        public string Extend2 { get; set; }
        public int? DeleteFlag { get; set; }
    }
}
