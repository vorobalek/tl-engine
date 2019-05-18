using System;
using TL.Engine.SDK.Modularity;

namespace TL.Linker
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Linker";

        protected override Version Version => new Version(1, 1, 0, 2);
    }
}
