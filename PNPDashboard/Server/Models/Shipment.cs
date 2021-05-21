using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("Shipments", Schema = "dbo")]
    public partial class Shipment
    {
        public Shipment()
        {
            PriceAdjustments = new HashSet<PriceAdjustment>();
        }

        [Key]
        [Column("ShipmentsID")]
        public long ShipmentsId { get; set; }
        [Column("SalesOrderID")]
        public long SalesOrderId { get; set; }
        [Column("OrderShipmentID")]
        [StringLength(512)]
        public string OrderShipmentId { get; set; }
        [StringLength(512)]
        public string ShipmentMethod { get; set; }
        [Column("ShippingAddressID")]
        public long ShippingAddressId { get; set; }
        public bool? IsGift { get; set; }
        [StringLength(4000)]
        public string GiftMessage { get; set; }
        [StringLength(100)]
        public string TaxRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ShipmentNetPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ShipmentTax { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ShipmentGrossPrice { get; set; }
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
        [StringLength(200)]
        public string ShippingStatus { get; set; }
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
        [StringLength(200)]
        public string RowStatus { get; set; }
        public string ErrorMessage { get; set; }
        public string AdditionalInfo { get; set; }
        [StringLength(512)]
        public string SourceShipmentMethod { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? HeaderFreightChargeGrossPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? HeaderFreightChargeNetPrice { get; set; }

        [ForeignKey(nameof(SalesOrderId))]
        [InverseProperty("Shipments")]
        public virtual SalesOrder SalesOrder { get; set; }
        [ForeignKey(nameof(ShippingAddressId))]
        [InverseProperty(nameof(CustomerAddressDetail.Shipments))]
        public virtual CustomerAddressDetail ShippingAddress { get; set; }
        [InverseProperty(nameof(PriceAdjustment.Shipment))]
        public virtual ICollection<PriceAdjustment> PriceAdjustments { get; set; }
    }
}
