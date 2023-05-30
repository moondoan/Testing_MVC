using Abp.Application.Services.Dto;

namespace Sp.AvSec.Mains.PrintBatches.Dto
{
    public class PrintBatchDto: EntityDto<long>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
