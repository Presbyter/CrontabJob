using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CommunityInCommuindex
    {
        public int IndexNodeId { get; set; }
        public int SubNodeId { get; set; }
        public byte? IndexNodeLevel { get; set; }
    }
}
