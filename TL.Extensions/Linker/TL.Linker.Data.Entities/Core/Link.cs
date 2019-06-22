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
    }
}
