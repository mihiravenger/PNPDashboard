using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("LineItems", Schema = "dbo")]
    public partial class LineItem
    {
        public LineItem()
        {
            DispatchedOrders = new HashSet<DispatchedOrder>();
            Personalisations = new HashSet<Personalisation>();
            PriceAdjustments = new HashSet<PriceAdjustment>();
        }

        [Key]
        [Column("LineItemID")]
        public long LineItemId { get; set; }
        [Column("SalesOrderID")]
        public long SalesOrderId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? NetPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Tax { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? GrossPrice { get; set; }
        [Required]
        [Column("ProductID")]
        [StringLength(40)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(2000)]
        public string ProductName { get; set; }
        [StringLength(50)]
        public string VariantNo { get; set; }
        public int? Quantity { get; set; }
        [StringLength(100)]
        public string TaxRate { get; set; }
        public bool? IsGift { get; set; }
        [StringLength(4000)]
        public string GiftMessage { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? GiftPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PersonalisationCharges { get; set; }
        [StringLength(100)]
        public string HandlingMessage { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? GiftCharge { get; set; }
        [Column("ShipmentID")]
        [StringLength(512)]
        public string ShipmentId { get; set; }
        public int? LineId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AxLineAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AxUnitPrice { get; set; }
        public int? AxQuantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AxDiscount { get; set; }
        [StringLength(100)]
        public string ShippingStatus { get; set; }
        public int? QtyShipped { get; set; }
        [StringLength(200)]
        public string RowStatus { get; set; }
        public string ErrorMessage { get; set; }
        public string AdditionalInfo { get; set; }
        [StringLength(50)]
        public string CashnCarry { get; set; }
        [Column("AxInventTransID")]
        [StringLength(20)]
        public string AxInventTransId { get; set; }
        [Column("ManufacturerID")]
        [StringLength(40)]
        public string ManufacturerId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DeliveryDate { get; set; }
        [StringLength(100)]
        public string Configuration { get; set; }
        public string ChargeCode { get; set; }

        [ForeignKey(nameof(SalesOrderId))]
        [InverseProperty("LineItems")]
        public virtual SalesOrder SalesOrder { get; set; }
        [InverseProperty(nameof(DispatchedOrder.LineItem))]
        public virtual ICollection<DispatchedOrder> DispatchedOrders { get; set; }
        [InverseProperty(nameof(Personalisation.LineItem))]
        public virtual ICollection<Personalisation> Personalisations { get; set; }
        [InverseProperty(nameof(PriceAdjustment.LineItem))]
        public virtual ICollection<PriceAdjustment> PriceAdjustments { get; set; }
    }
}
