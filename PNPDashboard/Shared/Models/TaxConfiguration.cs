using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("TaxConfiguration", Schema = "dbo")]
    public partial class TaxConfiguration
    {
        [Key]
        public long TaxConfigId { get; set; }
        [Required]
        [Column("AXSalesTaxGroup")]
        [StringLength(50)]
        public string AxsalesTaxGroup { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public bool? Status { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("TaxConfigurations")]
        public virtual Country Country { get; set; }
    }
}
