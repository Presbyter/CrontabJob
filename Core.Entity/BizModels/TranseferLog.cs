using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class TranseferLog
    {
        public Guid Id { get; set; }
        public string BatchNum { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Remark { get; set; }
    }
}
