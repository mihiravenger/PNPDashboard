using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("OrderVariance", Schema = "dbo")]
    public partial class OrderVariance
    {
        [Key]
        [Column("OrderVarianceID")]
        public long OrderVarianceId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; }
        [Required]
        [Column("AXSalesOrderID")]
        [StringLength(100)]
        public string AxsalesOrderId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal VarianceAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? LineVariance { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TaxVariance { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("OrderVariances")]
        public virtual Country Country { get; set; }
    }
}
