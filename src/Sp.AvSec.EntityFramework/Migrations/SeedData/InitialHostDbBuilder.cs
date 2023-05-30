using Sp.AvSec.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Sp.AvSec.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AvSecDbContext _context;

        public InitialHostDbBuilder(AvSecDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
