using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SubwayStations
    {
        public int StationId { get; set; }
        public string StationName { get; set; }
        public string Pinyin { get; set; }
        public bool? DeleteFlag { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
