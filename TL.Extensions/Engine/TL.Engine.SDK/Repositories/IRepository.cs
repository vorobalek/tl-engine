using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;
using IExtCoreRepository = ExtCore.Data.Abstractions.IRepository;

namespace TL.Engine.SDK.Repositories
{
    /// <summary>
    /// Интерфейс репозитория элементарных сущностей.
    /// </summary>
    /// <seealso cref="ExtCore.Data.Abstractions.IRepository" />
    public interface IRepository : IExtCoreRepository
    {
        Type EntityType { get; }
    }
}
