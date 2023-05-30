using Abp.Application.Services.Dto;

namespace Sp.AvSec.Mains.CardTemplates.Dto
{
    public class GetPagedCardTemplateInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
