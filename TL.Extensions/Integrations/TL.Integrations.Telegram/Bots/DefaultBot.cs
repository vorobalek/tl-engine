using Microsoft.Extensions.Logging;
using System;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Engine.SDK.Integrations.Telegram.Messages;

namespace TL.Integrations.Telegram.Bots
{
    public class DefaultBot : BaseBot
    {
        public DefaultBot(ILoggerFactory loggerFactory, string token, string name = null) : base(loggerFactory, token, name)
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
