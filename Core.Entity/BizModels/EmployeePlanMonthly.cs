using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class EmployeePlanMonthly
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Date { get; set; }
        public int? SaleTotal { get; set; }
        public double? SalePerformance { get; set; }
        public int? RealtyForSale { get; set; }
        public int? CustomerForBuy { get; set; }
        public int? RealtyFollowups { get; set; }
        public int? SoleRealtyTotal { get; set; }
        public int? TotalKeys { get; set; }
        public int? RentTotal { get; set; }
        public double? RentPerformance { get; set; }
        public int? RealtyForRent { get; set; }
        public int? CustomerFollowups { get; set; }
        public int? IntroductionTotal { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Memo { get; set; }
    }
}
