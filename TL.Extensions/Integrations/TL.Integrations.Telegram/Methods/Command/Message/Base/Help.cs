using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Engine.SDK.Services;
using TL.Integrations.SDK.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Message.Base
{
    public class Help : BaseBotMessageHCommandMethod
    {
        public Help(IActivatorService activator) : base(activator)
        {
        }

        public override string Command => "/help";

        public override string Description => "Вывести все доступные команды с описанием";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args)
        {
            var commands_arr = Bot.CommandHandler.Methods
               .Where(it => (!it.IsPrivate)
                   && it.IsPolicyAcceptable(new Update() { Message = message })
                   && (it.UpdateType == global::Telegram.Bot.Types.Enums.UpdateType.Message))
               .OrderBy(it => it.Command)
               .Select(it => $"{it.Command} {it.Description}");

            var commands = string.Join("\r\n", commands_arr);

            await Bot.SendAsync(new SDK.Telegram.Messages.Message()
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
