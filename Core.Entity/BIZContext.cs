using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Core.Entity.BizModels;
using JetBrains.Annotations;

namespace Core.Entity
{
    public partial class BIZContext : DbContext
    {
        public BIZContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<AbsenceSheet> AbsenceSheet { get; set; }
        public virtual DbSet<AllocationTemplate> AllocationTemplate { get; set; }
        public virtual DbSet<AreasApp> AreasApp { get; set; }
        public virtual DbSet<AttendanceAbnormal> AttendanceAbnormal { get; set; }
        public virtual DbSet<AttendanceDaily> AttendanceDaily { get; set; }
        public virtual DbSet<AttendanceStatisticMonthly> AttendanceStatisticMonthly { get; set; }
        public virtual DbSet<AttendantSheet> AttendantSheet { get; set; }
        public virtual DbSet<BambooRealty> BambooRealty { get; set; }
        public virtual DbSet<BizMail> BizMail { get; set; }
        public virtual DbSet<Blacklist> Blacklist { get; set; }
        public virtual DbSet<Building> Building { get; set; }
        public virtual DbSet<Bulletin> Bulletin { get; set; }
        public virtual DbSet<BulletinEmployee> BulletinEmployee { get; set; }
        public virtual DbSet<BulletinFiles> BulletinFiles { get; set; }
        public virtual DbSet<BulletinPublish> BulletinPublish { get; set; }
        public virtual DbSet<BusinessShop> BusinessShop { get; set; }
        public virtual DbSet<BusinessTeam> BusinessTeam { get; set; }
        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<ChangeRecord> ChangeRecord { get; set; }
        public virtual DbSet<CisMessage> CisMessage { get; set; }
        public virtual DbSet<CisPosition> CisPosition { get; set; }
        public virtual DbSet<CisPositionRoleMap> CisPositionRoleMap { get; set; }
        public virtual DbSet<CommitmentNum> CommitmentNum { get; set; }
        public virtual DbSet<Community> Community { get; set; }
        public virtual DbSet<CommunityAllocationTt> CommunityAllocationTt { get; set; }
        public virtual DbSet<CommunityFiles> CommunityFiles { get; set; }
        public virtual DbSet<CommunityInCommuindex> CommunityInCommuindex { get; set; }
        public virtual DbSet<CommunityIndexNodeDef> CommunityIndexNodeDef { get; set; }
        public virtual DbSet<CommunityInTeam> CommunityInTeam { get; set; }
        public virtual DbSet<CommunitySubway> CommunitySubway { get; set; }
        public virtual DbSet<ContactReadCount> ContactReadCount { get; set; }
        public virtual DbSet<ContactReadDay> ContactReadDay { get; set; }
        public virtual DbSet<ContactReadLog> ContactReadLog { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerContact> CustomerContact { get; set; }
        public virtual DbSet<CustomerContactCode> CustomerContactCode { get; set; }
        public virtual DbSet<CustomerEncounter> CustomerEncounter { get; set; }
        public virtual DbSet<CustomerFollowup> CustomerFollowup { get; set; }
        public virtual DbSet<CustomerImport> CustomerImport { get; set; }
        public virtual DbSet<CustomerInCommuindex> CustomerInCommuindex { get; set; }
        public virtual DbSet<CustomerInEmployee> CustomerInEmployee { get; set; }
        public virtual DbSet<CustomerReadDeptInDept> CustomerReadDeptInDept { get; set; }
        public virtual DbSet<CustomerSubway> CustomerSubway { get; set; }
        public virtual DbSet<CustomerTrade> CustomerTrade { get; set; }
        public virtual DbSet<CustomSeries> CustomSeries { get; set; }
        public virtual DbSet<DailyEmployeeDataHcisAll> DailyEmployeeDataHcisAll { get; set; }
        public virtual DbSet<DailyEmployeeDataHcisPrimary> DailyEmployeeDataHcisPrimary { get; set; }
        public virtual DbSet<DailyEmployeeDataHcisPrimaryCommunity> DailyEmployeeDataHcisPrimaryCommunity { get; set; }
        public virtual DbSet<DailyEmployeeDataPrimaryCommunity> DailyEmployeeDataPrimaryCommunity { get; set; }
        public virtual DbSet<DailyEmployeeDataSisPrimaryCommunity> DailyEmployeeDataSisPrimaryCommunity { get; set; }
        public virtual DbSet<DCommunityAllocation> DCommunityAllocation { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DepartmentRelation> DepartmentRelation { get; set; }
        public virtual DbSet<DepartmentTemplate> DepartmentTemplate { get; set; }
        public virtual DbSet<DeptInDept> DeptInDept { get; set; }
        public virtual DbSet<DictionaryItem> DictionaryItem { get; set; }
        public virtual DbSet<DictionaryRule> DictionaryRule { get; set; }
        public virtual DbSet<DistrictDef> DistrictDef { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeCommunitys> EmployeeCommunitys { get; set; }
        public virtual DbSet<EmployeeLogin> EmployeeLogin { get; set; }
        public virtual DbSet<EmployeeMessage> EmployeeMessage { get; set; }
        public virtual DbSet<EmployeePerformanceReportFinal> EmployeePerformanceReportFinal { get; set; }
        public virtual DbSet<EmployeePerformanceReportFinalManager> EmployeePerformanceReportFinalManager { get; set; }
        public virtual DbSet<EmployeePlanMonthly> EmployeePlanMonthly { get; set; }
        public virtual DbSet<EmployeeTmp> EmployeeTmp { get; set; }
        public virtual DbSet<HouseCheck> HouseCheck { get; set; }
        public virtual DbSet<ItemsDictionary> ItemsDictionary { get; set; }
        public virtual DbSet<KoofunWebSiteList> KoofunWebSiteList { get; set; }
        public virtual DbSet<LineStation> LineStation { get; set; }
        public virtual DbSet<MailEmployee> MailEmployee { get; set; }
        public virtual DbSet<Mission> Mission { get; set; }
        public virtual DbSet<NbusinessDepartment> NbusinessDepartment { get; set; }
        public virtual DbSet<NbusinessInDepartment> NbusinessInDepartment { get; set; }
        public virtual DbSet<PerformanceFieldConfig> PerformanceFieldConfig { get; set; }
        public virtual DbSet<PerformanceStat> PerformanceStat { get; set; }
        public virtual DbSet<PerformanceTemplate> PerformanceTemplate { get; set; }
        public virtual DbSet<PublicUserPerformance> PublicUserPerformance { get; set; }
        public virtual DbSet<Realty> Realty { get; set; }
        public virtual DbSet<RealtyCommissionLog> RealtyCommissionLog { get; set; }
        public virtual DbSet<RealtyContact> RealtyContact { get; set; }
        public virtual DbSet<RealtyContactCode> RealtyContactCode { get; set; }
        public virtual DbSet<RealtyDeal> RealtyDeal { get; set; }
        public virtual DbSet<RealtyFiles> RealtyFiles { get; set; }
        public virtual DbSet<RealtyFollowup> RealtyFollowup { get; set; }
        public virtual DbSet<RealtyInEmployee> RealtyInEmployee { get; set; }
        public virtual DbSet<RealtyInvalid> RealtyInvalid { get; set; }
        public virtual DbSet<RealtyInvalidTask> RealtyInvalidTask { get; set; }
        public virtual DbSet<RealtyPriceChange> RealtyPriceChange { get; set; }
        public virtual DbSet<RealtyReadDeptInDept> RealtyReadDeptInDept { get; set; }
        public virtual DbSet<RealtyToRemind> RealtyToRemind { get; set; }
        public virtual DbSet<RealtyTrade> RealtyTrade { get; set; }
        public virtual DbSet<RemindingDailyBySystem> RemindingDailyBySystem { get; set; }
        public virtual DbSet<RemindingDailyBySystemBak> RemindingDailyBySystemBak { get; set; }
        public virtual DbSet<RemindingInTime> RemindingInTime { get; set; }
        public virtual DbSet<RoleConfig> RoleConfig { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<SBaseItem> SBaseItem { get; set; }
        public virtual DbSet<SBizdataDailyStatRecount> SBizdataDailyStatRecount { get; set; }
        public virtual DbSet<SBizdataDailyStatTotal> SBizdataDailyStatTotal { get; set; }
        public virtual DbSet<ScheduleDef> ScheduleDef { get; set; }
        public virtual DbSet<ScheduleTimeDef> ScheduleTimeDef { get; set; }
        public virtual DbSet<ScheduleTimeRelation> ScheduleTimeRelation { get; set; }
        public virtual DbSet<SConfig> SConfig { get; set; }
        public virtual DbSet<SCustomerContactFollowup> SCustomerContactFollowup { get; set; }
        public virtual DbSet<SCustomerFieldLog> SCustomerFieldLog { get; set; }
        public virtual DbSet<SCustomerFollowup> SCustomerFollowup { get; set; }
        public virtual DbSet<SCustomerReadLog> SCustomerReadLog { get; set; }
        public virtual DbSet<SCustomerSmsLog> SCustomerSmsLog { get; set; }
        public virtual DbSet<SendSmsinfo> SendSmsinfo { get; set; }
        public virtual DbSet<SExpressionConfig> SExpressionConfig { get; set; }
        public virtual DbSet<SExpressions> SExpressions { get; set; }
        public virtual DbSet<SFieldValueConfig> SFieldValueConfig { get; set; }
        public virtual DbSet<SFollowup> SFollowup { get; set; }
        public virtual DbSet<SisStoreReport> SisStoreReport { get; set; }
        public virtual DbSet<SmsActualLog> SmsActualLog { get; set; }
        public virtual DbSet<SmsActualLogDetail> SmsActualLogDetail { get; set; }
        public virtual DbSet<SmsConfig> SmsConfig { get; set; }
        public virtual DbSet<SmsEmployeeLog> SmsEmployeeLog { get; set; }
        public virtual DbSet<SmsForbidNum> SmsForbidNum { get; set; }
        public virtual DbSet<SmsSendingCount> SmsSendingCount { get; set; }
        public virtual DbSet<SmsTemplate> SmsTemplate { get; set; }
        public virtual DbSet<SRealtyCommitmentNumFollowup> SRealtyCommitmentNumFollowup { get; set; }
        public virtual DbSet<SRealtyContactFollowup> SRealtyContactFollowup { get; set; }
        public virtual DbSet<SRealtyFieldLog> SRealtyFieldLog { get; set; }
        public virtual DbSet<SRealtyFollowup> SRealtyFollowup { get; set; }
        public virtual DbSet<SRealtyReadLog> SRealtyReadLog { get; set; }
        public virtual DbSet<SRealtySmsLog> SRealtySmsLog { get; set; }
        public virtual DbSet<SRoomChartItem> SRoomChartItem { get; set; }
        public virtual DbSet<SRoomChartType> SRoomChartType { get; set; }
        public virtual DbSet<SubwayLines> SubwayLines { get; set; }
        public virtual DbSet<SubwayStations> SubwayStations { get; set; }
        public virtual DbSet<Summary> Summary { get; set; }
        public virtual DbSet<SummaryReview> SummaryReview { get; set; }
        public virtual DbSet<TCommunityAllocation> TCommunityAllocation { get; set; }
        public virtual DbSet<TeamMessage> TeamMessage { get; set; }
        public virtual DbSet<TemplateItems> TemplateItems { get; set; }
        public virtual DbSet<TmsRealtyStatusLog> TmsRealtyStatusLog { get; set; }
        public virtual DbSet<TranseferLog> TranseferLog { get; set; }
        public virtual DbSet<TranseferLogSub> TranseferLogSub { get; set; }
        public virtual DbSet<UDujiaStatis> UDujiaStatis { get; set; }
        public virtual DbSet<UImpMaxIdLog> UImpMaxIdLog { get; set; }
        public virtual DbSet<UNrtConfig> UNrtConfig { get; set; }
        public virtual DbSet<UpdateOrgCache> UpdateOrgCache { get; set; }
        public virtual DbSet<UPhonedealHistory> UPhonedealHistory { get; set; }
        public virtual DbSet<UserCustom> UserCustom { get; set; }
        public virtual DbSet<WebServiceLog> WebServiceLog { get; set; }

        public virtual DbSet<EmployeeLoginTime> EmployeeLoginTime { get; set; }
        public virtual DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public virtual DbSet<FranchiseesManager> FranchiseesManager { get; set; }

        // Unable to generate entity type for table 'dbo.plcd_config'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.website_config'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_bizdata_Realtydaily_stat_total'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.attendance_time'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.realtyvalidity'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.nbusiness_department_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.attendance_lock'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.attendance_job_history_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CommunityTags'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.community_feature_tags'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.field_config'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_bizdata_daily_employeestat_total'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.u_old_realty_deleted_data'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AccountIDTeam'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.daily_employee_data_sis_all'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.daily_employee_data_sis_primary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.realty_temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.region_performance_report'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.employee_plan_weekly'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.u_bak_Reg_no_replace'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.realty_invalid_task_employee'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.employee_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.district_def_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sum_temp_person_daily'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sms_sending_config'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.department_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.service_config'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.non_cis_role'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.inspect_amerce'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_config_9_17'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customer_import_key'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.inspect_followup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_forbidden_words'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_realty_sms_log_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customer_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customer_followup_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_realty_read_log_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customer_encounter_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customer_contact_read_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SMS_glod_standard_in_templates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SMS_Template_auth'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customer_contact_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.customer_columns'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_field_values'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_bizdata_Customerdaily_stat_total_All'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_customer_sms_log_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.community_index_node_def_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.community_index_config'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.community_in_commuindex_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_bizdata_Customerdaily_stat_total'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_config_1558'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.community_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ImageTags'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cis_tree'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.room_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.employee_performance_report'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.business_team_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.business_shop_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.realty_followup_imp_error_partImp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.realty_followup_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.employee_performance_report_final_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.contact_read_realty_address_count'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.building_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.realty_contact_imp_error'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.position'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=172.16.1.23;Initial Catalog=C21_IMP_BIZ;User ID=sa;Password=shsisdata2017;Persist Security Info=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbsenceSheet>(entity =>
            {
                entity.ToTable("absence_sheet");

                entity.HasIndex(e => e.BeginDate)
                    .HasName("IX_Begin_date");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => e.EndDate)
                    .HasName("IX_End_date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("begin_date")
                    .HasColumnType("date");

                entity.Property(e => e.CreateId).HasColumnName("createID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.EmployeeNum)
                    .HasColumnName("employee_num")
                    .HasMaxLength(20);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.EndFlag).HasColumnName("end_flag");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(100);

                entity.Property(e => e.SheetType).HasColumnName("sheet_type");

                entity.Property(e => e.StartFlag).HasColumnName("start_flag");
            });

            modelBuilder.Entity<AllocationTemplate>(entity =>
            {
                entity.ToTable("allocation_template");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
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

            modelBuilder.Entity<AttendanceAbnormal>(entity =>
            {
                entity.ToTable("attendance_abnormal");

                entity.HasIndex(e => e.AttendanceId)
                    .HasName("IX_AttendanceID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbnormalType).HasColumnName("abnormal_type");

                entity.Property(e => e.AbnormalTypeName)
                    .HasColumnName("abnormal_type_name")
                    .HasMaxLength(20);

                entity.Property(e => e.ApprovedDatetime)
                    .HasColumnName("approved_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApproverId).HasColumnName("approverID");

                entity.Property(e => e.AttendanceId).HasColumnName("attendanceID");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateId).HasColumnName("createID");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.IsApproved).HasColumnName("is_approved");

                entity.Property(e => e.IsEnable).HasColumnName("isEnable");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AttendanceDaily>(entity =>
            {
                entity.ToTable("attendance_daily");

                entity.HasIndex(e => e.EmployeeNum)
                    .HasName("IX_EmployeeNum");

                entity.HasIndex(e => new { e.EmployeeId, e.Date })
                    .HasName("IX_EmployeeIDWithDate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbsenceFlag).HasColumnName("absence_flag");

                entity.Property(e => e.AttendanceStatus)
                    .HasColumnName("attendance_status")
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeNum)
                    .HasColumnName("employee_num")
                    .HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LateTime).HasColumnName("late_time");

                entity.Property(e => e.LeaveTime).HasColumnName("leave_time");

                entity.Property(e => e.OldLateTime).HasColumnName("old_late_time");

                entity.Property(e => e.OldLeaveTime).HasColumnName("old_leave_time");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<AttendanceStatisticMonthly>(entity =>
            {
                entity.ToTable("attendance_statistic_monthly");

                entity.HasIndex(e => new { e.EmployeeId, e.Date })
                    .HasName("IX_EmployeeIDWithDate");

                entity.HasIndex(e => new { e.EmployeeId, e.EmployeeNum, e.Date })
                    .HasName("IX_Attendance_Monthly_EmployeeIDNumWithDate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbsenceDays).HasColumnName("absence_days");

                entity.Property(e => e.AbsenceSheetDays)
                    .HasColumnName("absence_sheet_days")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.AttendanceDays)
                    .HasColumnName("attendance_days")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.BigregionName)
                    .HasColumnName("bigregion_name")
                    .HasMaxLength(30);

                entity.Property(e => e.BizdepartmentName)
                    .HasColumnName("bizdepartment_name")
                    .HasMaxLength(30);

                entity.Property(e => e.BizteamName)
                    .HasColumnName("bizteam_name")
                    .HasMaxLength(30);

                entity.Property(e => e.CisPositionName)
                    .HasColumnName("cis_position_name")
                    .HasMaxLength(30);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.EmployeeNum)
                    .HasColumnName("employee_num")
                    .HasMaxLength(20);

                entity.Property(e => e.EntryDate)
                    .HasColumnName("entry_date")
                    .HasColumnType("date");

                entity.Property(e => e.LateInHalfhour).HasColumnName("late_in_halfhour");

                entity.Property(e => e.LateInQuarter).HasColumnName("late_in_quarter");

                entity.Property(e => e.LateOverHalfhour).HasColumnName("late_over_halfhour");

                entity.Property(e => e.LeaveDays)
                    .HasColumnName("leave_days")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.RegionName)
                    .HasColumnName("region_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ReqAttendanceDays)
                    .HasColumnName("req_attendance_days")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.ResignDate)
                    .HasColumnName("resign_date")
                    .HasColumnType("date");

                entity.Property(e => e.ShopName)
                    .HasColumnName("shop_name")
                    .HasMaxLength(30);

                entity.Property(e => e.SickAbsenceDays)
                    .HasColumnName("sick_absence_days")
                    .HasColumnType("decimal(4, 1)");
            });

            modelBuilder.Entity<AttendantSheet>(entity =>
            {
                entity.ToTable("attendant_sheet");

                entity.HasIndex(e => e.EmployeeNum)
                    .HasName("IX_EmployeeNum");

                entity.HasIndex(e => new { e.EmployeeId, e.Date })
                    .HasName("IX_EmployeeIDWithDate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeNum)
                    .HasColumnName("employee_num")
                    .HasMaxLength(20);

                entity.Property(e => e.ScheduleId).HasColumnName("scheduleID");

                entity.Property(e => e.ScheduleTimeId).HasColumnName("schedule_timeID");
            });

            modelBuilder.Entity<BambooRealty>(entity =>
            {
                entity.ToTable("bamboo_realty");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationDatetime)
                    .HasColumnName("application_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApplyContent)
                    .HasColumnName("apply_content")
                    .HasMaxLength(200);

                entity.Property(e => e.ApprovedDatetime)
                    .HasColumnName("approved_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedId).HasColumnName("approvedID");

                entity.Property(e => e.ApprovedStatus).HasColumnName("approved_status");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");
            });

            modelBuilder.Entity<BizMail>(entity =>
            {
                entity.HasKey(e => e.MailId);

                entity.ToTable("biz_mail");

                entity.HasIndex(e => new { e.Deleted, e.SenderId })
                    .HasName("IX_senderID");

                entity.Property(e => e.MailId).HasColumnName("mailID");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("image");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.RecipientIds)
                    .HasColumnName("recipientIDs")
                    .IsUnicode(false);

                entity.Property(e => e.RecipientType).HasColumnName("recipient_type");

                entity.Property(e => e.SenderId).HasColumnName("senderID");

                entity.Property(e => e.SendingDatetime)
                    .HasColumnName("sending_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SendingType).HasColumnName("sending_type");

                entity.Property(e => e.SourceCode)
                    .HasColumnName("source_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("sourceID");

                entity.Property(e => e.SourceType).HasColumnName("source_type");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Blacklist>(entity =>
            {
                entity.ToTable("blacklist");

                entity.HasIndex(e => e.Phone)
                    .HasName("IX_Phone");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificationId)
                    .HasColumnName("certificationID")
                    .HasColumnType("char(20)");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.InputDatetime)
                    .HasColumnName("input_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsPhone).HasColumnName("isPhone");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("nchar(20)");
            });

            modelBuilder.Entity<Building>(entity =>
            {
                entity.ToTable("building");

                entity.HasIndex(e => e.CommunityId)
                    .HasName("IX_CommunityID");

                entity.Property(e => e.BuildingId)
                    .HasColumnName("buildingID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BuildingName)
                    .HasColumnName("building_name")
                    .HasMaxLength(80);

                entity.Property(e => e.CommunityId).HasColumnName("communityID");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.DeptName)
                    .HasColumnName("dept_name")
                    .HasMaxLength(30);

                entity.Property(e => e.LockSubListFlag).HasColumnName("lock_sub_list_flag");

                entity.Property(e => e.Maintainer).HasColumnName("maintainer");

                entity.Property(e => e.MaintainerName)
                    .HasColumnName("maintainer_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Pinyin)
                    .HasColumnName("pinyin")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalFloor).HasColumnName("total_floor");
            });

            modelBuilder.Entity<Bulletin>(entity =>
            {
                entity.ToTable("bulletin");

                entity.HasIndex(e => e.CreatorDate)
                    .HasName("IX_Date");

                entity.HasIndex(e => e.CreatorId)
                    .HasName("IX_CreaterID");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.Type)
                    .HasName("IX_Type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AutoPop).HasColumnName("auto_pop");

                entity.Property(e => e.CloseDate)
                    .HasColumnName("close_date")
                    .HasColumnType("date");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("image");

                entity.Property(e => e.CreatorDate)
                    .HasColumnName("creator_date")
                    .HasColumnType("date");

                entity.Property(e => e.CreatorId).HasColumnName("creatorID");

                entity.Property(e => e.CreatorName)
                    .HasColumnName("creator_name")
                    .HasMaxLength(35);

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.ExpiredDate)
                    .HasColumnName("expired_date")
                    .HasColumnType("date");

                entity.Property(e => e.RecipientList).HasColumnName("recipient_list");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.Property(e => e.Top).HasColumnName("top");

                entity.Property(e => e.TopCloseDate)
                    .HasColumnName("top_close_date")
                    .HasColumnType("date");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<BulletinEmployee>(entity =>
            {
                entity.HasKey(e => new { e.BulletinId, e.EmployeeId });

                entity.ToTable("bulletin_employee");

                entity.Property(e => e.BulletinId).HasColumnName("bulletinID");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.CreatorTime)
                    .HasColumnName("creator_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BulletinFiles>(entity =>
            {
                entity.ToTable("bulletin_files");

                entity.HasIndex(e => e.SourceId)
                    .HasName("IX_SourceID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(20);

                entity.Property(e => e.FileType)
                    .HasColumnName("file_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("sourceID");

                entity.Property(e => e.Uri)
                    .HasColumnName("URI")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulletinPublish>(entity =>
            {
                entity.HasKey(e => new { e.BulletinId, e.RelationId });

                entity.ToTable("bulletin_publish");

                entity.Property(e => e.BulletinId).HasColumnName("bulletinID");

                entity.Property(e => e.RelationId).HasColumnName("relationID");
            });

            modelBuilder.Entity<BusinessShop>(entity =>
            {
                entity.ToTable("business_shop");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasColumnName("abbreviation")
                    .HasMaxLength(50);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100);

                entity.Property(e => e.AuditStatus).HasColumnName("audit_status");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptIndex)
                    .HasColumnName("dept_index")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20);

                entity.Property(e => e.Funds).HasColumnName("funds");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LicenceName)
                    .HasColumnName("licence_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pinyin)
                    .HasColumnName("pinyin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<BusinessTeam>(entity =>
            {
                entity.ToTable("business_team");

                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_ShopID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ManagerId).HasColumnName("managerID");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.Pinyin)
                    .HasColumnName("pinyin")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QueryCode).HasColumnName("query_code");

                entity.Property(e => e.ShopId).HasColumnName("shopID");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasColumnName("C_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("Create_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteDatetime)
                    .HasColumnName("delete_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_Flag");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasColumnName("Image_path")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.ThumbnailUrl)
                    .HasColumnName("thumbnail_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpDate)
                    .HasColumnName("UP_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpDepartmentId).HasColumnName("Up_Department_Id");

                entity.Property(e => e.UpDepartmentName)
                    .IsRequired()
                    .HasColumnName("Up_Department_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.UpEmployeeId).HasColumnName("Up_Employee_ID");

                entity.Property(e => e.UpEmployeeName)
                    .IsRequired()
                    .HasColumnName("Up_Employee_Name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ChangeRecord>(entity =>
            {
                entity.ToTable("change_record");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HandleDate)
                    .HasColumnName("handle_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HandleState).HasColumnName("handle_state");

                entity.Property(e => e.ModuleName)
                    .HasColumnName("module_name")
                    .HasMaxLength(50);

                entity.Property(e => e.OperatingState).HasColumnName("operating_state");

                entity.Property(e => e.OperatingTable)
                    .IsRequired()
                    .HasColumnName("operating_table")
                    .HasMaxLength(30);

                entity.Property(e => e.PrimaryKey)
                    .IsRequired()
                    .HasColumnName("primary_key")
                    .HasMaxLength(50);

                entity.Property(e => e.PrimaryKeyValue)
                    .IsRequired()
                    .HasColumnName("primary_key_value")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CisMessage>(entity =>
            {
                entity.ToTable("cis_message");

                entity.HasIndex(e => e.DataId)
                    .HasName("IX_DataID");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataId).HasColumnName("dataID");

                entity.Property(e => e.MsgKind).HasColumnName("msg_kind");

                entity.Property(e => e.MsgState).HasColumnName("msg_state");

                entity.Property(e => e.MsgTime)
                    .HasColumnName("msg_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.MsgType).HasColumnName("msg_type");

                entity.Property(e => e.RespTime)
                    .HasColumnName("resp_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CisPosition>(entity =>
            {
                entity.ToTable("cis_position");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.Position).HasColumnName("position");
            });

            modelBuilder.Entity<CisPositionRoleMap>(entity =>
            {
                entity.HasKey(e => new { e.CisPositionId, e.RoleId });

                entity.ToTable("cis_position_role_map");

                entity.Property(e => e.CisPositionId).HasColumnName("cis_position_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");
            });

            modelBuilder.Entity<CommitmentNum>(entity =>
            {
                entity.ToTable("commitment_num");

                entity.HasIndex(e => e.CommitmentNum1)
                    .HasName("ix_commitment_num_commintmentNum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BizType).HasColumnName("biz_type");

                entity.Property(e => e.CommitmentNum1)
                    .IsRequired()
                    .HasColumnName("commitment_num")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactId).HasColumnName("contactId");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteFlag)
                    .HasColumnName("delete_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Community>(entity =>
            {
                entity.ToTable("community");

                entity.HasIndex(e => e.AreaId)
                    .HasName("IX_AreaID");

                entity.HasIndex(e => e.CommunityGuid)
                    .HasName("IX_CommonityGUID");

                entity.HasIndex(e => e.DistrictId)
                    .HasName("IX_DistrictID");

                entity.Property(e => e.CommunityId)
                    .HasColumnName("communityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100);

                entity.Property(e => e.AfforestationRatio).HasColumnName("afforestationRatio");

                entity.Property(e => e.AirConditioningFee)
                    .HasColumnName("airConditioningFee")
                    .HasColumnType("money");

                entity.Property(e => e.AirConditioningFeeUnit)
                    .HasColumnName("airConditioningFeeUnit")
                    .HasMaxLength(10);

                entity.Property(e => e.AliasName)
                    .HasColumnName("aliasName")
                    .HasMaxLength(20);

                entity.Property(e => e.AliasPinyin)
                    .HasColumnName("aliasPinyin")
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.AppendFacilities)
                    .HasColumnName("appendFacilities")
                    .HasMaxLength(500);

                entity.Property(e => e.ArchitecturalType)
                    .HasColumnName("architecturalType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ArchitecturalTypeName)
                    .HasColumnName("architecturalTypeName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AreaApprovingDate)
                    .HasColumnName("areaApprovingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AreaCode)
                    .HasColumnName("areaCode")
                    .HasMaxLength(20);

                entity.Property(e => e.AreaId).HasColumnName("areaID");

                entity.Property(e => e.BuildingType).HasColumnName("buildingType");

                entity.Property(e => e.BusLines)
                    .HasColumnName("busLines")
                    .HasMaxLength(500);

                entity.Property(e => e.BusinessDirectory)
                    .HasColumnName("businessDirectory")
                    .HasColumnType("ntext");

                entity.Property(e => e.CanDivide).HasColumnName("canDivide");

                entity.Property(e => e.CertificateType).HasColumnName("certificateType");

                entity.Property(e => e.CommunityGuid).HasColumnName("communityGUID");

                entity.Property(e => e.CommunityIntroduction)
                    .HasColumnName("communityIntroduction")
                    .HasMaxLength(1000);

                entity.Property(e => e.CommunityName)
                    .HasColumnName("communityName")
                    .HasMaxLength(23);

                entity.Property(e => e.CommunityType).HasColumnName("communityType");

                entity.Property(e => e.ConstructionArea).HasColumnName("constructionArea");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("deliveryDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DistrictId).HasColumnName("districtID");

                entity.Property(e => e.FeatureTags)
                    .HasColumnName("featureTags")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureTagsName)
                    .HasColumnName("featureTagsName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FloorHeight).HasColumnName("floorHeight");

                entity.Property(e => e.HeatingMode).HasColumnName("heatingMode");

                entity.Property(e => e.HighBuildType)
                    .HasColumnName("highBuildType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HousingType)
                    .HasColumnName("housingType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HousingTypeName)
                    .HasColumnName("housingTypeName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsElevator).HasColumnName("isElevator");

                entity.Property(e => e.IsLockCommunity).HasColumnName("isLockCommunity");

                entity.Property(e => e.IsLockDictionary).HasColumnName("isLockDictionary");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(20);

                entity.Property(e => e.LiftNums).HasColumnName("liftNums");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(20);

                entity.Property(e => e.ManagerialFee)
                    .HasColumnName("managerialFee")
                    .HasColumnType("money");

                entity.Property(e => e.NamePinyin)
                    .HasColumnName("namePinyin")
                    .HasMaxLength(23);

                entity.Property(e => e.NaturalGas).HasColumnName("naturalGas");

                entity.Property(e => e.OccupyedSpace).HasColumnName("occupyedSpace");

                entity.Property(e => e.OfficeLevel).HasColumnName("officeLevel");

                entity.Property(e => e.OfficeType).HasColumnName("officeType");

                entity.Property(e => e.OvertimeAirConditioningFee)
                    .HasColumnName("overtimeAirConditioningFee")
                    .HasColumnType("money");

                entity.Property(e => e.OvertimeAirConditioningFeeUnit)
                    .HasColumnName("overtimeAirConditioningFeeUnit")
                    .HasMaxLength(10);

                entity.Property(e => e.ParkingRatio)
                    .HasColumnName("parkingRatio")
                    .HasMaxLength(50);

                entity.Property(e => e.ParkingType).HasColumnName("parkingType");

                entity.Property(e => e.PlotRatio).HasColumnName("plotRatio");

                entity.Property(e => e.PowerSupply).HasColumnName("powerSupply");

                entity.Property(e => e.PropertyEndDate)
                    .HasColumnName("propertyEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PropertyMgmtCompany)
                    .HasColumnName("propertyMgmtCompany")
                    .HasMaxLength(50);

                entity.Property(e => e.PropertyMgmtPhone)
                    .HasColumnName("propertyMgmtPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.PropertyStartDate)
                    .HasColumnName("propertyStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PropertyType).HasColumnName("propertyType");

                entity.Property(e => e.PropertyYears).HasColumnName("propertyYears");

                entity.Property(e => e.RealtyDeveloper)
                    .HasColumnName("realtyDeveloper")
                    .HasMaxLength(50);

                entity.Property(e => e.RentDepartment)
                    .HasColumnName("rentDepartment")
                    .HasMaxLength(20);

                entity.Property(e => e.SaleDate)
                    .HasColumnName("saleDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SaleStartPrice)
                    .HasColumnName("saleStartPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ServicePhone)
                    .HasColumnName("servicePhone")
                    .HasMaxLength(50);

                entity.Property(e => e.ShopType).HasColumnName("shopType");

                entity.Property(e => e.StandardFloorArea).HasColumnName("standardFloorArea");

                entity.Property(e => e.StationIds)
                    .HasColumnName("stationIDs")
                    .HasMaxLength(200);

                entity.Property(e => e.SubwayLine)
                    .HasColumnName("subwayLine")
                    .HasMaxLength(300);

                entity.Property(e => e.TotalDoors).HasColumnName("totalDoors");

                entity.Property(e => e.TotalFloor).HasColumnName("totalFloor");

                entity.Property(e => e.TotalParkingNum).HasColumnName("totalParkingNum");

                entity.Property(e => e.WaterSupply).HasColumnName("waterSupply");

                entity.Property(e => e.YearBuilt)
                    .HasColumnName("yearBuilt")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CommunityAllocationTt>(entity =>
            {
                entity.HasKey(e => new { e.TeamId, e.TemplateId });

                entity.ToTable("community_allocation_tt");

                entity.Property(e => e.TeamId).HasColumnName("teamID");

                entity.Property(e => e.TemplateId).HasColumnName("templateID");
            });

            modelBuilder.Entity<CommunityFiles>(entity =>
            {
                entity.ToTable("community_files");

                entity.HasIndex(e => e.SourceId)
                    .HasName("IX_SourceID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultImageFlag).HasColumnName("default_image_flag");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FileType)
                    .HasColumnName("file_type")
                    .HasMaxLength(50);

                entity.Property(e => e.ImageClass)
                    .HasColumnName("image_class")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceId).HasColumnName("sourceID");

                entity.Property(e => e.Thumbnail)
                    .HasColumnName("thumbnail")
                    .HasColumnType("image");

                entity.Property(e => e.Uri)
                    .HasColumnName("URI")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CommunityInCommuindex>(entity =>
            {
                entity.HasKey(e => new { e.IndexNodeId, e.SubNodeId });

                entity.ToTable("community_in_commuindex");

                entity.Property(e => e.IndexNodeId).HasColumnName("index_nodeID");

                entity.Property(e => e.SubNodeId).HasColumnName("sub_nodeID");

                entity.Property(e => e.IndexNodeLevel).HasColumnName("index_node_level");
            });

            modelBuilder.Entity<CommunityIndexNodeDef>(entity =>
            {
                entity.HasKey(e => e.IndexNodeId);

                entity.ToTable("community_index_node_def");

                entity.Property(e => e.IndexNodeId)
                    .HasColumnName("index_nodeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IndexHeapId).HasColumnName("index_heapID");

                entity.Property(e => e.IndexNodeLevel).HasColumnName("index_node_level");

                entity.Property(e => e.IndexNodeName)
                    .IsRequired()
                    .HasColumnName("index_node_name")
                    .HasMaxLength(20);

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamePinyin)
                    .HasColumnName("name_pinyin")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CommunityInTeam>(entity =>
            {
                entity.HasKey(e => new { e.TeamId, e.CommunityId });

                entity.ToTable("community_in_team");

                entity.Property(e => e.TeamId).HasColumnName("teamID");

                entity.Property(e => e.CommunityId).HasColumnName("communityID");
            });

            modelBuilder.Entity<CommunitySubway>(entity =>
            {
                entity.HasKey(e => new { e.CommunityId, e.SubwayId });

                entity.ToTable("community_subway");

                entity.Property(e => e.CommunityId).HasColumnName("communityID");

                entity.Property(e => e.SubwayId).HasColumnName("subwayID");
            });

            modelBuilder.Entity<ContactReadCount>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.Date });

                entity.ToTable("contact_read_count");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.OtherCount).HasColumnName("other_count");
            });

            modelBuilder.Entity<ContactReadDay>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.RealtyId });

                entity.ToTable("contact_read_day");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.RealtyId).HasColumnName("RealtyID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<ContactReadLog>(entity =>
            {
                entity.ToTable("contact_read_log");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_departmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_employeeID");

                entity.HasIndex(e => new { e.DeleteFlag, e.BizRealtyType, e.ShareDomain })
                    .HasName("IX_Delete_BizType_Share");

                entity.HasIndex(e => new { e.CustomerStatus, e.DeleteFlag, e.EmployeeId, e.DepartmentId, e.BizRealtyType, e.PublicCustomerType, e.QueryCode, e.CommissionDatetime, e.Id })
                    .HasName("IX_Query");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaEnd).HasColumnName("area_end");

                entity.Property(e => e.AreaList)
                    .HasColumnName("area_list")
                    .HasMaxLength(200);

                entity.Property(e => e.AreaListIds)
                    .HasColumnName("area_listIDs")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AreaStart).HasColumnName("area_start");

                entity.Property(e => e.BizRealtyType).HasColumnName("biz_realty_type");

                entity.Property(e => e.BusinessType).HasColumnName("business_type");

                entity.Property(e => e.CommissionDatetime)
                    .HasColumnName("commission_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CommitmentFlag).HasColumnName("commitment_flag");

                entity.Property(e => e.CommunityIndexIdList)
                    .HasColumnName("community_indexID_list")
                    .HasMaxLength(50);

                entity.Property(e => e.CommunityList)
                    .HasColumnName("community_list")
                    .HasMaxLength(500);

                entity.Property(e => e.CommunityListIds)
                    .HasColumnName("community_listIDs")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConstructionType).HasColumnName("construction_type");

                entity.Property(e => e.CustomerAppellation).HasColumnName("customer_appellation");

                entity.Property(e => e.CustomerClass).HasColumnName("customer_class");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGuid).HasColumnName("customerGUID");

                entity.Property(e => e.CustomerStatus).HasColumnName("customer_status");

                entity.Property(e => e.CustomerType).HasColumnName("customer_type");

                entity.Property(e => e.DecorationLevel).HasColumnName("decoration_level");

                entity.Property(e => e.DelegateTerm).HasColumnName("delegate_term");

                entity.Property(e => e.DelegateTermDate)
                    .HasColumnName("delegate_term_date")
                    .HasColumnType("date");

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.DistrictList)
                    .HasColumnName("district_list")
                    .HasMaxLength(300);

                entity.Property(e => e.DistrictListIds)
                    .HasColumnName("district_listIDs")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DownPayment).HasColumnName("down_payment");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.FaceOrientation).HasColumnName("face_orientation");

                entity.Property(e => e.Facilities)
                    .HasColumnName("facilities")
                    .HasMaxLength(400);

                entity.Property(e => e.FloorEnd).HasColumnName("floor_end");

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.FloorStart).HasColumnName("floor_start");

                entity.Property(e => e.FloorsTotal).HasColumnName("floors_total");

                entity.Property(e => e.InspectStatus)
                    .HasColumnName("inspect_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastChangeDate)
                    .HasColumnName("last_change_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEncounterDate)
                    .HasColumnName("last_encounter_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastFollowupDate)
                    .HasColumnName("last_followup_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastInspectTime)
                    .HasColumnName("last_inspect_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastSalesmanFollowupDate)
                    .HasColumnName("last_salesman_followup_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastStatusDate)
                    .HasColumnName("last_status_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineIds)
                    .HasColumnName("lineIDs")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Lines)
                    .HasColumnName("lines")
                    .HasMaxLength(500);

                entity.Property(e => e.LiveStatus).HasColumnName("live_status");

                entity.Property(e => e.LivingRoomNumEnd).HasColumnName("living_room_num_end");

                entity.Property(e => e.LivingRoomNumStart).HasColumnName("living_room_num_start");

                entity.Property(e => e.ManagementFeeEnd).HasColumnName("management_fee_end");

                entity.Property(e => e.ManagementFeeStart).HasColumnName("management_fee_start");

                entity.Property(e => e.ManagementFeeUnit).HasColumnName("management_fee_unit");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(500);

                entity.Property(e => e.MonthlyPayment).HasColumnName("monthly_payment");

                entity.Property(e => e.OfficeClass).HasColumnName("office_class");

                entity.Property(e => e.OfficeType).HasColumnName("office_type");

                entity.Property(e => e.PayType).HasColumnName("pay_type");

                entity.Property(e => e.PublicCustomerType).HasColumnName("public_customer_type");

                entity.Property(e => e.QueryCode).HasColumnName("query_code");

                entity.Property(e => e.RealtyExchangeFlag).HasColumnName("realty_exchange_flag");

                entity.Property(e => e.RegisterDatetime)
                    .HasColumnName("register_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.RentPriceEnd).HasColumnName("rent_price_end");

                entity.Property(e => e.RentPriceStart).HasColumnName("rent_price_start");

                entity.Property(e => e.RentUnit)
                    .HasColumnName("rent_unit")
                    .HasMaxLength(5);

                entity.Property(e => e.RoomNumEnd).HasColumnName("room_num_end");

                entity.Property(e => e.RoomNumStart).HasColumnName("room_num_start");

                entity.Property(e => e.SalePriceEnd).HasColumnName("sale_price_end");

                entity.Property(e => e.SalePriceStart).HasColumnName("sale_price_start");

                entity.Property(e => e.ShareDomain).HasColumnName("share_domain");

                entity.Property(e => e.ShopLocation).HasColumnName("shop_location");

                entity.Property(e => e.ShopTradeName)
                    .HasColumnName("shop_trade_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShopTradeType)
                    .HasColumnName("shop_trade_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopType).HasColumnName("shop_type");

                entity.Property(e => e.SourceType).HasColumnName("source_type");

                entity.Property(e => e.StationIds)
                    .HasColumnName("stationIDs")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Stations)
                    .HasColumnName("stations")
                    .HasMaxLength(500);

                entity.Property(e => e.Toilet).HasColumnName("toilet");

                entity.Property(e => e.ToiletNumEnd).HasColumnName("toilet_num_end");

                entity.Property(e => e.ToiletNumStart).HasColumnName("toilet_num_start");

                entity.Property(e => e.TradeType).HasColumnName("trade_type");

                entity.Property(e => e.TransferFeeEnd).HasColumnName("transfer_fee_end");

                entity.Property(e => e.TransferFeeStart).HasColumnName("transfer_fee_start");

                entity.Property(e => e.UseType).HasColumnName("use_type");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.ToTable("customer_contact");

                entity.HasIndex(e => e.CommitmentNum)
                    .HasName("ix_customer_contact_commintmentNum");

                entity.HasIndex(e => new { e.PhoneCompare, e.PhonePre, e.PhonePost })
                    .HasName("IX_phone_compare");

                entity.HasIndex(e => new { e.Name, e.DeleteFlag, e.NativePlace, e.CustomerId, e.IsMain })
                    .HasName("IX_customerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Appellation).HasColumnName("appellation");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("date");

                entity.Property(e => e.CheckPhoneTime)
                    .HasColumnName("check_phone_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CommitmentNum)
                    .HasColumnName("commitment_num")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsMain).HasColumnName("is_main");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.NativePlace).HasColumnName("native_place");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(260);

                entity.Property(e => e.PhoneCompare)
                    .HasColumnName("phone_compare")
                    .HasColumnType("binary(20)");

                entity.Property(e => e.PhonePost)
                    .HasColumnName("phone_post")
                    .HasColumnType("binary(20)");

                entity.Property(e => e.PhonePre)
                    .HasColumnName("phone_pre")
                    .HasColumnType("binary(20)");

                entity.Property(e => e.PhoneStatus)
                    .HasColumnName("phone_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhoneType).HasColumnName("phone_type");

                entity.Property(e => e.Relation).HasColumnName("relation");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerContactCode>(entity =>
            {
                entity.ToTable("Customer_Contact_Code");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactPhone).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerRcId).HasColumnName("CustomerRcID");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.Property(e => e.PhoneCode)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CustomerEncounter>(entity =>
            {
                entity.ToTable("customer_encounter");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_customerID");

                entity.HasIndex(e => e.Date)
                    .HasName("IX_Date");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => e.RealtyId)
                    .HasName("IX_RealtyID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(500);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.CustomerInfo)
                    .HasColumnName("customer_info")
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerSourceNum)
                    .HasColumnName("customer_source_num")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EncounterCode)
                    .HasColumnName("encounter_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EncounterType).HasColumnName("encounter_type");

                entity.Property(e => e.Feedback)
                    .HasColumnName("feedback")
                    .HasMaxLength(300);

                entity.Property(e => e.InspectStatus)
                    .HasColumnName("inspect_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastInspectTime)
                    .HasColumnName("last_inspect_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");

                entity.Property(e => e.RealtyInfo)
                    .HasColumnName("realty_info")
                    .HasMaxLength(200);

                entity.Property(e => e.SourceNum)
                    .HasColumnName("source_num")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");

                entity.Property(e => e.TradeType).HasColumnName("trade_type");
            });

            modelBuilder.Entity<CustomerFollowup>(entity =>
            {
                entity.ToTable("customer_followup");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => new { e.CustomerFollowupType, e.AuditSourceId, e.EmployeeId, e.CreateTime })
                    .HasName("IX_Date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.BusinessType).HasColumnName("business_type");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerFollowupName)
                    .HasColumnName("customer_followup_name")
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerFollowupType).HasColumnName("customer_followup_type");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(2000);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.TradeType).HasColumnName("trade_type");
            });

            modelBuilder.Entity<CustomerImport>(entity =>
            {
                entity.ToTable("customer_Import");

                entity.Property(e => e.BizRealtyType).HasColumnName("biz_realty_type");

                entity.Property(e => e.CName)
                    .HasColumnName("c_name")
                    .HasMaxLength(35);

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("customer_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(100);

                entity.Property(e => e.IsSucess).HasColumnName("is_sucess");

                entity.Property(e => e.NoMessage)
                    .HasColumnName("No_message")
                    .HasMaxLength(2000);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublicCustomerType).HasColumnName("public_customer_type");

                entity.Property(e => e.RGuid)
                    .HasColumnName("r_guid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SourceType).HasColumnName("source_type");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(30);

                entity.Property(e => e.TradeType).HasColumnName("trade_type");
            });

            modelBuilder.Entity<CustomerInCommuindex>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CommuIndexId, e.BizRealtyType });

                entity.ToTable("customer_in_commuindex");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.CommuIndexId).HasColumnName("commu_indexID");

                entity.Property(e => e.BizRealtyType).HasColumnName("biz_realty_type");
            });

            modelBuilder.Entity<CustomerInEmployee>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.CustomerId });

                entity.ToTable("customer_in_employee");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<CustomerReadDeptInDept>(entity =>
            {
                entity.HasKey(e => new { e.RelationId, e.Id, e.Level, e.RealtyType });

                entity.ToTable("customer_read_dept_in_dept");

                entity.Property(e => e.RelationId).HasColumnName("relationID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.RealtyType).HasColumnName("realty_type");
            });

            modelBuilder.Entity<CustomerSubway>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.SubwayId });

                entity.ToTable("customer_subway");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.SubwayId).HasColumnName("subwayID");
            });

            modelBuilder.Entity<CustomerTrade>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.TradeCode });

                entity.ToTable("customer_trade");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.TradeCode).HasColumnName("trade_code");
            });

            modelBuilder.Entity<CustomSeries>(entity =>
            {
                entity.HasKey(e => e.SeriesId);

                entity.ToTable("custom_series");

                entity.Property(e => e.SeriesId).HasColumnName("seriesID");

                entity.Property(e => e.Example)
                    .HasColumnName("example")
                    .HasMaxLength(50);

                entity.Property(e => e.SeriesContent).HasColumnName("series_content");

                entity.Property(e => e.SeriesName)
                    .HasColumnName("series_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DailyEmployeeDataHcisAll>(entity =>
            {
                entity.ToTable("daily_employee_data_hcis_all");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(30);

                entity.Property(e => e.MoneyRent)
                    .HasColumnName("money_rent")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MoneyRentCount)
                    .HasColumnName("money_rent_count")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MoneySaleFirst)
                    .HasColumnName("money_sale_first")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MoneySaleSecond)
                    .HasColumnName("money_sale_second")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderRent)
                    .HasColumnName("order_rent")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderRentCount)
                    .HasColumnName("order_rent_count")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderSaleFirst)
                    .HasColumnName("order_sale_first")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderSaleSecond)
                    .HasColumnName("order_sale_second")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasColumnType("binary(8)");
            });

            modelBuilder.Entity<DailyEmployeeDataHcisPrimary>(entity =>
            {
                entity.ToTable("daily_employee_data_hcis_primary");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(30);

                entity.Property(e => e.MoneyRent)
                    .HasColumnName("money_rent")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MoneyRentCount)
                    .HasColumnName("money_rent_count")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MoneySaleFirst)
                    .HasColumnName("money_sale_first")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MoneySaleSecond)
                    .HasColumnName("money_sale_second")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderRent)
                    .HasColumnName("order_rent")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderRentCount)
                    .HasColumnName("order_rent_count")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderSaleFirst)
                    .HasColumnName("order_sale_first")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderSaleSecond)
                    .HasColumnName("order_sale_second")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasColumnType("binary(8)");
            });

            modelBuilder.Entity<DailyEmployeeDataHcisPrimaryCommunity>(entity =>
            {
                entity.ToTable("daily_employee_data_hcis_primary_community");

                entity.HasIndex(e => e.CommunityId)
                    .HasName("IX_hcis_primary_community_community_id");

                entity.HasIndex(e => e.EmployeeCode)
                    .HasName("IX_hcis_primary_community_employee_code");

                entity.HasIndex(e => e.StatDate)
                    .HasName("IX_hcis_primary_community_stat_date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.AreaName)
                    .HasColumnName("area_name")
                    .HasMaxLength(30);

                entity.Property(e => e.BigRegionId).HasColumnName("big_region_id");

                entity.Property(e => e.BigRegionName)
                    .HasColumnName("big_region_name")
                    .HasMaxLength(30);

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(30);

                entity.Property(e => e.OrderRent)
                    .HasColumnName("order_rent")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderSale)
                    .HasColumnName("order_sale")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OrderTotal)
                    .HasColumnName("order_total")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ShopId).HasColumnName("shop_id");

                entity.Property(e => e.ShopName)
                    .HasColumnName("shop_name")
                    .HasMaxLength(30);

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("date");

                entity.Property(e => e.TeamCode)
                    .HasColumnName("team_code")
                    .HasMaxLength(30);

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(30);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasColumnType("binary(8)");
            });

            modelBuilder.Entity<DailyEmployeeDataPrimaryCommunity>(entity =>
            {
                entity.ToTable("daily_employee_data_primary_community");

                entity.HasIndex(e => e.EmployeeCode)
                    .HasName("IX_daily_primary_community_employee_code");

                entity.HasIndex(e => e.StatDate)
                    .HasName("IX_daily_primary_community_stat_date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.AreaName)
                    .HasColumnName("area_name")
                    .HasMaxLength(30);

                entity.Property(e => e.BigRegionId).HasColumnName("big_region_id");

                entity.Property(e => e.BigRegionName)
                    .HasColumnName("big_region_name")
                    .HasMaxLength(30);

                entity.Property(e => e.DealRentAll)
                    .HasColumnName("deal_rent_all")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DealRentPrimary)
                    .HasColumnName("deal_rent_primary")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DealRentRate)
                    .HasColumnName("deal_rent_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DealSaleAll)
                    .HasColumnName("deal_sale_all")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DealSalePrimary)
                    .HasColumnName("deal_sale_primary")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DealSaleRate)
                    .HasColumnName("deal_sale_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DealTotalAll)
                    .HasColumnName("deal_total_all")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DealTotalPrimary)
                    .HasColumnName("deal_total_primary")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DealTotalRate)
                    .HasColumnName("deal_total_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EncounterRentAll).HasColumnName("encounter_rent_all");

                entity.Property(e => e.EncounterRentPrimary).HasColumnName("encounter_rent_primary");

                entity.Property(e => e.EncounterRentRate)
                    .HasColumnName("encounter_rent_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.EncounterSaleAll).HasColumnName("encounter_sale_all");

                entity.Property(e => e.EncounterSalePrimary).HasColumnName("encounter_sale_primary");

                entity.Property(e => e.EncounterSaleRate)
                    .HasColumnName("encounter_sale_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.EncounterTotalAll).HasColumnName("encounter_total_all");

                entity.Property(e => e.EncounterTotalPrimary).HasColumnName("encounter_total_primary");

                entity.Property(e => e.EncounterTotalRate)
                    .HasColumnName("encounter_total_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.FallowupTotalAll).HasColumnName("fallowup_total_all");

                entity.Property(e => e.FallowupTotalPrimary).HasColumnName("fallowup_total_primary");

                entity.Property(e => e.FallowupTotalRate)
                    .HasColumnName("fallowup_total_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyCommissionAll).HasColumnName("realty_commission_all");

                entity.Property(e => e.RealtyCommissionPrimary).HasColumnName("realty_commission_primary");

                entity.Property(e => e.RealtyCommissionRate)
                    .HasColumnName("realty_commission_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyKeyAll).HasColumnName("realty_key_all");

                entity.Property(e => e.RealtyKeyPrimary).HasColumnName("realty_key_primary");

                entity.Property(e => e.RealtyKeyRate)
                    .HasColumnName("realty_key_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyRentAll).HasColumnName("realty_rent_all");

                entity.Property(e => e.RealtyRentPrimary).HasColumnName("realty_rent_primary");

                entity.Property(e => e.RealtyRentRate)
                    .HasColumnName("realty_rent_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyRentSaleAll).HasColumnName("realty_rent_sale_all");

                entity.Property(e => e.RealtyRentSalePrimary).HasColumnName("realty_rent_sale_primary");

                entity.Property(e => e.RealtyRentSaleRate)
                    .HasColumnName("realty_rent_sale_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtySaleAll).HasColumnName("realty_sale_all");

                entity.Property(e => e.RealtySalePrimary).HasColumnName("realty_sale_primary");

                entity.Property(e => e.RealtySaleRate)
                    .HasColumnName("realty_sale_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyTotalAll).HasColumnName("realty_total_all");

                entity.Property(e => e.RealtyTotalPrimary).HasColumnName("realty_total_primary");

                entity.Property(e => e.RealtyTotalRate)
                    .HasColumnName("realty_total_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyUpimageAll).HasColumnName("realty_upimage_all");

                entity.Property(e => e.RealtyUpimagePrimary).HasColumnName("realty_upimage_primary");

                entity.Property(e => e.RealtyUpimageRate)
                    .HasColumnName("realty_upimage_rate")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ShopId).HasColumnName("shop_id");

                entity.Property(e => e.ShopName)
                    .HasColumnName("shop_name")
                    .HasMaxLength(30);

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("date");

                entity.Property(e => e.TeamCode)
                    .HasColumnName("team_code")
                    .HasMaxLength(30);

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<DailyEmployeeDataSisPrimaryCommunity>(entity =>
            {
                entity.ToTable("daily_employee_data_sis_primary_community");

                entity.HasIndex(e => e.CommunityId)
                    .HasName("IX_sis_primary_community_community_id");

                entity.HasIndex(e => e.StatDate)
                    .HasName("IX_sis_primary_community_stat_date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.AreaName)
                    .HasColumnName("area_name")
                    .HasMaxLength(30);

                entity.Property(e => e.BigRegionId).HasColumnName("big_region_id");

                entity.Property(e => e.BigRegionName)
                    .HasColumnName("big_region_name")
                    .HasMaxLength(30);

                entity.Property(e => e.CommunityId).HasColumnName("community_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EncounterRent)
                    .HasColumnName("encounter_rent")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.EncounterSale)
                    .HasColumnName("encounter_sale")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.EncounterTotal)
                    .HasColumnName("encounter_total")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyCommission)
                    .HasColumnName("realty_commission")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyFallowup)
                    .HasColumnName("realty_fallowup")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyKey)
                    .HasColumnName("realty_key")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyRent)
                    .HasColumnName("realty_rent")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyRentSale)
                    .HasColumnName("realty_rent_sale")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtySale)
                    .HasColumnName("realty_sale")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyTotal)
                    .HasColumnName("realty_total")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RealtyUpimage)
                    .HasColumnName("realty_upimage")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ShopId).HasColumnName("shop_id");

                entity.Property(e => e.ShopName)
                    .HasColumnName("shop_name")
                    .HasMaxLength(30);

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("date");

                entity.Property(e => e.TeamCode)
                    .HasColumnName("team_code")
                    .HasMaxLength(30);

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<DCommunityAllocation>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentId, e.CommunityId, e.Flag });

                entity.ToTable("d_community_allocation");

                entity.HasIndex(e => e.CommunityId);

                entity.HasIndex(e => e.DepartmentId);

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.CommunityId).HasColumnName("communityID");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.NumberFlag).HasColumnName("number_flag");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptIndex)
                    .HasColumnName("dept_index")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(30);

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.ManagerId).HasColumnName("managerID");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(30);

                entity.Property(e => e.Pinyin)
                    .HasColumnName("pinyin")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.QueryCode).HasColumnName("query_code");

                entity.Property(e => e.SuperDepartmentId).HasColumnName("superDepartmentID");
            });

            modelBuilder.Entity<DepartmentRelation>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.RelationId, e.Level });

                entity.ToTable("department_relation");

                entity.HasIndex(e => new { e.Id, e.RelationId });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RelationId).HasColumnName("relationID");

                entity.Property(e => e.Level).HasColumnName("level");
            });

            modelBuilder.Entity<DepartmentTemplate>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentId, e.TemplateId });

                entity.ToTable("department_template");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.TemplateId).HasColumnName("templateID");
            });

            modelBuilder.Entity<DeptInDept>(entity =>
            {
                entity.HasKey(e => new { e.RelationId, e.Id, e.Level, e.OperationType, e.RealtyType, e.Biztype });

                entity.ToTable("dept_in_dept");

                entity.Property(e => e.RelationId).HasColumnName("relationID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.OperationType).HasColumnName("operation_type");

                entity.Property(e => e.RealtyType).HasColumnName("realty_type");

                entity.Property(e => e.Biztype).HasColumnName("biztype");
            });

            modelBuilder.Entity<DictionaryItem>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.ItemNum });

                entity.ToTable("dictionary_item");

                entity.Property(e => e.RuleId).HasColumnName("ruleID");

                entity.Property(e => e.ItemNum)
                    .HasColumnName("itemNum")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomSeriesId).HasColumnName("customSeriesID");

                entity.Property(e => e.Postfix)
                    .HasColumnName("postfix")
                    .HasMaxLength(50);

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(50);

                entity.Property(e => e.SeriesType).HasColumnName("seriesType");
            });

            modelBuilder.Entity<DictionaryRule>(entity =>
            {
                entity.HasKey(e => e.RuleId);

                entity.ToTable("dictionary_rule");

                entity.Property(e => e.RuleId).HasColumnName("ruleID");

                entity.Property(e => e.ApprovalStatus)
                    .HasColumnName("approvalStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("createTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Example)
                    .HasColumnName("example")
                    .HasMaxLength(50);

                entity.Property(e => e.KeyNum).HasColumnName("keyNum");

                entity.Property(e => e.RuleName)
                    .HasColumnName("ruleName")
                    .HasMaxLength(50);

                entity.Property(e => e.RuleType).HasColumnName("ruleType");
            });

            modelBuilder.Entity<DistrictDef>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.ToTable("district_def");

                entity.Property(e => e.DistrictId)
                    .HasColumnName("districtID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictPinyin)
                    .HasColumnName("district_pinyin")
                    .HasMaxLength(50);

                entity.Property(e => e.PlcdCode).HasColumnName("plcd_code");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_AccountID");

                entity.HasIndex(e => e.DepartmentType)
                    .HasName("IX_Employee_DepartmentType");

                entity.HasIndex(e => e.IsPublic)
                    .HasName("IX_Employee_IsPublic");

                entity.HasIndex(e => new { e.Id, e.Name, e.DepartmentId })
                    .HasName("IX_DepartmentID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasMaxLength(20);

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("date");

                entity.Property(e => e.Blog)
                    .HasColumnName("blog")
                    .HasMaxLength(50);

                entity.Property(e => e.CertificationId)
                    .HasColumnName("certificationID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationType).HasColumnName("certification_type");

                entity.Property(e => e.CisEntryDate)
                    .HasColumnName("CIS_entry_date")
                    .HasColumnType("date");

                entity.Property(e => e.CisPosition).HasColumnName("CIS_position");

                entity.Property(e => e.CisPositionName)
                    .HasColumnName("CIS_position_name")
                    .HasMaxLength(20);

                entity.Property(e => e.CisResignDate)
                    .HasColumnName("CIS_resign_date")
                    .HasColumnType("date");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentType).HasColumnName("department_type");

                entity.Property(e => e.Education).HasColumnName("education");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.EntryDate)
                    .HasColumnName("entry_date")
                    .HasColumnType("date");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Homepage)
                    .HasColumnName("homepage")
                    .HasMaxLength(50);

                entity.Property(e => e.Introduction)
                    .HasColumnName("introduction")
                    .HasMaxLength(200);

                entity.Property(e => e.IsManager).HasColumnName("is_manager");

                entity.Property(e => e.IsPublic).HasColumnName("is_public");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnName("last_login_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(35);

                entity.Property(e => e.Nation).HasColumnName("nation");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(30);

                entity.Property(e => e.Phonecode)
                    .HasColumnName("phonecode")
                    .HasMaxLength(10);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pinyin)
                    .HasColumnName("pinyin")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.PositionStatus).HasColumnName("position_status");

                entity.Property(e => e.ResignDate)
                    .HasColumnName("resign_date")
                    .HasColumnType("date");

                entity.Property(e => e.RoleId).HasColumnName("roleID");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.ShopPhone).HasMaxLength(20);

                entity.Property(e => e.ShopPhoneOpx).HasMaxLength(20);

                entity.Property(e => e.SisPermission).HasColumnName("sis_permission");

                entity.Property(e => e.UnifiedAccountId).HasColumnName("UnifiedAccountID");

                entity.Property(e => e.University)
                    .HasColumnName("university")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkLicense)
                    .HasColumnName("work_license")
                    .HasMaxLength(30);

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("work_phone")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<EmployeeCommunitys>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.CommunityId });

                entity.ToTable("employee_communitys");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.CommunityId).HasColumnName("communityID");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<EmployeeLogin>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("employee_login");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastLoginDate)
                    .HasColumnName("last_login_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeMessage>(entity =>
            {
                entity.ToTable("employee_message");

                entity.HasIndex(e => e.EmployeeCode)
                    .HasName("IX_employee_message");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountCd)
                    .HasColumnName("AccountCD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("date");

                entity.Property(e => e.CertificationId)
                    .HasColumnName("certification_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CertificationType).HasColumnName("certification_type");

                entity.Property(e => e.CisPosition).HasColumnName("cis_position");

                entity.Property(e => e.CisPositionName)
                    .HasColumnName("cis_position_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(60);

                entity.Property(e => e.Education).HasColumnName("education");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EntryDate)
                    .HasColumnName("entry_date")
                    .HasColumnType("date");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(500);

                entity.Property(e => e.MsgCode).HasColumnName("msg_code");

                entity.Property(e => e.MsgState).HasColumnName("msg_state");

                entity.Property(e => e.MsgTime)
                    .HasColumnName("msg_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PositionStatus).HasColumnName("position_status");

                entity.Property(e => e.ResignDate)
                    .HasColumnName("resign_date")
                    .HasColumnType("date");

                entity.Property(e => e.RespTime)
                    .HasColumnName("resp_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.ShopPhone).HasMaxLength(20);

                entity.Property(e => e.ShopPhoneOpx).HasMaxLength(20);

                entity.Property(e => e.University)
                    .HasColumnName("university")
                    .HasMaxLength(50);

                entity.Property(e => e.ValidDate)
                    .HasColumnName("valid_date")
                    .HasColumnType("date");

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("work_phone")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<EmployeePerformanceReportFinal>(entity =>
            {
                entity.ToTable("employee_performance_report_final");

                entity.HasIndex(e => new { e.StatDate, e.EmployeeCode, e.TeamCode, e.DepartmentCode, e.AreaCode, e.RegionCode, e.BigRegionCode, e.RegionName, e.EmployeeId, e.EmployeeName, e.DepartmentName, e.BigRegionName, e.AreaName, e.TeamName, e.IsCount })
                    .HasName("IX_Emp_Performance_Report_Final");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AchievementFirstLx)
                    .HasColumnName("achievement_firstLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementFirstnoneLx)
                    .HasColumnName("achievement_firstnoneLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementOther)
                    .HasColumnName("achievement_other")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementRent)
                    .HasColumnName("achievement_rent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementRentCf)
                    .HasColumnName("achievement_rentCF")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementRentZh)
                    .HasColumnName("achievement_rentZH")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementRentZz)
                    .HasColumnName("achievement_rentZZ")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementSecond)
                    .HasColumnName("achievement_second")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus12r)
                    .HasColumnName("add_cus12r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus12s)
                    .HasColumnName("add_cus12s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus1r)
                    .HasColumnName("add_cus1r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus1s)
                    .HasColumnName("add_cus1s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus2r)
                    .HasColumnName("add_cus2r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus2s)
                    .HasColumnName("add_cus2s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone12r)
                    .HasColumnName("add_cusone12r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone12s)
                    .HasColumnName("add_cusone12s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone1r)
                    .HasColumnName("add_cusone1r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone1s)
                    .HasColumnName("add_cusone1s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone2r)
                    .HasColumnName("add_cusone2r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone2s)
                    .HasColumnName("add_cusone2s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth12r)
                    .HasColumnName("add_cusoth12r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth12s)
                    .HasColumnName("add_cusoth12s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth1r)
                    .HasColumnName("add_cusoth1r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth1s)
                    .HasColumnName("add_cusoth1s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth2r)
                    .HasColumnName("add_cusoth2r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth2s)
                    .HasColumnName("add_cusoth2s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerRent)
                    .HasColumnName("add_customer_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerSale)
                    .HasColumnName("add_customer_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerSum)
                    .HasColumnName("add_customer_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerfirstRent)
                    .HasColumnName("add_customerfirst_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerfirstSale)
                    .HasColumnName("add_customerfirst_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerotherRent)
                    .HasColumnName("add_customerother_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerotherSale)
                    .HasColumnName("add_customerother_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomersecondRent)
                    .HasColumnName("add_customersecond_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomersecondSale)
                    .HasColumnName("add_customersecond_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo12r)
                    .HasColumnName("add_custwo12r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo12s)
                    .HasColumnName("add_custwo12s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo1r)
                    .HasColumnName("add_custwo1r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo1s)
                    .HasColumnName("add_custwo1s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo2r)
                    .HasColumnName("add_custwo2r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo2s)
                    .HasColumnName("add_custwo2s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyRent)
                    .HasColumnName("add_realty_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyRentsale)
                    .HasColumnName("add_realty_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtySale)
                    .HasColumnName("add_realty_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtySum)
                    .HasColumnName("add_realty_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyfirstRent)
                    .HasColumnName("add_realtyfirst_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyfirstRentsale)
                    .HasColumnName("add_realtyfirst_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyfirstSale)
                    .HasColumnName("add_realtyfirst_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyotherRent)
                    .HasColumnName("add_realtyother_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyotherRentsale)
                    .HasColumnName("add_realtyother_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyotherSale)
                    .HasColumnName("add_realtyother_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtysecondRent)
                    .HasColumnName("add_realtysecond_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtysecondRentsale)
                    .HasColumnName("add_realtysecond_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtysecondSale)
                    .HasColumnName("add_realtysecond_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AreEmployeeName)
                    .HasColumnName("are_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaCode)
                    .HasColumnName("area_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaEmployeeCode)
                    .HasColumnName("area_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasColumnName("area_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BigRegionCode)
                    .HasColumnName("big_region_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BigRegionName)
                    .HasColumnName("big_region_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("department_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DepositMoneyFirstLx)
                    .HasColumnName("deposit_money_firstLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositMoneyFirstnoneLx)
                    .HasColumnName("deposit_money_firstnoneLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositMoneyOther)
                    .HasColumnName("deposit_money_other")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositMoneyRent)
                    .HasColumnName("deposit_money_rent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositMoneyRentagent)
                    .HasColumnName("deposit_money_rentagent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositMoneySecond)
                    .HasColumnName("deposit_money_second")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumFirstLx)
                    .HasColumnName("deposit_num_firstLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumFirstnoneLx)
                    .HasColumnName("deposit_num_firstnoneLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumOther)
                    .HasColumnName("deposit_num_other")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumRent)
                    .HasColumnName("deposit_num_rent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumRentagent)
                    .HasColumnName("deposit_num_rentagent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumSecond)
                    .HasColumnName("deposit_num_second")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptEmployeeCode)
                    .HasColumnName("dept_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeptEmployeeName)
                    .HasColumnName("dept_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpFlag).HasColumnName("emp_flag");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EncounterMix)
                    .HasColumnName("encounter_mix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EncounterRent)
                    .HasColumnName("encounter_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EncounterSaleFirst)
                    .HasColumnName("encounter_sale_first")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EncounterSaleSecond)
                    .HasColumnName("encounter_sale_second")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EntryDate)
                    .HasColumnName("entry_date")
                    .HasColumnType("date");

                entity.Property(e => e.FollowupCustomer)
                    .HasColumnName("followup_customer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FollowupRealty)
                    .HasColumnName("followup_realty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FollowupSum)
                    .HasColumnName("followup_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HashCode)
                    .HasColumnName("hash_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsCount).HasColumnName("is_count");

                entity.Property(e => e.JobId).HasColumnName("jobID");

                entity.Property(e => e.JobName)
                    .HasColumnName("job_name")
                    .HasMaxLength(50);

                entity.Property(e => e.KeyRealtySum)
                    .HasColumnName("key_realty_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegionCode)
                    .HasColumnName("region_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegionEmployeeCode)
                    .HasColumnName("region_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegionEmployeeName)
                    .HasColumnName("region_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionName)
                    .HasColumnName("region_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SoleAgentOrdinary)
                    .HasColumnName("sole_agent_ordinary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoleAgentRent)
                    .HasColumnName("sole_agent_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoleAgentTime)
                    .HasColumnName("sole_agent_time")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("date");

                entity.Property(e => e.TeamCode)
                    .HasColumnName("team_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamEmployeeCode)
                    .HasColumnName("team_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TeamEmployeeName)
                    .HasColumnName("team_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TeamId).HasColumnName("teamID");

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionNumFirstLx)
                    .HasColumnName("transaction_num_firstLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNumFirstnoneLx)
                    .HasColumnName("transaction_num_firstnoneLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNumOther)
                    .HasColumnName("transaction_num_other")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNumRent)
                    .HasColumnName("transaction_num_rent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNumRentagent)
                    .HasColumnName("transaction_num_rentagent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNumSecond)
                    .HasColumnName("transaction_num_second")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateFlag)
                    .HasColumnName("update_flag")
                    .IsRowVersion();

                entity.Property(e => e.UpimageRent)
                    .HasColumnName("upimage_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpimageRentsale)
                    .HasColumnName("upimage_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpimageSale)
                    .HasColumnName("upimage_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpimageSum)
                    .HasColumnName("upimage_sum")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EmployeePerformanceReportFinalManager>(entity =>
            {
                entity.ToTable("employee_performance_report_final_manager");

                entity.HasIndex(e => new { e.EmployeeCode, e.StatDate, e.RegionCode, e.EmployeeId })
                    .HasName("IX_employee_performance_report_final_manager");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AchievementFirstLx)
                    .HasColumnName("achievement_firstLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementFirstnoneLx)
                    .HasColumnName("achievement_firstnoneLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementOther)
                    .HasColumnName("achievement_other")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementRent)
                    .HasColumnName("achievement_rent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementRentCf)
                    .HasColumnName("achievement_rentCF")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementRentZh)
                    .HasColumnName("achievement_rentZH")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementRentZz)
                    .HasColumnName("achievement_rentZZ")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AchievementSecond)
                    .HasColumnName("achievement_second")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus12r)
                    .HasColumnName("add_cus12r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus12s)
                    .HasColumnName("add_cus12s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus1r)
                    .HasColumnName("add_cus1r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus1s)
                    .HasColumnName("add_cus1s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus2r)
                    .HasColumnName("add_cus2r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCus2s)
                    .HasColumnName("add_cus2s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone12r)
                    .HasColumnName("add_cusone12r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone12s)
                    .HasColumnName("add_cusone12s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone1r)
                    .HasColumnName("add_cusone1r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone1s)
                    .HasColumnName("add_cusone1s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone2r)
                    .HasColumnName("add_cusone2r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusone2s)
                    .HasColumnName("add_cusone2s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth12r)
                    .HasColumnName("add_cusoth12r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth12s)
                    .HasColumnName("add_cusoth12s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth1r)
                    .HasColumnName("add_cusoth1r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth1s)
                    .HasColumnName("add_cusoth1s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth2r)
                    .HasColumnName("add_cusoth2r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCusoth2s)
                    .HasColumnName("add_cusoth2s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerRent)
                    .HasColumnName("add_customer_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerSale)
                    .HasColumnName("add_customer_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerSum)
                    .HasColumnName("add_customer_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerfirstRent)
                    .HasColumnName("add_customerfirst_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerfirstSale)
                    .HasColumnName("add_customerfirst_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerotherRent)
                    .HasColumnName("add_customerother_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerotherSale)
                    .HasColumnName("add_customerother_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomersecondRent)
                    .HasColumnName("add_customersecond_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomersecondSale)
                    .HasColumnName("add_customersecond_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo12r)
                    .HasColumnName("add_custwo12r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo12s)
                    .HasColumnName("add_custwo12s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo1r)
                    .HasColumnName("add_custwo1r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo1s)
                    .HasColumnName("add_custwo1s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo2r)
                    .HasColumnName("add_custwo2r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustwo2s)
                    .HasColumnName("add_custwo2s")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyRent)
                    .HasColumnName("add_realty_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyRentsale)
                    .HasColumnName("add_realty_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtySale)
                    .HasColumnName("add_realty_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtySum)
                    .HasColumnName("add_realty_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyfirstRent)
                    .HasColumnName("add_realtyfirst_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyfirstRentsale)
                    .HasColumnName("add_realtyfirst_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyfirstSale)
                    .HasColumnName("add_realtyfirst_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyotherRent)
                    .HasColumnName("add_realtyother_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyotherRentsale)
                    .HasColumnName("add_realtyother_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyotherSale)
                    .HasColumnName("add_realtyother_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtysecondRent)
                    .HasColumnName("add_realtysecond_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtysecondRentsale)
                    .HasColumnName("add_realtysecond_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtysecondSale)
                    .HasColumnName("add_realtysecond_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AreEmployeeName)
                    .HasColumnName("are_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaCode)
                    .HasColumnName("area_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaEmployeeCode)
                    .HasColumnName("area_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasColumnName("area_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BigRegionCode)
                    .HasColumnName("big_region_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BigRegionName)
                    .HasColumnName("big_region_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("department_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DepositMoneyFirstLx)
                    .HasColumnName("deposit_money_firstLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositMoneyFirstnoneLx)
                    .HasColumnName("deposit_money_firstnoneLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositMoneyOther)
                    .HasColumnName("deposit_money_other")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositMoneyRent)
                    .HasColumnName("deposit_money_rent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositMoneyRentagent)
                    .HasColumnName("deposit_money_rentagent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositMoneySecond)
                    .HasColumnName("deposit_money_second")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumFirstLx)
                    .HasColumnName("deposit_num_firstLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumFirstnoneLx)
                    .HasColumnName("deposit_num_firstnoneLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumOther)
                    .HasColumnName("deposit_num_other")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumRent)
                    .HasColumnName("deposit_num_rent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumRentagent)
                    .HasColumnName("deposit_num_rentagent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositNumSecond)
                    .HasColumnName("deposit_num_second")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptEmployeeCode)
                    .HasColumnName("dept_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeptEmployeeName)
                    .HasColumnName("dept_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpFlag).HasColumnName("emp_flag");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EncounterMix)
                    .HasColumnName("encounter_mix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EncounterRent)
                    .HasColumnName("encounter_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EncounterSaleFirst)
                    .HasColumnName("encounter_sale_first")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EncounterSaleSecond)
                    .HasColumnName("encounter_sale_second")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EntryDate)
                    .HasColumnName("entry_date")
                    .HasColumnType("date");

                entity.Property(e => e.FollowupCustomer)
                    .HasColumnName("followup_customer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FollowupRealty)
                    .HasColumnName("followup_realty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FollowupSum)
                    .HasColumnName("followup_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HashCode)
                    .HasColumnName("hash_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsCount).HasColumnName("is_count");

                entity.Property(e => e.JobId).HasColumnName("jobID");

                entity.Property(e => e.JobName)
                    .HasColumnName("job_name")
                    .HasMaxLength(50);

                entity.Property(e => e.KeyRealtySum)
                    .HasColumnName("key_realty_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegionCode)
                    .HasColumnName("region_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegionEmployeeCode)
                    .HasColumnName("region_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegionEmployeeName)
                    .HasColumnName("region_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionName)
                    .HasColumnName("region_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SoleAgentOrdinary)
                    .HasColumnName("sole_agent_ordinary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoleAgentRent)
                    .HasColumnName("sole_agent_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoleAgentTime)
                    .HasColumnName("sole_agent_time")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("date");

                entity.Property(e => e.TeamCode)
                    .HasColumnName("team_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamEmployeeCode)
                    .HasColumnName("team_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TeamEmployeeName)
                    .HasColumnName("team_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TeamId).HasColumnName("teamID");

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionNumFirstLx)
                    .HasColumnName("transaction_num_firstLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNumFirstnoneLx)
                    .HasColumnName("transaction_num_firstnoneLX")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNumOther)
                    .HasColumnName("transaction_num_other")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNumRent)
                    .HasColumnName("transaction_num_rent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNumRentagent)
                    .HasColumnName("transaction_num_rentagent")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionNumSecond)
                    .HasColumnName("transaction_num_second")
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateFlag)
                    .HasColumnName("update_flag")
                    .IsRowVersion();

                entity.Property(e => e.UpimageRent)
                    .HasColumnName("upimage_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpimageRentsale)
                    .HasColumnName("upimage_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpimageSale)
                    .HasColumnName("upimage_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpimageSum)
                    .HasColumnName("upimage_sum")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EmployeePlanMonthly>(entity =>
            {
                entity.ToTable("employee_plan_monthly");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerFollowups).HasColumnName("customer_followups");

                entity.Property(e => e.CustomerForBuy).HasColumnName("customer_for_buy");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.IntroductionTotal).HasColumnName("introduction_total");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasColumnType("text");

                entity.Property(e => e.RealtyFollowups).HasColumnName("realty_followups");

                entity.Property(e => e.RealtyForRent).HasColumnName("realty_for_rent");

                entity.Property(e => e.RealtyForSale).HasColumnName("realty_for_sale");

                entity.Property(e => e.RentPerformance).HasColumnName("rent_performance");

                entity.Property(e => e.RentTotal).HasColumnName("rent_total");

                entity.Property(e => e.SalePerformance).HasColumnName("sale_performance");

                entity.Property(e => e.SaleTotal).HasColumnName("sale_total");

                entity.Property(e => e.SoleRealtyTotal).HasColumnName("sole_realty_total");

                entity.Property(e => e.TotalKeys).HasColumnName("total_keys");
            });

            modelBuilder.Entity<EmployeeTmp>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("employee_tmp");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CisEntryDate)
                    .HasColumnName("CIS_entry_date")
                    .HasColumnType("date");

                entity.Property(e => e.CisResignDate)
                    .HasColumnName("CIS_resign_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<HouseCheck>(entity =>
            {
                entity.ToTable("House_Check");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckDepartmentId).HasColumnName("Check_Department_Id");

                entity.Property(e => e.CheckDepartmentName)
                    .IsRequired()
                    .HasColumnName("Check_Department_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckEmployeeId).HasColumnName("Check_Employee_ID");

                entity.Property(e => e.CheckEmployeeName)
                    .IsRequired()
                    .HasColumnName("Check_Employee_Name")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("Create_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_Flag");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.HouseCheckNo)
                    .IsRequired()
                    .HasColumnName("HouseCheckNO")
                    .HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpDate)
                    .HasColumnName("UP_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemsDictionary>(entity =>
            {
                entity.ToTable("items_dictionary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.TemplateItemId).HasColumnName("template_itemID");

                entity.Property(e => e.Values).HasColumnName("values");
            });

            modelBuilder.Entity<KoofunWebSiteList>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineStation>(entity =>
            {
                entity.HasKey(e => new { e.LineId, e.StationId });

                entity.ToTable("line_station");

                entity.Property(e => e.LineId).HasColumnName("lineID");

                entity.Property(e => e.StationId).HasColumnName("stationID");

                entity.Property(e => e.Index).HasColumnName("index");
            });

            modelBuilder.Entity<MailEmployee>(entity =>
            {
                entity.ToTable("mail_employee");

                entity.HasIndex(e => new { e.Deleted, e.RecipientId, e.SendingDatetime })
                    .HasName("IX_mail_employee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.MailId).HasColumnName("mailID");

                entity.Property(e => e.MailStatus).HasColumnName("mail_status");

                entity.Property(e => e.RecipientId).HasColumnName("recipientID");

                entity.Property(e => e.SendingDatetime)
                    .HasColumnName("sending_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Mission>(entity =>
            {
                entity.ToTable("mission");

                entity.HasIndex(e => e.ApproveEmployeeId)
                    .HasName("IX_Approve_EmployeeID");

                entity.HasIndex(e => e.CreateDatetime)
                    .HasName("IX_DateTime");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => e.ExpectedApprovedDatetime)
                    .HasName("IX_expected_approved_datetime");

                entity.HasIndex(e => e.SourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => e.ToEmployeeId)
                    .HasName("IX_to_employeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApproveDepartmentId).HasColumnName("approve_departmentID");

                entity.Property(e => e.ApproveDepartmentName)
                    .HasColumnName("approve_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ApproveEmployeeId).HasColumnName("approve_employeeID");

                entity.Property(e => e.ApproveEmployeeName)
                    .HasColumnName("approve_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.BizType).HasColumnName("biz_type");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.CompletedDatetime)
                    .HasColumnName("completed_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompletedMemo)
                    .HasColumnName("completed_memo")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeDepartmentId).HasColumnName("employee_departmentID");

                entity.Property(e => e.EmployeeDepartmentName)
                    .HasColumnName("employee_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.EmployeeType)
                    .HasColumnName("employee_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedApprovedDatetime)
                    .HasColumnName("expected_approved_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MissionDescription)
                    .HasColumnName("mission_description")
                    .HasColumnType("text");

                entity.Property(e => e.OldEmployeeName)
                    .HasColumnName("old_employee_name")
                    .HasMaxLength(20);

                entity.Property(e => e.PublicCustomerType).HasColumnName("public_customer_type");

                entity.Property(e => e.SourceId).HasColumnName("sourceID");

                entity.Property(e => e.SourceNum)
                    .HasColumnName("source_num")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceSubType).HasColumnName("source_sub_type");

                entity.Property(e => e.ToEmployeeDepartmentId).HasColumnName("to_employee_departmentID");

                entity.Property(e => e.ToEmployeeDepartmentName)
                    .HasColumnName("to_employee_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ToEmployeeId).HasColumnName("to_employeeID");

                entity.Property(e => e.ToEmployeeName)
                    .HasColumnName("to_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.ToPublicCustomerType).HasColumnName("to_public_customer_type");

                entity.Property(e => e.ToTradeStatus).HasColumnName("to_trade_status");

                entity.Property(e => e.ToTradeType).HasColumnName("to_trade_type");

                entity.Property(e => e.TradeStatus)
                    .HasColumnName("trade_status")
                    .HasMaxLength(10);

                entity.Property(e => e.TradeType)
                    .HasColumnName("trade_type")
                    .HasMaxLength(10);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<NbusinessDepartment>(entity =>
            {
                entity.ToTable("nbusiness_department");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptIndex)
                    .HasColumnName("dept_index")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(30);

                entity.Property(e => e.ManagerId).HasColumnName("managerID");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(30);

                entity.Property(e => e.Pinyin)
                    .HasColumnName("pinyin")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuperDepartmentId).HasColumnName("superDepartmentID");
            });

            modelBuilder.Entity<NbusinessInDepartment>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.DepartmentId });

                entity.ToTable("nbusiness_in_department");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");
            });

            modelBuilder.Entity<PerformanceFieldConfig>(entity =>
            {
                entity.HasIndex(e => new { e.EmpId, e.FieldType })
                    .HasName("PK_PerfomanceFieldConfig");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Config).HasColumnType("text");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PerformanceStat>(entity =>
            {
                entity.ToTable("performance_stat");

                entity.HasIndex(e => e.BaseItemId)
                    .HasName("IX_BaseItemID");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => new { e.ApproveStatus, e.StatDate, e.DepartmentId, e.EmployeeId })
                    .HasName("IX_StatDateEmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApproveStatus).HasColumnName("approve_status");

                entity.Property(e => e.BaseItemId).HasColumnName("base_itemID");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ItemScore)
                    .HasColumnName("item_score")
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemValue)
                    .HasColumnName("item_value")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ItemValueScore)
                    .HasColumnName("item_value_score")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<PerformanceTemplate>(entity =>
            {
                entity.ToTable("performance_template");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateEmployeeId).HasColumnName("create_employeeID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.Values).HasColumnName("values");
            });

            modelBuilder.Entity<PublicUserPerformance>(entity =>
            {
                entity.ToTable("Public_User_Performance");

                entity.HasIndex(e => new { e.EmployeeCode, e.RegionCode, e.StatDate, e.DepartmentCode, e.BigRegionCode, e.AreaCode, e.TeamCode, e.EmployeeId, e.EmployeeName })
                    .HasName("IX_Public_User_Performance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddCustomerRent)
                    .HasColumnName("add_customer_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerSale)
                    .HasColumnName("add_customer_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerSum)
                    .HasColumnName("add_customer_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerfirstRent)
                    .HasColumnName("add_customerfirst_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerfirstSale)
                    .HasColumnName("add_customerfirst_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerotherRent)
                    .HasColumnName("add_customerother_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomerotherSale)
                    .HasColumnName("add_customerother_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomersecondRent)
                    .HasColumnName("add_customersecond_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddCustomersecondSale)
                    .HasColumnName("add_customersecond_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyRent)
                    .HasColumnName("add_realty_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyRentsale)
                    .HasColumnName("add_realty_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtySale)
                    .HasColumnName("add_realty_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtySum)
                    .HasColumnName("add_realty_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyfirstRent)
                    .HasColumnName("add_realtyfirst_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyfirstRentsale)
                    .HasColumnName("add_realtyfirst_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyfirstSale)
                    .HasColumnName("add_realtyfirst_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyotherRent)
                    .HasColumnName("add_realtyother_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyotherRentsale)
                    .HasColumnName("add_realtyother_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtyotherSale)
                    .HasColumnName("add_realtyother_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtysecondRent)
                    .HasColumnName("add_realtysecond_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtysecondRentsale)
                    .HasColumnName("add_realtysecond_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddRealtysecondSale)
                    .HasColumnName("add_realtysecond_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AreEmployeeName)
                    .HasColumnName("are_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaCode)
                    .HasColumnName("area_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaEmployeeCode)
                    .HasColumnName("area_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AreaName)
                    .HasColumnName("area_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BigRegionCode)
                    .HasColumnName("big_region_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BigRegionName)
                    .HasColumnName("big_region_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("department_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DeptEmployeeCode)
                    .HasColumnName("dept_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeptEmployeeName)
                    .HasColumnName("dept_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpFlag).HasColumnName("emp_flag");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EntryDate)
                    .HasColumnName("entry_date")
                    .HasColumnType("date");

                entity.Property(e => e.HashCode)
                    .HasColumnName("hash_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsCount)
                    .HasColumnName("is_count")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobId).HasColumnName("jobID");

                entity.Property(e => e.JobName)
                    .HasColumnName("job_name")
                    .HasMaxLength(50);

                entity.Property(e => e.KeyRealtySum)
                    .HasColumnName("key_realty_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RegionCode)
                    .HasColumnName("region_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegionEmployeeCode)
                    .HasColumnName("region_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegionEmployeeName)
                    .HasColumnName("region_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionName)
                    .HasColumnName("region_name")
                    .HasMaxLength(50);

                entity.Property(e => e.SoleAgentOrdinary)
                    .HasColumnName("sole_agent_ordinary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoleAgentRent)
                    .HasColumnName("sole_agent_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoleAgentSum)
                    .HasColumnName("sole_agent_sum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoleAgentTime)
                    .HasColumnName("sole_agent_time")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("date");

                entity.Property(e => e.TeamCode)
                    .HasColumnName("team_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamEmployeeCode)
                    .HasColumnName("team_employee_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TeamEmployeeName)
                    .HasColumnName("team_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TeamId).HasColumnName("teamID");

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateFlag)
                    .HasColumnName("update_flag")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Realty>(entity =>
            {
                entity.ToTable("realty");

                entity.HasIndex(e => e.BuildingId)
                    .HasName("IX_buildingID");

                entity.HasIndex(e => e.CommunityId)
                    .HasName("IX_communityID");

                entity.HasIndex(e => e.CommunityIndexId)
                    .HasName("IX_communityIndexID");

                entity.HasIndex(e => e.DistrictId)
                    .HasName("IX_districtID");

                entity.HasIndex(e => e.FilingDepartmentId)
                    .HasName("IX_filingDepartmentID");

                entity.HasIndex(e => e.FilingEmployeeId)
                    .HasName("IX_filingEmployeeID");

                entity.HasIndex(e => e.KeyDepartmentId)
                    .HasName("IX_keyDepartmentID");

                entity.HasIndex(e => e.KeyEmployeeId)
                    .HasName("IX_keyEmployeeID");

                entity.HasIndex(e => e.RealtyNum)
                    .HasName("IX_realtyNum");

                entity.HasIndex(e => e.RegisterDepartmentId)
                    .HasName("IX_registerDepartmentID");

                entity.HasIndex(e => e.RegisterEmployeeId)
                    .HasName("IX_registerEmployeeID");

                entity.HasIndex(e => e.RentDepartmentId)
                    .HasName("IX_rentDepartmentID");

                entity.HasIndex(e => e.RentEmployeeId)
                    .HasName("IX_rentEmployeeID");

                entity.HasIndex(e => e.RoomId)
                    .HasName("IX_roomID");

                entity.HasIndex(e => e.SaleDepartmentId)
                    .HasName("IX_saleDepartmentID");

                entity.HasIndex(e => e.SaleEmployeeId)
                    .HasName("IX_saleEmployeeID");

                entity.HasIndex(e => e.SoleAgentDepartmentId)
                    .HasName("IX_soleAgentDepartmentID");

                entity.HasIndex(e => e.SoleAgentEmployeeId)
                    .HasName("IX_soleAgentEmployeeID");

                entity.HasIndex(e => new { e.RealtyId, e.DeleteFlag })
                    .HasName("IX_deleted_flag_withID");

                entity.HasIndex(e => new { e.RentEmployeeId, e.SaleEmployeeId, e.KeyEmployeeId, e.SoleAgentEmployeeId, e.FilingEmployeeId })
                    .HasName("IX_For_Report");

                entity.HasIndex(e => new { e.TradeType, e.RealtyStatus, e.RentEmployeeId, e.RentDepartmentId, e.DeleteFlag, e.RentCommissionDate })
                    .HasName("IX_forreport_rent_commission_date");

                entity.HasIndex(e => new { e.TradeType, e.RealtyStatus, e.SaleEmployeeId, e.SaleDepartmentId, e.DeleteFlag, e.SaleCommissionDate })
                    .HasName("IX_forreport_sale_commission_date");

                entity.HasIndex(e => new { e.RentDepartmentId, e.SaleDepartmentId, e.LockFlag, e.RealtyId, e.RentEmployeeId, e.SaleEmployeeId, e.SalePrice, e.RentQueryCode, e.SaleQueryCode, e.DistrictId, e.LastFollowupDate, e.OriginalRegisterDate, e.RentCommissionDate, e.SaleCommissionDate, e.OpeningDatetime, e.LastUpdateDate, e.RentPrice, e.ConstructionArea, e.BambooFlag, e.RentAgencyFlag, e.CommunityId, e.CommunityIndexId, e.RealtyType, e.DeleteFlag, e.RealtyStatus, e.TradeType, e.CommissionDate })
                    .HasName("IX_Case5_Flags");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100);

                entity.Property(e => e.AirConditionerType).HasColumnName("air_conditioner_type");

                entity.Property(e => e.AirConditioningFee).HasColumnName("air_conditioning_fee");

                entity.Property(e => e.AirConditioningFeeUnit)
                    .HasColumnName("air_conditioning_fee_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.AreaCreated).HasColumnName("area_created");

                entity.Property(e => e.BalconyNum).HasColumnName("balcony_num");

                entity.Property(e => e.BambooFlag).HasColumnName("bamboo_flag");

                entity.Property(e => e.BasePrice).HasColumnName("base_price");

                entity.Property(e => e.BaseUnitPrice).HasColumnName("base_unit_price");

                entity.Property(e => e.BuildingId).HasColumnName("buildingID");

                entity.Property(e => e.BuildingName)
                    .HasColumnName("building_name")
                    .HasMaxLength(80);

                entity.Property(e => e.CertificateFlag).HasColumnName("Certificate_flag");

                entity.Property(e => e.CertificationDate)
                    .HasColumnName("certification_date")
                    .HasColumnType("date");

                entity.Property(e => e.CertificationYears).HasColumnName("certification_years");

                entity.Property(e => e.CommissionDate)
                    .HasColumnName("commission_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CommissionNum)
                    .HasColumnName("commission_num")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionType).HasColumnName("commission_type");

                entity.Property(e => e.CommitmentFlag).HasColumnName("commitment_flag");

                entity.Property(e => e.CommunityAlias)
                    .HasColumnName("community_alias")
                    .HasMaxLength(30);

                entity.Property(e => e.CommunityId).HasColumnName("communityID");

                entity.Property(e => e.CommunityIndexId).HasColumnName("community_indexID");

                entity.Property(e => e.CommunityIndexName)
                    .HasColumnName("community_index_name")
                    .HasMaxLength(20);

                entity.Property(e => e.CommunityName)
                    .HasColumnName("community_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ConstructionArea).HasColumnName("construction_area");

                entity.Property(e => e.ConstructionType).HasColumnName("construction_type");

                entity.Property(e => e.DataFrom).HasColumnName("dataFrom");

                entity.Property(e => e.DecorationLevel).HasColumnName("decoration_level");

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("delivery_date")
                    .HasColumnType("date");

                entity.Property(e => e.DictionaryFlag).HasColumnName("dictionary_flag");

                entity.Property(e => e.DistrictId).HasColumnName("districtID");

                entity.Property(e => e.DistrictName)
                    .HasColumnName("district_name")
                    .HasMaxLength(20);

                entity.Property(e => e.ExRentDepartmentId).HasColumnName("ex_rent_departmentID");

                entity.Property(e => e.ExRentDepartmentName)
                    .HasColumnName("ex_rent_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ExRentEmployeeId).HasColumnName("ex_rent_employeeID");

                entity.Property(e => e.ExRentEmployeeName)
                    .HasColumnName("ex_rent_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.ExSaleDepartmentId).HasColumnName("ex_sale_departmentID");

                entity.Property(e => e.ExSaleDepartmentName)
                    .HasColumnName("ex_sale_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ExSaleEmployeeId).HasColumnName("ex_sale_employeeID");

                entity.Property(e => e.ExSaleEmployeeName)
                    .HasColumnName("ex_sale_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.FaceOrientation).HasColumnName("face_orientation");

                entity.Property(e => e.Facilities)
                    .HasColumnName("facilities")
                    .HasMaxLength(400);

                entity.Property(e => e.FamilyUnique).HasColumnName("family_unique");

                entity.Property(e => e.FilingDepartmentId).HasColumnName("filing_departmentID");

                entity.Property(e => e.FilingDepartmentName)
                    .HasColumnName("filing_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.FilingEmployeeId).HasColumnName("filing_employeeID");

                entity.Property(e => e.FilingEmployeeName)
                    .HasColumnName("filing_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.FilingEndDate)
                    .HasColumnName("filing_end_date")
                    .HasColumnType("date");

                entity.Property(e => e.FilingNum)
                    .HasColumnName("filing_num")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilingStartDate)
                    .HasColumnName("filing_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.FloorName)
                    .HasColumnName("floor_name")
                    .HasMaxLength(10);

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.FloorsTotal).HasColumnName("floors_total");

                entity.Property(e => e.HouseCheckFlag).HasColumnName("HouseCheck_flag");

                entity.Property(e => e.ImageFlag).HasColumnName("image_flag");

                entity.Property(e => e.InspectStatus)
                    .HasColumnName("inspect_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyDepartmentId).HasColumnName("key_departmentID");

                entity.Property(e => e.KeyDepartmentName)
                    .HasColumnName("key_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.KeyEmployeeId).HasColumnName("key_employeeID");

                entity.Property(e => e.KeyEmployeeName)
                    .HasColumnName("key_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.KeyNum)
                    .HasColumnName("key_num")
                    .HasMaxLength(60);

                entity.Property(e => e.LastEncounterDate)
                    .HasColumnName("last_encounter_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastFollowupDate)
                    .HasColumnName("last_followup_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastInspectTime)
                    .HasColumnName("last_inspect_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastPriceDate)
                    .HasColumnName("last_price_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastRealtyStatusDate)
                    .HasColumnName("last_realty_status_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastSalesmanFollowupDate)
                    .HasColumnName("last_salesman_followup_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("last_update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LimitCommissionDate).HasColumnType("datetime");

                entity.Property(e => e.LivingRoomNum).HasColumnName("living_room_num");

                entity.Property(e => e.LockDatetime)
                    .HasColumnName("lock_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LockFlag).HasColumnName("lock_flag");

                entity.Property(e => e.ManagementFee).HasColumnName("management_fee");

                entity.Property(e => e.ManagementFeeUnit).HasColumnName("management_fee_unit");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(500);

                entity.Property(e => e.OfficeClass).HasColumnName("office_class");

                entity.Property(e => e.OfficeType).HasColumnName("office_type");

                entity.Property(e => e.OpeningDatetime)
                    .HasColumnName("opening_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OriginalPrice).HasColumnName("original_price");

                entity.Property(e => e.OriginalRegisterDate)
                    .HasColumnName("original_register_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OvertimeAirConditioningFee).HasColumnName("overtime_air_conditioning_fee");

                entity.Property(e => e.OvertimeAirConditioningFeeUnit)
                    .HasColumnName("overtime_air_conditioning_fee_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.OwnerEmployeeId).HasColumnName("owner_employeeID");

                entity.Property(e => e.PayType).HasColumnName("pay_type");

                entity.Property(e => e.PhoneInputDepartmentId).HasColumnName("phone_input_departmentId");

                entity.Property(e => e.PhoneInputDepartmentName)
                    .HasColumnName("phone_input_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneInputEmployeeId).HasColumnName("phone_input_employeeId");

                entity.Property(e => e.PhoneInputEmployeeName)
                    .HasColumnName("phone_input_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.PhoneReadtimes).HasColumnName("phone_readtimes");

                entity.Property(e => e.PhoneReadtimesDate)
                    .HasColumnName("phone_readtimes_date")
                    .HasColumnType("date");

                entity.Property(e => e.PropertyEndDate)
                    .HasColumnName("property_end_date")
                    .HasColumnType("date");

                entity.Property(e => e.PropertyNum)
                    .HasColumnName("property_num")
                    .HasMaxLength(50);

                entity.Property(e => e.PropertyStartDate)
                    .HasColumnName("property_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.PropertyType).HasColumnName("property_type");

                entity.Property(e => e.RealtyFloors).HasColumnName("realty_floors");

                entity.Property(e => e.RealtyGuid).HasColumnName("realtyGUID");

                entity.Property(e => e.RealtyNum)
                    .HasColumnName("realty_num")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealtyStatus).HasColumnName("realty_status");

                entity.Property(e => e.RealtyType).HasColumnName("realty_type");

                entity.Property(e => e.RegisterDepartmentId).HasColumnName("register_departmentID");

                entity.Property(e => e.RegisterDepartmentName)
                    .HasColumnName("register_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.RegisterEmployeeId).HasColumnName("register_employeeID");

                entity.Property(e => e.RegisterEmployeeName)
                    .HasColumnName("register_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.RentAgencyFlag).HasColumnName("rent_agency_flag");

                entity.Property(e => e.RentCommissionDate)
                    .HasColumnName("rent_commission_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RentDelegationDepartmentId).HasColumnName("rent_delegation_departmentId");

                entity.Property(e => e.RentDelegationDepartmentName)
                    .HasColumnName("rent_delegation_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.RentDelegationEmployeeId).HasColumnName("rent_delegation_employeeId");

                entity.Property(e => e.RentDelegationEmployeeName)
                    .HasColumnName("rent_delegation_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.RentDepartmentId).HasColumnName("rent_departmentID");

                entity.Property(e => e.RentDepartmentName)
                    .HasColumnName("rent_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.RentEmployeeId).HasColumnName("rent_employeeID");

                entity.Property(e => e.RentEmployeeName)
                    .HasColumnName("rent_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.RentEndDate)
                    .HasColumnName("rent_end_date")
                    .HasColumnType("date");

                entity.Property(e => e.RentPrice).HasColumnName("rent_price");

                entity.Property(e => e.RentPriceUpOrDown)
                    .HasColumnName("rent_price_up_or_down")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RentQueryCode).HasColumnName("rent_query_code");

                entity.Property(e => e.RentUnitPrice).HasColumnName("rent_unit_price");

                entity.Property(e => e.Returns).HasColumnName("returns");

                entity.Property(e => e.RoomDepth).HasColumnName("room_depth");

                entity.Property(e => e.RoomHeight).HasColumnName("room_height");

                entity.Property(e => e.RoomId).HasColumnName("roomID");

                entity.Property(e => e.RoomName)
                    .HasColumnName("room_name")
                    .HasMaxLength(10);

                entity.Property(e => e.RoomNum).HasColumnName("room_num");

                entity.Property(e => e.RoomWidth).HasColumnName("room_width");

                entity.Property(e => e.SaleCommissionDate)
                    .HasColumnName("sale_commission_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SaleDelegationDepartmentId).HasColumnName("sale_delegation_departmentId");

                entity.Property(e => e.SaleDelegationDepartmentName)
                    .HasColumnName("sale_delegation_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.SaleDelegationEmployeeId).HasColumnName("sale_delegation_employeeId");

                entity.Property(e => e.SaleDelegationEmployeeName)
                    .HasColumnName("sale_delegation_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.SaleDepartmentId).HasColumnName("sale_departmentID");

                entity.Property(e => e.SaleDepartmentName)
                    .HasColumnName("sale_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.SaleEmployeeId).HasColumnName("sale_employeeID");

                entity.Property(e => e.SaleEmployeeName)
                    .HasColumnName("sale_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.SalePrice).HasColumnName("sale_price");

                entity.Property(e => e.SalePriceUpOrDown)
                    .HasColumnName("sale_price_up_or_down")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SaleQueryCode).HasColumnName("sale_query_code");

                entity.Property(e => e.SaleUnitPrice).HasColumnName("sale_unit_price");

                entity.Property(e => e.SeparatedNum).HasColumnName("separated_num");

                entity.Property(e => e.ShopLocation).HasColumnName("shop_location");

                entity.Property(e => e.ShopTradeName)
                    .HasColumnName("shop_trade_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShopTradeType)
                    .HasColumnName("shop_trade_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopType).HasColumnName("shop_type");

                entity.Property(e => e.SoleAgentDepartmentId).HasColumnName("sole_agent_departmentID");

                entity.Property(e => e.SoleAgentDepartmentName)
                    .HasColumnName("sole_agent_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.SoleAgentEmployeeId).HasColumnName("sole_agent_employeeID");

                entity.Property(e => e.SoleAgentEmployeeName)
                    .HasColumnName("sole_agent_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.SourceType).HasColumnName("source_type");

                entity.Property(e => e.SpecialDatetime)
                    .HasColumnName("special_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpecialFlag).HasColumnName("special_flag");

                entity.Property(e => e.Stations).HasColumnName("stations");

                entity.Property(e => e.SurveyDepartmentId).HasColumnName("survey_departmentId");

                entity.Property(e => e.SurveyDepartmentName)
                    .HasColumnName("survey_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.SurveyEmployeeId).HasColumnName("survey_employeeId");

                entity.Property(e => e.SurveyEmployeeName)
                    .HasColumnName("survey_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Toilet).HasColumnName("toilet");

                entity.Property(e => e.ToiletNum).HasColumnName("toilet_num");

                entity.Property(e => e.TradeStatus).HasColumnName("trade_status");

                entity.Property(e => e.TradeType).HasColumnName("trade_type");

                entity.Property(e => e.TransferFee).HasColumnName("transfer_fee");

                entity.Property(e => e.TransmissionArea).HasColumnName("transmission_area");

                entity.Property(e => e.TransmissionAreaChi).HasColumnName("transmission_area_chi");

                entity.Property(e => e.Unit4rentPrice)
                    .HasColumnName("unit_4rent_price")
                    .HasMaxLength(5);

                entity.Property(e => e.Unit4rentunitPrice)
                    .HasColumnName("unit_4rentunit_price")
                    .HasMaxLength(5);

                entity.Property(e => e.UsageArea).HasColumnName("usage_area");

                entity.Property(e => e.UsageRatio).HasColumnName("usage_ratio");

                entity.Property(e => e.UseType).HasColumnName("use_type");

                entity.Property(e => e.ViewType).HasColumnName("view_type");
            });

            modelBuilder.Entity<RealtyCommissionLog>(entity =>
            {
                entity.ToTable("realty_commission_log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommissionType).HasColumnName("commission_type");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");
            });

            modelBuilder.Entity<RealtyContact>(entity =>
            {
                entity.ToTable("realty_contact");

                entity.HasIndex(e => e.CommitmentNum)
                    .HasName("ix_reantly_contact_commintmentNum");

                entity.HasIndex(e => e.PhoneCompare)
                    .HasName("IX_phone_compare");

                entity.HasIndex(e => e.RealtyId)
                    .HasName("IX_realtyID");

                entity.HasIndex(e => new { e.RealtyId, e.Id, e.DeleteFlag, e.PhonePre, e.PhonePost, e.PhoneCompare })
                    .HasName("IX_phone_compare_all");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Appellation).HasColumnName("appellation");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("date");

                entity.Property(e => e.CheckPhoneTime)
                    .HasColumnName("check_phone_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.CommitmentNum)
                    .HasColumnName("commitment_num")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("modify_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.NativePlace).HasColumnName("native_place");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(260);

                entity.Property(e => e.PhoneCompare)
                    .HasColumnName("phone_compare")
                    .HasColumnType("binary(20)");

                entity.Property(e => e.PhonePost)
                    .HasColumnName("phone_post")
                    .HasColumnType("binary(20)");

                entity.Property(e => e.PhonePre)
                    .HasColumnName("phone_pre")
                    .HasColumnType("binary(20)");

                entity.Property(e => e.PhoneStatus)
                    .HasColumnName("phone_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PhoneType).HasColumnName("phone_type");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");

                entity.Property(e => e.Relation).HasColumnName("relation");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<RealtyContactCode>(entity =>
            {
                entity.ToTable("Realty_Contact_Code");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactPhone).HasMaxLength(100);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmpId).HasColumnName("Emp_Id");

                entity.Property(e => e.PhoneCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RealtyId).HasColumnName("RealtyID");

                entity.Property(e => e.RealtyRcId).HasColumnName("RealtyRcID");
            });

            modelBuilder.Entity<RealtyDeal>(entity =>
            {
                entity.ToTable("realty_deal");

                entity.Property(e => e.CommunityAddress).HasMaxLength(100);

                entity.Property(e => e.CommunityId).HasColumnName("communityID");

                entity.Property(e => e.DealId).HasColumnName("DealID");

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");

                entity.Property(e => e.Extend1)
                    .HasColumnName("extend1")
                    .HasMaxLength(200);

                entity.Property(e => e.Extend2)
                    .HasColumnName("extend2")
                    .HasMaxLength(200);

                entity.Property(e => e.FixtureDate).HasColumnType("date");

                entity.Property(e => e.RealtyNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasMaxLength(10);
            });

            modelBuilder.Entity<RealtyFiles>(entity =>
            {
                entity.ToTable("realty_files");

                entity.HasIndex(e => e.SourceId)
                    .HasName("IX_SourceID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteDatetime)
                    .HasColumnName("delete_datetime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeleteEmployeeCode)
                    .HasColumnName("delete_employee_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteEmployeeId).HasColumnName("delete_employeeID");

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(20);

                entity.Property(e => e.FileType)
                    .HasColumnName("file_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageClass)
                    .HasColumnName("image_class")
                    .HasMaxLength(10);

                entity.Property(e => e.SourceId).HasColumnName("sourceID");

                entity.Property(e => e.SourceNum)
                    .HasColumnName("source_num")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceType).HasColumnName("source_type");

                entity.Property(e => e.Thumbnail)
                    .HasColumnName("thumbnail")
                    .HasColumnType("image");

                entity.Property(e => e.ThumbnailUrl)
                    .HasColumnName("thumbnail_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Uri)
                    .HasColumnName("URI")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<RealtyFollowup>(entity =>
            {
                entity.ToTable("realty_followup");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => e.RealtyFollowupType)
                    .HasName("IX_RealtyFollowUpType");

                entity.HasIndex(e => e.RealtyValidity)
                    .HasName("realty_validity_ix");

                entity.HasIndex(e => new { e.RealtyFollowupType, e.AuditSourceId, e.EmployeeId, e.CreateTime })
                    .HasName("IX_Date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.BusinessType).HasColumnName("business_type");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("Create_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsTop).HasColumnName("is_top");

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(2000);

                entity.Property(e => e.RealtyFollowupName)
                    .HasColumnName("realty_followup_name")
                    .HasMaxLength(10);

                entity.Property(e => e.RealtyFollowupType).HasColumnName("realty_followup_type");

                entity.Property(e => e.RealtyValidity).HasColumnName("realty_validity");

                entity.Property(e => e.RealtyValidityName)
                    .HasColumnName("realty_validity_name")
                    .HasMaxLength(100);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.TradeType).HasColumnName("trade_type");
            });

            modelBuilder.Entity<RealtyInEmployee>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.RealtyId });

                entity.ToTable("realty_in_employee");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<RealtyInvalid>(entity =>
            {
                entity.ToTable("realty_invalid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");

                entity.Property(e => e.RealtyNum)
                    .HasColumnName("realty_num")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RealtyInvalidTask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("realty_invalid_task");

                entity.Property(e => e.TaskId).HasColumnName("taskID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.HandleEmployeeId).HasColumnName("handle_employee_id");

                entity.Property(e => e.HandleEmployeeName)
                    .HasColumnName("handle_employee_name")
                    .HasMaxLength(50);

                entity.Property(e => e.HandleMemo)
                    .HasColumnName("handle_memo")
                    .HasMaxLength(100);

                entity.Property(e => e.HandleResult).HasColumnName("handle_result");

                entity.Property(e => e.HandleTime)
                    .HasColumnName("handle_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");

                entity.Property(e => e.RealtyNum)
                    .HasColumnName("realty_num")
                    .HasMaxLength(50);

                entity.Property(e => e.TaskResult).HasColumnName("task_result");
            });

            modelBuilder.Entity<RealtyPriceChange>(entity =>
            {
                entity.HasKey(e => new { e.RealtyId, e.RentOrSale });

                entity.ToTable("realty_price_change");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");

                entity.Property(e => e.RentOrSale).HasColumnName("rent_or_sale");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.UpOrDown)
                    .HasColumnName("up_or_down")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RealtyReadDeptInDept>(entity =>
            {
                entity.HasKey(e => new { e.RelationId, e.Id, e.Level, e.RealtyType });

                entity.ToTable("realty_read_dept_in_dept");

                entity.Property(e => e.RelationId).HasColumnName("relationID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.RealtyType).HasColumnName("realty_type");
            });

            modelBuilder.Entity<RealtyToRemind>(entity =>
            {
                entity.HasKey(e => e.RealtyId);

                entity.ToTable("realty_to_remind");

                entity.Property(e => e.RealtyId)
                    .HasColumnName("realtyID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ToPause).HasColumnName("to_pause");
            });

            modelBuilder.Entity<RealtyTrade>(entity =>
            {
                entity.HasKey(e => new { e.RealtyId, e.TradeCode });

                entity.ToTable("realty_trade");

                entity.Property(e => e.RealtyId).HasColumnName("realtyID");

                entity.Property(e => e.TradeCode).HasColumnName("trade_code");
            });

            modelBuilder.Entity<RemindingDailyBySystem>(entity =>
            {
                entity.ToTable("reminding_daily_by_system");

                entity.HasIndex(e => e.RecipientId)
                    .HasName("IX_RecipientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.RecipientId).HasColumnName("recipientID");

                entity.Property(e => e.RecipientName)
                    .HasColumnName("recipient_name")
                    .HasMaxLength(200);

                entity.Property(e => e.RemindingTime)
                    .HasColumnName("reminding_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceCode)
                    .HasColumnName("source_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("sourceID");

                entity.Property(e => e.SourceSubType).HasColumnName("source_sub_type");

                entity.Property(e => e.SourceType).HasColumnName("source_type");
            });

            modelBuilder.Entity<RemindingDailyBySystemBak>(entity =>
            {
                entity.ToTable("reminding_daily_by_system_bak");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.OriginalId).HasColumnName("originalID");

                entity.Property(e => e.RecipientId).HasColumnName("recipientID");

                entity.Property(e => e.RecipientName)
                    .HasColumnName("recipient_name")
                    .HasMaxLength(200);

                entity.Property(e => e.RemindingTime)
                    .HasColumnName("reminding_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceCode)
                    .HasColumnName("source_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("sourceID");

                entity.Property(e => e.SourceSubType).HasColumnName("source_sub_type");

                entity.Property(e => e.SourceType).HasColumnName("source_type");
            });

            modelBuilder.Entity<RemindingInTime>(entity =>
            {
                entity.ToTable("reminding_in_time");

                entity.HasIndex(e => e.CreatorId)
                    .HasName("IX_CreatorID");

                entity.HasIndex(e => new { e.Status, e.RecipientId, e.RemindingTime })
                    .HasName("IX_DateTime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreatorDepartmentName)
                    .HasColumnName("creator_department_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatorId).HasColumnName("creatorID");

                entity.Property(e => e.CreatorName)
                    .HasColumnName("creator_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RecipientId).HasColumnName("recipientID");

                entity.Property(e => e.RecipientName)
                    .HasColumnName("recipient_name")
                    .HasMaxLength(200);

                entity.Property(e => e.RecipientType).HasColumnName("recipient_type");

                entity.Property(e => e.RemindingTime)
                    .HasColumnName("reminding_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RemindingType).HasColumnName("reminding_type");

                entity.Property(e => e.SourceCode)
                    .HasColumnName("source_code")
                    .IsUnicode(false);

                entity.Property(e => e.SourceId)
                    .HasColumnName("sourceID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SourceIdCode)
                    .HasColumnName("source_id_code")
                    .IsUnicode(false);

                entity.Property(e => e.SourceSubType).HasColumnName("source_sub_type");

                entity.Property(e => e.SourceType).HasColumnName("source_type");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RoleConfig>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("role_config");

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllocatedSmsNum).HasColumnName("allocated_SMS_num");

                entity.Property(e => e.DailySendingSmsNum).HasColumnName("daily_sending_SMS_num");

                entity.Property(e => e.DefaultMenu)
                    .HasColumnName("default_menu")
                    .HasMaxLength(100);

                entity.Property(e => e.IsHaveCloseTeam).HasColumnName("is_have_close_team");

                entity.Property(e => e.IsInspectSpecialized).HasColumnName("is_inspect_specialized");

                entity.Property(e => e.IsPersonnelAttendance).HasColumnName("is_personnel_attendance");

                entity.Property(e => e.PerformanceFieldVisible).HasColumnName("performance_field_visible");

                entity.Property(e => e.SendingSmsDays).HasColumnName("sending_SMS_days");

                entity.Property(e => e.SendingSmsNumEverytime).HasColumnName("sending_SMS_num_everytime");

                entity.Property(e => e.SmsdayRepeatCustomer)
                    .HasColumnName("SMSDayRepeatCustomer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SmsdayRepeatRealty)
                    .HasColumnName("SMSDayRepeatRealty")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("room");

                entity.HasIndex(e => e.BuildingId)
                    .HasName("IX_BuildingID");

                entity.Property(e => e.RoomId).HasColumnName("roomID");

                entity.Property(e => e.BalconyNum).HasColumnName("balcony_num");

                entity.Property(e => e.BuildingId).HasColumnName("buildingID");

                entity.Property(e => e.ConstructionArea).HasColumnName("construction_area");

                entity.Property(e => e.FloorName)
                    .HasColumnName("floor_name")
                    .HasMaxLength(10);

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.IsAreaLocked).HasColumnName("is_area_locked");

                entity.Property(e => e.IsFloorLocked).HasColumnName("is_floor_locked");

                entity.Property(e => e.IsTypeLocked).HasColumnName("is_type_locked");

                entity.Property(e => e.LivingRoomNum).HasColumnName("living_room_num");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(10);

                entity.Property(e => e.Pinyin)
                    .HasColumnName("pinyin")
                    .HasMaxLength(10);

                entity.Property(e => e.RoomNum).HasColumnName("room_num");

                entity.Property(e => e.ToiletNum).HasColumnName("toilet_num");
            });

            modelBuilder.Entity<SBaseItem>(entity =>
            {
                entity.ToTable("s_base_item");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsBaseItem).HasColumnName("is_base_item");

                entity.Property(e => e.IsInput)
                    .HasColumnName("is_input")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaxValues)
                    .HasColumnName("max_values")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceType).HasColumnName("source_type");

                entity.Property(e => e.Values)
                    .HasColumnName("values")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<SBizdataDailyStatRecount>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.StatDate });

                entity.ToTable("s_bizdata_daily_stat_recount");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpName)
                    .HasColumnName("emp_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FyXzgjzl)
                    .HasColumnName("fy_xzgjzl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FyXzmmW)
                    .HasColumnName("fy_xzmm_w")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FyXzqbW)
                    .HasColumnName("fy_xzqb_w")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FyXzzlW)
                    .HasColumnName("fy_xzzl_w")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FyXzzsW)
                    .HasColumnName("fy_xzzs_w")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KyXzgjzl)
                    .HasColumnName("ky_xzgjzl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MmCxkp)
                    .HasColumnName("mm_cxkp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MmXzdkzl)
                    .HasColumnName("mm_xzdkzl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MmXzlt)
                    .HasColumnName("mm_xzlt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MmXzqb)
                    .HasColumnName("mm_xzqb")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MmZltl)
                    .HasColumnName("mm_zltl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrgId).HasColumnName("org_id");

                entity.Property(e => e.OrgName)
                    .HasColumnName("org_name")
                    .HasMaxLength(100);

                entity.Property(e => e.QbCxkp)
                    .HasColumnName("qb_cxkp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QbXzdjp)
                    .HasColumnName("qb_xzdjp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QbXzdkzl)
                    .HasColumnName("qb_xzdkzl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QbXzgjzl)
                    .HasColumnName("qb_xzgjzl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QbXzky)
                    .HasColumnName("qb_xzky")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QbXzlt)
                    .HasColumnName("qb_xzlt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QbXzqb)
                    .HasColumnName("qb_xzqb")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QbXzysp)
                    .HasColumnName("qb_xzysp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QbZltl)
                    .HasColumnName("qb_zltl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QgXzky)
                    .HasColumnName("qg_xzky")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QzXzky)
                    .HasColumnName("qz_xzky")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatActionDate)
                    .HasColumnName("stat_action_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StateBatchId).HasColumnName("state_batch_id");

                entity.Property(e => e.ZlCxkp)
                    .HasColumnName("zl_cxkp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZlXzdkzl)
                    .HasColumnName("zl_xzdkzl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZlXzlt)
                    .HasColumnName("zl_xzlt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZlXzqb)
                    .HasColumnName("zl_xzqb")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZlZltl)
                    .HasColumnName("zl_zltl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZsCxkp)
                    .HasColumnName("zs_cxkp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZsXzlt)
                    .HasColumnName("zs_xzlt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZsXzqb)
                    .HasColumnName("zs_xzqb")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZsZltl)
                    .HasColumnName("zs_zltl")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SBizdataDailyStatTotal>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.StatDate });

                entity.ToTable("s_bizdata_daily_stat_total");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CusAll)
                    .HasColumnName("cus_all")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CusBuy)
                    .HasColumnName("cus_buy")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CusBuyCirculation)
                    .HasColumnName("cus_buy_circulation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CusCirculation)
                    .HasColumnName("cus_circulation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CusRent)
                    .HasColumnName("cus_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CusRentCirculation)
                    .HasColumnName("cus_rent_circulation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpName)
                    .HasColumnName("emp_name")
                    .HasMaxLength(50);

                entity.Property(e => e.OrgId).HasColumnName("org_id");

                entity.Property(e => e.OrgName)
                    .HasColumnName("org_name")
                    .HasMaxLength(100);

                entity.Property(e => e.RelAll)
                    .HasColumnName("rel_all")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelCirculation)
                    .HasColumnName("rel_circulation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelKey)
                    .HasColumnName("rel_key")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelRent)
                    .HasColumnName("rel_rent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelRentCirculation)
                    .HasColumnName("rel_rent_circulation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelRentsale)
                    .HasColumnName("rel_rentsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelSaleCirculation)
                    .HasColumnName("rel_sale_circulation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelSaleandrentCirculation)
                    .HasColumnName("rel_saleandrent_circulation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelSalse)
                    .HasColumnName("rel_salse")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelSole)
                    .HasColumnName("rel_sole")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatActionDate)
                    .HasColumnName("stat_action_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StateBatchId).HasColumnName("state_batch_id");
            });

            modelBuilder.Entity<ScheduleDef>(entity =>
            {
                entity.ToTable("schedule_def");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("date");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("effective_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShowName)
                    .HasColumnName("show_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ScheduleTimeDef>(entity =>
            {
                entity.ToTable("schedule_time_def");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isvacation).HasColumnName("isvacation");

                entity.Property(e => e.ScheduleTimeName)
                    .HasColumnName("schedule_time_name")
                    .HasMaxLength(10);

                entity.Property(e => e.ShowName)
                    .HasColumnName("show_name")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ScheduleTimeRelation>(entity =>
            {
                entity.HasKey(e => new { e.ScheduleId, e.ScheduleTimeId });

                entity.ToTable("schedule_time_relation");

                entity.Property(e => e.ScheduleId).HasColumnName("scheduleID");

                entity.Property(e => e.ScheduleTimeId).HasColumnName("schedule_timeID");

                entity.Property(e => e.CheckinTime).HasColumnName("checkin_time");

                entity.Property(e => e.CheckoutTime).HasColumnName("checkout_time");
            });

            modelBuilder.Entity<SConfig>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("s_config");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("departmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<SCustomerContactFollowup>(entity =>
            {
                entity.ToTable("s_customer_contact_followup");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.BizoperationName)
                    .HasColumnName("bizoperation_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BizoperationType).HasColumnName("bizoperation_type");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SCustomerFieldLog>(entity =>
            {
                entity.ToTable("s_customer_field_log");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("Create_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.FieldType).HasColumnName("field_type");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SCustomerFollowup>(entity =>
            {
                entity.ToTable("s_customer_followup");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("IX_Date");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.BizoperationName)
                    .HasColumnName("bizoperation_name")
                    .HasMaxLength(10);

                entity.Property(e => e.BizoperationType).HasColumnName("bizoperation_type");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("Create_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SCustomerReadLog>(entity =>
            {
                entity.ToTable("s_customer_read_log");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("IX_Date");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("Create_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(200);

                entity.Property(e => e.ReadType).HasColumnName("read_type");

                entity.Property(e => e.ReadTypeName)
                    .HasColumnName("read_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SCustomerSmsLog>(entity =>
            {
                entity.ToTable("s_customer_sms_log");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(20);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SmstemplateId).HasColumnName("SMSTemplateId");

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SendSmsinfo>(entity =>
            {
                entity.HasKey(e => e.SendId);

                entity.ToTable("SendSMSInfo");

                entity.Property(e => e.SendId).HasColumnName("Send_ID");

                entity.Property(e => e.ContactPhone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasColumnName("departmentName")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RealtyAddress).HasMaxLength(200);

                entity.Property(e => e.RealtyId).HasColumnName("RealtyID");

                entity.Property(e => e.RealtyNum)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ReplyInfo).HasMaxLength(200);

                entity.Property(e => e.ReplyTime).HasColumnType("datetime");

                entity.Property(e => e.SendTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SExpressionConfig>(entity =>
            {
                entity.HasKey(e => e.ExpressionId);

                entity.ToTable("s_expression_config");

                entity.Property(e => e.ExpressionId)
                    .HasColumnName("expressionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpressionName)
                    .IsRequired()
                    .HasColumnName("expression_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ExpressionText)
                    .IsRequired()
                    .HasColumnName("expression_text")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SExpressions>(entity =>
            {
                entity.ToTable("s_expressions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CnName)
                    .IsRequired()
                    .HasColumnName("cn_name")
                    .HasMaxLength(20);

                entity.Property(e => e.ExpressionId).HasColumnName("expressionID");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SFieldValueConfig>(entity =>
            {
                entity.HasKey(e => e.FieldId);

                entity.ToTable("s_field_value_config");

                entity.Property(e => e.FieldId)
                    .HasColumnName("fieldID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultSelectKey).HasColumnName("default_select_key");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(20);

                entity.Property(e => e.FieldText)
                    .HasColumnName("field_text")
                    .HasMaxLength(20);

                entity.Property(e => e.LockFlag).HasColumnName("lock_flag");

                entity.Property(e => e.Pinyin)
                    .HasColumnName("pinyin")
                    .HasColumnType("char(20)");
            });

            modelBuilder.Entity<SFollowup>(entity =>
            {
                entity.ToTable("s_followup");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => e.SourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => new { e.BizoperationType, e.EmployeeId, e.DepartmentId, e.CreateTime, e.BizType, e.SubbizType })
                    .HasName("IX_BizType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.BizType).HasColumnName("biz_type");

                entity.Property(e => e.BizoperationName)
                    .HasColumnName("bizoperation_name")
                    .HasMaxLength(10);

                entity.Property(e => e.BizoperationType).HasColumnName("bizoperation_type");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(2000);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceId).HasColumnName("sourceID");

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SisStoreReport>(entity =>
            {
                entity.ToTable("sis_store_report");

                entity.HasIndex(e => new { e.StatDate, e.RegionCode })
                    .HasName("IX_sis_store_report");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegionCode)
                    .HasColumnName("region_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegionName)
                    .HasColumnName("region_name")
                    .HasMaxLength(50);

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("date");

                entity.Property(e => e.StoreCustomerRent).HasColumnName("store_customer_rent");

                entity.Property(e => e.StoreCustomerSale).HasColumnName("store_customer_sale");

                entity.Property(e => e.StoreCustomerSum).HasColumnName("store_customer_sum");

                entity.Property(e => e.StoreRealtyRent).HasColumnName("store_realty_rent");

                entity.Property(e => e.StoreRealtyRentsale).HasColumnName("store_realty_rentsale");

                entity.Property(e => e.StoreRealtySale).HasColumnName("store_realty_sale");

                entity.Property(e => e.StoreRealtySum).HasColumnName("store_realty_sum");

                entity.Property(e => e.UpdateFlag)
                    .HasColumnName("update_flag")
                    .IsRowVersion();
            });

            modelBuilder.Entity<SmsActualLog>(entity =>
            {
                entity.ToTable("SMS_Actual_log");

                entity.HasIndex(e => new { e.EmployeeId, e.CreateTime })
                    .HasName("SMS_Actual_log_emp_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("departmentName")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employeeName")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleName)
                    .HasColumnName("roleName")
                    .HasMaxLength(50);

                entity.Property(e => e.SmsContent).HasColumnName("sms_content");

                entity.Property(e => e.SmsOrder).HasColumnName("sms_order");

                entity.Property(e => e.SmstemplateId).HasColumnName("SMSTemplateId");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmsActualLogDetail>(entity =>
            {
                entity.ToTable("SMS_Actual_log_detail");

                entity.HasIndex(e => new { e.EmployeeId, e.CreateTime })
                    .HasName("SMS_Actual_log_detail_emp_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("departmentName")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employeeName")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleName)
                    .HasColumnName("roleName")
                    .HasMaxLength(50);

                entity.Property(e => e.SmsContent).HasColumnName("sms_content");

                entity.Property(e => e.SmsOrder).HasColumnName("sms_order");

                entity.Property(e => e.SmsResult)
                    .HasColumnName("sms_result")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SmstemplateId).HasColumnName("SMSTemplateId");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmsConfig>(entity =>
            {
                entity.ToTable("sms_config");

                entity.HasIndex(e => new { e.EmployeeId, e.Date })
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.SmsAmount).HasColumnName("sms_amount");

                entity.Property(e => e.SmsSendAmount).HasColumnName("sms_send_amount");
            });

            modelBuilder.Entity<SmsEmployeeLog>(entity =>
            {
                entity.ToTable("SMS_Employee_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RecieverId).HasColumnName("RecieverID");

                entity.Property(e => e.SendMessageCount).HasColumnName("send_message_count");

                entity.Property(e => e.SenderDepartmentName).HasMaxLength(50);

                entity.Property(e => e.SenderName).HasMaxLength(50);

                entity.Property(e => e.SenderTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SmsForbidNum>(entity =>
            {
                entity.ToTable("sms_forbid_num");

                entity.HasIndex(e => e.Phone)
                    .HasName("IX_Phone");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.InputDatetime)
                    .HasColumnName("input_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(10);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmsSendingCount>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("sms_sending_count");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Permission).HasColumnName("permission");

                entity.Property(e => e.PermissionMemo)
                    .HasColumnName("permission_memo")
                    .HasMaxLength(100);

                entity.Property(e => e.SendingFlag).HasColumnName("sending_flag");
            });

            modelBuilder.Entity<SmsTemplate>(entity =>
            {
                entity.ToTable("SMS_Template");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddEmpInfo)
                    .HasColumnName("addEmpInfo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AllowEdit)
                    .HasColumnName("allowEdit")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.DaySendLimit)
                    .HasColumnName("daySendLimit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupSendLimit)
                    .HasColumnName("groupSendLimit")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("orderNo")
                    .HasDefaultValueSql("((10))");
            });

            modelBuilder.Entity<SRealtyCommitmentNumFollowup>(entity =>
            {
                entity.ToTable("s_realty_commitmentNum_followup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.BizoperationName)
                    .HasColumnName("bizoperation_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BizoperationType).HasColumnName("bizoperation_type");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(200);

                entity.Property(e => e.SourceId).HasColumnName("sourceID");

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SRealtyContactFollowup>(entity =>
            {
                entity.ToTable("s_realty_contact_followup");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.BizoperationName)
                    .HasColumnName("bizoperation_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BizoperationType).HasColumnName("bizoperation_type");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(200);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SRealtyFieldLog>(entity =>
            {
                entity.ToTable("s_realty_field_log");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.FieldType).HasColumnName("field_type");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(200);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SRealtyFollowup>(entity =>
            {
                entity.ToTable("s_realty_followup");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_AuditSourceID");

                entity.HasIndex(e => e.BizopTypeCalc)
                    .HasName("IX_bizop_type_calc");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("IX_Date");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.HasIndex(e => new { e.AuditSourceId, e.BizoperationType, e.EmployeeId })
                    .HasName("IX_For_Report");

                entity.HasIndex(e => new { e.AuditSourceId, e.BizoperationType, e.Flag })
                    .HasName("IX_Flag");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.BizopTypeCalc)
                    .HasColumnName("bizop_type_calc")
                    .HasComputedColumnSql("(case when [bizoperation_type]=(4098) OR [bizoperation_type]=(4097) then (1) when [bizoperation_type]=(8194) OR [bizoperation_type]=(8193) then (2) else (0) end)");

                entity.Property(e => e.BizoperationName)
                    .HasColumnName("bizoperation_name")
                    .HasMaxLength(10);

                entity.Property(e => e.BizoperationType).HasColumnName("bizoperation_type");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SRealtyReadLog>(entity =>
            {
                entity.ToTable("s_realty_read_log");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("IX_Date");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.D)
                    .HasColumnName("d")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(50);

                entity.Property(e => e.ReadType).HasColumnName("read_type");

                entity.Property(e => e.ReadTypeName)
                    .HasColumnName("read_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SRealtySmsLog>(entity =>
            {
                entity.ToTable("s_realty_sms_log");

                entity.HasIndex(e => e.AuditSourceId)
                    .HasName("IX_SourceID");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("IX_Date");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(20);

                entity.Property(e => e.AuditSourceId).HasColumnName("audit_sourceID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machine_name")
                    .HasMaxLength(20);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500);

                entity.Property(e => e.RoleName)
                    .HasColumnName("role_name")
                    .HasMaxLength(20);

                entity.Property(e => e.SmstemplateId).HasColumnName("SMSTemplateId");

                entity.Property(e => e.SubbizType).HasColumnName("subbiz_type");
            });

            modelBuilder.Entity<SRoomChartItem>(entity =>
            {
                entity.ToTable("s_room_chart_item");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("image");

                entity.Property(e => e.MinSize).HasColumnName("min_size");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<SRoomChartType>(entity =>
            {
                entity.ToTable("s_room_chart_type");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubwayLines>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("subway_lines");

                entity.Property(e => e.LineId)
                    .HasColumnName("lineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.LineName)
                    .HasColumnName("line_name")
                    .HasMaxLength(10);

                entity.Property(e => e.Pinyin)
                    .HasColumnName("pinyin")
                    .HasColumnType("char(10)");
            });

            modelBuilder.Entity<SubwayStations>(entity =>
            {
                entity.HasKey(e => e.StationId);

                entity.ToTable("subway_stations");

                entity.Property(e => e.StationId)
                    .HasColumnName("stationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Pinyin)
                    .HasColumnName("pinyin")
                    .HasColumnType("char(10)");

                entity.Property(e => e.StationName)
                    .HasColumnName("station_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Summary>(entity =>
            {
                entity.ToTable("summary");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_employeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("image");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SummaryReview>(entity =>
            {
                entity.ToTable("summary_review");

                entity.HasIndex(e => e.ReviewerId)
                    .HasName("IX_reviewerID");

                entity.HasIndex(e => e.SummaryId)
                    .HasName("IX_summaryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ReviewContent)
                    .HasColumnName("review_content")
                    .HasColumnType("ntext");

                entity.Property(e => e.ReviewDate)
                    .HasColumnName("review_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReviewerId).HasColumnName("reviewerID");

                entity.Property(e => e.SummaryId).HasColumnName("summaryID");
            });

            modelBuilder.Entity<TCommunityAllocation>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.CommunityId });

                entity.ToTable("t_community_allocation");

                entity.Property(e => e.TemplateId).HasColumnName("templateID");

                entity.Property(e => e.CommunityId).HasColumnName("communityID");
            });

            modelBuilder.Entity<TeamMessage>(entity =>
            {
                entity.ToTable("team_message");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeginDate)
                    .HasColumnName("begin_date")
                    .HasColumnType("date");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IsSecondTeam).HasColumnName("is_second_team");

                entity.Property(e => e.MsgCode).HasColumnName("msg_code");

                entity.Property(e => e.MsgState).HasColumnName("msg_state");

                entity.Property(e => e.MsgTime)
                    .HasColumnName("msg_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RespTime)
                    .HasColumnName("resp_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TeamCode)
                    .HasColumnName("team_code")
                    .HasMaxLength(50);

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TemplateItems>(entity =>
            {
                entity.ToTable("template_items");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseItemId).HasColumnName("base_itemID");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsBaseItem).HasColumnName("is_base_item");

                entity.Property(e => e.IsInput).HasColumnName("is_input");

                entity.Property(e => e.MaxValues)
                    .HasColumnName("max_values")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(200);

                entity.Property(e => e.SourceType).HasColumnName("source_type");

                entity.Property(e => e.TemplateId).HasColumnName("templateID");

                entity.Property(e => e.Values)
                    .HasColumnName("values")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<TmsRealtyStatusLog>(entity =>
            {
                entity.ToTable("TMS_RealtyStatus_Log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Msg).HasMaxLength(200);

                entity.Property(e => e.RealtyNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TranseferLog>(entity =>
            {
                entity.ToTable("transefer_log");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BatchNum)
                    .IsRequired()
                    .HasColumnName("batch_num")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(500);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<TranseferLogSub>(entity =>
            {
                entity.ToTable("transefer_log_sub");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BizType).HasColumnName("biz_type");

                entity.Property(e => e.NewDepartmentId).HasColumnName("new_departmentID");

                entity.Property(e => e.NewDepartmentName)
                    .IsRequired()
                    .HasColumnName("new_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.NewEmployeeId).HasColumnName("new_employeeID");

                entity.Property(e => e.NewEmployeeName)
                    .IsRequired()
                    .HasColumnName("new_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.NewPublicCustomerType).HasColumnName("new_public_customer_type");

                entity.Property(e => e.NewQueryCode).HasColumnName("new_query_code");

                entity.Property(e => e.OldDepartmentId).HasColumnName("old_departmentID");

                entity.Property(e => e.OldDepartmentName)
                    .IsRequired()
                    .HasColumnName("old_department_name")
                    .HasMaxLength(30);

                entity.Property(e => e.OldEmployeeId).HasColumnName("old_employeeID");

                entity.Property(e => e.OldEmployeeName)
                    .IsRequired()
                    .HasColumnName("old_employee_name")
                    .HasMaxLength(35);

                entity.Property(e => e.OldPublicCustomerType).HasColumnName("old_public_customer_type");

                entity.Property(e => e.OldQueryCode).HasColumnName("old_query_code");

                entity.Property(e => e.OwnerType).HasColumnName("owner_type");

                entity.Property(e => e.SourceId).HasColumnName("sourceID");

                entity.Property(e => e.TransferId).HasColumnName("transferID");
            });

            modelBuilder.Entity<UDujiaStatis>(entity =>
            {
                entity.ToTable("u_dujia_statis");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.AreaName)
                    .HasColumnName("area_name")
                    .HasMaxLength(500);

                entity.Property(e => e.BigAreaId).HasColumnName("big_area_id");

                entity.Property(e => e.BigAreaName)
                    .HasColumnName("big_area_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BuildingId).HasColumnName("buildingId");

                entity.Property(e => e.BuildingName)
                    .HasColumnName("building_Name")
                    .HasMaxLength(30);

                entity.Property(e => e.BusiDeptId).HasColumnName("busi_dept_id");

                entity.Property(e => e.BusiDeptName)
                    .HasColumnName("busi_dept_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CommissionDate)
                    .HasColumnName("commission_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CommissionNum)
                    .HasColumnName("commission_num")
                    .HasMaxLength(50);

                entity.Property(e => e.CommissionType).HasColumnName("commission_type");

                entity.Property(e => e.CommissionTypeName)
                    .HasColumnName("commission_type_name")
                    .HasMaxLength(10);

                entity.Property(e => e.CommunityId).HasColumnName("communityId");

                entity.Property(e => e.CommunityName)
                    .HasColumnName("community_Name")
                    .HasMaxLength(30);

                entity.Property(e => e.ConstructionArea).HasColumnName("construction_area");

                entity.Property(e => e.EmpCd)
                    .HasColumnName("emp_cd")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasColumnName("emp_name")
                    .HasMaxLength(30);

                entity.Property(e => e.RealtyId).HasColumnName("realtyId");

                entity.Property(e => e.RealtyNum)
                    .HasColumnName("realty_num")
                    .HasMaxLength(16);

                entity.Property(e => e.RoomId).HasColumnName("roomId");

                entity.Property(e => e.RoomName)
                    .HasColumnName("room_Name")
                    .HasMaxLength(12);

                entity.Property(e => e.ShopName)
                    .HasColumnName("shop_name")
                    .HasMaxLength(50);

                entity.Property(e => e.StatDate)
                    .HasColumnName("stat_date")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.TeamCode)
                    .HasColumnName("team_code")
                    .HasMaxLength(30);

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<UImpMaxIdLog>(entity =>
            {
                entity.ToTable("u_imp_max_id_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataType).HasColumnName("data_type");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MaxIdEnd).HasColumnName("Max_ID_End");

                entity.Property(e => e.MaxIdStart).HasColumnName("Max_ID_Start");

                entity.Property(e => e.RowCount).HasColumnName("row_Count");

                entity.Property(e => e.TableType)
                    .HasColumnName("table_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TagMaxId).HasColumnName("tag_max_id");
            });

            modelBuilder.Entity<UNrtConfig>(entity =>
            {
                entity.ToTable("u_nrt_config");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ConfigDesc)
                    .HasColumnName("config_desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigName)
                    .HasColumnName("config_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigValue)
                    .HasColumnName("config_value")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("group_id");
            });

            modelBuilder.Entity<UpdateOrgCache>(entity =>
            {
                entity.ToTable("update_org_cache");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.Done).HasColumnName("done");
            });

            modelBuilder.Entity<UPhonedealHistory>(entity =>
            {
                entity.ToTable("u_phonedeal_history");

                entity.HasIndex(e => e.ContactorId)
                    .HasName("u_phonedeal_history_contactorID");

                entity.HasIndex(e => e.SourceId)
                    .HasName("u_phonedeal_history_source_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContactorId).HasColumnName("contactorID");

                entity.Property(e => e.ContactorType).HasColumnName("contactor_type");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(40);

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(40);

                entity.Property(e => e.RealtyType).HasColumnName("realty_type");

                entity.Property(e => e.SourceId).HasColumnName("source_ID");

                entity.Property(e => e.UseType).HasColumnName("use_type");
            });

            modelBuilder.Entity<UserCustom>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.Type });

                entity.ToTable("user_custom");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Custom)
                    .HasColumnName("custom")
                    .HasColumnType("xml");

                entity.Property(e => e.CustomVersion).HasColumnName("custom_version");
            });

            modelBuilder.Entity<WebServiceLog>(entity =>
            {
                entity.ToTable("web_service_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.InterfaceName)
                    .HasColumnName("interface_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MethodName)
                    .HasColumnName("method_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationResult)
                    .HasColumnName("operation_result")
                    .HasMaxLength(200);

                entity.Property(e => e.OperationXml)
                    .HasColumnName("operation_xml")
                    .HasMaxLength(2000);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<FranchiseesManager>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("Create_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedFlag).HasColumnName("Deleted_flag");

                entity.Property(e => e.FrcId).HasColumnName("Frc_ID");

                entity.Property(e => e.Memo).HasMaxLength(80);
            });
        }
    }
}
