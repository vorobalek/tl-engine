using System.Linq;
using System.Threading.Tasks;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.TelegramBots.Web.Bots.Handlers.Methods.Command.Message.Base
{
    public class Help : BaseBotMessageHCommandMethod
    {
        public override string Command => "/help";

        public override string Description => "Вывести все доступные команды с описанием";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(Telegram.Bot.Types.Message message)
        {
            var commands_arr = Handler.Methods
                .Where(it => (!it.IsPrivate) && (it.UpdateType == Telegram.Bot.Types.Enums.UpdateType.Message))
                .OrderBy(it => it.Command)
                .Select(it => $"{it.Command} {it.Description}");

            var commands = string.Join("\r\n", commands_arr);

            await Bot.SendAsync(new Engine.SDK.Integrations.Telegram.Messages.Message()
            {
                MessageType = Telegram.Bot.Types.Enums.MessageType.Text,
                ChatId = message.Chat,
                Text = $"🖖🏻 <b>Вот список команд, которые я в состоянии понять</b>\r\n\r\n{commands}",
                ParseMode = Telegram.Bot.Types.Enums.ParseMode.Html
            });

            return new HandlerMethodResult(true);
        }
    }
}
