using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Default
{
    public class Main : DefaultBotCallbackHCommandMethod
    {
        public override string Command => "main";

        public override string Description => "";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            var msg = Bot.GetHelloMessage();
            msg.ChatId = callbackQuery.Message.Chat;
            msg.IsEditMessage = true;
            msg.EditMessageId = callbackQuery.Message.MessageId;
            msg.CallbackQueryId = callbackQuery.Id;

            await Bot.SendAsync(msg);

            return new HandlerMethodResult(true);
        }
    }
}
