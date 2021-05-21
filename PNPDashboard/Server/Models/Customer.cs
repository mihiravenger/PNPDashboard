using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Server.Models
{
    [Table("Customers", Schema = "dbo")]
    public partial class Customer
    {
        public Customer()
        {
            CustomerAddressDetails = new HashSet<CustomerAddressDetail>();
            SalesOrders = new HashSet<SalesOrder>();
        }

        [Key]
        [Column("CustomerID")]
        public long CustomerId { get; set; }
        [Column("CountryID")]
        public int? CountryId { get; set; }
        [StringLength(30)]
        public string ExternalCustomerNo { get; set; }
        [Column("AxCustomerID")]
        [StringLength(20)]
        public string AxCustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AxValidAsOfDateTime { get; set; }
        [StringLength(50)]
        public string AxValidTimeStateType { get; set; }
        [StringLength(200)]
        public string AxCustDocumentHash { get; set; }
        [Column("AxPartyRecID")]
        public int? AxPartyRecId { get; set; }
        public int? AxPartyRecVersion { get; set; }
        [StringLength(200)]
        public string RowStatus { get; set; }
        public string ErrorMessage { get; set; }
        [Column("IsDimensionsUpdatedInAX")]
        public bool? IsDimensionsUpdatedInAx { get; set; }

        [InverseProperty(nameof(CustomerAddressDetail.Customer))]
        public virtual ICollection<CustomerAddressDetail> CustomerAddressDetails { get; set; }
        [InverseProperty(nameof(SalesOrder.Customer))]
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
