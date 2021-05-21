using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("AXStateMaster", Schema = "dbo")]
    public partial class AxstateMaster
    {
        [Key]
        [Column("AXStateID")]
        public int AxstateId { get; set; }
        [Column("AXStateName")]
        [StringLength(200)]
        public string AxstateName { get; set; }
        public bool? IsActive { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("AxstateMasters")]
        public virtual Country Country { get; set; }
    }
}
