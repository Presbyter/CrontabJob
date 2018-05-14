using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class UImpMaxIdLog
    {
        public int Id { get; set; }
        public int? MaxIdStart { get; set; }
        public int? MaxIdEnd { get; set; }
        public DateTime? Date { get; set; }
        public string TableType { get; set; }
        public int? RowCount { get; set; }
        public int? TagMaxId { get; set; }
        public int? DataType { get; set; }
    }
}
