using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class BizMail
    {
        public int MailId { get; set; }
        public int SenderId { get; set; }
        public string Title { get; set; }
        public byte[] Content { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? SendingDatetime { get; set; }
        public string RecipientIds { get; set; }
        public int? RecipientType { get; set; }
        public string EmployeeName { get; set; }
        public int? SendingType { get; set; }
        public byte Deleted { get; set; }
        public int? SourceId { get; set; }
        public string SourceCode { get; set; }
        public int? SourceType { get; set; }
    }
}
