using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("FinancialDimensionMaster", Schema = "dbo")]
    public partial class FinancialDimensionMaster
    {
        public FinancialDimensionMaster()
        {
            CountryFinancialDimensionMappings = new HashSet<CountryFinancialDimensionMapping>();
        }

        [Key]
        [Column("FinancialDimensionID")]
        public int FinancialDimensionId { get; set; }
        [StringLength(500)]
        public string FinancialDimensionName { get; set; }
        [StringLength(500)]
        public string Discription { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [InverseProperty(nameof(CountryFinancialDimensionMapping.FinancialDimension))]
        public virtual ICollection<CountryFinancialDimensionMapping> CountryFinancialDimensionMappings { get; set; }
    }
}
