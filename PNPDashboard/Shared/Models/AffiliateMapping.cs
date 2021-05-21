using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("AffiliateMapping", Schema = "dbo")]
    public partial class AffiliateMapping
    {
        public AffiliateMapping()
        {
            CountrySourceCreatedByAttributeMappings = new HashSet<CountrySourceCreatedByAttributeMapping>();
        }

        [Key]
        [Column("AffiliateMappingID")]
        public int AffiliateMappingId { get; set; }
        [Column("DWAffiliateID")]
        [StringLength(100)]
        public string DwaffiliateId { get; set; }
        [Column("AXCustomerID")]
        [StringLength(100)]
        public string AxcustomerId { get; set; }
        [Column("AXOffsetAccount")]
        [StringLength(100)]
        public string AxoffsetAccount { get; set; }
        public double? Percentage { get; set; }
        public bool? IsFreeTextInvoice { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        [Column("FinancialDimensionGroupID")]
        public int? FinancialDimensionGroupId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }

        [ForeignKey(nameof(FinancialDimensionGroupId))]
        [InverseProperty("AffiliateMappings")]
        public virtual FinancialDimensionGroup FinancialDimensionGroup { get; set; }
        [InverseProperty(nameof(CountrySourceCreatedByAttributeMapping.AffiliateMapping))]
        public virtual ICollection<CountrySourceCreatedByAttributeMapping> CountrySourceCreatedByAttributeMappings { get; set; }
    }
}
