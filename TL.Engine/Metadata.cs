using System;
using TL.Engine.SDK.Modularity;

namespace TL.Engine
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "Core";

        protected override Version Version => new Version(1, 1, 0, 6);
    }
}
