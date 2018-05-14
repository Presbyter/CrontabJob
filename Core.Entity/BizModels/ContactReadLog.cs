using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class ContactReadLog
    {
        public int Id { get; set; }
        public int? RealtyId { get; set; }
        public int EmployeeId { get; set; }
    }
}
