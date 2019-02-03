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
                update?.CallbackQuery?.Data?.StartsWith(Command) ?? false
            };

            return rules.All(rule => rule);
        }

        public override bool IsPolicyAcceptable(Update update, params object[] args)
        {
            return IsPolicyAcceptable(update.CallbackQuery, args);
        }

        protected abstract bool IsPolicyAcceptable(CallbackQuery callbackQuery, params object[] args);

        protected override async Task<IHandlerMethodResult> ExecuteAsync(Update update, params object[] args)
        {
            return await ExecuteAsync(update.CallbackQuery, args);
        }

        protected abstract Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args);
    }
}
