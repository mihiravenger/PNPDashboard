using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("Countries", Schema = "dbo")]
    public partial class Country
    {
        public Country()
        {
            Authentications = new HashSet<Authentication>();
            AxattributeGroups = new HashSet<AxattributeGroup>();
            AxstateMasters = new HashSet<AxstateMaster>();
            Configurations = new HashSet<Configuration>();
            CountryAxattributeMappings = new HashSet<CountryAxattributeMapping>();
            CountryConfigurations = new HashSet<CountryConfiguration>();
            CountryFinancialDimensionMappings = new HashSet<CountryFinancialDimensionMapping>();
            CountryMappings = new HashSet<CountryMapping>();
            CountrySourceCreatedByAttributeMappings = new HashSet<CountrySourceCreatedByAttributeMapping>();
            CountrySourceMappings = new HashSet<CountrySourceMapping>();
            DispatchedOrders = new HashSet<DispatchedOrder>();
            FinancialDimensionGroups = new HashSet<FinancialDimensionGroup>();
            Notes = new HashSet<Note>();
            OrderVariances = new HashSet<OrderVariance>();
            SalesOrders = new HashSet<SalesOrder>();
            ShipmentMethodMappings = new HashSet<ShipmentMethodMapping>();
            SourcePaymentMappings = new HashSet<SourcePaymentMapping>();
            StateCityMappings = new HashSet<StateCityMapping>();
            TaxConfigurations = new HashSet<TaxConfiguration>();
            UserCountryMappings = new HashSet<UserCountryMapping>();
        }

        [Key]
        [Column("CountryID")]
        public int CountryId { get; set; }
        [StringLength(100)]
        public string CountryName { get; set; }

        [InverseProperty(nameof(Authentication.Country))]
        public virtual ICollection<Authentication> Authentications { get; set; }
        [InverseProperty(nameof(AxattributeGroup.Country))]
        public virtual ICollection<AxattributeGroup> AxattributeGroups { get; set; }
        [InverseProperty(nameof(AxstateMaster.Country))]
        public virtual ICollection<AxstateMaster> AxstateMasters { get; set; }
        [InverseProperty(nameof(Configuration.Country))]
        public virtual ICollection<Configuration> Configurations { get; set; }
        [InverseProperty(nameof(CountryAxattributeMapping.Country))]
        public virtual ICollection<CountryAxattributeMapping> CountryAxattributeMappings { get; set; }
        [InverseProperty(nameof(CountryConfiguration.CountryNavigation))]
        public virtual ICollection<CountryConfiguration> CountryConfigurations { get; set; }
        [InverseProperty(nameof(CountryFinancialDimensionMapping.Country))]
        public virtual ICollection<CountryFinancialDimensionMapping> CountryFinancialDimensionMappings { get; set; }
        [InverseProperty(nameof(CountryMapping.Country))]
        public virtual ICollection<CountryMapping> CountryMappings { get; set; }
        [InverseProperty(nameof(CountrySourceCreatedByAttributeMapping.Country))]
        public virtual ICollection<CountrySourceCreatedByAttributeMapping> CountrySourceCreatedByAttributeMappings { get; set; }
        [InverseProperty(nameof(CountrySourceMapping.Country))]
        public virtual ICollection<CountrySourceMapping> CountrySourceMappings { get; set; }
        [InverseProperty(nameof(DispatchedOrder.Country))]
        public virtual ICollection<DispatchedOrder> DispatchedOrders { get; set; }
        [InverseProperty(nameof(FinancialDimensionGroup.Country))]
        public virtual ICollection<FinancialDimensionGroup> FinancialDimensionGroups { get; set; }
        [InverseProperty(nameof(Note.Country))]
        public virtual ICollection<Note> Notes { get; set; }
        [InverseProperty(nameof(OrderVariance.Country))]
        public virtual ICollection<OrderVariance> OrderVariances { get; set; }
        [InverseProperty(nameof(SalesOrder.Country))]
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        [InverseProperty(nameof(ShipmentMethodMapping.Country))]
        public virtual ICollection<ShipmentMethodMapping> ShipmentMethodMappings { get; set; }
        [InverseProperty(nameof(SourcePaymentMapping.Country))]
        public virtual ICollection<SourcePaymentMapping> SourcePaymentMappings { get; set; }
        [InverseProperty(nameof(StateCityMapping.Country))]
        public virtual ICollection<StateCityMapping> StateCityMappings { get; set; }
        [InverseProperty(nameof(TaxConfiguration.Country))]
        public virtual ICollection<TaxConfiguration> TaxConfigurations { get; set; }
        [InverseProperty(nameof(UserCountryMapping.Country))]
        public virtual ICollection<UserCountryMapping> UserCountryMappings { get; set; }
    }
}
