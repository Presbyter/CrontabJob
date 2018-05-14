using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class CommunityFiles
    {
        public int Id { get; set; }
        public int? SourceId { get; set; }
        public string Uri { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string ImageClass { get; set; }
        public int? EmployeeId { get; set; }
        public byte[] Thumbnail { get; set; }
        public bool DefaultImageFlag { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
