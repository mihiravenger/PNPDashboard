using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("SourceMaster", Schema = "dbo")]
    public partial class SourceMaster
    {
        public SourceMaster()
        {
            CountrySourceCreatedByAttributeMappings = new HashSet<CountrySourceCreatedByAttributeMapping>();
            CountrySourceMappings = new HashSet<CountrySourceMapping>();
            SourcePaymentMappings = new HashSet<SourcePaymentMapping>();
        }

        [Key]
        [Column("SourceID")]
        public int SourceId { get; set; }
        [StringLength(500)]
        public string SourceName { get; set; }
        [StringLength(500)]
        public string SourceValue { get; set; }
        [StringLength(500)]
        public string XmlAttribute { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MaxVariation { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [InverseProperty(nameof(CountrySourceCreatedByAttributeMapping.Source))]
        public virtual ICollection<CountrySourceCreatedByAttributeMapping> CountrySourceCreatedByAttributeMappings { get; set; }
        [InverseProperty(nameof(CountrySourceMapping.Source))]
        public virtual ICollection<CountrySourceMapping> CountrySourceMappings { get; set; }
        [InverseProperty(nameof(SourcePaymentMapping.Source))]
        public virtual ICollection<SourcePaymentMapping> SourcePaymentMappings { get; set; }
    }
}
