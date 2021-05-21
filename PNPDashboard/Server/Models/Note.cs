using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("Notes", Schema = "dbo")]
    public partial class Note
    {
        [Key]
        [Column("NoteConfigID")]
        public int NoteConfigId { get; set; }
        [Required]
        [Column("TypeID")]
        [StringLength(50)]
        public string TypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [StringLength(15)]
        public string Restriction { get; set; }
        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        public bool? Status { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Notes")]
        public virtual Country Country { get; set; }
    }
}
