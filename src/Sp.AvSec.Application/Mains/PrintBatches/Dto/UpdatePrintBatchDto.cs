using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace Sp.AvSec.Mains.PrintBatches.Dto
{
    public class UpdatePrintBatchDto: EntityDto<long>
    {
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
