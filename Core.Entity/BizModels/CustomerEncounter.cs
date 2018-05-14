using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CustomerEncounter
    {
        public int Id { get; set; }
        public int? RealtyId { get; set; }
        public int CustomerId { get; set; }
        public string SourceNum { get; set; }
        public string EncounterCode { get; set; }
        public string CustomerInfo { get; set; }
        public DateTime? Date { get; set; }
        public int? EmployeeId { get; set; }
        public string Content { get; set; }
        public byte? TradeType { get; set; }
        public string CustomerSourceNum { get; set; }
        public int? SubbizType { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? CreateTime { get; set; }
        public byte? EncounterType { get; set; }
        public int? InspectStatus { get; set; }
        public DateTime? LastInspectTime { get; set; }
        public string RealtyInfo { get; set; }
        public string Feedback { get; set; }
    }
}
