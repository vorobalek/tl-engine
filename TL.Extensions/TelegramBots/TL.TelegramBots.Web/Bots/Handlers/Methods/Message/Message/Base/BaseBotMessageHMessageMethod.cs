using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.TelegramBots.Web.Bots.Handlers.Methods.Message.Message.Base
{
    public class BaseBotMessageHMessageMethod : MessageHMessageMethod
    {
        public override Type BotType => typeof(BaseBot);

        public override string Command => "";

        public override string Description => "";

        public override bool IsPolicyAcceptable(Update update)
        {
            return true;
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(Telegram.Bot.Types.Message message)
        {
            var commands_arr = (Bot as BaseBot).CommandHandler.Methods
                .Where(it => (!it.IsPrivate) && (it.UpdateType == Telegram.Bot.Types.Enums.UpdateType.Message))
                .OrderBy(it => it.Command)
                .Select(it => $"{it.Command} {it.Description}");

            var commands = string.Join("\r\n", commands_arr);

            await Bot.SendAsync(new Engine.SDK.Integrations.Telegram.Messages.Message()
            {
                MessageType = Telegram.Bot.Types.Enums.MessageType.Text,
                ChatId = message.Chat,
                Text = $"🖖🏻 <b>Я вас не понимаю, но вот список команд, которые я в состоянии понять</b>\r\n\r\n{commands}",
                ParseMode = Telegram.Bot.Types.Enums.ParseMode.Html
            });

            return new HandlerMethodResult(true);
        }
    }
}
