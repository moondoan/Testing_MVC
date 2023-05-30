using Abp.Application.Services.Dto;

namespace Sp.AvSec.Mains.PrintBatches.Dto
{
    public class GetAllPrintPatchInput: PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
        public string NameFilter { get; set; }
    }
}
