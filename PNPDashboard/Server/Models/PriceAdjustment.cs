using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("PriceAdjustments", Schema = "dbo")]
    public partial class PriceAdjustment
    {
        [Key]
        [Column("PriceAdjustmentID")]
        public long PriceAdjustmentId { get; set; }
        [Column("SalesOrderID")]
        public long? SalesOrderId { get; set; }
        public long? LineItemId { get; set; }
        public long? ShipmentId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? NetPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Tax { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? GrossPrice { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? BasePrice { get; set; }
        [Column("PromotionID")]
        [StringLength(50)]
        public string PromotionId { get; set; }
        [StringLength(50)]
        public string CampaignId { get; set; }
        [StringLength(50)]
        public string CouponId { get; set; }
        [StringLength(50)]
        public string LineItemText { get; set; }
        [Column("PriceAdjustmentTypeID")]
        public int? PriceAdjustmentTypeId { get; set; }

        [ForeignKey(nameof(LineItemId))]
        [InverseProperty("PriceAdjustments")]
        public virtual LineItem LineItem { get; set; }
        [ForeignKey(nameof(PriceAdjustmentTypeId))]
        [InverseProperty("PriceAdjustments")]
        public virtual PriceAdjustmentType PriceAdjustmentType { get; set; }
        [ForeignKey(nameof(SalesOrderId))]
        [InverseProperty("PriceAdjustments")]
        public virtual SalesOrder SalesOrder { get; set; }
        [ForeignKey(nameof(ShipmentId))]
        [InverseProperty("PriceAdjustments")]
        public virtual Shipment Shipment { get; set; }
    }
}
