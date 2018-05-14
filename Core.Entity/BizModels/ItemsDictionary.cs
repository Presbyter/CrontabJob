using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class ItemsDictionary
    {
        public int Id { get; set; }
        public int? TemplateItemId { get; set; }
        public string Name { get; set; }
        public int? Values { get; set; }
    }
}
