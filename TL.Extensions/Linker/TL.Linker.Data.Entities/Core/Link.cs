using TL.Engine.SDK.Entities;

namespace TL.Linker.Data.Entities.Core
{
    public class Link : EntityComparableStored<int>
    {
        public string Url { get; set; }
    }
}
