using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("IntegrationRequests", Schema = "dbo")]
    public partial class IntegrationRequest
    {
        [Key]
        [Column("IntegrationRequestID")]
        public long IntegrationRequestId { get; set; }
        [Column("RequestMessageID")]
        public Guid RequestMessageId { get; set; }
        [StringLength(50)]
        public string RequestType { get; set; }
        [StringLength(100)]
        public string RequestEntity { get; set; }
        public long? InputParameter1 { get; set; }
        [StringLength(50)]
        public string RequestStatus { get; set; }
        public string ErrorMessage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequestStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RequestEndDate { get; set; }
        public long? SalesOrderId { get; set; }
        public long? RetriedFor { get; set; }
        [Column("OriginalRequestID")]
        public long? OriginalRequestId { get; set; }
        [StringLength(50)]
        public string RetriedBy { get; set; }
        [StringLength(50)]
        public string ExecutionMode { get; set; }
        public string DetailedErrorMessage { get; set; }
        public bool? IsAvailableForManualRetry { get; set; }
        [Column("AIFErrorMessage")]
        public string AiferrorMessage { get; set; }
        [Column("AIFRequest", TypeName = "xml")]
        public string Aifrequest { get; set; }
        [Column("AIFResponse", TypeName = "xml")]
        public string Aifresponse { get; set; }
        [Column("AIFRequestSize")]
        public long? AifrequestSize { get; set; }
        [Column("AIFResponseSize")]
        public long? AifresponseSize { get; set; }

        [ForeignKey(nameof(SalesOrderId))]
        [InverseProperty("IntegrationRequests")]
        public virtual SalesOrder SalesOrder { get; set; }
    }
}
