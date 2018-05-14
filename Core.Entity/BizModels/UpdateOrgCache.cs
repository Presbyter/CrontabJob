using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class UpdateOrgCache
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool Done { get; set; }
    }
}
