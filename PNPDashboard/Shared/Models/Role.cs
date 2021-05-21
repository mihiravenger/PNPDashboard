using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("Roles", Schema = "dbo")]
    public partial class Role
    {
        public Role()
        {
            RoleMenuMappings = new HashSet<RoleMenuMapping>();
            UserCountryMappings = new HashSet<UserCountryMapping>();
        }

        [Key]
        public int RoleId { get; set; }
        [StringLength(50)]
        public string RoleName { get; set; }
        public bool? Status { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [InverseProperty(nameof(RoleMenuMapping.Role))]
        public virtual ICollection<RoleMenuMapping> RoleMenuMappings { get; set; }
        [InverseProperty(nameof(UserCountryMapping.Role))]
        public virtual ICollection<UserCountryMapping> UserCountryMappings { get; set; }
    }
}
