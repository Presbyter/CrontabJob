using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class TmsRealtyStatusLog
    {
        public int Id { get; set; }
        public string RealtyNum { get; set; }
        public string Msg { get; set; }
        public string ResultMsg { get; set; }
        public bool? Result { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ChangeType { get; set; }
    }
}
