using System;
using TL.Engine.SDK.Modularity;

namespace TL.Linker.SDK
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Linker.SDK";

        public override string Owner => "TL.Linker";

        protected override Version Version => new Version(1, 3, 0, 0);
    }
}
