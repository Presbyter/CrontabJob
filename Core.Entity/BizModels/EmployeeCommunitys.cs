using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class EmployeeCommunitys
    {
        public int EmployeeId { get; set; }
        public int CommunityId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
