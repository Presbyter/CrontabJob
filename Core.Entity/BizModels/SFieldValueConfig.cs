using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SFieldValueConfig
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public string FieldText { get; set; }
        public bool? LockFlag { get; set; }
        public string Pinyin { get; set; }
        public int? DefaultSelectKey { get; set; }
    }
}
