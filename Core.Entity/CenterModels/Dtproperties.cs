﻿using System;
using System.Collections.Generic;

namespace Core.Entity.CenterModels
{
    public partial class Dtproperties
    {
        public int Id { get; set; }
        public int? Objectid { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }
        public string Uvalue { get; set; }
        public byte[] Lvalue { get; set; }
        public int Version { get; set; }
    }
}
