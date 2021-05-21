using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("FinancialDimensionDetail", Schema = "dbo")]
    public partial class FinancialDimensionDetail
    {
        [Key]
        [Column("FinancialDimensionDetailID")]
        public int FinancialDimensionDetailId { get; set; }
        [Column("CountryFinancialDimensionMappingID")]
        public int? CountryFinancialDimensionMappingId { get; set; }
        [StringLength(500)]
        public string FinancialDimensionValue { get; set; }
        [Column("FinancialDimensionGroupID")]
        public int? FinancialDimensionGroupId { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [ForeignKey(nameof(CountryFinancialDimensionMappingId))]
        [InverseProperty("FinancialDimensionDetails")]
        public virtual CountryFinancialDimensionMapping CountryFinancialDimensionMapping { get; set; }
        [ForeignKey(nameof(FinancialDimensionGroupId))]
        [InverseProperty("FinancialDimensionDetails")]
        public virtual FinancialDimensionGroup FinancialDimensionGroup { get; set; }
    }
}
