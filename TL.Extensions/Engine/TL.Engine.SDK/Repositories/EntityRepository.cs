using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    public abstract class EntityRepository<TEntity> : RepositoryBase<TEntity>, IEntityRepository<TEntity> where TEntity : class, IEntity
    {
        public TEntity Add(TEntity entity)
        {
            if (entity is IEntityStored entityStored)
            {
                entityStored.CreationDate = DateTime.Now.ToUniversalTime();
                entityStored.ModifiedDate = DateTime.Now.ToUniversalTime();
                entity = entityStored as TEntity;
            }
            return Load(dbSet.Add(entity).Entity);
        }

        public void Delete(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return dbSet.Select(e => Load(e));
        }

        public TEntity Update(TEntity entity)
        {
            if (entity is IEntityStored entityStored)
            {
                entityStored.ModifiedDate = DateTime.Now.ToUniversalTime();
                entity = entityStored as TEntity;
            }
            return Load(dbSet.Update(entity).Entity);
        }

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
