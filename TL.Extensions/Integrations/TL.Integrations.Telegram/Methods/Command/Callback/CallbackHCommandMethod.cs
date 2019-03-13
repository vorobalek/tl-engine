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

        public override bool IsRelevantMethod(Update update, params object[] args)
        {
            var rules = new bool[]
            {
                update.Type == UpdateType.CallbackQuery,
                update?.CallbackQuery?.Message?.Type == MessageType.Text,
                !string.IsNullOrWhiteSpace(update?.CallbackQuery?.Data),
                update?.CallbackQuery?.Data?.StartsWith(Command) ?? false,
                IsRelevantMethod(update?.Message, args)
            };

            return rules.All(rule => rule);
        }

        protected virtual bool IsRelevantMethod(global::Telegram.Bot.Types.Message message, object[] args)
        {
            return true;
        }

        public override bool IsPolicyAcceptable(Update update, params object[] args)
        {
            return IsPolicyAcceptable(update.CallbackQuery, args);
        }

        protected virtual bool IsPolicyAcceptable(CallbackQuery callbackQuery, params object[] args)
        {
            return true;
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(Update update, params object[] args)
        {
            return await ExecuteAsync(update.CallbackQuery, args);
        }

        protected abstract Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args);
    }
}
