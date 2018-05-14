using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class DailyEmployeeDataPrimaryCommunity
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
        public int? RealtySalePrimary { get; set; }
        public int? RealtySaleAll { get; set; }
        public decimal? RealtySaleRate { get; set; }
        public int? RealtyRentSalePrimary { get; set; }
        public int? RealtyRentSaleAll { get; set; }
        public decimal? RealtyRentSaleRate { get; set; }
        public int? RealtyRentPrimary { get; set; }
        public int? RealtyRentAll { get; set; }
        public decimal? RealtyRentRate { get; set; }
        public int? RealtyTotalPrimary { get; set; }
        public int? RealtyTotalAll { get; set; }
        public decimal? RealtyTotalRate { get; set; }
        public int? RealtyCommissionPrimary { get; set; }
        public int? RealtyCommissionAll { get; set; }
        public decimal? RealtyCommissionRate { get; set; }
        public int? RealtyKeyPrimary { get; set; }
        public int? RealtyKeyAll { get; set; }
        public decimal? RealtyKeyRate { get; set; }
        public int? RealtyUpimagePrimary { get; set; }
        public int? RealtyUpimageAll { get; set; }
        public decimal? RealtyUpimageRate { get; set; }
        public int? EncounterSalePrimary { get; set; }
        public int? EncounterSaleAll { get; set; }
        public decimal? EncounterSaleRate { get; set; }
        public int? EncounterRentPrimary { get; set; }
        public int? EncounterRentAll { get; set; }
        public decimal? EncounterRentRate { get; set; }
        public int? EncounterTotalPrimary { get; set; }
        public int? EncounterTotalAll { get; set; }
        public decimal? EncounterTotalRate { get; set; }
        public decimal? DealSalePrimary { get; set; }
        public decimal? DealSaleAll { get; set; }
        public decimal? DealSaleRate { get; set; }
        public decimal? DealRentPrimary { get; set; }
        public decimal? DealRentAll { get; set; }
        public decimal? DealRentRate { get; set; }
        public decimal? DealTotalPrimary { get; set; }
        public decimal? DealTotalAll { get; set; }
        public decimal? DealTotalRate { get; set; }
        public int? FallowupTotalPrimary { get; set; }
        public int? FallowupTotalAll { get; set; }
        public decimal? FallowupTotalRate { get; set; }
    }
}
