using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("StateCityMapping", Schema = "dbo")]
    public partial class StateCityMapping
    {
        [Key]
        public int StateCityMappingId { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        [StringLength(200)]
        public string CityName { get; set; }
        public bool? Status { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("StateCityMappings")]
        public virtual Country Country { get; set; }
    }
}
