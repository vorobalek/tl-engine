using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    public abstract class EntityComparableDuplicateStoredManager<TEntity, TKey> : EntityComparableStoredManager<TEntity, TKey>, IEntityComparableDuplicateStoredManager<TEntity, TKey>
        where TEntity : EntityComparableDuplicateStored<TKey>
        where TKey : IComparable
    {
        public EntityComparableDuplicateStoredManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }

        public TEntity GetOriginal(TKey key)
        {
            return GetOriginal(e => e.Id.Equals(key));
        }

        public TEntity GetOriginal(Func<TEntity, bool> predicate)
        {
            var entity = Get(predicate);
            if (entity.Original != null)
            {
                return GetOriginal(entity.Original.Id);
            }
            else
            {
                return entity;
            }
        }
    }
}
