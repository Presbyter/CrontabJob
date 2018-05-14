using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class ChangeRecord
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public int OperatingState { get; set; }
        public string OperatingTable { get; set; }
        public string PrimaryKey { get; set; }
        public string PrimaryKeyValue { get; set; }
        public int HandleState { get; set; }
        public DateTime? HandleDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string Remark { get; set; }
    }
}
