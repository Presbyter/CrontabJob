using System;
using System.Collections.Generic;

namespace Core.Entity.CenterModels
{
    public partial class UArea
    {
        public Guid AreaId { get; set; }
        public string AreaCd { get; set; }
        public string AreaName { get; set; }
        public string ContName { get; set; }
        public string AreaPostAddr { get; set; }
        public string AreaPostZip { get; set; }
        public string AreaTel { get; set; }
        public string AreaFax { get; set; }
        public string AreaEmail { get; set; }
        public string CorpName { get; set; }
        public string CorpAdd { get; set; }
        public string CorpPostZip { get; set; }
        public string CorpTel { get; set; }
        public string CorpFax { get; set; }
        public string CorpEmail { get; set; }
        public string CorpAuthority { get; set; }
        public string CorpStock { get; set; }
        public string LegalPerson { get; set; }
        public string CertificateNo { get; set; }
        public string TaxNo { get; set; }
        public byte? IsEstateRight { get; set; }
        public string AcorpName { get; set; }
        public string AcorpAddr { get; set; }
        public string BusiActivity { get; set; }
        public string Stock { get; set; }
        public byte? IsBankruptcy { get; set; }
        public string Content1 { get; set; }
        public byte? IsResearch { get; set; }
        public string Content2 { get; set; }
        public byte? IsProsecute { get; set; }
        public string Content3 { get; set; }
        public byte? IsBeprosecuet { get; set; }
        public string Content4 { get; set; }
        public byte? AreaTable { get; set; }
        public string ServerName { get; set; }
        public string ServerUsername { get; set; }
        public string ServerPassword { get; set; }
        public string DatabaseName { get; set; }
        public string WebUsername { get; set; }
        public string WebPassword { get; set; }
        public byte? Deleted { get; set; }
        public byte[] UploadDate { get; set; }
        public string DatabaseNameSys { get; set; }
        public string EmployeeCd { get; set; }
        public string Website { get; set; }
        public string Province { get; set; }
        public string DeptWebsite { get; set; }
        public byte? VerFlag { get; set; }
    }
}
