using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CustomerContactCode
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int CustomerId { get; set; }
        public int CustomerRcId { get; set; }
        public string PhoneCode { get; set; }
        public string ContactPhone { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
