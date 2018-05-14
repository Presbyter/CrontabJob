using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class DailyEmployeeDataHcisPrimaryCommunity
    {
        public int Id { get; set; }
        public DateTime? StatDate { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? BigRegionId { get; set; }
        public string BigRegionName { get; set; }
        public int? AreaId { get; set; }
        public string AreaName { get; set; }
        public int? ShopId { get; set; }
        public string ShopName { get; set; }
        public int? TeamId { get; set; }
        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public int? CommunityId { get; set; }
        public decimal? OrderRent { get; set; }
        public decimal? OrderSale { get; set; }
        public decimal? OrderTotal { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
