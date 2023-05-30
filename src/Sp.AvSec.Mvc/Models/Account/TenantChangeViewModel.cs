using Abp.AutoMapper;
using Sp.AvSec.Sessions.Dto;

namespace Sp.AvSec.Mvc.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}