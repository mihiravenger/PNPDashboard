using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Keyless]
    [Table("Configurations_BK_10_Feb_2017", Schema = "dbo")]
    public partial class ConfigurationsBk10Feb2017
    {
        public int ConfigurationId { get; set; }
        public int CountryId { get; set; }
        [Required]
        [StringLength(100)]
        public string ConfigurationKey { get; set; }
        [Required]
        public string ConfigurationValue { get; set; }
        public string ConfigurationValueType { get; set; }
        public bool Active { get; set; }
        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
    }
}
