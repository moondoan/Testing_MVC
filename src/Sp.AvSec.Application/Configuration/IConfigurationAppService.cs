using System.Threading.Tasks;
using Abp.Application.Services;
using Sp.AvSec.Configuration.Dto;

namespace Sp.AvSec.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}