using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("Authentication", Schema = "dbo")]
    public partial class Authentication
    {
        [Key]
        public int AuthenticationId { get; set; }
        [StringLength(50)]
        public string ClientId { get; set; }
        [StringLength(50)]
        public string AuthenticationKey { get; set; }
        public int? CountryId { get; set; }
        public bool? IsActive { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Authentications")]
        public virtual Country Country { get; set; }
    }
}
