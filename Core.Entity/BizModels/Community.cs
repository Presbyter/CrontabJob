using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Community
    {
        public int CommunityId { get; set; }
        public Guid? CommunityGuid { get; set; }
        public int? DistrictId { get; set; }
        public int? AreaId { get; set; }
        public string CommunityName { get; set; }
        public string AliasName { get; set; }
        public string NamePinyin { get; set; }
        public string AliasPinyin { get; set; }
        public string RentDepartment { get; set; }
        public string Address { get; set; }
        public DateTime? SaleDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? CommunityType { get; set; }
        public int? BuildingType { get; set; }
        public DateTime? AreaApprovingDate { get; set; }
        public string AreaCode { get; set; }
        public int? CertificateType { get; set; }
        public int? PropertyType { get; set; }
        public DateTime? PropertyStartDate { get; set; }
        public DateTime? PropertyEndDate { get; set; }
        public decimal? SaleStartPrice { get; set; }
        public int? TotalDoors { get; set; }
        public int? TotalParkingNum { get; set; }
        public double? OccupyedSpace { get; set; }
        public double? PlotRatio { get; set; }
        public int? LiftNums { get; set; }
        public decimal? ManagerialFee { get; set; }
        public double? ConstructionArea { get; set; }
        public double? AfforestationRatio { get; set; }
        public string RealtyDeveloper { get; set; }
        public decimal? OvertimeAirConditioningFee { get; set; }
        public string OvertimeAirConditioningFeeUnit { get; set; }
        public decimal? AirConditioningFee { get; set; }
        public string AirConditioningFeeUnit { get; set; }
        public string PropertyMgmtCompany { get; set; }
        public string PropertyMgmtPhone { get; set; }
        public string ServicePhone { get; set; }
        public string CommunityIntroduction { get; set; }
        public string AppendFacilities { get; set; }
        public string StationIds { get; set; }
        public string SubwayLine { get; set; }
        public string BusLines { get; set; }
        public string BusinessDirectory { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool IsLockDictionary { get; set; }
        public bool IsLockCommunity { get; set; }
        public bool? IsApproved { get; set; }
        public string HousingType { get; set; }
        public string HousingTypeName { get; set; }
        public string ArchitecturalType { get; set; }
        public string ArchitecturalTypeName { get; set; }
        public string FeatureTagsName { get; set; }
        public int? OfficeType { get; set; }
        public int? ShopType { get; set; }
        public string FeatureTags { get; set; }
        public int? PropertyYears { get; set; }
        public DateTime? YearBuilt { get; set; }
        public int? WaterSupply { get; set; }
        public int? PowerSupply { get; set; }
        public int? HeatingMode { get; set; }
        public int? NaturalGas { get; set; }
        public int? IsElevator { get; set; }
        public int? ParkingType { get; set; }
        public string ParkingRatio { get; set; }
        public int? CanDivide { get; set; }
        public int? OfficeLevel { get; set; }
        public double? FloorHeight { get; set; }
        public int? TotalFloor { get; set; }
        public double? StandardFloorArea { get; set; }
        public string HighBuildType { get; set; }
    }
}
