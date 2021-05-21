using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("AXAttributeMaster", Schema = "dbo")]
    public partial class AxattributeMaster
    {
        public AxattributeMaster()
        {
            CountryAxattributeMappings = new HashSet<CountryAxattributeMapping>();
        }

        [Key]
        [Column("AXAttributeID")]
        public int AxattributeId { get; set; }
        [Column("AXAttributeName")]
        [StringLength(500)]
        public string AxattributeName { get; set; }
        [StringLength(500)]
        public string Discription { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [InverseProperty(nameof(CountryAxattributeMapping.Axattribute))]
        public virtual ICollection<CountryAxattributeMapping> CountryAxattributeMappings { get; set; }
    }
}
