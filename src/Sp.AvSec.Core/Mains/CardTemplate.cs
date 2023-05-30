using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sp.AvSec.Mains
{
    [Table("CardTemplates")]
    public class CardTemplate: FullAuditedEntity
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [StringLength(256)]
        public string FileName { get; set; }

        public string FilePath { get; set; }

        public bool IsActive { get; set; }
    }
}
