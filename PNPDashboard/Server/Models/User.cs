using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("Users", Schema = "dbo")]
    public partial class User
    {
        public User()
        {
            UserCountryMappings = new HashSet<UserCountryMapping>();
        }

        [Key]
        public int UserId { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        public bool Status { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [InverseProperty(nameof(UserCountryMapping.User))]
        public virtual ICollection<UserCountryMapping> UserCountryMappings { get; set; }
    }
}
