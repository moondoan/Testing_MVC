using System.ComponentModel.DataAnnotations;

namespace Sp.AvSec.Mains.PrintBatches.Dto
{
    public class CreatePrintBatchDto
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
