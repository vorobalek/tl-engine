using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    public abstract class EntityComparableStoredManager<TEntity, TKey> : EntityManager<TEntity>, IEntityComparableStoredManager<TEntity, TKey>
        where TEntity : class, IEntityComparable<TKey>, IEntityStored
        where TKey : IComparable
    {
        public EntityComparableStoredManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }

        public virtual TEntity Get(TKey key)
        {
            return Get(e => e.Id.Equals(key));
        }

        public virtual TEntity GetOrCreate(TKey key, TEntity entity = null)
        {
            return GetOrCreate(e => e.Id.Equals(key), entity);
        }

        public virtual TEntity UpdateOrCreate(TKey key, TEntity entity = null)
        {
            return UpdateOrCreate(e => e.Id.Equals(key), entity);
        }

        public virtual TEntity UpdateOrCreate(Func<TEntity, bool> predicate, TEntity entity = null)
        {
            TEntity existedEntity = Get(predicate);
            if (existedEntity == null)
            {
                return Create(entity);
            }
            else
            {
                if (entity == null)
                {
                    entity = CreateEmpty();
                }
                entity.Id = existedEntity.Id;
                return Update(existedEntity);
            }
        }

        public virtual TEntity UpdateOrCreate(TEntity entity)
        {
            return UpdateOrCreate(e => e.Id.Equals(entity.Id), entity);
        }
    }
}
