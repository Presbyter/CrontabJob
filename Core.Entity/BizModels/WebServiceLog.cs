using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class WebServiceLog
    {
        public int Id { get; set; }
        public Guid? BatchId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string InterfaceName { get; set; }
        public string MethodName { get; set; }
        public int? Type { get; set; }
        public string OperationXml { get; set; }
        public string OperationResult { get; set; }
    }
}
