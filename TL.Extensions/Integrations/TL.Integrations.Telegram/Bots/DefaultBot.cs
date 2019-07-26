using System;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Integrations.SDK.Telegram.Messages;
using TL.Integrations.SDK.Telegram.Attributes;
using TL.Engine.SDK.Services;

namespace TL.Integrations.Telegram.Bots
{
    [Bot("Демо")]
    public class DefaultBot : BaseBot
    {
        public DefaultBot(IServiceProvider serviceProvider, IActivatorService activator) : base(serviceProvider, activator)
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
