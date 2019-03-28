using System.Threading.Tasks;
using TL.Integrations.SDK.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Message.Default
{
    public class Start : DefaultBotMessageHCommandMethod
    {
        public override string Command => "/start";

        public override string Description => "Начать работу с ботом";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args)
        {
            var msg = Bot.GetHelloMessage();
            msg.ChatId = message.Chat;

            await Bot.SendAsync(msg);

            return new HandlerMethodResult(true);
        }
    }
}
