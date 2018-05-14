using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Core.Entity.CenterModels;
using JetBrains.Annotations;

namespace Core.Entity
{
    public partial class CenterContext : DbContext
    {
        public CenterContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<AreasApp> AreasApp { get; set; }
        public virtual DbSet<Dtproperties> Dtproperties { get; set; }
        public virtual DbSet<SHousexmlflag> SHousexmlflag { get; set; }
        public virtual DbSet<SHousexmlflagKb> SHousexmlflagKb { get; set; }
        public virtual DbSet<SSftest> SSftest { get; set; }
        public virtual DbSet<SSftestC> SSftestC { get; set; }
        public virtual DbSet<STosoufun> STosoufun { get; set; }
        public virtual DbSet<U06to08> U06to08 { get; set; }
        public virtual DbSet<UArea> UArea { get; set; }
        public virtual DbSet<UAreaCount> UAreaCount { get; set; }
        public virtual DbSet<UAreaFlag> UAreaFlag { get; set; }
        public virtual DbSet<UEmpLog> UEmpLog { get; set; }
        public virtual DbSet<UEmployeeC> UEmployeeC { get; set; }
        public virtual DbSet<UPos> UPos { get; set; }

        // Unable to generate entity type for table 'dbo.s_reglogin_infor'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=192.168.114.172;Initial Catalog=MLS_SIS20_B_CENTER;User ID=sa;Password=c21admin;Persist Security Info=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Areas>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.Property(e => e.AreaId).HasColumnName("Area_ID");

                entity.Property(e => e.AreaActive).HasColumnName("Area_Active");

                entity.Property(e => e.AreaCode)
                    .IsRequired()
                    .HasColumnName("Area_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("Area_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaServerName)
                    .HasColumnName("Area_ServerName")
                    .HasMaxLength(100);

                entity.Property(e => e.AreaShopport)
                    .HasColumnName("Area_Shopport")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaWeb).HasColumnName("Area_Web");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ConnectionString)
                    .HasColumnName("connectionString")
                    .HasMaxLength(400);

                entity.Property(e => e.FileService).HasMaxLength(400);

                entity.Property(e => e.WebService)
                    .HasColumnName("webService")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<AreasApp>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("Areas_App");

                entity.Property(e => e.AreaId).HasColumnName("Area_ID");

                entity.Property(e => e.AreaActive).HasColumnName("Area_Active");

                entity.Property(e => e.AreaCode)
                    .IsRequired()
                    .HasColumnName("Area_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("Area_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaServerName)
                    .HasColumnName("Area_ServerName")
                    .HasMaxLength(1000);

                entity.Property(e => e.AreaServerNameMore)
                    .HasColumnName("Area_ServerNameMore")
                    .HasMaxLength(1000);

                entity.Property(e => e.AreaShopport)
                    .HasColumnName("Area_Shopport")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaWeb).HasColumnName("Area_Web");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.FileService).HasMaxLength(400);

                entity.Property(e => e.WebService)
                    .HasColumnName("webService")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Dtproperties>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Property });

                entity.ToTable("dtproperties");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Property)
                    .HasColumnName("property")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Lvalue)
                    .HasColumnName("lvalue")
                    .HasColumnType("image");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Uvalue)
                    .HasColumnName("uvalue")
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<SHousexmlflag>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.AreaCd });

                entity.ToTable("s_housexmlflag");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaCd)
                    .HasColumnName("area_cd")
                    .HasMaxLength(20);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pflag).HasColumnName("pflag");
            });

            modelBuilder.Entity<SHousexmlflagKb>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.AreaCd });

                entity.ToTable("s_housexmlflag_kb");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaCd)
                    .HasColumnName("area_cd")
                    .HasMaxLength(20);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pflag).HasColumnName("pflag");
            });

            modelBuilder.Entity<SSftest>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("s_sftest");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasMaxLength(500);

                entity.Property(e => e.Intime)
                    .HasColumnName("intime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Istest).HasColumnName("istest");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SSftestC>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("s_sftest_c");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasMaxLength(500);

                entity.Property(e => e.Intime)
                    .HasColumnName("intime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Istest).HasColumnName("istest");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<STosoufun>(entity =>
            {
                entity.HasKey(e => e.Filetime);

                entity.ToTable("s_tosoufun");

                entity.Property(e => e.Filetime)
                    .HasColumnName("filetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Readed).HasColumnName("readed");
            });

            modelBuilder.Entity<U06to08>(entity =>
            {
                entity.HasKey(e => e.Area);

                entity.ToTable("u_06to08");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anm)
                    .HasColumnName("anm")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Flg).HasColumnName("flg");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UArea>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("u_area");

                entity.Property(e => e.AreaId)
                    .HasColumnName("area_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AcorpAddr)
                    .HasColumnName("acorp_addr")
                    .HasMaxLength(100);

                entity.Property(e => e.AcorpName)
                    .HasColumnName("acorp_name")
                    .HasMaxLength(40);

                entity.Property(e => e.AreaCd)
                    .HasColumnName("area_cd")
                    .HasMaxLength(20);

                entity.Property(e => e.AreaEmail)
                    .HasColumnName("area_email")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaFax)
                    .HasColumnName("area_fax")
                    .HasMaxLength(40);

                entity.Property(e => e.AreaName)
                    .HasColumnName("area_name")
                    .HasMaxLength(40);

                entity.Property(e => e.AreaPostAddr)
                    .HasColumnName("area_post_addr")
                    .HasMaxLength(100);

                entity.Property(e => e.AreaPostZip)
                    .HasColumnName("area_post_zip")
                    .HasColumnType("char(6)");

                entity.Property(e => e.AreaTable).HasColumnName("area_table");

                entity.Property(e => e.AreaTel)
                    .HasColumnName("area_tel")
                    .HasMaxLength(40);

                entity.Property(e => e.BusiActivity)
                    .HasColumnName("busi_activity")
                    .HasMaxLength(400);

                entity.Property(e => e.CertificateNo)
                    .HasColumnName("certificate_no")
                    .HasMaxLength(40);

                entity.Property(e => e.ContName)
                    .HasColumnName("cont_name")
                    .HasMaxLength(40);

                entity.Property(e => e.Content1)
                    .HasColumnName("content1")
                    .HasMaxLength(400);

                entity.Property(e => e.Content2)
                    .HasColumnName("content2")
                    .HasMaxLength(400);

                entity.Property(e => e.Content3)
                    .HasColumnName("content3")
                    .HasMaxLength(400);

                entity.Property(e => e.Content4)
                    .HasColumnName("content4")
                    .HasMaxLength(400);

                entity.Property(e => e.CorpAdd)
                    .HasColumnName("corp_add")
                    .HasMaxLength(100);

                entity.Property(e => e.CorpAuthority)
                    .HasColumnName("corp_authority")
                    .HasMaxLength(40);

                entity.Property(e => e.CorpEmail)
                    .HasColumnName("corp_email")
                    .HasMaxLength(100);

                entity.Property(e => e.CorpFax)
                    .HasColumnName("corp_fax")
                    .HasMaxLength(40);

                entity.Property(e => e.CorpName)
                    .HasColumnName("corp_name")
                    .HasMaxLength(40);

                entity.Property(e => e.CorpPostZip)
                    .HasColumnName("corp_post_zip")
                    .HasColumnType("char(6)");

                entity.Property(e => e.CorpStock)
                    .HasColumnName("corp_stock")
                    .HasMaxLength(100);

                entity.Property(e => e.CorpTel)
                    .HasColumnName("corp_tel")
                    .HasMaxLength(40);

                entity.Property(e => e.DatabaseName)
                    .HasColumnName("database_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DatabaseNameSys)
                    .HasColumnName("database_name_sys")
                    .HasMaxLength(50);

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptWebsite)
                    .HasColumnName("dept_website")
                    .HasMaxLength(200);

                entity.Property(e => e.EmployeeCd)
                    .IsRequired()
                    .HasColumnName("employee_cd")
                    .HasColumnType("nchar(2)");

                entity.Property(e => e.IsBankruptcy).HasColumnName("is_bankruptcy");

                entity.Property(e => e.IsBeprosecuet).HasColumnName("is_beprosecuet");

                entity.Property(e => e.IsEstateRight).HasColumnName("is_estate_right");

                entity.Property(e => e.IsProsecute).HasColumnName("is_prosecute");

                entity.Property(e => e.IsResearch).HasColumnName("is_research");

                entity.Property(e => e.LegalPerson)
                    .HasColumnName("legal_person")
                    .HasMaxLength(40);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(50);

                entity.Property(e => e.ServerName)
                    .HasColumnName("server_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ServerPassword)
                    .HasColumnName("server_password")
                    .HasMaxLength(50);

                entity.Property(e => e.ServerUsername)
                    .HasColumnName("server_username")
                    .HasMaxLength(50);

                entity.Property(e => e.Stock)
                    .HasColumnName("stock")
                    .HasMaxLength(40);

                entity.Property(e => e.TaxNo)
                    .HasColumnName("tax_no")
                    .HasMaxLength(40);

                entity.Property(e => e.UploadDate)
                    .HasColumnName("upload_date")
                    .IsRowVersion();

                entity.Property(e => e.VerFlag)
                    .HasColumnName("verFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WebPassword)
                    .HasColumnName("web_password")
                    .HasMaxLength(50);

                entity.Property(e => e.WebUsername)
                    .HasColumnName("web_username")
                    .HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<UAreaCount>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("u_area_count");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.AgentCode)
                    .HasColumnName("agent_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCount).HasColumnName("area_count");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.FldCount).HasColumnName("fld_count");

                entity.Property(e => e.GfzCount).HasColumnName("gfz_count");

                entity.Property(e => e.KbAll).HasColumnName("kb_all");

                entity.Property(e => e.KbCount).HasColumnName("kb_count");

                entity.Property(e => e.RecordCount).HasColumnName("record_count");
            });

            modelBuilder.Entity<UAreaFlag>(entity =>
            {
                entity.HasKey(e => e.AreaCd);

                entity.ToTable("u_area_flag");

                entity.Property(e => e.AreaCd)
                    .HasColumnName("area_cd")
                    .HasColumnType("char(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KfDb)
                    .HasColumnName("kf_db")
                    .HasMaxLength(50);

                entity.Property(e => e.KfPwd)
                    .HasColumnName("kf_pwd")
                    .HasMaxLength(50);

                entity.Property(e => e.KfServer)
                    .HasColumnName("kf_server")
                    .HasMaxLength(100);

                entity.Property(e => e.KfUser)
                    .HasColumnName("kf_user")
                    .HasMaxLength(50);

                entity.Property(e => e.MapCity)
                    .HasColumnName("map_city")
                    .HasColumnType("char(50)");
            });

            modelBuilder.Entity<UEmpLog>(entity =>
            {
                entity.ToTable("u_emp_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaName)
                    .HasColumnName("area_name")
                    .HasMaxLength(10);

                entity.Property(e => e.DeptName)
                    .HasColumnName("dept_name")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpCd)
                    .HasColumnName("emp_cd")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasColumnName("emp_name")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpType).HasColumnName("emp_type");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(200);

                entity.Property(e => e.SetType).HasColumnName("set_type");
            });

            modelBuilder.Entity<UEmployeeC>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("u_employee_c");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.EMail)
                    .HasColumnName("e_mail")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpAddr)
                    .HasColumnName("emp_addr")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpBirth)
                    .HasColumnName("emp_birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpCardNo)
                    .HasColumnName("emp_card_no")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpDeptTime)
                    .HasColumnName("emp_dept_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpName)
                    .HasColumnName("emp_name")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpPostZip)
                    .HasColumnName("emp_post_zip")
                    .HasColumnType("char(6)");

                entity.Property(e => e.EmpSex).HasColumnName("emp_sex");

                entity.Property(e => e.EnglishName)
                    .HasColumnName("english_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Fix)
                    .HasColumnName("fix")
                    .HasMaxLength(50);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(400);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50);

                entity.Property(e => e.UseSis).HasColumnName("use_sis");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<UPos>(entity =>
            {
                entity.ToTable("u_pos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaCd)
                    .HasColumnName("area_cd")
                    .HasMaxLength(20);

                entity.Property(e => e.DeptCd)
                    .HasColumnName("dept_cd")
                    .HasMaxLength(20);

                entity.Property(e => e.Termid)
                    .HasColumnName("termid")
                    .HasColumnType("char(8)");
            });
        }
    }
}
