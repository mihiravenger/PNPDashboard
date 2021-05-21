using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("AXAttributeGroup", Schema = "dbo")]
    public partial class AxattributeGroup
    {
        public AxattributeGroup()
        {
            AxattributeDetails = new HashSet<AxattributeDetail>();
            CountrySourceCreatedByAttributeMappings = new HashSet<CountrySourceCreatedByAttributeMapping>();
        }

        [Key]
        [Column("AXAttributeGroupID")]
        public int AxattributeGroupId { get; set; }
        [Column("AXAttributeGroupName")]
        [StringLength(500)]
        public string AxattributeGroupName { get; set; }
        [StringLength(500)]
        public string Discription { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("AxattributeGroups")]
        public virtual Country Country { get; set; }
        [InverseProperty(nameof(AxattributeDetail.AxattributeGroup))]
        public virtual ICollection<AxattributeDetail> AxattributeDetails { get; set; }
        [InverseProperty(nameof(CountrySourceCreatedByAttributeMapping.AxattributeGroup))]
        public virtual ICollection<CountrySourceCreatedByAttributeMapping> CountrySourceCreatedByAttributeMappings { get; set; }
    }
}
