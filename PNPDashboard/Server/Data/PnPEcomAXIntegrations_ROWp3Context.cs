using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PNPDashboard.Server.Models;

#nullable disable

namespace PNPDashboard.Server.Data
{
    public partial class PnPEcomAXIntegrations_ROWp3Context : DbContext
    {
        public PnPEcomAXIntegrations_ROWp3Context()
        {
        }

        public PnPEcomAXIntegrations_ROWp3Context(DbContextOptions<PnPEcomAXIntegrations_ROWp3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AffiliateMapping> AffiliateMappings { get; set; }
        public virtual DbSet<Authentication> Authentications { get; set; }
        public virtual DbSet<AxattributeDetail> AxattributeDetails { get; set; }
        public virtual DbSet<AxattributeGroup> AxattributeGroups { get; set; }
        public virtual DbSet<AxattributeMaster> AxattributeMasters { get; set; }
        public virtual DbSet<AxstateMaster> AxstateMasters { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<ConfigurationsBk10Feb2017> ConfigurationsBk10Feb2017s { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CountryAxattributeMapping> CountryAxattributeMappings { get; set; }
        public virtual DbSet<CountryConfiguration> CountryConfigurations { get; set; }
        public virtual DbSet<CountryFinancialDimensionMapping> CountryFinancialDimensionMappings { get; set; }
        public virtual DbSet<CountryMapping> CountryMappings { get; set; }
        public virtual DbSet<CountrySourceCreatedByAttributeMapping> CountrySourceCreatedByAttributeMappings { get; set; }
        public virtual DbSet<CountrySourceMapping> CountrySourceMappings { get; set; }
        public virtual DbSet<CountryconfigurationBak> CountryconfigurationBaks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddressDetail> CustomerAddressDetails { get; set; }
        public virtual DbSet<DashboardMenu> DashboardMenus { get; set; }
        public virtual DbSet<DispatchedOrder> DispatchedOrders { get; set; }
        public virtual DbSet<FileLog> FileLogs { get; set; }
        public virtual DbSet<FinancialDimensionDetail> FinancialDimensionDetails { get; set; }
        public virtual DbSet<FinancialDimensionGroup> FinancialDimensionGroups { get; set; }
        public virtual DbSet<FinancialDimensionMaster> FinancialDimensionMasters { get; set; }
        public virtual DbSet<IntegrationRequest> IntegrationRequests { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<OrderLog> OrderLogs { get; set; }
        public virtual DbSet<OrderVariance> OrderVariances { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Personalisation> Personalisations { get; set; }
        public virtual DbSet<PriceAdjustment> PriceAdjustments { get; set; }
        public virtual DbSet<PriceAdjustmentType> PriceAdjustmentTypes { get; set; }
        public virtual DbSet<Query> Queries { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleMenuMapping> RoleMenuMappings { get; set; }
        public virtual DbSet<RunLog> RunLogs { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<ShipmentMethodMapping> ShipmentMethodMappings { get; set; }
        public virtual DbSet<SourceMaster> SourceMasters { get; set; }
        public virtual DbSet<SourcePaymentMapping> SourcePaymentMappings { get; set; }
        public virtual DbSet<StateCityMapping> StateCityMappings { get; set; }
        public virtual DbSet<StatusCode> StatusCodes { get; set; }
        public virtual DbSet<TaxConfiguration> TaxConfigurations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCountryMapping> UserCountryMappings { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=TRI-SQL2-UAT;Database=PnPEcomAXIntegrations_ROWp3;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AffiliateMapping>(entity =>
            {
                entity.HasOne(d => d.FinancialDimensionGroup)
                    .WithMany(p => p.AffiliateMappings)
                    .HasForeignKey(d => d.FinancialDimensionGroupId)
                    .HasConstraintName("FK_AffiliateMapping_FinancialDimensionGroup");
            });

            modelBuilder.Entity<Authentication>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Authentications)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Authentication_Countries");
            });

            modelBuilder.Entity<AxattributeDetail>(entity =>
            {
                entity.HasOne(d => d.AxattributeGroup)
                    .WithMany(p => p.AxattributeDetails)
                    .HasForeignKey(d => d.AxattributeGroupId)
                    .HasConstraintName("FK_CountrySourceCreatedByAttribute_AXAttributeDetail_AXAttributeGroup");

                entity.HasOne(d => d.CountryAxattributeMapping)
                    .WithMany(p => p.AxattributeDetails)
                    .HasForeignKey(d => d.CountryAxattributeMappingId)
                    .HasConstraintName("FK_CountrySourceCreatedByAttribute_AXAttributeDetail_CountryAXAttributeMapping");
            });

            modelBuilder.Entity<AxattributeGroup>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AxattributeGroups)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_AXAttributeGroup_Countries");
            });

            modelBuilder.Entity<AxstateMaster>(entity =>
            {
                entity.HasKey(e => e.AxstateId)
                    .HasName("PK_AXStateid");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AxstateMasters)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_AXStateMaster_Countries");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Configurations)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Configurations_Countries");
            });

            modelBuilder.Entity<ConfigurationsBk10Feb2017>(entity =>
            {
                entity.Property(e => e.ConfigurationId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CountryAxattributeMapping>(entity =>
            {
                entity.HasOne(d => d.Axattribute)
                    .WithMany(p => p.CountryAxattributeMappings)
                    .HasForeignKey(d => d.AxattributeId)
                    .HasConstraintName("FK_CountryAXAttributeMappingMaster_AXAttributeMaster");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryAxattributeMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CountryAXAttributeMappingMaster_Countries");
            });

            modelBuilder.Entity<CountryConfiguration>(entity =>
            {
                entity.Property(e => e.CountryFullName).IsUnicode(false);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.CountryConfigurations)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CountryConfiguration_Countries");
            });

            modelBuilder.Entity<CountryFinancialDimensionMapping>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryFinancialDimensionMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CountryFinancialDimensionMappingMaster_Countries");

                entity.HasOne(d => d.FinancialDimension)
                    .WithMany(p => p.CountryFinancialDimensionMappings)
                    .HasForeignKey(d => d.FinancialDimensionId)
                    .HasConstraintName("FK_CountryFinancialDimensionMappingMaster_FinancialDimensionMaster");
            });

            modelBuilder.Entity<CountryMapping>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CountryMapping_Countries");
            });

            modelBuilder.Entity<CountrySourceCreatedByAttributeMapping>(entity =>
            {
                entity.HasOne(d => d.AffiliateMapping)
                    .WithMany(p => p.CountrySourceCreatedByAttributeMappings)
                    .HasForeignKey(d => d.AffiliateMappingId)
                    .HasConstraintName("FK_CountrySourceCreatedByAttributeMappingMaster_AffiliateMapping");

                entity.HasOne(d => d.AxattributeGroup)
                    .WithMany(p => p.CountrySourceCreatedByAttributeMappings)
                    .HasForeignKey(d => d.AxattributeGroupId)
                    .HasConstraintName("FK_CountrySourceCreatedByAttributeMapping_AXAttributeGroup");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountrySourceCreatedByAttributeMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CountrySourceCreatedByAttributeMappingMaster_Countries");

                entity.HasOne(d => d.FinancialDimensionGroup)
                    .WithMany(p => p.CountrySourceCreatedByAttributeMappings)
                    .HasForeignKey(d => d.FinancialDimensionGroupId)
                    .HasConstraintName("FK_CountrySourceCreatedByAttributeMapping_FinancialDimensionGroup");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.CountrySourceCreatedByAttributeMappings)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_CountrySourceCreatedByAttributeMappingMaster_SourceMaster");
            });

            modelBuilder.Entity<CountrySourceMapping>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountrySourceMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CountrySourceMappingMaster_Countries");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.CountrySourceMappings)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_CountrySourceMappingMaster_SourceMaster");
            });

            modelBuilder.Entity<CountryconfigurationBak>(entity =>
            {
                entity.Property(e => e.CountryConfigId).ValueGeneratedOnAdd();

                entity.Property(e => e.CountryFullName).IsUnicode(false);
            });

            modelBuilder.Entity<CustomerAddressDetail>(entity =>
            {
                entity.Property(e => e.AxlocationId).IsUnicode(false);

                entity.Property(e => e.ContactInfoLocationId).IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddressDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerAddressDetails_Customers1");
            });

            modelBuilder.Entity<DashboardMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK_Menu");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.MenuName).IsUnicode(false);

                entity.Property(e => e.PageUrl).IsUnicode(false);
            });

            modelBuilder.Entity<DispatchedOrder>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.DispatchedOrders)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_DispatchedOrders_Countries");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.DispatchedOrders)
                    .HasForeignKey(d => d.LineItemId)
                    .HasConstraintName("FK_DispatchedOrders_LineItems");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.DispatchedOrders)
                    .HasForeignKey(d => d.SalesOrderId)
                    .HasConstraintName("FK_DispatchedOrders_DispatchedOrders");
            });

            modelBuilder.Entity<FileLog>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_FileLog");

                entity.HasOne(d => d.Run)
                    .WithMany(p => p.FileLogs)
                    .HasForeignKey(d => d.RunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FileLogs_RunLogs");
            });

            modelBuilder.Entity<FinancialDimensionDetail>(entity =>
            {
                entity.HasOne(d => d.CountryFinancialDimensionMapping)
                    .WithMany(p => p.FinancialDimensionDetails)
                    .HasForeignKey(d => d.CountryFinancialDimensionMappingId)
                    .HasConstraintName("FK_CountrySourceCreatedByAttribute_FinancialDimensionDetail_CountryFinancialDimensionMapping");

                entity.HasOne(d => d.FinancialDimensionGroup)
                    .WithMany(p => p.FinancialDimensionDetails)
                    .HasForeignKey(d => d.FinancialDimensionGroupId)
                    .HasConstraintName("FK_CountrySourceCreatedByAttribute_FinancialDimensionDetail_FinancialDimensionGroup");
            });

            modelBuilder.Entity<FinancialDimensionGroup>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.FinancialDimensionGroups)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_FinancialDimensionGroup_Countries");
            });

            modelBuilder.Entity<IntegrationRequest>(entity =>
            {
                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.IntegrationRequests)
                    .HasForeignKey(d => d.SalesOrderId)
                    .HasConstraintName("FK_IntegrationRequests_SalesOrders");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.SalesOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineItems_SalesOrders");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Notes_Countries");
            });

            modelBuilder.Entity<OrderLog>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_OrderLog");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.OrderLogs)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLogs_FileLogs");
            });

            modelBuilder.Entity<OrderVariance>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.OrderVariances)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_OrderVariance_Countries");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.SalesOrderId)
                    .HasConstraintName("FK_Payments_SalesOrders");
            });

            modelBuilder.Entity<Personalisation>(entity =>
            {
                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.Personalisations)
                    .HasForeignKey(d => d.LineItemId)
                    .HasConstraintName("FK_Personalisation_LineItems");
            });

            modelBuilder.Entity<PriceAdjustment>(entity =>
            {
                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.PriceAdjustments)
                    .HasForeignKey(d => d.LineItemId)
                    .HasConstraintName("FK_PriceAdjustments_LineItems");

                entity.HasOne(d => d.PriceAdjustmentType)
                    .WithMany(p => p.PriceAdjustments)
                    .HasForeignKey(d => d.PriceAdjustmentTypeId)
                    .HasConstraintName("FK_PriceAdjustments_PriceAdjustmentType");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.PriceAdjustments)
                    .HasForeignKey(d => d.SalesOrderId)
                    .HasConstraintName("FK_PriceAdjustments_SalesOrders");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.PriceAdjustments)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK_PriceAdjustments_Shipments");
            });

            modelBuilder.Entity<Query>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasPrecision(3);

                entity.Property(e => e.LastModifiedDate).HasPrecision(3);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleName).IsUnicode(false);
            });

            modelBuilder.Entity<RoleMenuMapping>(entity =>
            {
                entity.Property(e => e.AccessRights).HasComment("0=None, 1=View, 2=Full Access");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.RoleMenuMappings)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_RoleMenuMapping_DashboardMenus");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleMenuMappings)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleMenuMapping_Roles");
            });

            modelBuilder.Entity<SalesOrder>(entity =>
            {
                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.BillingAddressId)
                    .HasConstraintName("FK_SalesOrders_CustomerAddressDetails");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_SalesOrders_Countries");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SalesOrders_Customers");
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.SalesOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipments_Shipments");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipments_CustomerAddressDetails");
            });

            modelBuilder.Entity<ShipmentMethodMapping>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ShipmentMethodMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_ShipmentMethodMapping_Countries");
            });

            modelBuilder.Entity<SourcePaymentMapping>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SourcePaymentMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_SourcePaymentMapping_Countries");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.SourcePaymentMappings)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_SourcePaymentMapping_SourceMaster");
            });

            modelBuilder.Entity<StateCityMapping>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateCityMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_StateCityMapping_Countries");
            });

            modelBuilder.Entity<TaxConfiguration>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TaxConfigurations)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_TaxConfiguration_Countries");
            });

            modelBuilder.Entity<UserCountryMapping>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.UserCountryMappings)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCountryMapping_UserCountryMapping");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserCountryMappings)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCountryMapping_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCountryMappings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCountryMapping_UserCountryMapping1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
