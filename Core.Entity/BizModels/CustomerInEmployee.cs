using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CustomerInEmployee
    {
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
