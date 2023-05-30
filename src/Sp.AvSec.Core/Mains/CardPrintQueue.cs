using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sp.AvSec.Mains
{
    [Table("CardPrintQueues")]
    public class CardPrintQueue: FullAuditedEntity<long>
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

        [StringLength(36)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
