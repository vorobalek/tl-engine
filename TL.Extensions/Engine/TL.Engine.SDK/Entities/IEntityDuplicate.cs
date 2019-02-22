using System;

namespace TL.Engine.SDK.Entities
{
    public interface IEntityDuplicate<TKey> : IEntityComparable<TKey>
        where TKey : IComparable
    {
        TKey OriginalId { get; set; }

        IEntityDuplicate<TKey> Original { get; set; }
    }
}
