using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project_Manager.Models
{
    public partial class SAGSContext : DbContext
    {
        public SAGSContext()
        {
        }

        public SAGSContext(DbContextOptions<SAGSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avaya> Avayas { get; set; }
        public virtual DbSet<ListAirCraft> ListAirCrafts { get; set; }
        public virtual DbSet<ListAirCraftType> ListAirCraftTypes { get; set; }
        public virtual DbSet<ListCarrier> ListCarriers { get; set; }
        public virtual DbSet<ListCity> ListCities { get; set; }
        public virtual DbSet<ListCountry> ListCountries { get; set; }
        public virtual DbSet<ListCurrency> ListCurrencies { get; set; }
        public virtual DbSet<ListDelivery> ListDeliveries { get; set; }
        public virtual DbSet<ListDept> ListDepts { get; set; }
        public virtual DbSet<ListEducationLevel> ListEducationLevels { get; set; }
        public virtual DbSet<ListEmp> ListEmps { get; set; }
        public virtual DbSet<ListOfFee> ListOfFees { get; set; }
        public virtual DbSet<ListOrg> ListOrgs { get; set; }
        public virtual DbSet<ListProvince> ListProvinces { get; set; }
        public virtual DbSet<ListReason> ListReasons { get; set; }
        public virtual DbSet<ListRoe> ListRoes { get; set; }
        public virtual DbSet<ListServiceType> ListServiceTypes { get; set; }
        public virtual DbSet<ListStation> ListStations { get; set; }
        public virtual DbSet<LostInformation> LostInformations { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonGroup> PersonGroups { get; set; }
        public virtual DbSet<ReportBaggage> ReportBaggages { get; set; }
        public virtual DbSet<ReportDelay> ReportDelays { get; set; }
        public virtual DbSet<ReportItinerary> ReportItineraries { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<SysGroup> SysGroups { get; set; }
        public virtual DbSet<SysGroupRight> SysGroupRights { get; set; }
        public virtual DbSet<SysGroupUser> SysGroupUsers { get; set; }
        public virtual DbSet<SysParameter> SysParameters { get; set; }
        public virtual DbSet<SysReport> SysReports { get; set; }
        public virtual DbSet<SysReportParameter> SysReportParameters { get; set; }
        public virtual DbSet<SysRight> SysRights { get; set; }
        public virtual DbSet<SysTable> SysTables { get; set; }
        public virtual DbSet<SysUser> SysUsers { get; set; }
        public virtual DbSet<SysUserRight> SysUserRights { get; set; }
        public virtual DbSet<TagDetail> TagDetails { get; set; }
        public virtual DbSet<ViewPersonPersonGroup> ViewPersonPersonGroups { get; set; }
        public virtual DbSet<VwGroup> VwGroups { get; set; }
        public virtual DbSet<VwPerson> VwPersons { get; set; }
        public virtual DbSet<VwPersonWithOutUnicode> VwPersonWithOutUnicodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-IE7IIGL\\LOCALSERVER2017;Initial Catalog=SAGS;Persist Security Info=True;User ID=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Avaya>(entity =>
            {
                entity.ToTable("Avaya");

                entity.Property(e => e.BusinessPhone).HasMaxLength(4000);

                entity.Property(e => e.Fullname).HasMaxLength(4000);

                entity.Property(e => e.Position).HasMaxLength(4000);
            });

            modelBuilder.Entity<ListAirCraft>(entity =>
            {
                entity.HasKey(e => e.AirCraftId)
                    .HasName("PK_ListAirCraft");

                entity.ToTable("_ListAirCraft");

                entity.Property(e => e.AirCraftId).HasColumnName("AirCraftID");

                entity.Property(e => e.AirCraftType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Carrier)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Mtow).HasColumnName("MTOW");

                entity.Property(e => e.RegistrationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.AirCraftTypeNavigation)
                    .WithMany(p => p.ListAirCrafts)
                    .HasForeignKey(d => d.AirCraftType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListAirCraft_ListAirCraftType");
            });

            modelBuilder.Entity<ListAirCraftType>(entity =>
            {
                entity.HasKey(e => e.AirCraftType)
                    .HasName("PK_ListAirCraftType");

                entity.ToTable("_ListAirCraftType");

                entity.Property(e => e.AirCraftType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListCarrier>(entity =>
            {
                entity.HasKey(e => e.Carrier)
                    .HasName("PK_ListCarrier");

                entity.ToTable("_ListCarrier");

                entity.Property(e => e.Carrier)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CarrierName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListCity>(entity =>
            {
                entity.HasKey(e => e.City)
                    .HasName("PK_ListCity");

                entity.ToTable("_ListCity");

                entity.Property(e => e.City)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListCountry>(entity =>
            {
                entity.HasKey(e => e.Country)
                    .HasName("PK_ListCountry");

                entity.ToTable("_ListCountry");

                entity.Property(e => e.Country)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Areacode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AREACODE");

                entity.Property(e => e.Areaout)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AREAOUT");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListCurrency>(entity =>
            {
                entity.HasKey(e => e.Curr)
                    .HasName("PK_ListCurrency");

                entity.ToTable("_ListCurrency");

                entity.Property(e => e.Curr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListDelivery>(entity =>
            {
                entity.HasKey(e => e.DeliveryType)
                    .HasName("PK_ListPickupType");

                entity.ToTable("_ListDelivery");

                entity.Property(e => e.DeliveryType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListDept>(entity =>
            {
                entity.HasKey(e => new { e.DeptId, e.OrgId })
                    .HasName("PK_ListDept");

                entity.ToTable("_ListDept");

                entity.Property(e => e.DeptId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrgId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName).HasMaxLength(50);
            });

            modelBuilder.Entity<ListEducationLevel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_ListEducationLevel");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EducationLevel)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListEmp>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_ListUser");

                entity.ToTable("_ListEmp");

                entity.HasIndex(e => e.UserName, "IX_ListUser")
                    .IsUnique();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.AlterEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");

                entity.Property(e => e.DeptId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EducationLevel).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(35);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDCard");

                entity.Property(e => e.IdcardDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("IDCardDate");

                entity.Property(e => e.IdcardPlaceOfIssue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDCardPlaceOfIssue");

                entity.Property(e => e.Job).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(15);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.Occupation).HasMaxLength(50);

                entity.Property(e => e.OrgId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentPlace).HasMaxLength(50);

                entity.Property(e => e.PlaceOfBirth)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province).HasMaxLength(50);

                entity.Property(e => e.TemporaryAddress).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPosition).HasMaxLength(20);
            });

            modelBuilder.Entity<ListOfFee>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryBy, e.TagOrder })
                    .HasName("PK_ListOfFee");

                entity.ToTable("_ListOfFee");

                entity.Property(e => e.DeliveryBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddChargeCurr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeCurr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ExpressFeeCurr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InterimCurr)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListOrg>(entity =>
            {
                entity.HasKey(e => e.OrgId)
                    .HasName("PK_ListOrganisation");

                entity.ToTable("_ListOrg");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.BusinessPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrgName).HasMaxLength(50);
            });

            modelBuilder.Entity<ListProvince>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_ListProvince");

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            });

            modelBuilder.Entity<ListReason>(entity =>
            {
                entity.HasKey(e => e.ReasonCode)
                    .HasName("PK_ListReason");

                entity.ToTable("_ListReason");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reason4)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListRoe>(entity =>
            {
                entity.HasKey(e => new { e.Curr, e.FromDate })
                    .HasName("PK_ListRoe");

                entity.ToTable("_ListRoe");

                entity.Property(e => e.Curr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ListServiceType>(entity =>
            {
                entity.HasKey(e => e.ServiceType)
                    .HasName("PK_ListServiceType");

                entity.ToTable("_ListServiceType");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListStation>(entity =>
            {
                entity.HasKey(e => e.StationCode)
                    .HasName("PK_ListStation");

                entity.ToTable("_ListStation");

                entity.Property(e => e.StationCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LostInformation>(entity =>
            {
                entity.HasKey(e => e.FileNo)
                    .HasName("PK_LostInformation");

                entity.ToTable("_LostInformation");

                entity.Property(e => e.FileNo)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Carrier)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FaultStation)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaxName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.CarrierNavigation)
                    .WithMany(p => p.LostInformations)
                    .HasForeignKey(d => d.Carrier)
                    .HasConstraintName("FK_LostInformation_ListCarrier");

                entity.HasOne(d => d.FaultStationNavigation)
                    .WithMany(p => p.LostInformations)
                    .HasForeignKey(d => d.FaultStation)
                    .HasConstraintName("FK_LostInformation_ListStation");

                entity.HasOne(d => d.ReasonCodeNavigation)
                    .WithMany(p => p.LostInformations)
                    .HasForeignKey(d => d.ReasonCode)
                    .HasConstraintName("FK_LostInformation_ListReason");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.Address).HasMaxLength(4000);

                entity.Property(e => e.BusinessPhone).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.HomePhone).IsUnicode(false);

                entity.Property(e => e.Hrmid).HasColumnName("HRMId");

                entity.Property(e => e.JobTitle).HasMaxLength(4000);

                entity.Property(e => e.MobilePhone).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Person_PersonGroup");
            });

            modelBuilder.Entity<PersonGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("PersonGroup");

                entity.Property(e => e.Address).HasMaxLength(4000);

                entity.Property(e => e.GroupDescription).HasMaxLength(4000);

                entity.Property(e => e.GroupName).HasMaxLength(4000);

                entity.Property(e => e.GroupParentId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.GroupType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportBaggage>(entity =>
            {
                entity.HasKey(e => e.BaggageId)
                    .HasName("PK_ReportBaggage");

                entity.ToTable("_ReportBaggage");

                entity.Property(e => e.BaggageId).HasColumnName("BaggageID");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TagNo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportBaggages)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTagDetail_ReportDelay");
            });

            modelBuilder.Entity<ReportDelay>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_DelayReport");

                entity.ToTable("_ReportDelay");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AlternatePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Carrier)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateOfTravel).HasColumnType("smalldatetime");

                entity.Property(e => e.NameOnTag)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaxName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TicketNo)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.HasOne(d => d.CarrierNavigation)
                    .WithMany(p => p.ReportDelays)
                    .HasForeignKey(d => d.Carrier)
                    .HasConstraintName("FK_ReportDelay_ListCarrier");
            });

            modelBuilder.Entity<ReportItinerary>(entity =>
            {
                entity.HasKey(e => e.ItineraryId)
                    .HasName("PK_ReportItinerary");

                entity.ToTable("_ReportItinerary");

                entity.Property(e => e.Carrier)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FromPort)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ToPort)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportItineraries)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportItinerary_ReportDelay");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("_Service");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.AddChargeCurr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AirCraftType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Carrier)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeCurr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Mtow).HasColumnName("MTOW");

                entity.Property(e => e.Notes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Subscriber).HasDefaultValueSql("(1)");

                entity.Property(e => e.TimeGraft1st)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TimeGraft2nd)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TimeWithdraw1st)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TimeWithdraw2nd)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.AirCraftTypeNavigation)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.AirCraftType)
                    .HasConstraintName("FK_Service_ListAirCraftType");

                entity.HasOne(d => d.CarrierNavigation)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.Carrier)
                    .HasConstraintName("FK_Service_ListCarrier");

                entity.HasOne(d => d.ServiceTypeNavigation)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.ServiceType)
                    .HasConstraintName("FK_Service_ListServiceType");
            });

            modelBuilder.Entity<SysGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("SysGroup");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<SysGroupRight>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.RightId });

                entity.ToTable("SysGroupRight");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RightId)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysGroupUser>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId });

                entity.ToTable("SysGroupUser");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysParameter>(entity =>
            {
                entity.HasKey(e => e.ParaName)
                    .HasName("PK_SysParameter");

                entity.ToTable("_SysParameter");

                entity.Property(e => e.ParaName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ParaValue)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_SysReport");

                entity.ToTable("_SysReport");

                entity.Property(e => e.ReportId)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ReportFile)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTitle)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SysReportParameter>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.ParaId })
                    .HasName("PK_SysReportParameter");

                entity.ToTable("_SysReportParameter");

                entity.Property(e => e.ReportId)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ParaId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParaValue)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysRight>(entity =>
            {
                entity.HasKey(e => e.RightId);

                entity.ToTable("SysRight");

                entity.Property(e => e.RightId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ParentRight)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RightDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysTable>(entity =>
            {
                entity.HasKey(e => e.TableName)
                    .HasName("PK_SysTable");

                entity.ToTable("_SysTable");

                entity.Property(e => e.TableName).HasMaxLength(20);

                entity.Property(e => e.TableAlias)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("SysUser");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPos).HasMaxLength(50);

                entity.Property(e => e.UserPwd)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysUserRight>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RightId });

                entity.ToTable("SysUserRight");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RightId)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TagDetail>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK_TagDetail");

                entity.ToTable("_TagDetail");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.AddChargeCurr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeCurr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExpressFeeCurr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FileNo)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.InterimCurr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TagNo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.DeliveryByNavigation)
                    .WithMany(p => p.TagDetails)
                    .HasForeignKey(d => d.DeliveryBy)
                    .HasConstraintName("FK_TagDetail_ListDelivery");

                entity.HasOne(d => d.FileNoNavigation)
                    .WithMany(p => p.TagDetails)
                    .HasForeignKey(d => d.FileNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TagDetail_LostInformation");
            });

            modelBuilder.Entity<ViewPersonPersonGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Person_PersonGroup");

                entity.Property(e => e.Address).HasMaxLength(4000);

                entity.Property(e => e.BusinessPhone).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.GroupName).HasMaxLength(4000);

                entity.Property(e => e.HomePhone).IsUnicode(false);

                entity.Property(e => e.Hrmid).HasColumnName("HRMId");

                entity.Property(e => e.JobTitle).HasMaxLength(4000);

                entity.Property(e => e.MobilePhone).IsUnicode(false);

                entity.Property(e => e.PersonId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGroups");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.ChildAddress).HasMaxLength(100);

                entity.Property(e => e.ChildGroupDescription).HasMaxLength(100);

                entity.Property(e => e.ChildGroupName).HasMaxLength(50);

                entity.Property(e => e.ChildPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupDescription).HasMaxLength(100);

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPersons");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.BusinessPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupAddress).HasMaxLength(100);

                entity.Property(e => e.GroupDescription).HasMaxLength(100);

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle).HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPersonWithOutUnicode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PersonWithOutUnicode");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.BusinessPhone)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle).HasMaxLength(100);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
