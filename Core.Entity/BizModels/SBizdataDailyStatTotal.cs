using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SBizdataDailyStatTotal
    {
        public int? OrgId { get; set; }
        public string OrgName { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime StatDate { get; set; }
        public DateTime? StatActionDate { get; set; }
        public Guid? StateBatchId { get; set; }
        public int? RelAll { get; set; }
        public int? RelCirculation { get; set; }
        public int? RelSalse { get; set; }
        public int? RelRentsale { get; set; }
        public int? RelRent { get; set; }
        public int? RelSole { get; set; }
        public int? RelKey { get; set; }
        public int? CusAll { get; set; }
        public int? CusCirculation { get; set; }
        public int? CusBuy { get; set; }
        public int? CusRent { get; set; }
        public int? RelSaleCirculation { get; set; }
        public int? RelRentCirculation { get; set; }
        public int? RelSaleandrentCirculation { get; set; }
        public int? CusBuyCirculation { get; set; }
        public int? CusRentCirculation { get; set; }
    }
}
