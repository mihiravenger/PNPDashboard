using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Keyless]
    [Table("Query", Schema = "dbo")]
    public partial class Query
    {
        [Column("AXAttributeName")]
        [StringLength(500)]
        public string AxattributeName { get; set; }
        [StringLength(500)]
        public string Discription { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
