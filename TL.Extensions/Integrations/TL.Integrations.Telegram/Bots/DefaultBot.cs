using System;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Engine.SDK.Integrations.Telegram.Messages;
using TL.Engine.SDK.Attributes.Bots;

namespace TL.Integrations.Telegram.Bots
{
    [Bot("Демо")]
    public class DefaultBot : BaseBot
    {
        public DefaultBot(IServiceProvider serviceProvider, string token, bool skipUpdates) : this(serviceProvider, token, null, skipUpdates)
        {
        }

        public DefaultBot(IServiceProvider serviceProvider, string token, string name = null, bool skipUpdates = false) : base(serviceProvider, token, name, skipUpdates)
        {
        }

        public IMessage GetHelloMessage()
        {
            return new Message()
            {
                MessageType = MessageType.Text,
                Text = DateTime.Now.ToString(),
                ReplyMarkup = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("✅ Тык!", "some.query.request")
                    }
                })
            };
        }
    }
}
