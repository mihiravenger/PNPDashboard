using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("CountrySourceCreatedByAttributeMapping", Schema = "dbo")]
    public partial class CountrySourceCreatedByAttributeMapping
    {
        [Key]
        [Column("CountrySourceCreatedByAttributeMappingID")]
        public int CountrySourceCreatedByAttributeMappingId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [Column("SourceID")]
        public int? SourceId { get; set; }
        [StringLength(100)]
        public string CreatedByAttribute { get; set; }
        [Column("FinancialDimensionGroupID")]
        public int? FinancialDimensionGroupId { get; set; }
        [Column("AXAttributeGroupID")]
        public int? AxattributeGroupId { get; set; }
        [Column("AXSalesGroup")]
        [StringLength(100)]
        public string AxsalesGroup { get; set; }
        [Column("AffiliateMappingID")]
        public int? AffiliateMappingId { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        [StringLength(100)]
        public string SalesResponsible { get; set; }

        [ForeignKey(nameof(AffiliateMappingId))]
        [InverseProperty("CountrySourceCreatedByAttributeMappings")]
        public virtual AffiliateMapping AffiliateMapping { get; set; }
        [ForeignKey(nameof(AxattributeGroupId))]
        [InverseProperty("CountrySourceCreatedByAttributeMappings")]
        public virtual AxattributeGroup AxattributeGroup { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty("CountrySourceCreatedByAttributeMappings")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(FinancialDimensionGroupId))]
        [InverseProperty("CountrySourceCreatedByAttributeMappings")]
        public virtual FinancialDimensionGroup FinancialDimensionGroup { get; set; }
        [ForeignKey(nameof(SourceId))]
        [InverseProperty(nameof(SourceMaster.CountrySourceCreatedByAttributeMappings))]
        public virtual SourceMaster Source { get; set; }
    }
}
