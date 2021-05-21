using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("CountryConfiguration", Schema = "dbo")]
    public partial class CountryConfiguration
    {
        [Key]
        [Column("CountryConfigID")]
        public int CountryConfigId { get; set; }
        public int? CountryId { get; set; }
        [StringLength(100)]
        public string Country { get; set; }
        [StringLength(100)]
        public string Currency { get; set; }
        [StringLength(100)]
        public string Locale { get; set; }
        public bool? IsActive { get; set; }
        [Column("DAXCompany")]
        [StringLength(100)]
        public string Daxcompany { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastModifiedDate { get; set; }
        [StringLength(100)]
        public string Language { get; set; }
        public int? AutoRetryInterval { get; set; }
        public int? AutoRetryAllowableCount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MaxVariation { get; set; }
        [Column("CashNCarryAction")]
        public int? CashNcarryAction { get; set; }
        [StringLength(100)]
        public string CountryFullName { get; set; }
        [Column("AIFStandardServiceURL")]
        [StringLength(200)]
        public string AifstandardServiceUrl { get; set; }
        [Column("AIFCustomServiceURL")]
        [StringLength(200)]
        public string AifcustomServiceUrl { get; set; }
        [Column("AIFContactInfoServiceURL")]
        [StringLength(200)]
        public string AifcontactInfoServiceUrl { get; set; }
        [Column("AIFCityAddressServiceURL")]
        [StringLength(200)]
        public string AifcityAddressServiceUrl { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("CountryConfigurations")]
        public virtual Country CountryNavigation { get; set; }
    }
}
