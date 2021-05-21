using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("CountryMapping", Schema = "dbo")]
    public partial class CountryMapping
    {
        [Key]
        [Column("CountryMappingID")]
        public long CountryMappingId { get; set; }
        [Required]
        [Column("SVStateName")]
        [StringLength(100)]
        public string SvstateName { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        public bool? IsActive { get; set; }
        [Column("AXStateID")]
        public int? AxstateId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("CountryMappings")]
        public virtual Country Country { get; set; }
    }
}
