using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CommunityIndexNodeDef
    {
        public int IndexNodeId { get; set; }
        public int IndexHeapId { get; set; }
        public string IndexNodeName { get; set; }
        public int IndexNodeLevel { get; set; }
        public string NamePinyin { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
