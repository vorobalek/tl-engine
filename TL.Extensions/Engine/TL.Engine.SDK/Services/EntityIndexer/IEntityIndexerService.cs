using System.Collections.Generic;
using TL.Engine.SDK.Attributes.Api.Executable;

namespace TL.Engine.SDK.Services
{
    public interface IEntityIndexerService
    {
        [PrivateApi]
        IEnumerable<object> Find(string query, int count = 0);

        IEnumerable<object> Find<TEntity>(string query, int count = 0);
        bool Add<TEntity>(TEntity entity);
        bool Update<TEntity>(TEntity oldEntity, TEntity newEntity);
        bool Remove<TEntity>(TEntity entity);

        [PrivateApi]
        void Reset();
    }
}