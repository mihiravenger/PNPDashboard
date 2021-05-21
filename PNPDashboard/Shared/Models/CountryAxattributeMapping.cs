using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("CountryAXAttributeMapping", Schema = "dbo")]
    public partial class CountryAxattributeMapping
    {
        public CountryAxattributeMapping()
        {
            AxattributeDetails = new HashSet<AxattributeDetail>();
        }

        [Key]
        [Column("CountryAXAttributeMappingID")]
        public int CountryAxattributeMappingId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [Column("AXAttributeID")]
        public int? AxattributeId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsCustomer { get; set; }
        public bool? IsSalesorder { get; set; }
        public bool? IsPayment { get; set; }
        public bool? IsFreeTextInvoice { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }

        [ForeignKey(nameof(AxattributeId))]
        [InverseProperty(nameof(AxattributeMaster.CountryAxattributeMappings))]
        public virtual AxattributeMaster Axattribute { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty("CountryAxattributeMappings")]
        public virtual Country Country { get; set; }
        [InverseProperty(nameof(AxattributeDetail.CountryAxattributeMapping))]
        public virtual ICollection<AxattributeDetail> AxattributeDetails { get; set; }
    }
}
