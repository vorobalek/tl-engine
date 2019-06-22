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

        public virtual TEntity Get(Func<TEntity, bool> predicate, bool loadDeleted = false)
        {
            return Load(dbSet.SingleOrDefault(e => predicate(e) && (loadDeleted || !loadDeleted && !e.IsDeleted)));
        }

        public virtual IEnumerable<TEntity> GetAll(bool loadDeleted = false)
        {
            return GetAll(e => true, loadDeleted);
        }

        public virtual IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate, bool loadDeleted = false)
        {
            return dbSet.Where(e => predicate(e) && (loadDeleted || !loadDeleted && !e.IsDeleted)).Select(e => Load(e));
        }

        public TEntity Remove(TEntity entity)
        {
            return Load(dbSet.Remove(entity).Entity);
        }

        public TEntity Remove(Func<TEntity, bool> predicate, bool loadDeleted = false)
        {
            return Remove(dbSet.SingleOrDefault(e => predicate(e) && (loadDeleted || !loadDeleted && !e.IsDeleted)));
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

        public virtual TEntity Load(TEntity entity)
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
