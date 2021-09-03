using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FSTodoList.EF.Models;

#nullable disable

namespace FSTodoList.EF
{
    public partial class AccuPrecisionDbContext : DbContext
    {
        public AccuPrecisionDbContext()
        {
        }

        public AccuPrecisionDbContext(DbContextOptions<AccuPrecisionDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<ApplicationSetting> ApplicationSettings { get; set; }
        public virtual DbSet<AqlTable> AqlTables { get; set; }
        public virtual DbSet<Bin> Bins { get; set; }
        public virtual DbSet<Cell> Cells { get; set; }
        public virtual DbSet<ChangeAudit> ChangeAudits { get; set; }
        public virtual DbSet<ChangeAuditExclusion> ChangeAuditExclusions { get; set; }
        public virtual DbSet<ChangeAuditLookup> ChangeAuditLookups { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<EmployeePerformance> EmployeePerformances { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<FlywaySchemaHistory> FlywaySchemaHistories { get; set; }
        public virtual DbSet<Hardware> Hardwares { get; set; }
        public virtual DbSet<HardwareBkp20190828> HardwareBkp20190828s { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<InProcessInspectionItem> InProcessInspectionItems { get; set; }
        public virtual DbSet<InProcessOperation> InProcessOperations { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceJobPartBkp> InvoiceJobPartBkps { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobDueDate> JobDueDates { get; set; }
        public virtual DbSet<JobFunction> JobFunctions { get; set; }
        public virtual DbSet<JobHardware> JobHardwares { get; set; }
        public virtual DbSet<JobHardwareBkp20200723> JobHardwareBkp20200723s { get; set; }
        public virtual DbSet<JobMaterial> JobMaterials { get; set; }
        public virtual DbSet<JobMaterialBkp20200723> JobMaterialBkp20200723s { get; set; }
        public virtual DbSet<JobPartBatch> JobPartBatches { get; set; }
        public virtual DbSet<JobRoute> JobRoutes { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PackingList> PackingLists { get; set; }
        public virtual DbSet<PackingListJobPart> PackingListJobParts { get; set; }
        public virtual DbSet<PackingListJobPartBkp> PackingListJobPartBkps { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<PartHardware> PartHardwares { get; set; }
        public virtual DbSet<PartHardwareQuoteEstimate> PartHardwareQuoteEstimates { get; set; }
        public virtual DbSet<PartMaterialQuoteEstimate> PartMaterialQuoteEstimates { get; set; }
        public virtual DbSet<PartRoute> PartRoutes { get; set; }
        public virtual DbSet<PartRouteCostEstimateBracket> PartRouteCostEstimateBrackets { get; set; }
        public virtual DbSet<PayPeriod> PayPeriods { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<RawMaterial> RawMaterials { get; set; }
        public virtual DbSet<Receiver> Receivers { get; set; }
        public virtual DbSet<ReceiverItem> ReceiverItems { get; set; }
        public virtual DbSet<Rma> Rmas { get; set; }
        public virtual DbSet<RmaJobNote> RmaJobNotes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<TimeEntry> TimeEntries { get; set; }
        public virtual DbSet<TimeEntryLog> TimeEntryLogs { get; set; }
        public virtual DbSet<Timesheet> Timesheets { get; set; }
        public virtual DbSet<TypeAccountingSystemSynchEvent> TypeAccountingSystemSynchEvents { get; set; }
        public virtual DbSet<TypeAddress> TypeAddresses { get; set; }
        public virtual DbSet<TypeAllowableJobPartStatus> TypeAllowableJobPartStatuses { get; set; }
        public virtual DbSet<TypeBin> TypeBins { get; set; }
        public virtual DbSet<TypeCell> TypeCells { get; set; }
        public virtual DbSet<TypeContact> TypeContacts { get; set; }
        public virtual DbSet<TypeCustomer> TypeCustomers { get; set; }
        public virtual DbSet<TypeCustomerInvoiceStatus> TypeCustomerInvoiceStatuses { get; set; }
        public virtual DbSet<TypeCustomerInvoiceTax> TypeCustomerInvoiceTaxes { get; set; }
        public virtual DbSet<TypeCustomerShipmentStatus> TypeCustomerShipmentStatuses { get; set; }
        public virtual DbSet<TypeCustomerTax> TypeCustomerTaxes { get; set; }
        public virtual DbSet<TypeJobHardwareStatus> TypeJobHardwareStatuses { get; set; }
        public virtual DbSet<TypeJobMaterialStatus> TypeJobMaterialStatuses { get; set; }
        public virtual DbSet<TypeJobPartStatus> TypeJobPartStatuses { get; set; }
        public virtual DbSet<TypeJobStatus> TypeJobStatuses { get; set; }
        public virtual DbSet<TypeMaterial> TypeMaterials { get; set; }
        public virtual DbSet<TypeOrderStatus> TypeOrderStatuses { get; set; }
        public virtual DbSet<TypePackingListStatus> TypePackingListStatuses { get; set; }
        public virtual DbSet<TypePart> TypeParts { get; set; }
        public virtual DbSet<TypePayPeriodStatus> TypePayPeriodStatuses { get; set; }
        public virtual DbSet<TypePaymentTerm> TypePaymentTerms { get; set; }
        public virtual DbSet<TypePurchaseOrder> TypePurchaseOrders { get; set; }
        public virtual DbSet<TypePurchaseOrderStatus> TypePurchaseOrderStatuses { get; set; }
        public virtual DbSet<TypeQuoteStatus> TypeQuoteStatuses { get; set; }
        public virtual DbSet<TypeRawMaterial> TypeRawMaterials { get; set; }
        public virtual DbSet<TypeRejectionReason> TypeRejectionReasons { get; set; }
        public virtual DbSet<TypeRmaJob> TypeRmaJobs { get; set; }
        public virtual DbSet<TypeRmaJobNote> TypeRmaJobNotes { get; set; }
        public virtual DbSet<TypeRmaStatus> TypeRmaStatuses { get; set; }
        public virtual DbSet<TypeRoute> TypeRoutes { get; set; }
        public virtual DbSet<TypeRouteCategory> TypeRouteCategories { get; set; }
        public virtual DbSet<TypeSalesTaxCode> TypeSalesTaxCodes { get; set; }
        public virtual DbSet<TypeShippingCode> TypeShippingCodes { get; set; }
        public virtual DbSet<TypeTimeEntry> TypeTimeEntries { get; set; }
        public virtual DbSet<TypeUserShift> TypeUserShifts { get; set; }
        public virtual DbSet<TypeUserStatus> TypeUserStatuses { get; set; }
        public virtual DbSet<TypeVendorAccountCode> TypeVendorAccountCodes { get; set; }
        public virtual DbSet<TypeVendorInvoiceStatus> TypeVendorInvoiceStatuses { get; set; }
        public virtual DbSet<TypeVendorStatus> TypeVendorStatuses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorInvoice> VendorInvoices { get; set; }
        public virtual DbSet<VendorInvoiceItem> VendorInvoiceItems { get; set; }
        public virtual DbSet<VwJobTimeDatum> VwJobTimeData { get; set; }
        public virtual DbSet<VwPackingListItem> VwPackingListItems { get; set; }
        public virtual DbSet<VwTimeEntry> VwTimeEntries { get; set; }
        public virtual DbSet<VwTimeEntrySummedByDay> VwTimeEntrySummedByDays { get; set; }
        public virtual DbSet<XrefCustomerAddress> XrefCustomerAddresses { get; set; }
        public virtual DbSet<XrefCustomerContact> XrefCustomerContacts { get; set; }
        public virtual DbSet<XrefJobCell> XrefJobCells { get; set; }
        public virtual DbSet<XrefJobItemPurchaseOrderItem> XrefJobItemPurchaseOrderItems { get; set; }
        public virtual DbSet<XrefJobMaterialBin> XrefJobMaterialBins { get; set; }
        public virtual DbSet<XrefJobPart> XrefJobParts { get; set; }
        public virtual DbSet<XrefJobPartBkp> XrefJobPartBkps { get; set; }
        public virtual DbSet<XrefJobPartStatusChangeHistory> XrefJobPartStatusChangeHistories { get; set; }
        public virtual DbSet<XrefJobTimeEntry> XrefJobTimeEntries { get; set; }
        public virtual DbSet<XrefPartMaterial> XrefPartMaterials { get; set; }
        public virtual DbSet<XrefPartPart> XrefPartParts { get; set; }
        public virtual DbSet<XrefPurchaseOrderItemBin> XrefPurchaseOrderItemBins { get; set; }
        public virtual DbSet<XrefQuotePart> XrefQuoteParts { get; set; }
        public virtual DbSet<XrefRmaJob> XrefRmaJobs { get; set; }
        public virtual DbSet<XrefRoleFeature> XrefRoleFeatures { get; set; }
        public virtual DbSet<XrefUserRole> XrefUserRoles { get; set; }
        public virtual DbSet<XrefVendorAddress> XrefVendorAddresses { get; set; }
        public virtual DbSet<XrefVendorContact> XrefVendorContacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.HasIndex(e => e.AddressId, "AddressID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.AddressTypeId, "FK_Address_AddressType_idx");

                entity.Property(e => e.AddressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AddressID");

                entity.Property(e => e.AddressTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AddressTypeID");

                entity.Property(e => e.City).HasMaxLength(45);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.State).HasMaxLength(15);

                entity.Property(e => e.Street1).HasMaxLength(255);

                entity.Property(e => e.Street2).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Zip).HasMaxLength(20);

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_AddressType");
            });

            modelBuilder.Entity<ApplicationSetting>(entity =>
            {
                entity.ToTable("application_setting");

                entity.HasIndex(e => e.SettingKey, "application_setting_SettingKey_unique")
                    .IsUnique();

                entity.Property(e => e.ApplicationSettingId).HasColumnType("int(11)");

                entity.Property(e => e.SettingDataType)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.SettingDescription).HasMaxLength(512);

                entity.Property(e => e.SettingKey)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<AqlTable>(entity =>
            {
                entity.ToTable("aql_table");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Aqlvalue)
                    .HasPrecision(32, 3)
                    .HasColumnName("AQLValue");

                entity.Property(e => e.LotSizeLower).HasColumnType("int(11)");

                entity.Property(e => e.LotSizeUpper).HasColumnType("int(11)");

                entity.Property(e => e.SampleSize).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Bin>(entity =>
            {
                entity.ToTable("bin");

                entity.HasIndex(e => e.BinTypeId, "FK_bin_type_bin");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.BinName)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.BinTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("BinTypeID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BinType)
                    .WithMany(p => p.Bins)
                    .HasForeignKey(d => d.BinTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bin_type_bin");
            });

            modelBuilder.Entity<Cell>(entity =>
            {
                entity.ToTable("cell");

                entity.HasIndex(e => e.CellTypeId, "cell_type_cell_fk_idx");

                entity.Property(e => e.CellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CellID");

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CellTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CellTypeID")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CellType)
                    .WithMany(p => p.Cells)
                    .HasForeignKey(d => d.CellTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cell_type_cell_fk");
            });

            modelBuilder.Entity<ChangeAudit>(entity =>
            {
                entity.HasKey(e => e.ChangeId)
                    .HasName("PRIMARY");

                entity.ToTable("change_audit");

                entity.Property(e => e.ChangeId).HasColumnType("int(11)");

                entity.Property(e => e.ClosedById).HasColumnType("int(11)");

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InitiatedById).HasColumnType("int(11)");

                entity.Property(e => e.InitiatedDate).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasMaxLength(5000);
            });

            modelBuilder.Entity<ChangeAuditExclusion>(entity =>
            {
                entity.ToTable("change_audit_exclusion");

                entity.HasIndex(e => e.ChangeAuditExclusionId, "ChangeAuditExclusionId_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => new { e.EntityName, e.PropertyName }, "ChangeAuditExclusion_TableName_PropertyName_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ChangeAuditExclusionId).HasColumnType("int(11)");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PropertyName).HasMaxLength(128);
            });

            modelBuilder.Entity<ChangeAuditLookup>(entity =>
            {
                entity.ToTable("change_audit_lookup");

                entity.HasIndex(e => e.ChangeAuditLookupId, "ChangeAuditLookupId_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => new { e.SourceProperty, e.DestinationTable, e.DestinationProperty, e.DestinationDisplayField }, "ChangeAuditLookup_LookupFields_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ChangeAuditLookupId).HasColumnType("int(11)");

                entity.Property(e => e.DestinationDisplayField).HasMaxLength(128);

                entity.Property(e => e.DestinationProperty).HasMaxLength(128);

                entity.Property(e => e.DestinationTable).HasMaxLength(128);

                entity.Property(e => e.SourceProperty)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.HasIndex(e => e.ContactTypeId, "FK_Contact_TypeContact_idx");

                entity.Property(e => e.ContactId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContactID");

                entity.Property(e => e.BusinessPhone).HasMaxLength(45);

                entity.Property(e => e.CellPhone).HasMaxLength(45);

                entity.Property(e => e.ContactTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContactTypeID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(45);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.MiddleName).HasMaxLength(45);

                entity.Property(e => e.PhoneExt)
                    .HasMaxLength(45)
                    .HasColumnName("Phone_Ext");

                entity.Property(e => e.Title).HasMaxLength(45);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_TypeContact");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.HasIndex(e => e.CustomerId, "CustomerID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PaymentTermsTypeId, "FK_Customer_CustomerPaymentTermsType_idx");

                entity.HasIndex(e => e.CustomerTypeId, "FK_Customer_Type");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(45);

                entity.Property(e => e.CustomerTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerTypeID");

                entity.Property(e => e.EmailAddress).HasMaxLength(1024);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.PaymentTermsTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PaymentTermsTypeID");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UpdatedDate)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Type");

                entity.HasOne(d => d.PaymentTermsType)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PaymentTermsTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_PaymentTermsType");
            });

            modelBuilder.Entity<EmployeePerformance>(entity =>
            {
                entity.ToTable("employee_performance");

                entity.HasIndex(e => e.JobId, "fk_job_employee_performance_idx");

                entity.HasIndex(e => e.UserId, "fk_user_employee_performance");

                entity.Property(e => e.EmployeePerformanceId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedById).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FeaturesInspected).HasColumnType("int(11)");

                entity.Property(e => e.Hours).HasPrecision(32, 2);

                entity.Property(e => e.InspectorUserId).HasColumnType("int(11)");

                entity.Property(e => e.JobId).HasColumnType("int(11)");

                entity.Property(e => e.Pass).HasColumnType("bit(1)");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.RejectionReasonId).HasColumnType("int(11)");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.EmployeePerformances)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_employee_performance");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmployeePerformances)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_user_employee_performance");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.ToTable("feature");

                entity.HasIndex(e => e.Name, "feature_Name_unique")
                    .IsUnique();

                entity.Property(e => e.FeatureId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<FlywaySchemaHistory>(entity =>
            {
                entity.HasKey(e => e.InstalledRank)
                    .HasName("PRIMARY");

                entity.ToTable("flyway_schema_history");

                entity.HasIndex(e => e.Success, "flyway_schema_history_s_idx");

                entity.Property(e => e.InstalledRank)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("installed_rank");

                entity.Property(e => e.Checksum)
                    .HasColumnType("int(11)")
                    .HasColumnName("checksum");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("description");

                entity.Property(e => e.ExecutionTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("execution_time");

                entity.Property(e => e.InstalledBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("installed_by");

                entity.Property(e => e.InstalledOn)
                    .HasColumnType("timestamp")
                    .HasColumnName("installed_on")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Script)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("script");

                entity.Property(e => e.Success).HasColumnName("success");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("type");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<Hardware>(entity =>
            {
                entity.ToTable("hardware");

                entity.HasIndex(e => e.PartNumber, "hardware_PartNumber_unique")
                    .IsUnique();

                entity.Property(e => e.HardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("HardwareID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HardwareDescription)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasPrecision(32, 2);

                entity.Property(e => e.UnitCount).HasColumnType("int(11)");

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(10);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HardwareBkp20190828>(entity =>
            {
                entity.HasKey(e => e.HardwareId)
                    .HasName("PRIMARY");

                entity.ToTable("hardware_bkp20190828");

                entity.HasIndex(e => e.PartNumber, "hardware_PartNumber_unique")
                    .IsUnique();

                entity.Property(e => e.HardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("HardwareID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HardwareDescription)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasPrecision(32, 2);

                entity.Property(e => e.UnitCount).HasColumnType("int(11)");

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(10);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("holiday");

                entity.Property(e => e.HolidayId)
                    .HasColumnType("int(11)")
                    .HasColumnName("HolidayID");

                entity.Property(e => e.AllocatedHours).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.HolidayDate).HasColumnType("datetime");

                entity.Property(e => e.HolidayName).HasMaxLength(255);

                entity.Property(e => e.ScheduleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ScheduleID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");
            });

            modelBuilder.Entity<InProcessInspectionItem>(entity =>
            {
                entity.HasKey(e => e.InspectionItemId)
                    .HasName("PRIMARY");

                entity.ToTable("in_process_inspection_item");

                entity.HasIndex(e => e.OperationId, "fk_item_template");

                entity.Property(e => e.InspectionItemId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedById).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Dimension).HasPrecision(10, 4);

                entity.Property(e => e.Feature).HasMaxLength(50);

                entity.Property(e => e.HundredPercent)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ItemNumber).HasColumnType("int(11)");

                entity.Property(e => e.MinusTolerance).HasPrecision(10, 4);

                entity.Property(e => e.OperationId).HasColumnType("int(11)");

                entity.Property(e => e.PlusTolerance).HasPrecision(10, 4);

                entity.Property(e => e.Sequence).HasColumnType("int(11)");

                entity.Property(e => e.ToolNumber).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.InProcessInspectionItems)
                    .HasForeignKey(d => d.OperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_item_template");
            });

            modelBuilder.Entity<InProcessOperation>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("PRIMARY");

                entity.ToTable("in_process_operation");

                entity.HasIndex(e => e.PartId, "fk_operation_part");

                entity.Property(e => e.OperationId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedById).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Interval).HasColumnType("int(11)");

                entity.Property(e => e.OperationName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.PartId).HasColumnType("int(11)");

                entity.Property(e => e.Sequence).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.InProcessOperations)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_operation_part");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.HasIndex(e => e.PackingListId, "fk_invoice_packing_list");

                entity.HasIndex(e => e.InvoiceStatusId, "fk_invoice_type_customer_invoice_status");

                entity.HasIndex(e => e.PaymentTermsTypeId, "fk_invoice_type_payment_terms");

                entity.Property(e => e.InvoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("InvoiceID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(1024);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("InvoiceStatusID");

                entity.Property(e => e.InvoiceSubTotal).HasPrecision(32, 2);

                entity.Property(e => e.InvoiceTaxTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("InvoiceTaxTypeID");

                entity.Property(e => e.InvoiceTotal).HasPrecision(32, 2);

                entity.Property(e => e.Notes).HasMaxLength(2000);

                entity.Property(e => e.PackingListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PackingListID");

                entity.Property(e => e.PaymentTermsTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PaymentTermsTypeID");

                entity.Property(e => e.ShippingCost).HasPrecision(32, 2);

                entity.Property(e => e.Tax).HasPrecision(32, 2);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.InvoiceStatus)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.InvoiceStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_invoice_type_customer_invoice_status");

                entity.HasOne(d => d.PackingList)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.PackingListId)
                    .HasConstraintName("fk_invoice_packing_list");

                entity.HasOne(d => d.PaymentTermsType)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.PaymentTermsTypeId)
                    .HasConstraintName("fk_invoice_type_payment_terms");
            });

            modelBuilder.Entity<InvoiceJobPartBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("invoice_job_part_bkp");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("InvoiceItemID");

                entity.Property(e => e.JobPartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobPartID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("job");

                entity.HasIndex(e => e.PartId, "FK_part_job_ID_idx");

                entity.HasIndex(e => e.JobStatusTypeId, "FK_type_job_status_ID_idx");

                entity.HasIndex(e => e.JobNumber, "JobNumber_Idx")
                    .IsUnique()
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.OrderId, "OrderID_idx");

                entity.HasIndex(e => new { e.Sequence, e.JobId }, "Sequence_JobID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ParentJobId, "fk_job_job");

                entity.HasIndex(e => e.TravelerPrintedById, "fk_user_job_idx");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerNote).HasMaxLength(5000);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExtendedPrice).HasPrecision(32, 2);

                entity.Property(e => e.JobExtra).HasColumnType("int(11)");

                entity.Property(e => e.JobHierarchyLevel).HasColumnType("int(11)");

                entity.Property(e => e.JobNumber).HasMaxLength(45);

                entity.Property(e => e.JobStatusTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobStatusTypeID");

                entity.Property(e => e.JobTotal).HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.ParentJobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParentJobID");

                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartID");

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Price).HasPrecision(32, 2);

                entity.Property(e => e.ProcessExtra).HasColumnType("int(11)");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.Red)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Revision)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Sequence).HasColumnType("int(11)");

                entity.Property(e => e.TravelerNote).HasMaxLength(5000);

                entity.Property(e => e.TravelerPrintedById).HasColumnType("int(11)");

                entity.Property(e => e.TravelerPrintedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.JobStatusType)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.JobStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_type_job_status_ID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_order");

                entity.HasOne(d => d.ParentJob)
                    .WithMany(p => p.InverseParentJob)
                    .HasForeignKey(d => d.ParentJobId)
                    .HasConstraintName("fk_job_job");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("FK_part_job_ID");

                entity.HasOne(d => d.TravelerPrintedBy)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.TravelerPrintedById)
                    .HasConstraintName("fk_user_job");
            });

            modelBuilder.Entity<JobDueDate>(entity =>
            {
                entity.ToTable("job_due_date");

                entity.HasIndex(e => e.JobId, "fk_job_job_due_date_idx");

                entity.HasIndex(e => e.CreatedById, "fk_user_job_due_date_created_by_id_idx");

                entity.HasIndex(e => e.UpdatedById, "fk_user_job_due_date_updated_by_id_idx");

                entity.Property(e => e.JobDueDateId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedById).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Fulfilled)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.FulfilledDate).HasColumnType("datetime");

                entity.Property(e => e.JobId).HasColumnType("int(11)");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.JobDueDateCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_job_due_date_created_by_id");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobDueDates)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_job_due_date");

                entity.HasOne(d => d.UpdatedBy)
                    .WithMany(p => p.JobDueDateUpdatedBies)
                    .HasForeignKey(d => d.UpdatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_job_due_date_updated_by_id");
            });

            modelBuilder.Entity<JobFunction>(entity =>
            {
                entity.ToTable("job_function");

                entity.HasIndex(e => e.JobFunctionName, "job_function_JobFunctionName_unique")
                    .IsUnique();

                entity.Property(e => e.JobFunctionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobFunctionID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.JobFunctionDescription).HasMaxLength(8000);

                entity.Property(e => e.RequiresJob)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");
            });

            modelBuilder.Entity<JobHardware>(entity =>
            {
                entity.ToTable("job_hardware");

                entity.HasIndex(e => e.HardwareId, "fk_job_hardware_hardware");

                entity.HasIndex(e => e.JobId, "fk_job_hardware_job");

                entity.HasIndex(e => e.JobHardwareStatusId, "fk_job_hardware_type_job_hardware_status");

                entity.Property(e => e.JobHardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobHardwareID");

                entity.Property(e => e.CertificationRequired)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("HardwareID");

                entity.Property(e => e.JobHardwareStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobHardwareStatusID");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.PartHardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartHardwareID");

                entity.Property(e => e.PricePerUnit).HasPrecision(32, 2);

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Hardware)
                    .WithMany(p => p.JobHardwares)
                    .HasForeignKey(d => d.HardwareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_hardware_hardware");

                entity.HasOne(d => d.JobHardwareStatus)
                    .WithMany(p => p.JobHardwares)
                    .HasForeignKey(d => d.JobHardwareStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_hardware_type_job_hardware_status");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobHardwares)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_hardware_job");
            });

            modelBuilder.Entity<JobHardwareBkp20200723>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("job_hardware_bkp_20200723");

                entity.Property(e => e.CertificationRequired)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("HardwareID");

                entity.Property(e => e.JobHardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobHardwareID");

                entity.Property(e => e.JobHardwareStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobHardwareStatusID");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.PartHardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartHardwareID");

                entity.Property(e => e.PricePerUnit).HasPrecision(32, 2);

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobMaterial>(entity =>
            {
                entity.ToTable("job_material");

                entity.HasIndex(e => e.JobId, "fk_job_material_job");

                entity.HasIndex(e => e.MaterialId, "fk_job_material_material");

                entity.HasIndex(e => e.JobMaterialStatusId, "fk_job_material_type_job_material_status");

                entity.HasIndex(e => e.RawMaterialTypeId, "fk_type_raw_material_job_material_idx");

                entity.Property(e => e.JobMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobMaterialID");

                entity.Property(e => e.CertificationRequired)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Diameter).HasMaxLength(50);

                entity.Property(e => e.Height).HasMaxLength(50);

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.JobMaterialStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobMaterialStatusID");

                entity.Property(e => e.Length).HasMaxLength(50);

                entity.Property(e => e.MaterialDescription).HasMaxLength(2000);

                entity.Property(e => e.MaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MaterialID");

                entity.Property(e => e.PartMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartMaterialID");

                entity.Property(e => e.PricePerUnit).HasPrecision(32, 2);

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.QuantityReceived).HasColumnType("int(11)");

                entity.Property(e => e.RawMaterialTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RawMaterialTypeID");

                entity.Property(e => e.UnitCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Width).HasMaxLength(50);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobMaterials)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_material_job");

                entity.HasOne(d => d.JobMaterialStatus)
                    .WithMany(p => p.JobMaterials)
                    .HasForeignKey(d => d.JobMaterialStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_material_type_job_material_status");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.JobMaterials)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("fk_job_material_material");

                entity.HasOne(d => d.RawMaterialType)
                    .WithMany(p => p.JobMaterials)
                    .HasForeignKey(d => d.RawMaterialTypeId)
                    .HasConstraintName("fk_type_raw_material_job_material");
            });

            modelBuilder.Entity<JobMaterialBkp20200723>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("job_material_bkp_20200723");

                entity.Property(e => e.CertificationRequired)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Diameter).HasMaxLength(50);

                entity.Property(e => e.Height).HasMaxLength(50);

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.JobMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobMaterialID");

                entity.Property(e => e.JobMaterialStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobMaterialStatusID");

                entity.Property(e => e.Length).HasMaxLength(50);

                entity.Property(e => e.MaterialDescription).HasMaxLength(2000);

                entity.Property(e => e.MaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MaterialID");

                entity.Property(e => e.PartMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartMaterialID");

                entity.Property(e => e.PricePerUnit).HasPrecision(32, 2);

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.QuantityReceived).HasColumnType("int(11)");

                entity.Property(e => e.RawMaterialTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RawMaterialTypeID");

                entity.Property(e => e.UnitCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Width).HasMaxLength(50);
            });

            modelBuilder.Entity<JobPartBatch>(entity =>
            {
                entity.ToTable("job_part_batch");

                entity.Property(e => e.JobPartBatchId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedById).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobRoute>(entity =>
            {
                entity.ToTable("job_route");

                entity.HasIndex(e => e.JobId, "fk_job_route_job");

                entity.HasIndex(e => e.RouteId, "fk_job_route_route");

                entity.HasIndex(e => e.RouteTypeId, "fk_job_route_type_route");

                entity.Property(e => e.JobRouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobRouteID");

                entity.Property(e => e.CertificationRequired)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CycleTime).HasPrecision(32, 2);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.LeadTime).HasPrecision(32, 2);

                entity.Property(e => e.OperationalNotes).HasMaxLength(2000);

                entity.Property(e => e.OutsourceTime).HasPrecision(32, 2);

                entity.Property(e => e.OutsourceUnitCost).HasPrecision(32, 2);

                entity.Property(e => e.PartRouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartRouteID");

                entity.Property(e => e.PoquantityExtra)
                    .HasColumnType("int(11)")
                    .HasColumnName("POQuantityExtra");

                entity.Property(e => e.PoquantityTotal)
                    .HasColumnType("int(11)")
                    .HasColumnName("POQuantityTotal");

                entity.Property(e => e.RouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RouteID");

                entity.Property(e => e.RouteTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RouteTypeID");

                entity.Property(e => e.Sequence).HasColumnType("int(11)");

                entity.Property(e => e.SetupTime).HasPrecision(32, 2);

                entity.Property(e => e.UnitCount).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobRoutes)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_route_job");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.JobRoutes)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("fk_job_route_route");

                entity.HasOne(d => d.RouteType)
                    .WithMany(p => p.JobRoutes)
                    .HasForeignKey(d => d.RouteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_route_type_route");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("material");

                entity.HasIndex(e => e.RawMaterialTypeId, "fk_material_type_raw_material");

                entity.Property(e => e.MaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MaterialID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Diameter).HasMaxLength(50);

                entity.Property(e => e.Height).HasMaxLength(50);

                entity.Property(e => e.MaterialDescription)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Price).HasPrecision(32, 2);

                entity.Property(e => e.RawMaterialTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RawMaterialTypeID");

                entity.Property(e => e.UnitCount).HasColumnType("int(11)");

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(10);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Width).HasMaxLength(50);

                entity.HasOne(d => d.RawMaterialType)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.RawMaterialTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_material_type_raw_material");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.PrimaryCustomerShippingAddressId, "FK_Order_Address_idx");

                entity.HasIndex(e => e.PrimaryCustomerContactId, "FK_Order_Contact_idx");

                entity.HasIndex(e => e.OrderId, "OrderId_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.OrderStatusTypeId, "OrderStatusTypeID_idx");

                entity.HasIndex(e => e.PaymentTermsTypeId, "fk_TypePaymentTerms_Order");

                entity.HasIndex(e => e.CustomerId, "fk_order_customer");

                entity.HasIndex(e => e.ClonedFromQuoteId, "fk_quoteId");

                entity.Property(e => e.OrderId).HasColumnType("int(11)");

                entity.Property(e => e.ClonedFromQuoteId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(5000);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderStatusTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderStatusTypeID");

                entity.Property(e => e.OrderTotal).HasPrecision(32, 2);

                entity.Property(e => e.PaymentTermsTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PaymentTermsTypeID");

                entity.Property(e => e.PrimaryCustomerContactId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PrimaryCustomerContactID");

                entity.Property(e => e.PrimaryCustomerShippingAddressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PrimaryCustomerShippingAddressID");

                entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(25);

                entity.Property(e => e.QuoteNumber).HasMaxLength(45);

                entity.Property(e => e.SalesId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SalesID");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClonedFromQuote)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClonedFromQuoteId)
                    .HasConstraintName("fk_quoteId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk_order_customer");

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .HasConstraintName("FK_type_order_status_type_order");

                entity.HasOne(d => d.PaymentTermsType)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PaymentTermsTypeId)
                    .HasConstraintName("fk_TypePaymentTerms_Order");

                entity.HasOne(d => d.PrimaryCustomerContact)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PrimaryCustomerContactId)
                    .HasConstraintName("FK_Order_Contact");

                entity.HasOne(d => d.PrimaryCustomerShippingAddress)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PrimaryCustomerShippingAddressId)
                    .HasConstraintName("FK_Order_Address");
            });

            modelBuilder.Entity<PackingList>(entity =>
            {
                entity.ToTable("packing_list");

                entity.HasIndex(e => e.OrderId, "fk_packing_list_order");

                entity.HasIndex(e => e.PackingListStatusId, "fk_packing_list_type_packing_list_status");

                entity.Property(e => e.PackingListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PackingListID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(2000);

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.PackingListStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PackingListStatusID");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PackingLists)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_packing_list_order");

                entity.HasOne(d => d.PackingListStatus)
                    .WithMany(p => p.PackingLists)
                    .HasForeignKey(d => d.PackingListStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_packing_list_type_packing_list_status");
            });

            modelBuilder.Entity<PackingListJobPart>(entity =>
            {
                entity.HasKey(e => e.PackingListItemId)
                    .HasName("PRIMARY");

                entity.ToTable("packing_list_job_part");

                entity.HasIndex(e => e.PackingListId, "fk_packing_list_job_part_packing_list");

                entity.HasIndex(e => e.JobPartId, "fk_packing_list_job_part_xref_job_part");

                entity.Property(e => e.PackingListItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PackingListItemID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobPartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobPartID");

                entity.Property(e => e.PackedQty).HasColumnType("int(11)");

                entity.Property(e => e.PackingListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PackingListID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.JobPart)
                    .WithMany(p => p.PackingListJobParts)
                    .HasForeignKey(d => d.JobPartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_packing_list_job_part_xref_job_part");

                entity.HasOne(d => d.PackingList)
                    .WithMany(p => p.PackingListJobParts)
                    .HasForeignKey(d => d.PackingListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_packing_list_job_part_packing_list");
            });

            modelBuilder.Entity<PackingListJobPartBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("packing_list_job_part_bkp");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobPartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobPartID");

                entity.Property(e => e.PackedQty).HasColumnType("int(11)");

                entity.Property(e => e.PackingListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PackingListID");

                entity.Property(e => e.PackingListItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PackingListItemID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.ToTable("part");

                entity.HasIndex(e => e.PartNumber, "PartNumber_Idx")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => new { e.PartNumber, e.Revision }, "UNIQUE_part_PartNumber_Revision")
                    .IsUnique();

                entity.HasIndex(e => e.PartTypeId, "fk_TypePart_Part");

                entity.HasIndex(e => e.FixtureLocationId, "fk_part_fixture_bin");

                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartID");

                entity.Property(e => e.CalculatedPrice).HasPrecision(32, 2);

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Features).HasColumnType("int(11)");

                entity.Property(e => e.FixtureLocationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FixtureLocationID");

                entity.Property(e => e.HighRezImage).HasMaxLength(150);

                entity.Property(e => e.LowRezImage).HasMaxLength(150);

                entity.Property(e => e.Note).HasMaxLength(5000);

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.PartTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartTypeID")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuotePrice).HasPrecision(32, 2);

                entity.Property(e => e.Revision)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Setups).HasColumnType("int(11)");

                entity.Property(e => e.TightTolerances).HasColumnType("int(11)");

                entity.Property(e => e.UnitPrice).HasPrecision(32, 2);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FixtureLocation)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.FixtureLocationId)
                    .HasConstraintName("fk_part_fixture_bin");

                entity.HasOne(d => d.PartType)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.PartTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TypePart_Part");
            });

            modelBuilder.Entity<PartHardware>(entity =>
            {
                entity.ToTable("part_hardware");

                entity.HasIndex(e => e.HardwareId, "fk_part_hardware_hardware");

                entity.HasIndex(e => e.PartId, "fk_part_hardware_part");

                entity.Property(e => e.PartHardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartHardwareID");

                entity.Property(e => e.CertificationRequired)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.CostEstimate).HasPrecision(32, 2);

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("HardwareID");

                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartID");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Hardware)
                    .WithMany(p => p.PartHardwares)
                    .HasForeignKey(d => d.HardwareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_part_hardware_hardware");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.PartHardwares)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_part_hardware_part");
            });

            modelBuilder.Entity<PartHardwareQuoteEstimate>(entity =>
            {
                entity.ToTable("part_hardware_quote_estimate");

                entity.HasIndex(e => e.PartHardwareId, "fk_PartHardware_PartHardwareQuoteEstimate");

                entity.HasIndex(e => e.QuoteId, "fk_Quote_PartHardwareQuoteEstimate");

                entity.Property(e => e.PartHardwareQuoteEstimateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartHardwareQuoteEstimateID");

                entity.Property(e => e.CostEstimate).HasPrecision(32, 2);

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PartHardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartHardwareID");

                entity.Property(e => e.QuoteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("QuoteID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PartHardware)
                    .WithMany(p => p.PartHardwareQuoteEstimates)
                    .HasForeignKey(d => d.PartHardwareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PartHardware_PartHardwareQuoteEstimate");

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.PartHardwareQuoteEstimates)
                    .HasForeignKey(d => d.QuoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Quote_PartHardwareQuoteEstimate");
            });

            modelBuilder.Entity<PartMaterialQuoteEstimate>(entity =>
            {
                entity.ToTable("part_material_quote_estimate");

                entity.HasIndex(e => e.QuoteId, "fk_Quote_PartMaterialQuoteEstimate");

                entity.HasIndex(e => new { e.PartId, e.MaterialId }, "fk_XrefPartMaterial_PartHardwareQuoteEstimate");

                entity.HasIndex(e => e.PartMaterialId, "fk_XrefPartMaterial_PartMaterialQuoteEstimate_idx");

                entity.Property(e => e.PartMaterialQuoteEstimateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartMaterialQuoteEstimateID");

                entity.Property(e => e.CostEstimate).HasPrecision(32, 2);

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MaterialID");

                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartID");

                entity.Property(e => e.PartMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartMaterialID");

                entity.Property(e => e.QuoteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("QuoteID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PartMaterial)
                    .WithMany(p => p.PartMaterialQuoteEstimates)
                    .HasForeignKey(d => d.PartMaterialId)
                    .HasConstraintName("fk_XrefPartMaterial_PartMaterialQuoteEstimate");

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.PartMaterialQuoteEstimates)
                    .HasForeignKey(d => d.QuoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Quote_PartMaterialQuoteEstimate");
            });

            modelBuilder.Entity<PartRoute>(entity =>
            {
                entity.ToTable("part_route");

                entity.HasIndex(e => e.PartId, "fk_part_route_part");

                entity.HasIndex(e => e.RouteId, "fk_part_route_route");

                entity.HasIndex(e => e.RouteTypeId, "fk_part_route_type_route");

                entity.Property(e => e.PartRouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartRouteID");

                entity.Property(e => e.CertificationRequired)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CycleTime).HasPrecision(32, 2);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.LeadTime).HasPrecision(32, 2);

                entity.Property(e => e.OperationalNotes).HasMaxLength(2000);

                entity.Property(e => e.OutsourceTime).HasPrecision(32, 2);

                entity.Property(e => e.OutsourceUnitCost).HasPrecision(32, 2);

                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartID");

                entity.Property(e => e.RouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RouteID");

                entity.Property(e => e.RouteTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RouteTypeID");

                entity.Property(e => e.Sequence).HasColumnType("int(11)");

                entity.Property(e => e.SetupTime).HasPrecision(32, 2);

                entity.Property(e => e.UnitCount).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.PartRoutes)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_part_route_part");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.PartRoutes)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_part_route_route");

                entity.HasOne(d => d.RouteType)
                    .WithMany(p => p.PartRoutes)
                    .HasForeignKey(d => d.RouteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_part_route_type_route");
            });

            modelBuilder.Entity<PartRouteCostEstimateBracket>(entity =>
            {
                entity.ToTable("part_route_cost_estimate_bracket");

                entity.HasIndex(e => e.PartRouteId, "fk_PartRoute_PartRouteCostBracket");

                entity.HasIndex(e => e.QuoteId, "fk_Quote_PartRouteCostBracket");

                entity.Property(e => e.PartRouteCostEstimateBracketId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartRouteCostEstimateBracketID");

                entity.Property(e => e.CostEstimate).HasPrecision(32, 2);

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LotPricing)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.MaxQuantity).HasColumnType("int(11)");

                entity.Property(e => e.PartRouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartRouteID");

                entity.Property(e => e.QuoteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("QuoteID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PartRoute)
                    .WithMany(p => p.PartRouteCostEstimateBrackets)
                    .HasForeignKey(d => d.PartRouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PartRoute_PartRouteCostBracket");

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.PartRouteCostEstimateBrackets)
                    .HasForeignKey(d => d.QuoteId)
                    .HasConstraintName("fk_Quote_PartRouteCostBracket");
            });

            modelBuilder.Entity<PayPeriod>(entity =>
            {
                entity.ToTable("pay_period");

                entity.HasIndex(e => e.PayPeriodStatusId, "fk_pay_period_type_pay_period_status");

                entity.Property(e => e.PayPeriodId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PayPeriodID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.PayPeriodStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PayPeriodStatusID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.HasOne(d => d.PayPeriodStatus)
                    .WithMany(p => p.PayPeriods)
                    .HasForeignKey(d => d.PayPeriodStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pay_period_pay_period_status");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.ToTable("purchase_order");

                entity.HasIndex(e => e.AddressId, "fk_purchase_order_address");

                entity.HasIndex(e => e.ContactId, "fk_purchase_order_contact");

                entity.HasIndex(e => e.PaymentTermsTypeId, "fk_purchase_order_type_payment_terms");

                entity.HasIndex(e => e.PurchaseOrderTypeId, "fk_purchase_order_type_purchase_order");

                entity.HasIndex(e => e.PurchaseOrderStatusId, "fk_purchase_order_type_purchase_order_status");

                entity.HasIndex(e => e.ShippingCodeTypeId, "fk_purchase_order_type_shipping_code");

                entity.HasIndex(e => e.VendorId, "fk_purchase_order_vendor");

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PurchaseOrderID");

                entity.Property(e => e.AddressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AddressID");

                entity.Property(e => e.CityUseTax).HasColumnType("bit(1)");

                entity.Property(e => e.ContactId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContactID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedArrivalDate).HasColumnType("date");

                entity.Property(e => e.Notes).HasMaxLength(2000);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.PaymentTermsTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PaymentTermsTypeID");

                entity.Property(e => e.PurchaseOrderStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PurchaseOrderStatusID");

                entity.Property(e => e.PurchaseOrderTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PurchaseOrderTypeID");

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.SalesTaxCodeTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SalesTaxCodeTypeID");

                entity.Property(e => e.ShippingCodeTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ShippingCodeTypeID");

                entity.Property(e => e.ShippingCost).HasPrecision(32, 2);

                entity.Property(e => e.SubTotal).HasPrecision(32, 2);

                entity.Property(e => e.TaxAmount).HasPrecision(32, 2);

                entity.Property(e => e.TotalCost).HasPrecision(32, 2);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VendorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VendorID");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("fk_purchase_order_address");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("fk_purchase_order_contact");

                entity.HasOne(d => d.PaymentTermsType)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.PaymentTermsTypeId)
                    .HasConstraintName("fk_purchase_order_type_payment_terms");

                entity.HasOne(d => d.PurchaseOrderStatus)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.PurchaseOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_purchase_order_type_purchase_order_status");

                entity.HasOne(d => d.PurchaseOrderType)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.PurchaseOrderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_purchase_order_type_purchase_order");

                entity.HasOne(d => d.ShippingCodeType)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.ShippingCodeTypeId)
                    .HasConstraintName("fk_purchase_order_type_shipping_code");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("fk_purchase_order_vendor");
            });

            modelBuilder.Entity<PurchaseOrderItem>(entity =>
            {
                entity.ToTable("purchase_order_item");

                entity.HasIndex(e => e.PurchaseOrderId, "fk_purchase_order_item_purchase_order");

                entity.Property(e => e.PurchaseOrderItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PurchaseOrderItemID");

                entity.Property(e => e.CertificationRequired)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ExtendedPrice).HasPrecision(32, 2);

                entity.Property(e => e.Extra).HasColumnType("int(11)");

                entity.Property(e => e.HasCityUseTax).HasColumnType("bit(1)");

                entity.Property(e => e.LineItemNumber).HasColumnType("int(11)");

                entity.Property(e => e.MinimumJobDueDate).HasColumnType("datetime");

                entity.Property(e => e.OrderTotal).HasColumnType("int(11)");

                entity.Property(e => e.PackageQuantity).HasColumnType("int(11)");

                entity.Property(e => e.PartNumber).HasMaxLength(255);

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PurchaseOrderID");

                entity.Property(e => e.PurchaseQuantity).HasColumnType("int(11)");

                entity.Property(e => e.PurchaseSlug)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.PurchaseUom)
                    .HasMaxLength(100)
                    .HasColumnName("PurchaseUOM");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.UnitPrice).HasPrecision(32, 2);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderItems)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_purchase_order_item_purchase_order");
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.ToTable("quote");

                entity.HasIndex(e => e.PaymentTermsTypeId, "fk_TypePaymentTerms_Quote");

                entity.HasIndex(e => e.QuoteStatusId, "fk_TypeQuoteStatus_Quote");

                entity.HasIndex(e => e.PrimaryCustomerShippingAddressId, "fk_address_quote");

                entity.HasIndex(e => e.PrimaryCustomerContactId, "fk_contact_quote");

                entity.HasIndex(e => e.CustomerId, "fk_customer_quote");

                entity.HasIndex(e => e.SalesContactUserId, "fk_user_quote1");

                entity.Property(e => e.QuoteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("QuoteID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(2000);

                entity.Property(e => e.PaymentTermsTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PaymentTermsTypeID");

                entity.Property(e => e.PrimaryCustomerContactId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PrimaryCustomerContactID");

                entity.Property(e => e.PrimaryCustomerShippingAddressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PrimaryCustomerShippingAddressID");

                entity.Property(e => e.QuoteDate).HasColumnType("datetime");

                entity.Property(e => e.QuoteNumber)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.QuoteStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("QuoteStatusID")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuotedByUserId)
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Rfqnumber)
                    .HasMaxLength(44)
                    .HasColumnName("RFQNumber");

                entity.Property(e => e.SalesContactUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SalesContactUserID");

                entity.Property(e => e.Total).HasPrecision(32, 2);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk_customer_quote");

                entity.HasOne(d => d.PaymentTermsType)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.PaymentTermsTypeId)
                    .HasConstraintName("fk_TypePaymentTerms_Quote");

                entity.HasOne(d => d.PrimaryCustomerContact)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.PrimaryCustomerContactId)
                    .HasConstraintName("fk_contact_quote");

                entity.HasOne(d => d.PrimaryCustomerShippingAddress)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.PrimaryCustomerShippingAddressId)
                    .HasConstraintName("fk_address_quote");

                entity.HasOne(d => d.QuoteStatus)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.QuoteStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TypeQuoteStatus_Quote");

                entity.HasOne(d => d.SalesContactUser)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.SalesContactUserId)
                    .HasConstraintName("fk_user_quote1");
            });

            modelBuilder.Entity<RawMaterial>(entity =>
            {
                entity.ToTable("raw_material");

                entity.HasIndex(e => e.RawMaterialName, "raw_material_RawMaterialName_unique")
                    .IsUnique();

                entity.Property(e => e.RawMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RawMaterialID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RawMaterialName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Receiver>(entity =>
            {
                entity.ToTable("receiver");

                entity.Property(e => e.ReceiverId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReceiverID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReceiverItem>(entity =>
            {
                entity.ToTable("receiver_item");

                entity.HasIndex(e => e.JobHardwareId, "fk_receiver_item_job_hardware");

                entity.HasIndex(e => e.JobMaterialId, "fk_receiver_item_job_material");

                entity.HasIndex(e => e.JobRouteId, "fk_receiver_item_job_route");

                entity.HasIndex(e => e.PurchaseOrderItemId, "fk_receiver_item_purchase_order_item");

                entity.HasIndex(e => e.ReceiverId, "fk_receiver_item_receiver");

                entity.Property(e => e.ReceiverItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReceiverItemID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobHardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobHardwareID");

                entity.Property(e => e.JobMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobMaterialID");

                entity.Property(e => e.JobRouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobRouteID");

                entity.Property(e => e.PurchaseOrderItemId)
                    .HasColumnType("int(1)")
                    .HasColumnName("PurchaseOrderItemID");

                entity.Property(e => e.ReceivedQty).HasColumnType("int(11)");

                entity.Property(e => e.ReceiverId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReceiverID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.JobHardware)
                    .WithMany(p => p.ReceiverItems)
                    .HasForeignKey(d => d.JobHardwareId)
                    .HasConstraintName("fk_receiver_item_job_hardware");

                entity.HasOne(d => d.JobMaterial)
                    .WithMany(p => p.ReceiverItems)
                    .HasForeignKey(d => d.JobMaterialId)
                    .HasConstraintName("fk_receiver_item_job_material");

                entity.HasOne(d => d.JobRoute)
                    .WithMany(p => p.ReceiverItems)
                    .HasForeignKey(d => d.JobRouteId)
                    .HasConstraintName("fk_receiver_item_job_route");

                entity.HasOne(d => d.PurchaseOrderItem)
                    .WithMany(p => p.ReceiverItems)
                    .HasForeignKey(d => d.PurchaseOrderItemId)
                    .HasConstraintName("fk_receiver_item_purchase_order_item");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.ReceiverItems)
                    .HasForeignKey(d => d.ReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_receiver_item_receiver");
            });

            modelBuilder.Entity<Rma>(entity =>
            {
                entity.ToTable("rma");

                entity.HasIndex(e => e.RmaId, "fk_order_rma_ix");

                entity.HasIndex(e => e.RmaStatusTypeId, "fk_type_rma_status_rma_ix");

                entity.Property(e => e.RmaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RmaID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderID");

                entity.Property(e => e.RmaStatusTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RmaStatusTypeID")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.RmaStatusType)
                    .WithMany(p => p.Rmas)
                    .HasForeignKey(d => d.RmaStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_type_rma_status_rma");
            });

            modelBuilder.Entity<RmaJobNote>(entity =>
            {
                entity.ToTable("rma_job_note");

                entity.HasIndex(e => e.RmaJobId, "fk_rma_ix");

                entity.HasIndex(e => e.RmaJobNoteTypeId, "fk_type_rma_job_note_ix");

                entity.Property(e => e.RmaJobNoteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RmaJobNoteID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.RmaJobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RmaJobID");

                entity.Property(e => e.RmaJobNoteTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RmaJobNoteTypeID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.RmaJob)
                    .WithMany(p => p.RmaJobNotes)
                    .HasForeignKey(d => d.RmaJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rma_Job");

                entity.HasOne(d => d.RmaJobNoteType)
                    .WithMany(p => p.RmaJobNotes)
                    .HasForeignKey(d => d.RmaJobNoteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Type_Rma_Job_Note");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.HasIndex(e => e.Name, "role_Name_unique")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasColumnType("int(11)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.StartPage)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'Orders'");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("route");

                entity.HasIndex(e => e.RouteTypeId, "fk_route_type_route");

                entity.HasIndex(e => e.RouteCategoryId, "fk_route_type_route_category");

                entity.Property(e => e.RouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RouteID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CycleTime).HasPrecision(32, 2);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.LeadTime).HasPrecision(32, 2);

                entity.Property(e => e.OperationalNotes).HasMaxLength(2000);

                entity.Property(e => e.OutsourceTime).HasPrecision(32, 2);

                entity.Property(e => e.OutsourceUnitCost).HasPrecision(32, 2);

                entity.Property(e => e.RouteCategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RouteCategoryID");

                entity.Property(e => e.RouteName).HasMaxLength(2000);

                entity.Property(e => e.RouteTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RouteTypeID");

                entity.Property(e => e.SetupTime).HasPrecision(32, 2);

                entity.Property(e => e.UnitCount).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.RouteCategory)
                    .WithMany(p => p.Routes)
                    .HasForeignKey(d => d.RouteCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_route_type_route_category");

                entity.HasOne(d => d.RouteType)
                    .WithMany(p => p.Routes)
                    .HasForeignKey(d => d.RouteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_route_type_route");
            });

            modelBuilder.Entity<TimeEntry>(entity =>
            {
                entity.ToTable("time_entry");

                entity.HasIndex(e => e.JobId, "fk_time_entry_job");

                entity.HasIndex(e => e.PayPeriodId, "fk_time_entry_pay_period");

                entity.HasIndex(e => e.TimeEntryTypeId, "fk_time_entry_time_entry_type");

                entity.HasIndex(e => e.UserId, "fk_time_entry_user");

                entity.Property(e => e.TimeEntryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TimeEntryID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.PayPeriodId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PayPeriodID");

                entity.Property(e => e.TimeEntryTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TimeEntryTypeID");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeInMinutes).HasPrecision(32, 2);

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("UserID");

                entity.Property(e => e.Violation)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.TimeEntries)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("fk_time_entry_job");

                entity.HasOne(d => d.PayPeriod)
                    .WithMany(p => p.TimeEntries)
                    .HasForeignKey(d => d.PayPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_time_entry_pay_period");

                entity.HasOne(d => d.TimeEntryType)
                    .WithMany(p => p.TimeEntries)
                    .HasForeignKey(d => d.TimeEntryTypeId)
                    .HasConstraintName("fk_time_entry_time_entry_type");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TimeEntries)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_time_entry_user");
            });

            modelBuilder.Entity<TimeEntryLog>(entity =>
            {
                entity.ToTable("time_entry_log");

                entity.HasIndex(e => e.JobId, "fk_time_entry_log_job");

                entity.HasIndex(e => e.JobFunctionId, "fk_time_entry_log_job_function");

                entity.HasIndex(e => e.PayPeriodId, "fk_time_entry_log_pay_period");

                entity.HasIndex(e => e.UserId, "fk_time_entry_log_user");

                entity.Property(e => e.TimeEntryLogId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TimeEntryLogID");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionTaken)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.JobFunctionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobFunctionID");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.PayPeriodId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PayPeriodID");

                entity.Property(e => e.TimeEntryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TimeEntryID");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeInMinutes).HasColumnType("int(11)");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("UserID");

                entity.HasOne(d => d.JobFunction)
                    .WithMany(p => p.TimeEntryLogs)
                    .HasForeignKey(d => d.JobFunctionId)
                    .HasConstraintName("fk_time_entry_log_job_function");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.TimeEntryLogs)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("fk_time_entry_log_job");

                entity.HasOne(d => d.PayPeriod)
                    .WithMany(p => p.TimeEntryLogs)
                    .HasForeignKey(d => d.PayPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_time_entry_log_pay_period");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TimeEntryLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_time_entry_log_user");
            });

            modelBuilder.Entity<Timesheet>(entity =>
            {
                entity.ToTable("timesheet");

                entity.HasIndex(e => e.PayPeriodId, "fk_timesheet_pay_period");

                entity.HasIndex(e => e.UserId, "fk_timesheet_user");

                entity.Property(e => e.TimesheetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TimesheetID");

                entity.Property(e => e.EndDay).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HolidayHours).HasPrecision(32, 2);

                entity.Property(e => e.IsFullTimeEmployee).HasColumnType("int(11)");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.OverTimeHours).HasPrecision(32, 2);

                entity.Property(e => e.PayPeriodId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PayPeriodID");

                entity.Property(e => e.RegularHours).HasPrecision(32, 2);

                entity.Property(e => e.StartDay).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("UserID");

                entity.Property(e => e.VacationHours).HasPrecision(32, 2);

                entity.HasOne(d => d.PayPeriod)
                    .WithMany(p => p.Timesheets)
                    .HasForeignKey(d => d.PayPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_timesheet_pay_period");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Timesheets)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_timesheet_user");
            });

            modelBuilder.Entity<TypeAccountingSystemSynchEvent>(entity =>
            {
                entity.HasKey(e => e.AccountingSystemSynchEventTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_accounting_system_synch_event");

                entity.HasIndex(e => e.AccountingSystemSynchEventTypeId, "AccountingSystemSynchEventTypeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_accounting_system_synch_event_Value_unique")
                    .IsUnique();

                entity.Property(e => e.AccountingSystemSynchEventTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AccountingSystemSynchEventTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeAddress>(entity =>
            {
                entity.HasKey(e => e.AddressTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_address");

                entity.HasIndex(e => e.AddressTypeId, "AddressTypeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayOrder, "DisplayValue_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_address_Value_unique")
                    .IsUnique();

                entity.Property(e => e.AddressTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AddressTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeAllowableJobPartStatus>(entity =>
            {
                entity.HasKey(e => new { e.JobPartStatusId, e.AllowableJobPartStatusId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("type_allowable_job_part_status");

                entity.Property(e => e.JobPartStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobPartStatusID");

                entity.Property(e => e.AllowableJobPartStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AllowableJobPartStatusID");

                entity.HasOne(d => d.JobPartStatus)
                    .WithMany(p => p.TypeAllowableJobPartStatuses)
                    .HasForeignKey(d => d.JobPartStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_type_job_part_status_type_allowable_job_part_status");
            });

            modelBuilder.Entity<TypeBin>(entity =>
            {
                entity.HasKey(e => e.BinTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_bin");

                entity.HasIndex(e => e.Value, "UniqueBinValue")
                    .IsUnique();

                entity.Property(e => e.BinTypeId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("BinTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeCell>(entity =>
            {
                entity.HasKey(e => e.CellTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_cell");

                entity.HasIndex(e => e.Value, "tyep_cell_value_unique")
                    .IsUnique();

                entity.Property(e => e.CellTypeId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("CellTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue).HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeContact>(entity =>
            {
                entity.HasKey(e => e.ContactTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_contact");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_contact_Value_unique")
                    .IsUnique();

                entity.Property(e => e.ContactTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContactTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_customer");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "Value")
                    .IsUnique();

                entity.Property(e => e.CustomerTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeCustomerInvoiceStatus>(entity =>
            {
                entity.HasKey(e => e.CustomerInvoiceStatusTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_customer_invoice_status");

                entity.HasIndex(e => e.CustomerInvoiceStatusTypeId, "CustomerInvoiceStatusTypeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_customer_invoice_status_Value_unique")
                    .IsUnique();

                entity.Property(e => e.CustomerInvoiceStatusTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerInvoiceStatusTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeCustomerInvoiceTax>(entity =>
            {
                entity.HasKey(e => e.CustomerInvoiceTaxTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_customer_invoice_tax");

                entity.HasIndex(e => e.Value, "type_customer_invoice_tax_Value_unique")
                    .IsUnique();

                entity.Property(e => e.CustomerInvoiceTaxTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerInvoiceTaxTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeCustomerShipmentStatus>(entity =>
            {
                entity.HasKey(e => e.CustomerShipmentStatusTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_customer_shipment_status");

                entity.HasIndex(e => e.CustomerShipmentStatusTypeId, "CustomerShipmentStatusTypeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_customer_shipment_status_Value_unique")
                    .IsUnique();

                entity.Property(e => e.CustomerShipmentStatusTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerShipmentStatusTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeCustomerTax>(entity =>
            {
                entity.HasKey(e => e.CustomerTaxTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_customer_tax");

                entity.HasIndex(e => e.TaxCode, "Code_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.CustomerTaxTypeId, "CustomerTaxTypeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CustomerTaxTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerTaxTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.TaxCode)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.TaxPercentage).HasPrecision(32, 2);
            });

            modelBuilder.Entity<TypeJobHardwareStatus>(entity =>
            {
                entity.HasKey(e => e.JobHardwareStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("type_job_hardware_status");

                entity.HasIndex(e => e.JobHardwareStatusId, "JobHardwareStatusID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.JobHardwareStatus, "type_job_hardware_status_JobHardwareStatus_unique")
                    .IsUnique();

                entity.Property(e => e.JobHardwareStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobHardwareStatusID");

                entity.Property(e => e.JobHardwareStatus)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeJobMaterialStatus>(entity =>
            {
                entity.HasKey(e => e.JobMaterialStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("type_job_material_status");

                entity.HasIndex(e => e.JobMaterialStatusId, "JobMaterialStatusID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.JobMaterialStatus, "JobMaterialStatus_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.JobMaterialStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobMaterialStatusID");

                entity.Property(e => e.JobMaterialStatus)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeJobPartStatus>(entity =>
            {
                entity.HasKey(e => e.JobPartStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("type_job_part_status");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.JobPartStatusId, "JobPartStatusID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.JobPartStatusValue, "JobPartStatusValue_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.JobPartStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobPartStatusID");

                entity.Property(e => e.CanAssignCell)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.CanBeBatched)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue).HasMaxLength(50);

                entity.Property(e => e.IsCompletedStatus)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.JobPartStatusValue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeJobStatus>(entity =>
            {
                entity.HasKey(e => e.JobStatusTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_job_status");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.JobStatusTypeId, "JobStatusTypeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_job_status_Value_unique")
                    .IsUnique();

                entity.Property(e => e.JobStatusTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobStatusTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeMaterial>(entity =>
            {
                entity.HasKey(e => e.MaterialTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_material");

                entity.HasIndex(e => e.DisplayOrder, "type_material_DisplayOrder_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_material_Value_unique")
                    .IsUnique();

                entity.Property(e => e.MaterialTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MaterialTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeOrderStatus>(entity =>
            {
                entity.HasKey(e => e.OrderStatusTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_order_status");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.OrderStatusTypeId, "OrderStstusTypeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_order_status_Value_unique")
                    .IsUnique();

                entity.Property(e => e.OrderStatusTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrderStatusTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypePackingListStatus>(entity =>
            {
                entity.HasKey(e => e.PackingListStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("type_packing_list_status");

                entity.HasIndex(e => e.DisplayOrder, "type_packing_list_status_DisplayOrder_unique")
                    .IsUnique();

                entity.HasIndex(e => e.StatusValue, "type_packing_list_status_StatusValue_unique")
                    .IsUnique();

                entity.Property(e => e.PackingListStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PackingListStatusID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.StatusDisplayName).HasMaxLength(50);

                entity.Property(e => e.StatusValue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypePart>(entity =>
            {
                entity.HasKey(e => e.PartTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_part");

                entity.Property(e => e.PartTypeId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("PartTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue).HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypePayPeriodStatus>(entity =>
            {
                entity.HasKey(e => e.PayPeriodStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("type_pay_period_status");

                entity.HasIndex(e => e.PayPeriodStatusName, "type_pay_period_status_PayPeriodStatusName_unique")
                    .IsUnique();

                entity.Property(e => e.PayPeriodStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PayPeriodStatusID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.PayPeriodStatusName).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");
            });

            modelBuilder.Entity<TypePaymentTerm>(entity =>
            {
                entity.HasKey(e => e.PaymentTermsTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_payment_terms");

                entity.HasIndex(e => e.PaymentTermsTypeId, "CustomerPaymentTermsTypeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_payment_terms_Value_unique")
                    .IsUnique();

                entity.Property(e => e.PaymentTermsTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PaymentTermsTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypePurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_purchase_order");

                entity.HasIndex(e => e.DisplayOrder, "type_purchase_order_DisplayOrder_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_purchase_order_Value_unique")
                    .IsUnique();

                entity.Property(e => e.PurchaseOrderTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PurchaseOrderTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypePurchaseOrderStatus>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("type_purchase_order_status");

                entity.HasIndex(e => e.DisplayOrder, "type_purchase_order_status_DisplayOrder_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_purchase_order_status_Value_unique")
                    .IsUnique();

                entity.Property(e => e.PurchaseOrderStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PurchaseOrderStatusID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeQuoteStatus>(entity =>
            {
                entity.HasKey(e => e.QuoteStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("type_quote_status");

                entity.Property(e => e.QuoteStatusId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("QuoteStatusID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue).HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeRawMaterial>(entity =>
            {
                entity.HasKey(e => e.RawMaterialTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_raw_material");

                entity.HasIndex(e => e.RawMaterialId, "fk_raw_material");

                entity.HasIndex(e => e.RawMaterialDetail, "type_raw_material_RawMaterialDetail_unique")
                    .IsUnique();

                entity.Property(e => e.RawMaterialTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RawMaterialTypeID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RawMaterialDetail).IsRequired();

                entity.Property(e => e.RawMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RawMaterialID");

                entity.Property(e => e.RawMaterialTypeDescription)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.RawMaterial)
                    .WithMany(p => p.TypeRawMaterials)
                    .HasForeignKey(d => d.RawMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_raw_material");
            });

            modelBuilder.Entity<TypeRejectionReason>(entity =>
            {
                entity.HasKey(e => e.RejectionReasonId)
                    .HasName("PRIMARY");

                entity.ToTable("type_rejection_reason");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "Value")
                    .IsUnique();

                entity.Property(e => e.RejectionReasonId).HasColumnType("int(11)");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeRmaJob>(entity =>
            {
                entity.HasKey(e => e.RmaJobTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_rma_job");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue")
                    .IsUnique();

                entity.HasIndex(e => e.RmaJobTypeId, "RmaJobTypeID")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "Value")
                    .IsUnique();

                entity.Property(e => e.RmaJobTypeId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("RmaJobTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeRmaJobNote>(entity =>
            {
                entity.HasKey(e => e.RmaJobNoteTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_rma_job_note");

                entity.Property(e => e.RmaJobNoteTypeId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("RmaJobNoteTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeRmaStatus>(entity =>
            {
                entity.HasKey(e => e.RmaStatusTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_rma_status");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.RmaStatusTypeId, "RmaStatusTypeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_rma_status_Value_unique")
                    .IsUnique();

                entity.Property(e => e.RmaStatusTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RmaStatusTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeRoute>(entity =>
            {
                entity.HasKey(e => e.RouteTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_route");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.RouteTypeId, "RouteTypeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_route_Value_unique")
                    .IsUnique();

                entity.Property(e => e.RouteTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RouteTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeRouteCategory>(entity =>
            {
                entity.HasKey(e => e.RouteCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("type_route_category");

                entity.Property(e => e.RouteCategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RouteCategoryID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RouteCategoryDescription).HasMaxLength(2000);

                entity.Property(e => e.RouteCategoryName).HasMaxLength(255);

                entity.Property(e => e.RouteTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RouteTypeID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TypeSalesTaxCode>(entity =>
            {
                entity.HasKey(e => e.SalesTaxCodeTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_sales_tax_code");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_sales_tax_code_Value_unique")
                    .IsUnique();

                entity.Property(e => e.SalesTaxCodeTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SalesTaxCodeTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeShippingCode>(entity =>
            {
                entity.HasKey(e => e.ShippingCodeTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_shipping_code");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_shipping_code_Value_unique")
                    .IsUnique();

                entity.Property(e => e.ShippingCodeTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ShippingCodeTypeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeTimeEntry>(entity =>
            {
                entity.HasKey(e => e.TimeEntryTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_time_entry");

                entity.HasIndex(e => e.TimeEntryTypeName, "time_entry_type_TimeEntryTypeName_unique")
                    .IsUnique();

                entity.Property(e => e.TimeEntryTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TimeEntryTypeID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.TimeEntryTypeDescription).HasMaxLength(8000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");
            });

            modelBuilder.Entity<TypeUserShift>(entity =>
            {
                entity.HasKey(e => e.ShiftId)
                    .HasName("PRIMARY");

                entity.ToTable("type_user_shift");

                entity.Property(e => e.ShiftId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ShiftID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue).HasMaxLength(50);

                entity.Property(e => e.ShiftValue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeUserStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PRIMARY");

                entity.ToTable("type_user_status");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue).HasMaxLength(50);

                entity.Property(e => e.StatusValue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeVendorAccountCode>(entity =>
            {
                entity.HasKey(e => e.AccountCodeId)
                    .HasName("PRIMARY");

                entity.ToTable("type_vendor_account_code");

                entity.HasIndex(e => e.DisplayOrder, "DisplayOrder_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DisplayValue, "DisplayValue_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.AccountCodeId, "VendorAccountCodeID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_vendor_account_code_Value_unique")
                    .IsUnique();

                entity.Property(e => e.AccountCodeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AccountCodeID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<TypeVendorInvoiceStatus>(entity =>
            {
                entity.HasKey(e => e.VendorInvoiceStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("type_vendor_invoice_status");

                entity.HasIndex(e => e.DisplayOrder, "type_vendor_invoice_status_DisplayOrder_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Value, "type_vendor_invoice_status_Value_unique")
                    .IsUnique();

                entity.Property(e => e.VendorInvoiceStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VendorInvoiceStatusID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeVendorStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PRIMARY");

                entity.ToTable("type_vendor_status");

                entity.HasIndex(e => e.StatusValue, "type_vendor_status_Value_unique")
                    .IsUnique();

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.DisplayValue).HasMaxLength(50);

                entity.Property(e => e.StatusValue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.CellId, "fk_cell_user_ix");

                entity.HasIndex(e => e.ShiftId, "fk_shift_user");

                entity.HasIndex(e => e.Email, "user_email_unique")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "user_username_unique")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnType("int(1)")
                    .HasColumnName("CellID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EmployeeNumber).HasColumnType("int(11)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.IsFullTimeEmployee).HasColumnType("bit(1)");

                entity.Property(e => e.IsHourly).HasColumnType("int(1)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ScheduleId)
                    .HasColumnType("int(1)")
                    .HasColumnName("ScheduleID");

                entity.Property(e => e.ShiftId)
                    .HasColumnType("int(1)")
                    .HasColumnName("ShiftID");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(1)")
                    .HasColumnName("StatusID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VacationHours).HasColumnType("int(2)");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("fk_cell_user");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_shift_user");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("vendor");

                entity.HasIndex(e => e.PaymentTermsTypeId, "FK_Vendor_PaymentTerms_idx");

                entity.HasIndex(e => e.AccountCodeId, "fk_vendor_type_account_code_idx");

                entity.HasIndex(e => e.ShippingCodeTypeId, "fk_vendor_type_shipping_code");

                entity.HasIndex(e => e.StatusId, "fk_vendor_type_status");

                entity.Property(e => e.VendorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VendorID");

                entity.Property(e => e.AccountCodeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AccountCodeID");

                entity.Property(e => e.CommentsAbout).HasColumnType("varchar(50000)");

                entity.Property(e => e.CommentsTo).HasMaxLength(5000);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Notes).HasMaxLength(5000);

                entity.Property(e => e.PaymentTermsTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PaymentTermsTypeID");

                entity.Property(e => e.ShippingCodeTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ShippingCodeTypeID");

                entity.Property(e => e.StatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatusID");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AccountCode)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.AccountCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vendor_type_account_code");

                entity.HasOne(d => d.PaymentTermsType)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.PaymentTermsTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vendor_PaymentTermsType");

                entity.HasOne(d => d.ShippingCodeType)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.ShippingCodeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vendor_type_shipping_code");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vendor_type_status");
            });

            modelBuilder.Entity<VendorInvoice>(entity =>
            {
                entity.ToTable("vendor_invoice");

                entity.HasIndex(e => e.PaymentTermsTypeId, "fk_vendor_invoice_type_payment_terms");

                entity.HasIndex(e => e.VendorInvoiceStatusId, "fk_vendor_invoice_type_vendor_invoice_status");

                entity.Property(e => e.VendorInvoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VendorInvoiceID");

                entity.Property(e => e.AddressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AddressID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(45);

                entity.Property(e => e.InvoiceShipping).HasPrecision(32, 2);

                entity.Property(e => e.InvoiceSubTotal).HasPrecision(32, 2);

                entity.Property(e => e.InvoiceTax).HasPrecision(32, 2);

                entity.Property(e => e.InvoiceTotal).HasPrecision(32, 2);

                entity.Property(e => e.Notes).HasMaxLength(2000);

                entity.Property(e => e.PaymentTermsTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PaymentTermsTypeID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VendorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VendorID");

                entity.Property(e => e.VendorInvoiceStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VendorInvoiceStatusID");

                entity.HasOne(d => d.PaymentTermsType)
                    .WithMany(p => p.VendorInvoices)
                    .HasForeignKey(d => d.PaymentTermsTypeId)
                    .HasConstraintName("fk_vendor_invoice_type_payment_terms");

                entity.HasOne(d => d.VendorInvoiceStatus)
                    .WithMany(p => p.VendorInvoices)
                    .HasForeignKey(d => d.VendorInvoiceStatusId)
                    .HasConstraintName("fk_vendor_invoice_type_vendor_invoice_status");
            });

            modelBuilder.Entity<VendorInvoiceItem>(entity =>
            {
                entity.ToTable("vendor_invoice_item");

                entity.HasIndex(e => e.ReceiverItemId, "fk_vendor_invoice_item_receiver_item");

                entity.HasIndex(e => e.VendorInvoiceId, "fk_vendor_invoice_item_vendor_invoice");

                entity.Property(e => e.VendorInvoiceItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VendorInvoiceItemID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceCost).HasPrecision(32, 2);

                entity.Property(e => e.InvoiceExtendedCost).HasPrecision(32, 2);

                entity.Property(e => e.InvoiceQuantity).HasColumnType("int(11)");

                entity.Property(e => e.ReceiverItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReceiverItemID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VendorInvoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VendorInvoiceID");

                entity.HasOne(d => d.ReceiverItem)
                    .WithMany(p => p.VendorInvoiceItems)
                    .HasForeignKey(d => d.ReceiverItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vendor_invoice_item_receiver_item");

                entity.HasOne(d => d.VendorInvoice)
                    .WithMany(p => p.VendorInvoiceItems)
                    .HasForeignKey(d => d.VendorInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vendor_invoice_item_vendor_invoice");
            });

            modelBuilder.Entity<VwJobTimeDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_job_time_data");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.HighRezImage).HasMaxLength(150);

                entity.Property(e => e.JobNumber).HasMaxLength(45);

                entity.Property(e => e.JobStatusTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobStatusTypeID");

                entity.Property(e => e.PartNumber)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.Revision)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VwPackingListItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_packing_list_item");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.PackingListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PackingListID");

                entity.Property(e => e.Quantity).HasColumnType("bigint(21)");
            });

            modelBuilder.Entity<VwTimeEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_time_entry");

                entity.Property(e => e.DayWorked).HasColumnType("datetime");

                entity.Property(e => e.PayPeriodId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PayPeriodID");

                entity.Property(e => e.TimeEntryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TimeEntryID");

                entity.Property(e => e.TimeEntryTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TimeEntryTypeID");

                entity.Property(e => e.TotalHolidayHours).HasPrecision(36, 6);

                entity.Property(e => e.TotalVacationHours).HasPrecision(36, 6);

                entity.Property(e => e.TotalWorkedHours).HasPrecision(36, 6);

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<VwTimeEntrySummedByDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_time_entry_summed_by_day");

                entity.Property(e => e.DayWorked).HasColumnType("datetime");

                entity.Property(e => e.PayPeriodId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PayPeriodID");

                entity.Property(e => e.TotalHolidayHours).HasPrecision(55, 2);

                entity.Property(e => e.TotalVacationHours).HasPrecision(55, 2);

                entity.Property(e => e.TotalWorkedHours).HasPrecision(55, 2);

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<XrefCustomerAddress>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AddressId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("xref_customer_address");

                entity.HasIndex(e => e.AddressId, "FK_Address_xrefCustomerAddress_idx");

                entity.HasIndex(e => e.CustomerTaxTypeId, "FK_type_customer_tax_xrefCustomerAddress_idx");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerID");

                entity.Property(e => e.AddressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AddressID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerTaxTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerTaxTypeID");

                entity.Property(e => e.IsPrimary).HasColumnType("tinyint(4)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.XrefCustomerAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_xrefCustomerAddress");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.XrefCustomerAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_xrefCustomerAddress");

                entity.HasOne(d => d.CustomerTaxType)
                    .WithMany(p => p.XrefCustomerAddresses)
                    .HasForeignKey(d => d.CustomerTaxTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_type_customer_tax_xrefCustomerAddress");
            });

            modelBuilder.Entity<XrefCustomerContact>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ContactId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("xref_customer_contact");

                entity.HasIndex(e => e.ContactId, "FK_xrefCustomerContact_Contact_idx");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CustomerID");

                entity.Property(e => e.ContactId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContactID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsPrimary).HasColumnType("tinyint(4)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.XrefCustomerContacts)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_xrefCustomerContact_Contact");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.XrefCustomerContacts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_xrefCustomerContact_Customer");
            });

            modelBuilder.Entity<XrefJobCell>(entity =>
            {
                entity.HasKey(e => e.JobCellId)
                    .HasName("PRIMARY");

                entity.ToTable("xref_job_cell");

                entity.HasIndex(e => e.CellId, "fk_cell_xref_job_cell_ix");

                entity.HasIndex(e => e.JobId, "fk_job_xref_job_cell_ix");

                entity.Property(e => e.JobCellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobCellID");

                entity.Property(e => e.CellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CellID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.XrefJobCells)
                    .HasForeignKey(d => d.CellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cell_xref_job_cell_ix");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.XrefJobCells)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_xref_job_cell_ix");
            });

            modelBuilder.Entity<XrefJobItemPurchaseOrderItem>(entity =>
            {
                entity.HasKey(e => e.JobItemPurchaseOrderItemId)
                    .HasName("PRIMARY");

                entity.ToTable("xref_job_item_purchase_order_item");

                entity.HasIndex(e => e.JobHardwareId, "fk_job_hardware__xref_job_item_purchase_order_item_ix");

                entity.HasIndex(e => e.JobMaterialId, "fk_job_material__xref_job_item_purchase_order_item_ix");

                entity.HasIndex(e => e.JobRouteId, "fk_job_route__xref_job_item_purchase_order_item_ix");

                entity.HasIndex(e => e.PurchaseOrderItemId, "fk_purchase_order_item__xref_job_item_purchase_order_item_ix");

                entity.HasIndex(e => new { e.JobHardwareId, e.JobMaterialId, e.JobRouteId, e.PurchaseOrderItemId }, "job_item_po_item_unique")
                    .IsUnique();

                entity.Property(e => e.JobItemPurchaseOrderItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobItemPurchaseOrderItemID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobExtra).HasColumnType("int(11)");

                entity.Property(e => e.JobHardwareId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobHardwareID");

                entity.Property(e => e.JobItemQuantity).HasColumnType("int(11)");

                entity.Property(e => e.JobMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobMaterialID");

                entity.Property(e => e.JobQuantity).HasColumnType("int(11)");

                entity.Property(e => e.JobReceived).HasColumnType("int(11)");

                entity.Property(e => e.JobRouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobRouteID");

                entity.Property(e => e.JobTotal).HasColumnType("int(11)");

                entity.Property(e => e.PurchaseOrderItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PurchaseOrderItemID");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.JobHardware)
                    .WithMany(p => p.XrefJobItemPurchaseOrderItems)
                    .HasForeignKey(d => d.JobHardwareId)
                    .HasConstraintName("fk_job_hardware__xref_job_item_purchase_order_item");

                entity.HasOne(d => d.JobMaterial)
                    .WithMany(p => p.XrefJobItemPurchaseOrderItems)
                    .HasForeignKey(d => d.JobMaterialId)
                    .HasConstraintName("fk_job_material__xref_job_item_purchase_order_item");

                entity.HasOne(d => d.JobRoute)
                    .WithMany(p => p.XrefJobItemPurchaseOrderItems)
                    .HasForeignKey(d => d.JobRouteId)
                    .HasConstraintName("fk_job_route__xref_job_item_purchase_order_item");

                entity.HasOne(d => d.PurchaseOrderItem)
                    .WithMany(p => p.XrefJobItemPurchaseOrderItems)
                    .HasForeignKey(d => d.PurchaseOrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_purchase_order_item__xref_job_item_purchase_order_item");
            });

            modelBuilder.Entity<XrefJobMaterialBin>(entity =>
            {
                entity.HasKey(e => e.JobMaterialBinId)
                    .HasName("PRIMARY");

                entity.ToTable("xref_job_material_bin");

                entity.HasIndex(e => e.BinId, "fk_bin_xref_job_material_bin");

                entity.HasIndex(e => e.JobMaterialId, "fk_job_material_xref_job_material_bin");

                entity.Property(e => e.JobMaterialBinId).HasColumnType("int(11)");

                entity.Property(e => e.BinId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedById).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobMaterialId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Bin)
                    .WithMany(p => p.XrefJobMaterialBins)
                    .HasForeignKey(d => d.BinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bin_xref_job_material_bin");

                entity.HasOne(d => d.JobMaterial)
                    .WithMany(p => p.XrefJobMaterialBins)
                    .HasForeignKey(d => d.JobMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_material_xref_job_material_bin");
            });

            modelBuilder.Entity<XrefJobPart>(entity =>
            {
                entity.HasKey(e => e.JobPartId)
                    .HasName("PRIMARY");

                entity.ToTable("xref_job_part");

                entity.HasIndex(e => e.BinId, "fk_bin_xref_job_part_idx");

                entity.HasIndex(e => e.CellId, "fk_cell_xref_job_part_idx");

                entity.HasIndex(e => e.JobPartBatchId, "fk_job_part_batch_xref_job_part_idx");

                entity.HasIndex(e => e.JobPartStatusId, "fk_type_job_part_status_xref_job_part");

                entity.HasIndex(e => e.SubmittedById, "fk_user_xref_job_part");

                entity.HasIndex(e => new { e.JobId, e.CellId, e.JobPartStatusId, e.SubmittedById, e.BinId }, "uq_xref_job_part_composite_key")
                    .IsUnique();

                entity.Property(e => e.JobPartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobPartID");

                entity.Property(e => e.BinId).HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CellID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtraInspectionReview)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.InspectionPriority).HasColumnType("int(11)");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.JobPartBatchId).HasColumnType("int(11)");

                entity.Property(e => e.JobPartStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobPartStatusID");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.SubmittedById).HasColumnType("int(11)");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Bin)
                    .WithMany(p => p.XrefJobParts)
                    .HasForeignKey(d => d.BinId)
                    .HasConstraintName("fk_bin_xref_job_part");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.XrefJobParts)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("fk_cell_xref_job_part");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.XrefJobParts)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_job_xref_job_part");

                entity.HasOne(d => d.JobPartBatch)
                    .WithMany(p => p.XrefJobParts)
                    .HasForeignKey(d => d.JobPartBatchId)
                    .HasConstraintName("fk_job_part_batch_xref_job_part");

                entity.HasOne(d => d.JobPartStatus)
                    .WithMany(p => p.XrefJobParts)
                    .HasForeignKey(d => d.JobPartStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_type_job_part_status_xref_job_part");

                entity.HasOne(d => d.SubmittedBy)
                    .WithMany(p => p.XrefJobParts)
                    .HasForeignKey(d => d.SubmittedById)
                    .HasConstraintName("fk_user_xref_job_part");
            });

            modelBuilder.Entity<XrefJobPartBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xref_job_part_bkp");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.JobPartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobPartID");

                entity.Property(e => e.JobPartStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobPartStatusID");

                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartID");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<XrefJobPartStatusChangeHistory>(entity =>
            {
                entity.HasKey(e => e.JobPartStatusChangeHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("xref_job_part_status_change_history");

                entity.HasIndex(e => e.OldCellId, "cell_ xref_job_part_status_change_history_idx1");

                entity.HasIndex(e => e.NewCellId, "cell_ xref_job_part_status_change_history_idx2");

                entity.HasIndex(e => e.RejectionReasonId, "fk_rejection_reason_xref_job_part_status_change_history");

                entity.HasIndex(e => e.OldSubmittedById, "fk_user_xref_job_part_status_change_history1");

                entity.HasIndex(e => e.NewSubmittedById, "fk_user_xref_job_part_status_change_history2");

                entity.HasIndex(e => e.JobId, "job_xref_job_part_status_change_history_idx");

                entity.HasIndex(e => e.OldJobPartStatusId, "type_job_part_status_ xref_job_part_status_change_history_idx1");

                entity.HasIndex(e => e.NewJobPartStatusId, "type_job_part_status_ xref_job_part_status_change_history_idx2");

                entity.Property(e => e.JobPartStatusChangeHistoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobPartStatusChangeHistoryID");

                entity.Property(e => e.InspectionPriority).HasColumnType("int(11)");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.NewCellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("NewCellID");

                entity.Property(e => e.NewJobPartStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("NewJobPartStatusID");

                entity.Property(e => e.NewSubmittedById).HasColumnType("int(11)");

                entity.Property(e => e.Notes).HasMaxLength(5000);

                entity.Property(e => e.OldCellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OldCellID");

                entity.Property(e => e.OldJobPartStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OldJobPartStatusID");

                entity.Property(e => e.OldSubmittedById).HasColumnType("int(11)");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.RejectionReasonId).HasColumnType("int(11)");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.NewCell)
                    .WithMany(p => p.XrefJobPartStatusChangeHistoryNewCells)
                    .HasForeignKey(d => d.NewCellId)
                    .HasConstraintName("cell_ xref_job_part_status_change_history2");

                entity.HasOne(d => d.NewJobPartStatus)
                    .WithMany(p => p.XrefJobPartStatusChangeHistoryNewJobPartStatuses)
                    .HasForeignKey(d => d.NewJobPartStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("type_job_part_status_ xref_job_part_status_change_history2");

                entity.HasOne(d => d.NewSubmittedBy)
                    .WithMany(p => p.XrefJobPartStatusChangeHistoryNewSubmittedBies)
                    .HasForeignKey(d => d.NewSubmittedById)
                    .HasConstraintName("fk_user_xref_job_part_status_change_history2");

                entity.HasOne(d => d.OldCell)
                    .WithMany(p => p.XrefJobPartStatusChangeHistoryOldCells)
                    .HasForeignKey(d => d.OldCellId)
                    .HasConstraintName("cell_ xref_job_part_status_change_history1");

                entity.HasOne(d => d.OldJobPartStatus)
                    .WithMany(p => p.XrefJobPartStatusChangeHistoryOldJobPartStatuses)
                    .HasForeignKey(d => d.OldJobPartStatusId)
                    .HasConstraintName("type_job_part_status_ xref_job_part_status_change_history1");

                entity.HasOne(d => d.OldSubmittedBy)
                    .WithMany(p => p.XrefJobPartStatusChangeHistoryOldSubmittedBies)
                    .HasForeignKey(d => d.OldSubmittedById)
                    .HasConstraintName("fk_user_xref_job_part_status_change_history1");

                entity.HasOne(d => d.RejectionReason)
                    .WithMany(p => p.XrefJobPartStatusChangeHistories)
                    .HasForeignKey(d => d.RejectionReasonId)
                    .HasConstraintName("fk_rejection_reason_xref_job_part_status_change_history");
            });

            modelBuilder.Entity<XrefJobTimeEntry>(entity =>
            {
                entity.HasKey(e => e.JobTimeEntryId)
                    .HasName("PRIMARY");

                entity.ToTable("xref_job_time_entry");

                entity.HasIndex(e => e.CellId, "fk_cell_xref_job_time_entry_ix");

                entity.HasIndex(e => e.JobFunctionId, "fk_job_function_xref_job_time_entry_idx");

                entity.HasIndex(e => e.JobId, "fk_job_xref_job_time_entry_ix");

                entity.HasIndex(e => e.TimeEntryId, "fk_time_entry_xref_job_time_entry_ix");

                entity.Property(e => e.JobTimeEntryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobTimeEntryID");

                entity.Property(e => e.CellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CellID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.JobFunctionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobFunctionID");

                entity.Property(e => e.JobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("JobID");

                entity.Property(e => e.TimeEntryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TimeEntryID");

                entity.Property(e => e.TimeInMinutes).HasPrecision(32, 2);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.XrefJobTimeEntries)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("fk_cell_xref_job_time_entry");

                entity.HasOne(d => d.JobFunction)
                    .WithMany(p => p.XrefJobTimeEntries)
                    .HasForeignKey(d => d.JobFunctionId)
                    .HasConstraintName("fk_job_function_xref_job_time_entry");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.XrefJobTimeEntries)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("fk_job_xref_job_time_entry");

                entity.HasOne(d => d.TimeEntry)
                    .WithMany(p => p.XrefJobTimeEntries)
                    .HasForeignKey(d => d.TimeEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_time_entry_xref_job_time_entry");
            });

            modelBuilder.Entity<XrefPartMaterial>(entity =>
            {
                entity.HasKey(e => e.PartMaterialId)
                    .HasName("PRIMARY");

                entity.ToTable("xref_part_material");

                entity.HasIndex(e => e.RawMaterialTypeId, "fk_type_raw_material_xref_part_material_idx");

                entity.Property(e => e.PartMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartMaterialID");

                entity.Property(e => e.CertificationRequired)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.CostEstimate).HasPrecision(32, 2);

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Diameter).HasMaxLength(50);

                entity.Property(e => e.Height).HasMaxLength(50);

                entity.Property(e => e.Length).HasMaxLength(50);

                entity.Property(e => e.MaterialDescription).HasMaxLength(2000);

                entity.Property(e => e.MaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MaterialID");

                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartID");

                entity.Property(e => e.PricePerUnit).HasPrecision(32, 2);

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.RawMaterialTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RawMaterialTypeID");

                entity.Property(e => e.UnitCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Width).HasMaxLength(50);

                entity.HasOne(d => d.RawMaterialType)
                    .WithMany(p => p.XrefPartMaterials)
                    .HasForeignKey(d => d.RawMaterialTypeId)
                    .HasConstraintName("fk_type_raw_material_xref_part_material");
            });

            modelBuilder.Entity<XrefPartPart>(entity =>
            {
                entity.HasKey(e => new { e.PartId, e.SubPartId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("xref_part_part");

                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartID");

                entity.Property(e => e.SubPartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SubPartID");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");
            });

            modelBuilder.Entity<XrefPurchaseOrderItemBin>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderItemBinId)
                    .HasName("PRIMARY");

                entity.ToTable("xref_purchase_order_item_bin");

                entity.HasIndex(e => e.CreatedById, "fk_ xref_purchase_order_item_bin_created_by_id_idx");

                entity.HasIndex(e => e.UpdatedById, "fk_ xref_purchase_order_item_bin_udpated_by_id_idx");

                entity.HasIndex(e => e.BinId, "fk_bin_ xref_purchase_order_item_bin_idx");

                entity.HasIndex(e => e.PurchaseOrderItemId, "fk_purchase_order_item__ xref_purchase_order_item_bin_idx");

                entity.Property(e => e.PurchaseOrderItemBinId).HasColumnType("int(11)");

                entity.Property(e => e.BinId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedById).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseOrderItemId).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Bin)
                    .WithMany(p => p.XrefPurchaseOrderItemBins)
                    .HasForeignKey(d => d.BinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bin_ xref_purchase_order_item_bin");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.XrefPurchaseOrderItemBinCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ xref_purchase_order_item_bin_created_by_id");

                entity.HasOne(d => d.PurchaseOrderItem)
                    .WithMany(p => p.XrefPurchaseOrderItemBins)
                    .HasForeignKey(d => d.PurchaseOrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_purchase_order_item__ xref_purchase_order_item_bin");

                entity.HasOne(d => d.UpdatedBy)
                    .WithMany(p => p.XrefPurchaseOrderItemBinUpdatedBies)
                    .HasForeignKey(d => d.UpdatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ xref_purchase_order_item_bin_udpated_by_id");
            });

            modelBuilder.Entity<XrefQuotePart>(entity =>
            {
                entity.HasKey(e => e.QuotePartId)
                    .HasName("PRIMARY");

                entity.ToTable("xref_quote_part");

                entity.HasIndex(e => e.PartId, "fk_part_XRefQuotePart");

                entity.HasIndex(e => e.QuoteId, "fk_quote_XRefQuotePart");

                entity.HasIndex(e => e.ParentQuotePartId, "fk_quote_part_parent_quote_part_idx");

                entity.Property(e => e.QuotePartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("QuotePartID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtendedPrice).HasPrecision(32, 2);

                entity.Property(e => e.IsSelected)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID");

                entity.Property(e => e.ParentQuotePartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParentQuotePartID");

                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PartID");

                entity.Property(e => e.Qty).HasColumnType("int(11)");

                entity.Property(e => e.QuoteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("QuoteID");

                entity.Property(e => e.TargetExtendedPrice).HasPrecision(32, 2);

                entity.Property(e => e.TargetUnitPrice).HasPrecision(32, 2);

                entity.Property(e => e.UnitPrice).HasPrecision(32, 2);

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ParentQuotePart)
                    .WithMany(p => p.InverseParentQuotePart)
                    .HasForeignKey(d => d.ParentQuotePartId)
                    .HasConstraintName("fk_quote_part_parent_quote_part");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.XrefQuoteParts)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_part_XRefQuotePart");

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.XrefQuoteParts)
                    .HasForeignKey(d => d.QuoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_quote_XRefQuotePart");
            });

            modelBuilder.Entity<XrefRmaJob>(entity =>
            {
                entity.HasKey(e => e.RmaJobId)
                    .HasName("PRIMARY");

                entity.ToTable("xref_rma_job");

                entity.Property(e => e.RmaJobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RmaJobID");

                entity.Property(e => e.CreatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditMemo)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.NewJobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("NewJobID");

                entity.Property(e => e.OrigJobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("OrigJobID");

                entity.Property(e => e.RmaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RmaID");

                entity.Property(e => e.RmaJobTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RmaJobTypeID");

                entity.Property(e => e.RmaQty).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedById)
                    .HasColumnType("int(11)")
                    .HasColumnName("UpdatedByID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<XrefRoleFeature>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.FeatureId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("xref_role_feature");

                entity.HasIndex(e => e.FeatureId, "FK_Feature_XrefRoleFeature_idx");

                entity.HasIndex(e => e.RoleId, "FK_Role_XrefRoleFeature_idx");

                entity.Property(e => e.RoleId).HasColumnType("int(11)");

                entity.Property(e => e.FeatureId).HasColumnType("int(11)");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.XrefRoleFeatures)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feature_XrefRoleFeature");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.XrefRoleFeatures)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_XrefRoleFeature");
            });

            modelBuilder.Entity<XrefUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("xref_user_role");

                entity.HasIndex(e => e.RoleId, "FK_Role_XrefUserRole");

                entity.HasIndex(e => e.UserId, "FK_User_XrefUserRole");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.RoleId).HasColumnType("int(11)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.XrefUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_XrefUserRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.XrefUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_XrefUserRole");
            });

            modelBuilder.Entity<XrefVendorAddress>(entity =>
            {
                entity.HasKey(e => new { e.VendorId, e.AddressId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("xref_vendor_address");

                entity.HasIndex(e => e.AddressId, "FK_VendorAddress_Address_idx");

                entity.HasIndex(e => e.VendorId, "FK_VendorAddress_Vendor_idx");

                entity.Property(e => e.VendorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VendorID");

                entity.Property(e => e.AddressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AddressID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsPrimary).HasColumnType("tinyint(4)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.XrefVendorAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorAddress_Address");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.XrefVendorAddresses)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorAddress_Vendor");
            });

            modelBuilder.Entity<XrefVendorContact>(entity =>
            {
                entity.HasKey(e => new { e.VendorId, e.ContactId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("xref_vendor_contact");

                entity.HasIndex(e => e.ContactId, "FK_VendorContact_Contact_idx");

                entity.Property(e => e.VendorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VendorID");

                entity.Property(e => e.ContactId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContactID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsPrimary).HasColumnType("tinyint(4)");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.XrefVendorContacts)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorContact_Contact");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.XrefVendorContacts)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendorContact_Vendor");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
