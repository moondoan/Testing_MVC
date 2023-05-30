using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Sp.AvSec.Authorization;
using Sp.AvSec.Mains.PrintBatches.Dto;
using System.Linq;
using System.Threading.Tasks;

namespace Sp.AvSec.Mains.PrintBatches
{
    [AbpAuthorize(PermissionNames.Pages_PrintBatches)]
    public class PrintBatchService : AsyncCrudAppService<PrintBatch, PrintBatchDto, long, GetAllPrintPatchInput, CreatePrintBatchDto, UpdatePrintBatchDto>, IPrintBatchService
    {
        private readonly IRepository<PrintBatch, long> _printBatchRepository;

        public PrintBatchService(IRepository<PrintBatch, long> printBatchRepository): base(printBatchRepository)
        {
            _printBatchRepository = printBatchRepository;
        }

        public async Task<PagedResultDto<PrintBatchDto>> GetPagedAsync(GetAllPrintPatchInput input)
        {
            var filteredQuery = _printBatchRepository.GetAll()
                       .WhereIf(!string.IsNullOrWhiteSpace(input.Filter), e => false || e.Name.Contains(input.Filter))
                       .WhereIf(!string.IsNullOrWhiteSpace(input.NameFilter), e => e.Name == input.NameFilter);

            var sortAndPagedQuery = SortingDatas(filteredQuery, input.Sorting).PageBy(input);

            var totalCount = await base.AsyncQueryableExecuter.CountAsync(filteredQuery);

            var entities = await base.AsyncQueryableExecuter.ToListAsync(sortAndPagedQuery);

            return new PagedResultDto<PrintBatchDto>(
               totalCount,
               entities.Select(MapToEntityDto).ToList()
           );
        }

        #region Private && Protected Method
        private IQueryable<PrintBatch> SortingDatas(IQueryable<PrintBatch> pagedAndFiltered, string sorting)
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
