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

        public override bool IsRelevantMethod(Update update)
        {
            var rules = new bool[]
            {
                update.Type == UpdateType.Message,
                update?.Message?.Type == MessageType.Text,
                !string.IsNullOrWhiteSpace(update?.Message?.Text),
                update?.Message?.Text?.StartsWith(Command) ?? false
            };

            return rules.All(rule => rule);
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(Update update)
        {
            return await ExecuteAsync(update.Message);
        }

        protected abstract Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message);
    }
}
