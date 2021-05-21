using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("FileLogs", Schema = "dbo")]
    public partial class FileLog
    {
        public FileLog()
        {
            OrderLogs = new HashSet<OrderLog>();
        }

        [Key]
        public long FileId { get; set; }
        public long RunId { get; set; }
        [StringLength(100)]
        public string SourceFileName { get; set; }
        [StringLength(100)]
        public string DestFileName { get; set; }
        public int? NoOfOrders { get; set; }
        public long? FileSize { get; set; }
        [Column("OrderXML", TypeName = "xml")]
        public string OrderXml { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(2000)]
        public string ErrorMessage { get; set; }
        public bool ShouldRetry { get; set; }
        public int CountryId { get; set; }
        [StringLength(100)]
        public string LastModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastModifiedDate { get; set; }
        public int? NoOfOrderProcessed { get; set; }
        public int? NoOfOrderFailed { get; set; }
        public int? NoOfIgnoredOrder { get; set; }

        [ForeignKey(nameof(RunId))]
        [InverseProperty(nameof(RunLog.FileLogs))]
        public virtual RunLog Run { get; set; }
        [InverseProperty(nameof(OrderLog.File))]
        public virtual ICollection<OrderLog> OrderLogs { get; set; }
    }
}
