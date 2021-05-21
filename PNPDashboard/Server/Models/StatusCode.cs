using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("StatusCode", Schema = "dbo")]
    public partial class StatusCode
    {
        [Key]
        [Column("StatusCodeID")]
        public int StatusCodeId { get; set; }
        public int? StatusCodeNumber { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
    }
}
