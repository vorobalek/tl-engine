using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    public abstract class EntityDuplicateComparableStoredManager<TEntity, TKey> : EntityComparableStoredManager<TEntity, TKey>, IEntityDuplicateComparableStoredManager<TEntity, TKey>
        where TEntity : class, IEntityDuplicate<TKey>, IEntityComparable<TKey>, IEntityStored
        where TKey : struct, IComparable
    {
        public EntityDuplicateComparableStoredManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }

        public TEntity GetOriginal(TKey key)
        {
            return GetOriginal(e => e.Id.Equals(key));
        }

        public TEntity GetOriginal(Func<TEntity, bool> predicate)
        {
            var entity = Get(predicate);
            if (entity.OriginalId.HasValue)
            {
                return GetOriginal(entity.OriginalId.Value);
            }
            else
            {
                return entity;
            }
        }
    }
}
