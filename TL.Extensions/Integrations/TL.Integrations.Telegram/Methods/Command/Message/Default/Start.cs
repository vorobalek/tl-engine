using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Message.Default
{
    public class Start : DefaultBotMessageHCommandMethod
    {
        public override string Command => "/start";

        public override string Description => "Начать работу с ботом";

        public override bool IsPolicyAcceptable(Update update)
        {
            return true;
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message)
        {
            var msg = (Bot as Bots.DefaultBot).GetHelloMessage();
            msg.ChatId = message.Chat;

            await Bot.SendAsync(msg);

            return new HandlerMethodResult(true);
        }
    }
}
