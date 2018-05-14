using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CustomerImport
    {
        public int? BizRealtyType { get; set; }
        public int? TradeType { get; set; }
        public string CustomerCode { get; set; }
        public int? PublicCustomerType { get; set; }
        public int? SourceType { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string CName { get; set; }
        public string Tel { get; set; }
        public string NoMessage { get; set; }
        public int? IsSucess { get; set; }
        public string Number { get; set; }
        public Guid? RGuid { get; set; }
        public int Id { get; set; }
    }
}
