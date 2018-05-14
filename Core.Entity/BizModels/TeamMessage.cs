using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class TeamMessage
    {
        public int Id { get; set; }
        public Guid? Guid { get; set; }
        public int? MsgCode { get; set; }
        public DateTime? MsgTime { get; set; }
        public int? MsgState { get; set; }
        public DateTime? RespTime { get; set; }
        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? IsSecondTeam { get; set; }
    }
}
