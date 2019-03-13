using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Message
{
    public abstract class MessageHCommandMethod : HCommandMethod
    {
        public override UpdateType UpdateType => UpdateType.Message;

        public override bool IsRelevantMethod(Update update, params object[] args)
        {
            var rules = new bool[]
            {
                update.Type == UpdateType.Message,
                update?.Message?.Type == MessageType.Text,
                !string.IsNullOrWhiteSpace(update?.Message?.Text),
                update?.Message?.Text?.StartsWith(Command) ?? false,
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
            return IsPolicyAcceptable(update?.Message, args);
        }

        protected virtual bool IsPolicyAcceptable(global::Telegram.Bot.Types.Message message, object[] args)
        {
            return true;
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(Update update, params object[] args)
        {
            return await ExecuteAsync(update.Message, args);
        }

        protected abstract Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args);
    }
}
