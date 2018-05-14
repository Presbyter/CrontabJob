using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class DepartmentRelation
    {
        public int Id { get; set; }
        public int RelationId { get; set; }
        public int Level { get; set; }
    }
}
