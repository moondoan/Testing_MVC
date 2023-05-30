using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Sp.AvSec.EntityFramework.Repositories
{
    public abstract class AvSecRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AvSecDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AvSecRepositoryBase(IDbContextProvider<AvSecDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AvSecRepositoryBase<TEntity> : AvSecRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AvSecRepositoryBase(IDbContextProvider<AvSecDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
