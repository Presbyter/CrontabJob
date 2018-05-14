using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public int? BuildingId { get; set; }
        public int? FloorNum { get; set; }
        public string FloorName { get; set; }
        public string Pinyin { get; set; }
        public int? RoomNum { get; set; }
        public int? LivingRoomNum { get; set; }
        public int? ToiletNum { get; set; }
        public int? BalconyNum { get; set; }
        public double? ConstructionArea { get; set; }
        public bool? IsTypeLocked { get; set; }
        public bool? IsAreaLocked { get; set; }
        public bool? IsFloorLocked { get; set; }
    }
}
