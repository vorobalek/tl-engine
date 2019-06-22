using System.Collections.Generic;

namespace TL.Engine.SDK.Services
{
    public interface IEntityIndexerService
    {
        IEnumerable<object> Find(string query, int count = 0);
        IEnumerable<object> Find<TEntity>(string query, int count = 0);
        bool Add<TEntity>(TEntity entity);
        bool Update<TEntity>(TEntity oldEntity, TEntity newEntity);
        bool Remove<TEntity>(TEntity entity);
        void Reset();
    }
}