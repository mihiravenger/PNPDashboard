using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("CountryFinancialDimensionMapping", Schema = "dbo")]
    [Index(nameof(CountryId), nameof(FinancialDimensionId), Name = "IX_CountryFinancialDimensionMapping", IsUnique = true)]
    public partial class CountryFinancialDimensionMapping
    {
        public CountryFinancialDimensionMapping()
        {
            FinancialDimensionDetails = new HashSet<FinancialDimensionDetail>();
        }

        [Key]
        [Column("CountryFinancialDimensionMappingID")]
        public int CountryFinancialDimensionMappingId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [Column("FinancialDimensionID")]
        public int? FinancialDimensionId { get; set; }
        public bool? IsEnabled { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsRequired { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("CountryFinancialDimensionMappings")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(FinancialDimensionId))]
        [InverseProperty(nameof(FinancialDimensionMaster.CountryFinancialDimensionMappings))]
        public virtual FinancialDimensionMaster FinancialDimension { get; set; }
        [InverseProperty(nameof(FinancialDimensionDetail.CountryFinancialDimensionMapping))]
        public virtual ICollection<FinancialDimensionDetail> FinancialDimensionDetails { get; set; }
    }
}
