using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SExpressions
    {
        public int Id { get; set; }
        public int ExpressionId { get; set; }
        public string Value { get; set; }
        public string CnName { get; set; }
        public int Index { get; set; }
    }
}
