using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("PriceAdjustmentType", Schema = "dbo")]
    public partial class PriceAdjustmentType
    {
        public PriceAdjustmentType()
        {
            PriceAdjustments = new HashSet<PriceAdjustment>();
        }

        [Key]
        [Column("PriceAdjustmentTypeID")]
        public int PriceAdjustmentTypeId { get; set; }
        [Column("PriceAdjustmentType")]
        [StringLength(100)]
        public string PriceAdjustmentType1 { get; set; }

        [InverseProperty(nameof(PriceAdjustment.PriceAdjustmentType))]
        public virtual ICollection<PriceAdjustment> PriceAdjustments { get; set; }
    }
}
