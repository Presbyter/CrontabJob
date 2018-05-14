using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CisPosition
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Position { get; set; }
    }
}
