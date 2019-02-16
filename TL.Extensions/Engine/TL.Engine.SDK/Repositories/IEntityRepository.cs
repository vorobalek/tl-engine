using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    public interface IEntityRepository<TEntity> : IRepository where TEntity : class, IEntity
    {
        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        void Delete(TEntity entity);

        IEnumerable<TEntity> GetAll();
    }
}
