using System;
using System.Collections;

namespace TL.Engine.SDK.Entities
{
    public interface IEntityDuplicate<TKey> : IEntityComparable<TKey>
        where TKey : struct, IComparable
    {
        TKey? OriginalId { get; set; }
    }
}
