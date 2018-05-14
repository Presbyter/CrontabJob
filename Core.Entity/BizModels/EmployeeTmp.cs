using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class EmployeeTmp
    {
        public Guid Guid { get; set; }
        public DateTime? CisEntryDate { get; set; }
        public DateTime? CisResignDate { get; set; }
    }
}
