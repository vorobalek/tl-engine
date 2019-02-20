using System;

namespace TL.Engine.SDK.Entities
{
    public interface IEntityComparableStored<TKey> : IEntityComparable<TKey>, IEntityStored
        where TKey : IComparable
    {
    }
}
