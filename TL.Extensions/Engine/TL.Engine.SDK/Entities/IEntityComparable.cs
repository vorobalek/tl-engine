using System;

namespace TL.Engine.SDK.Entities
{
    public interface IEntityComparable<TKey> : IEntity
        where TKey : IComparable
    {
        TKey Id { get; set; }
    }
}
