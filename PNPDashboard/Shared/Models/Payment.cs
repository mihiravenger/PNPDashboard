using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("Payments", Schema = "dbo")]
    public partial class Payment
    {
        [Key]
        [Column("PaymentID")]
        public long PaymentId { get; set; }
        [Column("SalesOrderID")]
        public long? SalesOrderId { get; set; }
        [StringLength(200)]
        public string MethodName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [StringLength(512)]
        public string ProcessorId { get; set; }
        [StringLength(96)]
        public string TransactionId { get; set; }
        [StringLength(200)]
        public string TransactionType { get; set; }
        [StringLength(200)]
        public string AuthAttemptId { get; set; }
        [StringLength(200)]
        public string AuthEffortId { get; set; }
        [StringLength(512)]
        public string TransactionResult { get; set; }
        [StringLength(200)]
        public string TransactionStatus { get; set; }
        [StringLength(200)]
        public string FraudCode { get; set; }
        [StringLength(200)]
        public string FraudResult { get; set; }
        [StringLength(200)]
        public string JournalId { get; set; }
        [StringLength(200)]
        public string VoucherId { get; set; }
        [StringLength(10)]
        public string TransactionCode { get; set; }
        [StringLength(200)]
        public string AccountNumber { get; set; }
        [StringLength(200)]
        public string PlanNumber { get; set; }
        [StringLength(200)]
        public string ApprovalCode { get; set; }
        [StringLength(200)]
        public string PaymentMethod { get; set; }
        [StringLength(200)]
        public string ChequeNumber { get; set; }
        [StringLength(200)]
        public string RoutingNumber { get; set; }
        [StringLength(50)]
        public string ReasonCode { get; set; }
        [StringLength(100)]
        public string CardHolderName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CardExpiryDate { get; set; }
        [StringLength(500)]
        public string ReplyMessage { get; set; }
        [StringLength(200)]
        public string MerchantId { get; set; }
        [StringLength(200)]
        public string ReferenceCode { get; set; }
        [StringLength(96)]
        public string MerchantReference { get; set; }
        [StringLength(50)]
        public string CreditCardAuthirization { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransactionDate { get; set; }
        [StringLength(100)]
        public string TransReferenceNumber { get; set; }
        [StringLength(100)]
        public string SubscriptionId { get; set; }
        [StringLength(100)]
        public string PostalMatch { get; set; }
        [Column("CVVValidation")]
        [StringLength(100)]
        public string Cvvvalidation { get; set; }
        [StringLength(100)]
        public string AccountSuffix { get; set; }
        [StringLength(100)]
        public string CyberSourceRequestToken { get; set; }
        [StringLength(100)]
        public string CyberRequestId { get; set; }
        public string ErrorMessage { get; set; }
        [StringLength(200)]
        public string RowStatus { get; set; }
        [Column("CreditDepositPaymentMethodID")]
        [StringLength(200)]
        public string CreditDepositPaymentMethodId { get; set; }
        [StringLength(50)]
        public string CreditDepositPercentage { get; set; }
        [StringLength(50)]
        public string CreditDuration { get; set; }
        [Column("ConvertedAXPayment")]
        [StringLength(100)]
        public string ConvertedAxpayment { get; set; }
        [StringLength(100)]
        public string ConvertedSourcePayment { get; set; }
        [StringLength(250)]
        public string PaymentNote { get; set; }

        [ForeignKey(nameof(SalesOrderId))]
        [InverseProperty("Payments")]
        public virtual SalesOrder SalesOrder { get; set; }
    }
}
