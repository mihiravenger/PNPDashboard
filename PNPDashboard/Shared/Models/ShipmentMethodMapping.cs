using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("ShipmentMethodMapping", Schema = "dbo")]
    public partial class ShipmentMethodMapping
    {
        [Key]
        [Column("ShipmentMethodMapID")]
        public int ShipmentMethodMapId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [Required]
        [Column("AXMethodType")]
        [StringLength(100)]
        public string AxmethodType { get; set; }
        [Required]
        [Column("SVMethodType")]
        [StringLength(100)]
        public string SvmethodType { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        [Column("AXMethodDescription")]
        [StringLength(200)]
        public string AxmethodDescription { get; set; }
        [Column("SVMethodDescription")]
        [StringLength(200)]
        public string SvmethodDescription { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("ShipmentMethodMappings")]
        public virtual Country Country { get; set; }
    }
}
