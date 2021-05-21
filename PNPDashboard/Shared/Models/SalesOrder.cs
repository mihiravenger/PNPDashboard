using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("SalesOrders", Schema = "dbo")]
    public partial class SalesOrder
    {
        public SalesOrder()
        {
            DispatchedOrders = new HashSet<DispatchedOrder>();
            IntegrationRequests = new HashSet<IntegrationRequest>();
            LineItems = new HashSet<LineItem>();
            Payments = new HashSet<Payment>();
            PriceAdjustments = new HashSet<PriceAdjustment>();
            Shipments = new HashSet<Shipment>();
        }

        [Key]
        [Column("SalesOrderID")]
        public long SalesOrderId { get; set; }
        [Column("CustomerID")]
        public long? CustomerId { get; set; }
        [Column("BillingAddressID")]
        public long? BillingAddressId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [Column("SourceID")]
        public int? SourceId { get; set; }
        [StringLength(100)]
        public string CreatedByAttribute { get; set; }
        [StringLength(100)]
        public string ExternalOrderNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        [StringLength(6)]
        public string Currency { get; set; }
        [StringLength(512)]
        public string CustomerLocale { get; set; }
        [StringLength(50)]
        public string OrderStatus { get; set; }
        [StringLength(50)]
        public string ShippingStatus { get; set; }
        [StringLength(50)]
        public string ConfirmationStatus { get; set; }
        [StringLength(50)]
        public string PaymentStatus { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MerchandizeNetPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MerchandizeTax { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MerchandizeGrossPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AdjMerchandizeNetPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AdjMerchandizeTax { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AdjMerchandizeGrossPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ShippingNetPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ShippingTax { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ShippingGrossPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AdjShippingNetPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AdjShippingTax { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AdjShippingGrossPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? OrderNetPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? OrderTax { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? OrderGrossPrice { get; set; }
        public bool? IsFulFilFromPartner { get; set; }
        [Column("FulFilFromPartnerID")]
        [StringLength(512)]
        public string FulFilFromPartnerId { get; set; }
        [Column("AxSalesOrderID")]
        [StringLength(100)]
        public string AxSalesOrderId { get; set; }
        [StringLength(200)]
        public string RowStatus { get; set; }
        public string ErrorMessage { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AxTotalBalance { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AxTotalInvoice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AxTotalMiscCharges { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AxTotalSalesTax { get; set; }
        [StringLength(200)]
        public string AxDocumentHash { get; set; }
        public bool? IsNewCustomer { get; set; }
        public bool? IsConvertedToSales { get; set; }
        [StringLength(50)]
        public string DispatchOrderStatus { get; set; }
        public string AdditionalInfo { get; set; }
        [StringLength(200)]
        public string LocationId { get; set; }
        public int? NumberOfAutoRetries { get; set; }
        public bool? IsAutoRetry { get; set; }
        public int? NumberOfManualRetries { get; set; }
        public bool? IsAvailableForManualRetry { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        public string ClientId { get; set; }
        public bool MarkForResend { get; set; }
        [Column("AxInvoiceID")]
        [StringLength(100)]
        public string AxInvoiceId { get; set; }
        public bool? IsBillingAddressExists { get; set; }
        public bool? IsShippingAddressExists { get; set; }
        public int? AffiliateId { get; set; }
        [Column("PackingSlipID")]
        [StringLength(100)]
        public string PackingSlipId { get; set; }
        [Column("CashNCarryInvoiceID")]
        [StringLength(100)]
        public string CashNcarryInvoiceId { get; set; }
        [StringLength(100)]
        public string PaymentTerms { get; set; }
        [StringLength(100)]
        public string Segment { get; set; }
        [StringLength(100)]
        public string WareHouse { get; set; }
        [StringLength(100)]
        public string MediaKey { get; set; }
        [StringLength(10)]
        public string DeliveryIndicator { get; set; }
        public bool? IsInProgress { get; set; }
        public int SalesOrderStatus { get; set; }
        [StringLength(200)]
        public string CustomerRef { get; set; }
        [Column("OrderUpdateSentToOMS")]
        public bool? OrderUpdateSentToOms { get; set; }

        [ForeignKey(nameof(BillingAddressId))]
        [InverseProperty(nameof(CustomerAddressDetail.SalesOrders))]
        public virtual CustomerAddressDetail BillingAddress { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty("SalesOrders")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("SalesOrders")]
        public virtual Customer Customer { get; set; }
        [InverseProperty(nameof(DispatchedOrder.SalesOrder))]
        public virtual ICollection<DispatchedOrder> DispatchedOrders { get; set; }
        [InverseProperty(nameof(IntegrationRequest.SalesOrder))]
        public virtual ICollection<IntegrationRequest> IntegrationRequests { get; set; }
        [InverseProperty(nameof(LineItem.SalesOrder))]
        public virtual ICollection<LineItem> LineItems { get; set; }
        [InverseProperty(nameof(Payment.SalesOrder))]
        public virtual ICollection<Payment> Payments { get; set; }
        [InverseProperty(nameof(PriceAdjustment.SalesOrder))]
        public virtual ICollection<PriceAdjustment> PriceAdjustments { get; set; }
        [InverseProperty(nameof(Shipment.SalesOrder))]
        public virtual ICollection<Shipment> Shipments { get; set; }
    }
}
