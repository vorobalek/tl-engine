using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Attributes.Api.Executable;
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

        public virtual TEntity Get(TKey key, bool loadDeleted = false)
        {
            return Get(e => e.Id.Equals(key), loadDeleted);
        }

        public virtual TEntity GetOrCreate(TKey key, bool loadDeleted = false, TEntity entity = null, bool cacheOnly = false)
        {
            return GetOrCreate(e => e.Id.Equals(key), loadDeleted, entity, cacheOnly);
        }

        public virtual TEntity UpdateOrCreate(TKey key, TEntity entity = null, bool cacheOnly = false)
        {
            return UpdateOrCreate(e => e.Id.Equals(key), entity, cacheOnly);
        }

        public virtual TEntity UpdateOrCreate(Func<TEntity, bool> predicate, TEntity entity = null, bool cacheOnly = false)
        {
            TEntity existedEntity = Get(predicate);
            if (existedEntity == null)
            {
                return Create(entity, cacheOnly);
            }
            else
            {
                if (entity == null)
                {
                    entity = CreateEmpty(cacheOnly);
                }
                entity.Id = existedEntity.Id;
                return Update(existedEntity, cacheOnly);
            }
        }

        public virtual TEntity UpdateOrCreate(TEntity entity, bool cacheOnly = false)
        {
            return UpdateOrCreate(e => e.Id.Equals(entity.Id), entity, cacheOnly);
        }
    }
}
