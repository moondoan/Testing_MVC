using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sp.AvSec.MultiTenancy.Dto;

namespace Sp.AvSec.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
