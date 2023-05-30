using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sp.AvSec.Mains
{
    [Table("PrintBatchDatas")]
    public class PrintBatchData: FullAuditedEntity<long>
    {
        [ForeignKey("PrintBatchId")]
        public PrintBatch PrintBatchFk { get; set; }
        public long? PrintBatchId { get; set; }

        public string PrintData { get; set; }
        public short PrintNum { get; set; }
    }
}
