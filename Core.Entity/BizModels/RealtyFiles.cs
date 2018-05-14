using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class RealtyFiles
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public string Uri { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string ImageClass { get; set; }
        public int? EmployeeId { get; set; }
        public byte[] Thumbnail { get; set; }
        public DateTime? Datetime { get; set; }
        public int? DeleteEmployeeId { get; set; }
        public DateTime? DeleteDatetime { get; set; }
        public bool? DeleteFlag { get; set; }
        public string EmployeeCode { get; set; }
        public string DeleteEmployeeCode { get; set; }
        public string SourceNum { get; set; }
        public int? SourceType { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
