using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class BusinessTeam
    {
        public int Id { get; set; }
        public Guid? Guid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }
        public int? ShopId { get; set; }
        public int? Status { get; set; }
        public int? ManagerId { get; set; }
        public string Pinyin { get; set; }
        public int? QueryCode { get; set; }
    }
}
