using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CustomerReadDeptInDept
    {
        public int Id { get; set; }
        public int RelationId { get; set; }
        public int RealtyType { get; set; }
        public int Level { get; set; }
    }
}
