using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sp.AvSec.Mains
{
    [Table("CardPrintQueueLogs")]
    public class CardPrintQueueLog : FullAuditedEntity<long>
    {
        [Required]
        [StringLength(64)]
        public string ReportFileName { get; set; }

        [Required]
        [StringLength(512)]
        public string ReportUrl { get; set; }

        [Required]
        [StringLength(64)]
        public string ReportPrintName { get; set; }

        [Required]
        public string ReportDataJson { get; set; }

        [Required]
        [StringLength(36)]
        public string ReportStatus { get; set; }

        [StringLength(512)]
        public string ReportError { get; set; }

        public int ReportCount { get; set; }

        [StringLength(36)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(36)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
