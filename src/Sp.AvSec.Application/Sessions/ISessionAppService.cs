using System.Threading.Tasks;
using Abp.Application.Services;
using Sp.AvSec.Sessions.Dto;

namespace Sp.AvSec.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
