using System.Linq;
using Sp.AvSec.EntityFramework;
using Sp.AvSec.MultiTenancy;

namespace Sp.AvSec.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AvSecDbContext _context;

        public DefaultTenantCreator(AvSecDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
