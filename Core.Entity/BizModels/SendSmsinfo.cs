using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SendSmsinfo
    {
        public int SendId { get; set; }
        public string RealtyNum { get; set; }
        public int RealtyId { get; set; }
        public string RealtyAddress { get; set; }
        public double RealtyArea { get; set; }
        public double? RealtyRentPrice { get; set; }
        public double? RealtySalePrice { get; set; }
        public int RealtyTradeType { get; set; }
        public int ReatlyStatus { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string ContactPhone { get; set; }
        public bool SendSuccess { get; set; }
        public DateTime SendTime { get; set; }
        public int? ReplyReatltyStatus { get; set; }
        public bool? ReplySuccess { get; set; }
        public DateTime? ReplyTime { get; set; }
        public string ReplyInfo { get; set; }
    }
}
