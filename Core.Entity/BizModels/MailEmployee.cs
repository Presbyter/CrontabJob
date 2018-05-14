using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class MailEmployee
    {
        public int Id { get; set; }
        public int MailId { get; set; }
        public int RecipientId { get; set; }
        public byte? MailStatus { get; set; }
        public byte? Deleted { get; set; }
        public string Title { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? SendingDatetime { get; set; }
    }
}
