using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RealtyInvalidTask
    {
        public int TaskId { get; set; }
        public int? RealtyId { get; set; }
        public string RealtyNum { get; set; }
        public int? HandleEmployeeId { get; set; }
        public string HandleEmployeeName { get; set; }
        public int? TaskResult { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? HandleResult { get; set; }
        public DateTime? HandleTime { get; set; }
        public string HandleMemo { get; set; }
    }
}
