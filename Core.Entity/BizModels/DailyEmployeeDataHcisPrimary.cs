using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class DailyEmployeeDataHcisPrimary
    {
        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? StatDate { get; set; }
        public decimal? OrderSaleFirst { get; set; }
        public decimal? OrderSaleSecond { get; set; }
        public decimal? OrderRent { get; set; }
        public decimal? OrderRentCount { get; set; }
        public decimal? MoneySaleFirst { get; set; }
        public decimal? MoneySaleSecond { get; set; }
        public decimal? MoneyRent { get; set; }
        public decimal? MoneyRentCount { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
