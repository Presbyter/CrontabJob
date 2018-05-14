using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Customer
    {
        public int Id { get; set; }
        public Guid? CustomerGuid { get; set; }
        public string CustomerCode { get; set; }
        public string DistrictList { get; set; }
        public string AreaList { get; set; }
        public string CommunityList { get; set; }
        public string StationIds { get; set; }
        public string Stations { get; set; }
        public string LineIds { get; set; }
        public string Lines { get; set; }
        public int? TradeType { get; set; }
        public int? CustomerStatus { get; set; }
        public double? RentPriceStart { get; set; }
        public double? RentPriceEnd { get; set; }
        public double? SalePriceStart { get; set; }
        public double? SalePriceEnd { get; set; }
        public string RentUnit { get; set; }
        public double? AreaStart { get; set; }
        public double? AreaEnd { get; set; }
        public int? FloorStart { get; set; }
        public int? FloorEnd { get; set; }
        public byte? PayType { get; set; }
        public int? PublicCustomerType { get; set; }
        public int? ShareDomain { get; set; }
        public int? FaceOrientation { get; set; }
        public int? DecorationLevel { get; set; }
        public int? UseType { get; set; }
        public int? ConstructionType { get; set; }
        public int? RoomNumStart { get; set; }
        public int? RoomNumEnd { get; set; }
        public int? LivingRoomNumStart { get; set; }
        public int? LivingRoomNumEnd { get; set; }
        public int? ToiletNumStart { get; set; }
        public int? ToiletNumEnd { get; set; }
        public int? SourceType { get; set; }
        public int? CustomerType { get; set; }
        public int? CustomerClass { get; set; }
        public int? CustomerAppellation { get; set; }
        public string Email { get; set; }
        public int? LiveStatus { get; set; }
        public int? DelegateTerm { get; set; }
        public double? DownPayment { get; set; }
        public double? MonthlyPayment { get; set; }
        public bool? RealtyExchangeFlag { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? CommissionDatetime { get; set; }
        public DateTime? RegisterDatetime { get; set; }
        public int? ShopLocation { get; set; }
        public string ShopTradeType { get; set; }
        public string ShopTradeName { get; set; }
        public int? ShopType { get; set; }
        public double? ManagementFeeStart { get; set; }
        public double? ManagementFeeEnd { get; set; }
        public int? ManagementFeeUnit { get; set; }
        public int? Toilet { get; set; }
        public int? OfficeType { get; set; }
        public int? OfficeClass { get; set; }
        public int? FloorNum { get; set; }
        public int? FloorsTotal { get; set; }
        public int? BizRealtyType { get; set; }
        public string Memo { get; set; }
        public bool DeleteFlag { get; set; }
        public DateTime? LastFollowupDate { get; set; }
        public DateTime? LastChangeDate { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public string CommunityListIds { get; set; }
        public string DistrictListIds { get; set; }
        public string AreaListIds { get; set; }
        public DateTime? DelegateTermDate { get; set; }
        public double? TransferFeeStart { get; set; }
        public double? TransferFeeEnd { get; set; }
        public int? QueryCode { get; set; }
        public string CommunityIndexIdList { get; set; }
        public string Facilities { get; set; }
        public int? BusinessType { get; set; }
        public DateTime? LastEncounterDate { get; set; }
        public bool? CommitmentFlag { get; set; }
        public int? InspectStatus { get; set; }
        public DateTime? LastInspectTime { get; set; }
        public DateTime? LastSalesmanFollowupDate { get; set; }
    }
}
