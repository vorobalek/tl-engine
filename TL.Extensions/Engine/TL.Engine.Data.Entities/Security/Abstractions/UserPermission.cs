using System;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Types;

namespace TL.Engine.Data.Entities.Security.Abstractions
{
    public abstract class UserPermission<TObject, TObjectKey> : Permission<User, Guid, TObject, TObjectKey>
        where TObject : class, IEntityComparable<TObjectKey>
        where TObjectKey : IComparable
    {
    }
}
