using System;
using TL.Engine.SDK.Attributes.EntityIndexer;
using TL.Engine.SDK.Entities;

namespace TL.Linker.Data.Entities.Core
{
    public class Link : EntityComparableStored<Guid>
    {
        public ulong Identifier { get; set; }
        
        [StringIndex]
        public string Url { get; set; }

        public int LifetimeSeconds { get; set; } = int.MaxValue;

        public TimeSpan Lifetime => TimeSpan.FromSeconds(LifetimeSeconds);

        public bool IsActual => CreationDate + Lifetime > DateTime.Now;
    }
}
