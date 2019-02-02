using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Default
{
    public class Main : DefaultBotCallbackHCommandMethod
    {
        public override string Command => "main";

        public override string Description => "";

        protected override Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery)
        {
            throw new NotImplementedException();
        }
    }
}
