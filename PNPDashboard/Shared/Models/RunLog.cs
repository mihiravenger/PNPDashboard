using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PNPDashboard.Shared.Models
{
    [Table("RunLogs", Schema = "dbo")]
    public partial class RunLog
    {
        public RunLog()
        {
            FileLogs = new HashSet<FileLog>();
        }

        [Key]
        public long RunId { get; set; }
        [Required]
        [StringLength(10)]
        public string StartDate { get; set; }
        [Required]
        [StringLength(20)]
        public string StartTime { get; set; }
        [StringLength(10)]
        public string EndDate { get; set; }
        [StringLength(20)]
        public string EndTime { get; set; }
        public bool IsRetryRun { get; set; }
        [Required]
        [StringLength(100)]
        public string Status { get; set; }
        [StringLength(2000)]
        public string ErrorMessage { get; set; }
        public int CountryId { get; set; }
        [StringLength(50)]
        public string Runtype { get; set; }
        public bool? IsActiveRun { get; set; }
        public int? NoOfFiles { get; set; }
        public int? NoOfProcessedFiles { get; set; }
        public int? NoOfInvalidFiles { get; set; }
        public int? NoOfDuplicateFiles { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string RunOnDemandType { get; set; }

        [InverseProperty(nameof(FileLog.Run))]
        public virtual ICollection<FileLog> FileLogs { get; set; }
    }
}
