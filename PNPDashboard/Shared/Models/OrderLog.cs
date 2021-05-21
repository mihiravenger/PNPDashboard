using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("OrderLogs", Schema = "dbo")]
    public partial class OrderLog
    {
        [Key]
        public long OrderId { get; set; }
        public long FileId { get; set; }
        [StringLength(50)]
        public string OrderNo { get; set; }
        [Column("OrderXML", TypeName = "xml")]
        public string OrderXml { get; set; }
        public bool ShouldRetry { get; set; }
        public int? NoOfRetry { get; set; }
        [Required]
        [StringLength(100)]
        public string Status { get; set; }
        public int CountryId { get; set; }
        [StringLength(2000)]
        public string ErrorMessage { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastModifiedDate { get; set; }
        [Column("OrderUpdateSentToOMS")]
        public bool? OrderUpdateSentToOms { get; set; }

        [ForeignKey(nameof(FileId))]
        [InverseProperty(nameof(FileLog.OrderLogs))]
        public virtual FileLog File { get; set; }
    }
}
