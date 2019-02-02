using System.Linq;
using System.Threading.Tasks;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Message.Base
{
    public class NotImplementated : BotMessageHCommandMethod
    {
        public override bool IsPrivate => true;

        public override string Command => "notimplemented";

        public override string Description => "";

        public override int Priority => int.MinValue;

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message)
        {
            var commands_arr = (Bot as Bots.BaseBot).CommandHandler.Methods
               .Where(it => (!it.IsPrivate) && (it.UpdateType == global::Telegram.Bot.Types.Enums.UpdateType.Message))
               .OrderBy(it => it.Command)
               .Select(it => $"{it.Command} {it.Description}");

            var commands = string.Join("\r\n", commands_arr);

            await Bot.SendAsync(new Engine.SDK.Integrations.Telegram.Messages.Message()
            {
                MessageType = global::Telegram.Bot.Types.Enums.MessageType.Text,
                ChatId = message.Chat,
                Text = $"🖖🏻 <b>Я вас не понимаю, но вот список команд, которые я в состоянии понять</b>\r\n\r\n{commands}",
                ParseMode = global::Telegram.Bot.Types.Enums.ParseMode.Html
            });

            return new HandlerMethodResult(true);
        }
    }
}