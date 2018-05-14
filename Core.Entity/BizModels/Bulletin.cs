using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Bulletin
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Content { get; set; }
        public int? CreatorId { get; set; }
        public string CreatorName { get; set; }
        public int? DepartmentId { get; set; }
        public string RecipientList { get; set; }
        public int? Type { get; set; }
        public bool? Top { get; set; }
        public bool? AutoPop { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? CreatorDate { get; set; }
        public int? Status { get; set; }
        public DateTime? TopCloseDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
    }
}
