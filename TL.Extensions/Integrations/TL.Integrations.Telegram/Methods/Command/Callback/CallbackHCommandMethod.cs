using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Callback
{
    public abstract class CallbackHCommandMethod : HCommandMethod
    {
        public override UpdateType UpdateType => UpdateType.CallbackQuery;

        public override bool IsRelevantMethod(Update update)
        {
            var rules = new bool[]
            {
                update.Type == UpdateType.CallbackQuery,
                update?.CallbackQuery?.Message?.Type == MessageType.Text,
                !string.IsNullOrWhiteSpace(update?.CallbackQuery?.Data),
                update?.CallbackQuery?.Data?.StartsWith(Command) ?? false
            };

            return rules.All(rule => rule);
        }

        public override bool IsPolicyAcceptable(Update update)
        {
            return IsPolicyAcceptable(update.CallbackQuery);
        }

        protected abstract bool IsPolicyAcceptable(CallbackQuery callbackQuery);

        protected override async Task<IHandlerMethodResult> ExecuteAsync(Update update)
        {
            return await ExecuteAsync(update.CallbackQuery);
        }

        protected abstract Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery);
    }
}
