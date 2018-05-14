using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class UNrtConfig
    {
        public Guid Id { get; set; }
        public string ConfigName { get; set; }
        public string ConfigValue { get; set; }
        public string ConfigDesc { get; set; }
        public int? GroupId { get; set; }
    }
}
