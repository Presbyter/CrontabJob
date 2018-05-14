using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class DistrictDef
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int? PlcdCode { get; set; }
        public string DistrictPinyin { get; set; }
    }
}
