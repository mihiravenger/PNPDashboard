using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("SourcePaymentMapping", Schema = "dbo")]
    public partial class SourcePaymentMapping
    {
        [Key]
        [Column("SourcePaymentMappingID")]
        public int SourcePaymentMappingId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [Column("SourceID")]
        public int? SourceId { get; set; }
        [StringLength(100)]
        public string SourcePaymentMethodType { get; set; }
        [Column("AXPaymentMethodType")]
        [StringLength(100)]
        public string AxpaymentMethodType { get; set; }
        [StringLength(100)]
        public string SourceTransactionStatus { get; set; }
        [Column("AXTransactionStatus")]
        [StringLength(100)]
        public string AxtransactionStatus { get; set; }
        [Column("AXDeliveryTerm")]
        [StringLength(100)]
        public string AxdeliveryTerm { get; set; }
        [Column("AXPaymentTerm")]
        [StringLength(100)]
        public string AxpaymentTerm { get; set; }
        public bool? CreatePaymentJournal { get; set; }
        public bool? CreateAuthEntry { get; set; }
        public bool? UpgradeToSales { get; set; }
        public bool? CreatePaymentFee { get; set; }
        [Column("AXOffsetAccount")]
        [StringLength(100)]
        public string AxoffsetAccount { get; set; }
        [Column("AXFeeCode")]
        [StringLength(100)]
        public string AxfeeCode { get; set; }
        [Column("FinancialDimensionGroupID")]
        public int? FinancialDimensionGroupId { get; set; }
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
        [InverseProperty("SourcePaymentMappings")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(SourceId))]
        [InverseProperty(nameof(SourceMaster.SourcePaymentMappings))]
        public virtual SourceMaster Source { get; set; }
    }
}
