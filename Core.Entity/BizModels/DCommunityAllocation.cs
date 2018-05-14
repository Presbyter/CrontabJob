using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class DCommunityAllocation
    {
        public int DepartmentId { get; set; }
        public int CommunityId { get; set; }
        public bool Flag { get; set; }
        public int? NumberFlag { get; set; }
    }
}
