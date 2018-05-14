using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Certificate
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public byte[] Thumbnail { get; set; }
        public string ImagePath { get; set; }
        public int Realtyid { get; set; }
        public int? UpEmployeeId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? DeleteFlag { get; set; }
        public string UpEmployeeName { get; set; }
        public int UpDepartmentId { get; set; }
        public string UpDepartmentName { get; set; }
        public DateTime? DeleteDatetime { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
