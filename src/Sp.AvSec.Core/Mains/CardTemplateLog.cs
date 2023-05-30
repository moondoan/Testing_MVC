using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sp.AvSec.Mains
{
    [Table("CardTemplateLogs")]
    public class CardTemplateLog: FullAuditedEntity
    {
        [ForeignKey("CardTemplateId")]
        public CardTemplate CardTemplateFk { get; set; }
        public int? CardTemplateId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [StringLength(256)]
        public string FileName { get; set; }

        public string FilePath { get; set; }

        [StringLength(32)]
        public string ActionType { get; set; }
    }
}
