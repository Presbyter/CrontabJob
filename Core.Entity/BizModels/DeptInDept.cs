using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class DeptInDept
    {
        public int Id { get; set; }
        public int RelationId { get; set; }
        public int Level { get; set; }
        public int OperationType { get; set; }
        public int RealtyType { get; set; }
        public byte Biztype { get; set; }
    }
}
