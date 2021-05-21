using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("CountrySourceMapping", Schema = "dbo")]
    public partial class CountrySourceMapping
    {
        [Key]
        [Column("CountrySourceMappingID")]
        public int CountrySourceMappingId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [Column("SourceID")]
        public int? SourceId { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        public bool? SourceUpdate { get; set; }
        [StringLength(100)]
        public string SourcePath { get; set; }
        public bool? CreateDeliveryContactInfo { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("CountrySourceMappings")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(SourceId))]
        [InverseProperty(nameof(SourceMaster.CountrySourceMappings))]
        public virtual SourceMaster Source { get; set; }
    }
}
