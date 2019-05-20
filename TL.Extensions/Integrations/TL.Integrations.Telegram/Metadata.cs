using System;
using TL.Engine.SDK.Modularity;

namespace TL.Integrations.Telegram
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Integrations.Telegram";

        public override string Owner => "TL.Integrations";

        protected override Version Version => new Version(1, 1, 0, 4);
    }
}
