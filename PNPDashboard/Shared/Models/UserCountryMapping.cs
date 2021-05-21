using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("UserCountryMapping", Schema = "dbo")]
    [Index(nameof(UserId), nameof(CountryId), Name = "IX_UserCountryMapping", IsUnique = true)]
    public partial class UserCountryMapping
    {
        [Key]
        public int UserCountryId { get; set; }
        public int UserId { get; set; }
        public int CountryId { get; set; }
        public bool Status { get; set; }
        public bool IsDefault { get; set; }
        public int RoleId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("UserCountryMappings")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(RoleId))]
        [InverseProperty("UserCountryMappings")]
        public virtual Role Role { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserCountryMappings")]
        public virtual User User { get; set; }
    }
}
