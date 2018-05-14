using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SisStoreReport
    {
        public int Id { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public DateTime? StatDate { get; set; }
        public int? StoreRealtyRent { get; set; }
        public int? StoreRealtySale { get; set; }
        public int? StoreRealtyRentsale { get; set; }
        public int? StoreRealtySum { get; set; }
        public int? StoreCustomerRent { get; set; }
        public int? StoreCustomerSale { get; set; }
        public int? StoreCustomerSum { get; set; }
        public DateTime? CreateTime { get; set; }
        public byte[] UpdateFlag { get; set; }
    }
}
