using System.Collections.Generic;

namespace TL.Engine.SDK.Services
{
    public interface IEntityIndexerService
    {
        IEnumerable<object> Find(string query, int count = 0);
        IEnumerable<object> Find<TEntity>(string query, int count = 0);
        void Add<TEntity>(TEntity entity);
        void Update<TEntity>(TEntity oldEntity, TEntity newEntity);
        void Remove<TEntity>(TEntity entity);
        void Reset();
    }
}