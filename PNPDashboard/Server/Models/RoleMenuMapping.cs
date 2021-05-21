using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("RoleMenuMapping", Schema = "dbo")]
    public partial class RoleMenuMapping
    {
        [Key]
        public int RoleMenuMappingId { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
        public int? AccessRights { get; set; }
        public bool? Status { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [ForeignKey(nameof(MenuId))]
        [InverseProperty(nameof(DashboardMenu.RoleMenuMappings))]
        public virtual DashboardMenu Menu { get; set; }
        [ForeignKey(nameof(RoleId))]
        [InverseProperty("RoleMenuMappings")]
        public virtual Role Role { get; set; }
    }
}
