using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("DispatchedOrders", Schema = "dbo")]
    public partial class DispatchedOrder
    {
        [Key]
        [Column("DispatchedOrderUpdateID")]
        public long DispatchedOrderUpdateId { get; set; }
        [Column("SalesOrderID")]
        public long? SalesOrderId { get; set; }
        [Column("LineItemID")]
        public long? LineItemId { get; set; }
        public int? QtyShipped { get; set; }
        [StringLength(100)]
        public string CarrierName { get; set; }
        [StringLength(100)]
        public string CarrierTrackingNumber { get; set; }
        [Column("CarrierURL")]
        [StringLength(200)]
        public string CarrierUrl { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LineDispatchTime { get; set; }
        [StringLength(100)]
        public string LineStatus { get; set; }
        [Column("LineID")]
        public int? LineId { get; set; }
        [Column("AxSalesOrderID")]
        [StringLength(100)]
        public string AxSalesOrderId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [Column("PackingSlipID")]
        [StringLength(100)]
        public string PackingSlipId { get; set; }
        [StringLength(100)]
        public string RowStatus { get; set; }
        [Column("SourceID")]
        public int? SourceId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("DispatchedOrders")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(LineItemId))]
        [InverseProperty("DispatchedOrders")]
        public virtual LineItem LineItem { get; set; }
        [ForeignKey(nameof(SalesOrderId))]
        [InverseProperty("DispatchedOrders")]
        public virtual SalesOrder SalesOrder { get; set; }
    }
}
