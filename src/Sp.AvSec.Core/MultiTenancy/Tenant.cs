using Abp.MultiTenancy;
using Sp.AvSec.Authorization.Users;

namespace Sp.AvSec.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}