using System;
using TL.Engine.SDK.Modularity;

namespace TL.Account
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Account";

        protected override Version Version => new Version(1, 3, 0, 0);
    }
}
