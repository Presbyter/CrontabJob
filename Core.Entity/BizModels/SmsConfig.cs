using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SmsConfig
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int SmsAmount { get; set; }
        public DateTime Date { get; set; }
        public int? SmsSendAmount { get; set; }
    }
}
