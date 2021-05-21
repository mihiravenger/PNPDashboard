using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("Personalisation", Schema = "dbo")]
    public partial class Personalisation
    {
        [Key]
        [Column("PersonalisationID")]
        public long PersonalisationId { get; set; }
        [Column("LineItemID")]
        public long? LineItemId { get; set; }
        [StringLength(50)]
        public string PersonalisationKey { get; set; }
        [StringLength(100)]
        public string PersonalisationValue { get; set; }

        [ForeignKey(nameof(LineItemId))]
        [InverseProperty("Personalisations")]
        public virtual LineItem LineItem { get; set; }
    }
}
