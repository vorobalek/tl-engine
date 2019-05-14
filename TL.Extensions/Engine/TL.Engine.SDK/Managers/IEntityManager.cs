using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    public interface IEntityManager<TEntity>
        where TEntity : class, IEntity
    {
        TEntity Create(TEntity entity, bool cacheOnly = false);
        TEntity CreateEmpty(bool cacheOnly = false);
        TEntity Get(Func<TEntity, bool> predicate, bool loadDeleted = false);
        IEnumerable<TEntity> GetAll(bool loadDeleted = false);
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate, bool loadDeleted = false);
        TEntity GetOrCreate(Func<TEntity, bool> predicate, bool loadDeleted = false, TEntity entity = null, bool cacheOnly = false);
        TEntity Update(TEntity entity, bool cacheOnly = false);
        TEntity Delete(TEntity entity, bool cacheOnly = false);
        TEntity Delete(Func<TEntity, bool> predicate, bool cacheOnly = false);
        IEnumerable<TEntity> DeleteAll(Func<TEntity, bool> predicate, bool cacheOnly = false);
        TEntity Remove(TEntity entity, bool cacheOnly = false);
        TEntity Remove(Func<TEntity, bool> predicate, bool loadDeleted = false, bool cacheOnly = false);
        IEnumerable<TEntity> RemoveAll(Func<TEntity, bool> predicate, bool loadDeleted = false, bool cacheOnly = false);
    }
}
