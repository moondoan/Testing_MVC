using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sp.AvSec.Mains
{
    [Table("PrintBatches")]
    public class PrintBatch: FullAuditedEntity<long>
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
