using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class BulletinFiles
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public string Uri { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int? EmployeeId { get; set; }
    }
}
