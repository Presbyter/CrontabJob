using System;
using System.Collections.Generic;

namespace Core.Entity.CenterModels
{
    public partial class Areas
    {
        public int AreaId { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string AreaShopport { get; set; }
        public string AreaServerName { get; set; }
        public byte AreaWeb { get; set; }
        public bool? AreaActive { get; set; }
        public string WebService { get; set; }
        public string FileService { get; set; }
        public int? CityId { get; set; }
        public string ConnectionString { get; set; }
    }
}
