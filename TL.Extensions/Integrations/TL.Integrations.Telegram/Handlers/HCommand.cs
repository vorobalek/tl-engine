using TL.Engine.SDK.Services;
using TL.Integrations.SDK.Telegram.Bots;
using TL.Integrations.SDK.Telegram.Handlers;

namespace TL.Integrations.Telegram.Handlers
{
    public class HCommand : Handler
    {
        public HCommand(IActivatorService activator) : base(activator)
        {
        }
    }
}
