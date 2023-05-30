using System.Data.Common;
using System.Data.Entity;
using System.Threading.Tasks;
using Abp.DynamicEntityProperties;
using Abp.Zero.EntityFramework;
using Sp.AvSec.Authorization.Roles;
using Sp.AvSec.Authorization.Users;
using Sp.AvSec.Mains;
using Sp.AvSec.MultiTenancy;

namespace Sp.AvSec.EntityFramework
{
    public class AvSecDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        #region Declare IDbSets
        public virtual IDbSet<PrintBatch> PrintBatches { get; set; }
        public virtual IDbSet<PrintBatchData> PrintBatchDatas { get; set; }
        public virtual IDbSet<CardTemplate> CardTemplates { get; set; }
        public virtual IDbSet<CardTemplateLog> CardTemplateLogs { get; set; }
        public virtual IDbSet<CardPrintQueue> CardPrintQueues { get; set; }
        public virtual IDbSet<CardPrintQueueLog> CardPrintQueueLogs { get; set; }
        #endregion

        #region Constructors
        public AvSecDbContext()
            : base("Default")
        {

        }

       
        public AvSecDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public AvSecDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AvSecDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Set Entity Relactionships
            modelBuilder.Entity<DynamicProperty>().Property(p => p.PropertyName).HasMaxLength(250);
            modelBuilder.Entity<DynamicEntityProperty>().Property(p => p.EntityFullName).HasMaxLength(250);

            modelBuilder.Entity<PrintBatch>().HasIndex(p => p.Name);

            modelBuilder.Entity<PrintBatchData>().HasIndex(p => p.PrintBatchId);
            modelBuilder.Entity<PrintBatchData>().HasIndex(p => p.PrintNum);

            modelBuilder.Entity<CardTemplate>().HasIndex(p => p.Name);
            modelBuilder.Entity<CardTemplate>().HasIndex(p => p.FileName);

            modelBuilder.Entity<CardTemplateLog>().HasIndex(p => p.CardTemplateId);
            modelBuilder.Entity<CardTemplateLog>().HasIndex(p => p.Name);
            modelBuilder.Entity<CardTemplateLog>().HasIndex(p => p.FileName);
            modelBuilder.Entity<CardTemplateLog>().HasIndex(p => p.ActionType);

            modelBuilder.Entity<CardPrintQueue>().HasIndex(p => p.ReportFileName);
            modelBuilder.Entity<CardPrintQueue>().HasIndex(p => p.ReportPrintName);

            modelBuilder.Entity<CardPrintQueueLog>().HasIndex(p => p.ReportFileName);
            modelBuilder.Entity<CardPrintQueueLog>().HasIndex(p => p.ReportPrintName);
            modelBuilder.Entity<CardPrintQueueLog>().HasIndex(p => p.ReportStatus);
            #endregion
        }
    }
}
