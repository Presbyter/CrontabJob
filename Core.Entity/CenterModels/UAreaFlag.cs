using System;
using System.Collections.Generic;

namespace Core.Entity.CenterModels
{
    public partial class UAreaFlag
    {
        public string AreaCd { get; set; }
        public short Flag { get; set; }
        public string KfServer { get; set; }
        public string KfDb { get; set; }
        public string KfUser { get; set; }
        public string KfPwd { get; set; }
        public string MapCity { get; set; }
    }
}
