using ExtCore.Data.EntityFramework;
using System.Linq;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    public abstract class EntityRepository<TEntity> : RepositoryBase<TEntity>, IEntityRepository<TEntity> where TEntity : class, IEntity
    {
        protected virtual TEntity Load(TEntity entity)
        {
            try
            {
                storageContext.Entry(entity).References.ToList().ForEach(prop => prop.Load());
                storageContext.Entry(entity).Collections.ToList().ForEach(prop => prop.Load());
            }
            catch { }

            return entity;
        }
    }
}
