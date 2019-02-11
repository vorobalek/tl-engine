using ExtCore.Data.Abstractions;
using System;
using System.Threading.Tasks;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Managers
{
    public interface IEntityManager<TEntity> where TEntity : IEntity
    {
        IStorage Storage { get; }
    }
}
