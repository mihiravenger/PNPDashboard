using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("AXAttributeDetail", Schema = "dbo")]
    public partial class AxattributeDetail
    {
        [Key]
        [Column("AXAttributeDetailID")]
        public int AxattributeDetailId { get; set; }
        [Column("CountryAXAttributeMappingID")]
        public int? CountryAxattributeMappingId { get; set; }
        [Column("AXAttributeValue")]
        [StringLength(500)]
        public string AxattributeValue { get; set; }
        [Column("AXAttributeGroupID")]
        public int? AxattributeGroupId { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [ForeignKey(nameof(AxattributeGroupId))]
        [InverseProperty("AxattributeDetails")]
        public virtual AxattributeGroup AxattributeGroup { get; set; }
        [ForeignKey(nameof(CountryAxattributeMappingId))]
        [InverseProperty("AxattributeDetails")]
        public virtual CountryAxattributeMapping CountryAxattributeMapping { get; set; }
    }
}
