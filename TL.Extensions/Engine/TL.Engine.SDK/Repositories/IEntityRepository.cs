using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Repositories
{
    public interface IEntityRepository<TEntity> : IRepository where TEntity : class, IEntity
    {
    }
}
