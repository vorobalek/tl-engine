using System.Threading;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TL.Integrations.SDK.Telegram.Messages
{
    public class Message : IMessage
    {
        public MessageType MessageType { get; set; }

        public ChatId ChatId { get; set; }
        public string Text { get; set; }
        public ParseMode ParseMode { get; set; }
        public bool DisableWebPagePreview { get; set; }
        public bool DisableNotification { get; set; }
        public int ReplyToMessageId { get; set; }
        public IReplyMarkup ReplyMarkup { get; set; }
        public CancellationToken CancellationToken { get; set; }

        public bool IsEditMessage { get; set; }
        public int EditMessageId { get; set; }

        public string CallbackQueryId { get; set; }

        public bool IsCallbackAnswer { get; set; }
        public string CallbackAnswerText { get; set; }
        public bool CallbackShowAlert { get; set; }
        public string CallbackUrl { get; set; }
        public int CallbackCacheTime { get; set; }
    }
}
