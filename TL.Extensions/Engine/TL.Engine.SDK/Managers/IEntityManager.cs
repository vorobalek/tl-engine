using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    public interface IEntityManager<TEntity>
        where TEntity : class, IEntity
    {
        TEntity Create(TEntity entity);
        TEntity CreateEmpty();
        TEntity Get(Func<TEntity, bool> predicate);
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate);
        TEntity GetOrCreate(Func<TEntity, bool> predicate, TEntity entity = null);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity Delete(Func<TEntity, bool> predicate);
        IEnumerable<TEntity> DeleteAll(Func<TEntity, bool> predicate);
    }
}
