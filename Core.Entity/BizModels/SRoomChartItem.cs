using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SRoomChartItem
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? MinSize { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
    }
}
