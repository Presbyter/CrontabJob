using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class PublicUserPerformance
    {
        public long Id { get; set; }
        public DateTime StatDate { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public Guid? JobId { get; set; }
        public string JobName { get; set; }
        public DateTime? EntryDate { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string DeptEmployeeCode { get; set; }
        public string DeptEmployeeName { get; set; }
        public string BigRegionCode { get; set; }
        public string BigRegionName { get; set; }
        public string RegionEmployeeCode { get; set; }
        public string RegionEmployeeName { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string AreaEmployeeCode { get; set; }
        public string AreEmployeeName { get; set; }
        public int? TeamId { get; set; }
        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public string TeamEmployeeCode { get; set; }
        public string TeamEmployeeName { get; set; }
        public int? AddRealtyRent { get; set; }
        public int? AddRealtyfirstRent { get; set; }
        public int? AddRealtysecondRent { get; set; }
        public int? AddRealtyotherRent { get; set; }
        public int? AddRealtySale { get; set; }
        public int? AddRealtyfirstSale { get; set; }
        public int? AddRealtysecondSale { get; set; }
        public int? AddRealtyotherSale { get; set; }
        public int? AddRealtyRentsale { get; set; }
        public int? AddRealtyfirstRentsale { get; set; }
        public int? AddRealtysecondRentsale { get; set; }
        public int? AddRealtyotherRentsale { get; set; }
        public int? AddRealtySum { get; set; }
        public int? KeyRealtySum { get; set; }
        public int? SoleAgentOrdinary { get; set; }
        public int? SoleAgentTime { get; set; }
        public int? SoleAgentRent { get; set; }
        public int? SoleAgentSum { get; set; }
        public int? AddCustomerRent { get; set; }
        public int? AddCustomerfirstRent { get; set; }
        public int? AddCustomersecondRent { get; set; }
        public int? AddCustomerotherRent { get; set; }
        public int? AddCustomerSale { get; set; }
        public int? AddCustomerfirstSale { get; set; }
        public int? AddCustomersecondSale { get; set; }
        public int? AddCustomerotherSale { get; set; }
        public int? AddCustomerSum { get; set; }
        public bool? IsCount { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? EmpFlag { get; set; }
        public byte[] UpdateFlag { get; set; }
        public string HashCode { get; set; }
    }
}
