using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sp.AvSec.Mains.PrintBatches.Dto;
using System.Threading.Tasks;

namespace Sp.AvSec.Mains.PrintBatches
{
    public interface IPrintBatchService : IAsyncCrudAppService<PrintBatchDto, long, GetAllPrintPatchInput, CreatePrintBatchDto, UpdatePrintBatchDto>
    {
        Task<PagedResultDto<PrintBatchDto>> GetPagedAsync(GetAllPrintPatchInput input);
    }
}
