using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class TranseferLogSub
    {
        public int Id { get; set; }
        public Guid TransferId { get; set; }
        public int BizType { get; set; }
        public int SourceId { get; set; }
        public int OwnerType { get; set; }
        public int OldEmployeeId { get; set; }
        public string OldEmployeeName { get; set; }
        public int OldDepartmentId { get; set; }
        public string OldDepartmentName { get; set; }
        public int? OldQueryCode { get; set; }
        public int? OldPublicCustomerType { get; set; }
        public int NewEmployeeId { get; set; }
        public string NewEmployeeName { get; set; }
        public int NewDepartmentId { get; set; }
        public string NewDepartmentName { get; set; }
        public int? NewQueryCode { get; set; }
        public int? NewPublicCustomerType { get; set; }
    }
}
