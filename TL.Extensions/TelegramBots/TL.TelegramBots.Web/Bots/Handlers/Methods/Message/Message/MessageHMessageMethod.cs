using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.TelegramBots.Web.Bots.Handlers.Methods.Message.Message
{
    public abstract class MessageHMessageMethod : HMessageMethod
    {
        public override UpdateType UpdateType => UpdateType.Message;

        public override bool IsRelevantMethod(Update update)
        {
            var rules = new bool[]
            {
                update.Type == UpdateType.Message
            };

            return rules.All(rule => rule);
        }

        public override async Task<IHandlerMethodResult> ExecuteAsync(Update update)
        {
            return await ExecuteAsync(update.Message);
        }

        protected abstract Task<IHandlerMethodResult> ExecuteAsync(Telegram.Bot.Types.Message message);
    }
}
