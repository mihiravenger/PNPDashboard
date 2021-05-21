using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("CustomerAddressDetails", Schema = "dbo")]
    public partial class CustomerAddressDetail
    {
        public CustomerAddressDetail()
        {
            SalesOrders = new HashSet<SalesOrder>();
            Shipments = new HashSet<Shipment>();
        }

        [Key]
        [Column("CustomerAddressID")]
        public long CustomerAddressId { get; set; }
        [Column("CustomerID")]
        public long? CustomerId { get; set; }
        [StringLength(10)]
        public string AddressType { get; set; }
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string AddressLine1 { get; set; }
        [StringLength(250)]
        public string AddressLine2 { get; set; }
        [StringLength(60)]
        public string City { get; set; }
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(10)]
        public string StateCode { get; set; }
        [StringLength(10)]
        public string CountryCode { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(80)]
        public string Email { get; set; }
        public int? LocationId { get; set; }
        [StringLength(200)]
        public string RowStatus { get; set; }
        [StringLength(200)]
        public string HouseNo { get; set; }
        [StringLength(50)]
        public string EveningPhone { get; set; }
        public string ErrorMessage { get; set; }
        public string AdditionalInfo { get; set; }
        [StringLength(250)]
        public string Address3 { get; set; }
        [Column("ContactInfoLocationID")]
        [StringLength(50)]
        public string ContactInfoLocationId { get; set; }
        [Column("AXLocationId")]
        [StringLength(50)]
        public string AxlocationId { get; set; }
        [StringLength(250)]
        public string BillToStreet { get; set; }
        [Column("salutation")]
        [StringLength(10)]
        public string Salutation { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("CustomerAddressDetails")]
        public virtual Customer Customer { get; set; }
        [InverseProperty(nameof(SalesOrder.BillingAddress))]
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        [InverseProperty(nameof(Shipment.ShippingAddress))]
        public virtual ICollection<Shipment> Shipments { get; set; }
    }
}
