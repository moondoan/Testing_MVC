using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Sp.AvSec.Authorization;
using Sp.AvSec.CardTemplates.Dto;
using Sp.AvSec.Mains;
using Sp.AvSec.Mains.CardTemplates.Dto;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace Sp.AvSec.CardTemplates
{
    [AbpAuthorize(PermissionNames.Pages_CardTemplates)]
    public class CardTemplateAppService : AvSecAppServiceBase, ICardTemplateAppService
    {
        private readonly IRepository<CardTemplate, int> _cardTemplateRepository;

        public CardTemplateAppService(IRepository<CardTemplate, int> cardTemplateRepository)
        {
            _cardTemplateRepository = cardTemplateRepository;
        }

        public async Task<PagedResultDto<CardTemplateDto>> GetPagedAsync(GetPagedCardTemplateInput input)
        {
            var filteredQuery = _cardTemplateRepository.GetAll().Where(x => x.Name.Contains(input.Filter));

            var pagedAndFiltereCardTemplates = SortingDatas(filteredQuery, input.Sorting).PageBy(input);

            var cardTemplates = await pagedAndFiltereCardTemplates.Select(c => new CardTemplateDto
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                FileName = c.FileName,
                FilePath = c.FilePath,
                IsActive = c.IsActive
            }).ToDynamicListAsync<CardTemplateDto>();

            var totalCount = filteredQuery.Count();

            return new PagedResultDto<CardTemplateDto>(
               totalCount,
               cardTemplates
           );
        }

        #region Private && Protected Method
        private IQueryable<CardTemplate> SortingDatas(IQueryable<CardTemplate> pagedAndFiltered, string sorting)
        {
            if (string.IsNullOrEmpty(sorting))
                return pagedAndFiltered.OrderBy(x => x.Id);

            if (sorting.Contains("Name"))
            {
                if (sorting.Contains("DESC"))
                {
                    return pagedAndFiltered.OrderByDescending(x => x.Name);
                }

                return pagedAndFiltered.OrderBy(x => x.Name);
            }

            return pagedAndFiltered.OrderByDescending(x => x.CreationTime);
        }
        #endregion
    }
}
