using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.TelegramBots.Web.Bots.Handlers.Methods.Command.Message.Default
{
    public class Start : DefaultBotMessageHCommandMethod
    {
        public override string Command => "/start";

        public override string Description => "Начать работу с ботом";

        public override bool IsPolicyAcceptable(Update update)
        {
            return true;
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(Telegram.Bot.Types.Message message)
        {
            await Bot.SendAsync(new Engine.SDK.Integrations.Telegram.Messages.Message()
            {
                MessageType = Telegram.Bot.Types.Enums.MessageType.Text,
                ChatId = message.Chat,
                Text = DateTime.Now.ToString()
            });

            return new HandlerMethodResult(true);
        }
    }
}
