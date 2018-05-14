using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Summary
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string Title { get; set; }
        public byte[] Content { get; set; }
        public DateTime? CreateDate { get; set; }
        public byte? Status { get; set; }
        public bool? Deleted { get; set; }
    }
}
