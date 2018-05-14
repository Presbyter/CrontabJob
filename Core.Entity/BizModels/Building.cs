using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Building
    {
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public int? CommunityId { get; set; }
        public bool? LockSubListFlag { get; set; }
        public int? TotalFloor { get; set; }
        public string Pinyin { get; set; }
        public int? Maintainer { get; set; }
        public string MaintainerName { get; set; }
        public int? DeptId { get; set; }
        public string DeptName { get; set; }
    }
}
