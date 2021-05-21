using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("DashboardMenus", Schema = "dbo")]
    public partial class DashboardMenu
    {
        public DashboardMenu()
        {
            RoleMenuMappings = new HashSet<RoleMenuMapping>();
        }

        [Key]
        public int MenuId { get; set; }
        [StringLength(50)]
        public string MenuName { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public int? ParentId { get; set; }
        [Column("PageURL")]
        [StringLength(100)]
        public string PageUrl { get; set; }
        public int? Sequence { get; set; }
        public bool? Status { get; set; }

        [InverseProperty(nameof(RoleMenuMapping.Menu))]
        public virtual ICollection<RoleMenuMapping> RoleMenuMappings { get; set; }
    }
}
