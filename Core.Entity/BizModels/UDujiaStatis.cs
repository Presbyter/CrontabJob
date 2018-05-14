using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class UDujiaStatis
    {
        public Guid Id { get; set; }
        public int? TeamId { get; set; }
        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public string Status { get; set; }
        public string BusiDeptName { get; set; }
        public int? BusiDeptId { get; set; }
        public string BigAreaName { get; set; }
        public int? BigAreaId { get; set; }
        public string AreaName { get; set; }
        public int? AreaId { get; set; }
        public int? EmpId { get; set; }
        public string EmpCd { get; set; }
        public string EmpName { get; set; }
        public string ShopName { get; set; }
        public int? RealtyId { get; set; }
        public string RealtyNum { get; set; }
        public string Address { get; set; }
        public int? CommunityId { get; set; }
        public string CommunityName { get; set; }
        public int? BuildingId { get; set; }
        public string BuildingName { get; set; }
        public int? RoomId { get; set; }
        public string RoomName { get; set; }
        public double? ConstructionArea { get; set; }
        public int? CommissionType { get; set; }
        public string CommissionTypeName { get; set; }
        public string CommissionNum { get; set; }
        public DateTime? CommissionDate { get; set; }
        public DateTime? StatDate { get; set; }
    }
}
