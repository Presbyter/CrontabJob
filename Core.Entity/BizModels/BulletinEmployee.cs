using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class BulletinEmployee
    {
        public int BulletinId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? CreatorTime { get; set; }
    }
}
