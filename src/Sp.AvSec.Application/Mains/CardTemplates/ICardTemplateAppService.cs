using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sp.AvSec.CardTemplates.Dto;
using Sp.AvSec.Mains.CardTemplates.Dto;
using System.Threading.Tasks;

namespace Sp.AvSec.CardTemplates
{
    public interface ICardTemplateAppService
    {
        Task<PagedResultDto<CardTemplateDto>> GetPagedAsync(GetPagedCardTemplateInput input);
    }
}
