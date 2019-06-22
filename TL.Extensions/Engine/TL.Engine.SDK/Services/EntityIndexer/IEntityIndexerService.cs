using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Services
{
    public interface IEntityIndexerService
    {
        IEnumerable<object> Find(string query, int count = 0);
        IEnumerable<object> Find<TEntity>(string query, int count = 0);
        void Add<TEntity>(TEntity entity);
        void Update<TEntity>(TEntity entity);
        void AddOrUpdate<TEntity>(TEntity entity);
        void Remove<TEntity>(TEntity entity);
        void Reset();
    }
}