using System.Threading;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TL.Engine.SDK.Integrations.Telegram.Messages
{
    public interface IMessage
    {
        MessageType MessageType { get; set; }

        ChatId ChatId { get; set; }

        string Text { get; set; }

        ParseMode ParseMode { get; set; }

        bool DisableWebPagePreview { get; set; }

        bool DisableNotification { get; set; }

        int ReplyToMessageId { get; set; }

        IReplyMarkup ReplyMarkup { get; set; }

        CancellationToken CancellationToken { get; set; }

        bool IsEditMessage { get; set; }

        int EditMessageId { get; set; }

        string CallbackQueryId { get; set; }

        bool IsCallbackAnswer { get; set; }

        string CallbackAnswerText { get; set; }

        bool CallbackShowAlert { get; set; }

        string CallbackUrl { get; set; }

        int CallbackCacheTime { get; set; }
    }
}
