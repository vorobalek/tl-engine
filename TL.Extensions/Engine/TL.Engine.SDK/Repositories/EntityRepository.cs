using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    public abstract class EntityRepository<TEntity> : RepositoryBase<TEntity>, IEntityRepository<TEntity> where TEntity : class, IEntity
    {
        public virtual TEntity Add(TEntity entity)
        {
            if (entity != null)
            {
                if (entity is IEntityStored entityStored)
                {
                    entityStored.CreationDate = DateTime.Now.ToUniversalTime();
                    entityStored.ModifiedDate = DateTime.Now.ToUniversalTime();
                    entity = entityStored as TEntity;
                }
                return Load(dbSet.Add(entity).Entity);
            }
            else
            {
                return null;
            }
        }

        public virtual void Delete(TEntity entity)
        {
            if (entity != null)
            {
                entity.IsDeleted = true;
            }
        }

        public virtual TEntity Get(Func<TEntity, bool> predicate)
        {
            return Load(dbSet.FirstOrDefault(e => predicate(e) && !e.IsDeleted));
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return GetAll(e => true);
        }

        public virtual IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate)
        {
            return dbSet.Where(e => predicate(e) && !e.IsDeleted).Select(e => Load(e));
        }

        public virtual TEntity Update(TEntity entity)
        {
            if (entity != null)
            {
                if (entity is IEntityStored entityStored)
                {
                    entityStored.ModifiedDate = DateTime.Now.ToUniversalTime();
                    entity = entityStored as TEntity;
                }
                return Load(dbSet.Update(entity).Entity);
            }
            else
            {
                return null;
            }
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
