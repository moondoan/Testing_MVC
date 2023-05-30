using Abp.Application.Services.Dto;
using Sp.AvSec.CardTemplates.Dto;

namespace Sp.AvSec.Mvc.Models.CardTemplates
{
    public class CardTemplateListViewModel
    {
        public PagedResultDto<CardTemplateDto> CardTemplates { get; set; }
    }
}