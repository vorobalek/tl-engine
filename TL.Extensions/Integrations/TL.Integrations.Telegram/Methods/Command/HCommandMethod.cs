using TL.Engine.SDK.Services;
using TL.Integrations.SDK.Telegram.Handlers;
using TL.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command
{
    public abstract class HCommandMethod : HandlerMethod<HCommand>
    {
        public HCommandMethod(IActivatorService activator) : base(activator)
        {
        }
    }
}
