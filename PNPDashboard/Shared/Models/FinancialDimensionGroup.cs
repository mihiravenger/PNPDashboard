using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("FinancialDimensionGroup", Schema = "dbo")]
    public partial class FinancialDimensionGroup
    {
        public FinancialDimensionGroup()
        {
            AffiliateMappings = new HashSet<AffiliateMapping>();
            CountrySourceCreatedByAttributeMappings = new HashSet<CountrySourceCreatedByAttributeMapping>();
            FinancialDimensionDetails = new HashSet<FinancialDimensionDetail>();
        }

        [Key]
        [Column("FinancialDimensionGroupID")]
        public int FinancialDimensionGroupId { get; set; }
        [StringLength(500)]
        public string FinancialDimensionGroupName { get; set; }
        [StringLength(500)]
        public string Discription { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("FinancialDimensionGroups")]
        public virtual Country Country { get; set; }
        [InverseProperty(nameof(AffiliateMapping.FinancialDimensionGroup))]
        public virtual ICollection<AffiliateMapping> AffiliateMappings { get; set; }
        [InverseProperty(nameof(CountrySourceCreatedByAttributeMapping.FinancialDimensionGroup))]
        public virtual ICollection<CountrySourceCreatedByAttributeMapping> CountrySourceCreatedByAttributeMappings { get; set; }
        [InverseProperty(nameof(FinancialDimensionDetail.FinancialDimensionGroup))]
        public virtual ICollection<FinancialDimensionDetail> FinancialDimensionDetails { get; set; }
    }
}
