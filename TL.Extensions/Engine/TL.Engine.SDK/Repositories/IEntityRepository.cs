using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    public interface IEntityRepository<TEntity> : IRepository
        where TEntity : class, IEntity
    {
        TEntity Add(TEntity entity);
        TEntity Remove(TEntity entity);
        TEntity Remove(Func<TEntity, bool> predicate, bool loadDeleted = false);
        TEntity Get(Func<TEntity, bool> predicate, bool loadDeleted = false);
        IEnumerable<TEntity> GetAll(bool loadDeleted = false);
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate, bool loadDeleted = false);
        TEntity Update(TEntity entity);
        TEntity Load(TEntity entity);
    }
}
