using System;
using TL.Engine.SDK.Entities;

namespace TL.Linker.Data.Entities.Core
{
    public class Link : EntityComparableStored<Guid>
    {
        public ulong Identifier { get; set; }
        
        public string Url { get; set; }
    }
}
