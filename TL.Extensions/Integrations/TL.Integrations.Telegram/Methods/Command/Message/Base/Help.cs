using System.Linq;
using System.Threading.Tasks;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Message.Base
{
    public class Help : BotMessageHCommandMethod
    {
        public override string Command => "/help";

        public override string Description => "Вывести все доступные команды с описанием";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args)
        {
            var commands_arr = Handler.Methods
                .Where(it => (!it.IsPrivate) && (it.UpdateType == global::Telegram.Bot.Types.Enums.UpdateType.Message))
                .OrderBy(it => it.Command)
                .Select(it => $"{it.Command} {it.Description}");

            var commands = string.Join("\r\n", commands_arr);

            await Bot.SendAsync(new Engine.SDK.Integrations.Telegram.Messages.Message()
            {
                MessageType = global::Telegram.Bot.Types.Enums.MessageType.Text,
                ChatId = message.Chat,
                Text = $"🖖🏻 <b>Вот список команд, которые я в состоянии понять</b>\r\n\r\n{commands}",
                ParseMode = global::Telegram.Bot.Types.Enums.ParseMode.Html
            });

            return new HandlerMethodResult(true);
        }
    }
}
