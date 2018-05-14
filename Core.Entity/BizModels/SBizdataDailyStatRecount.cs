using System;
using System.Collections.Generic;

namespace Core.Entity.BizModels
{
    public partial class SBizdataDailyStatRecount
    {
        public int? OrgId { get; set; }
        public string OrgName { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime StatDate { get; set; }
        public DateTime? StatActionDate { get; set; }
        public Guid? StateBatchId { get; set; }
        public int? MmXzlt { get; set; }
        public int? MmXzqb { get; set; }
        public int? MmCxkp { get; set; }
        public int? MmZltl { get; set; }
        public int? ZlXzlt { get; set; }
        public int? ZlXzqb { get; set; }
        public int? ZlCxkp { get; set; }
        public int? ZlZltl { get; set; }
        public int? ZsXzlt { get; set; }
        public int? ZsXzqb { get; set; }
        public int? ZsCxkp { get; set; }
        public int? ZsZltl { get; set; }
        public int? QbXzlt { get; set; }
        public int? QbXzqb { get; set; }
        public int? QbCxkp { get; set; }
        public int? QbZltl { get; set; }
        public int? QbXzysp { get; set; }
        public int? QbXzdjp { get; set; }
        public int? QbXzky { get; set; }
        public int? QgXzky { get; set; }
        public int? QzXzky { get; set; }
        public int? QbXzgjzl { get; set; }
        public int? FyXzgjzl { get; set; }
        public int? KyXzgjzl { get; set; }
        public int? QbXzdkzl { get; set; }
        public int? MmXzdkzl { get; set; }
        public int? ZlXzdkzl { get; set; }
        public int? FyXzqbW { get; set; }
        public int? FyXzmmW { get; set; }
        public int? FyXzzsW { get; set; }
        public int? FyXzzlW { get; set; }
    }
}
