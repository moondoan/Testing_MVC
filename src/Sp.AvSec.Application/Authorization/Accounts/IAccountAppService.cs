using System.Threading.Tasks;
using Abp.Application.Services;
using Sp.AvSec.Authorization.Accounts.Dto;

namespace Sp.AvSec.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
