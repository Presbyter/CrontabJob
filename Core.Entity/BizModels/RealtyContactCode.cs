using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RealtyContactCode
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int RealtyId { get; set; }
        public int RealtyRcId { get; set; }
        public string PhoneCode { get; set; }
        public string ContactPhone { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
