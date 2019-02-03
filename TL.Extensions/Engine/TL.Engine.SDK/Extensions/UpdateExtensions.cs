using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace TL.Engine.SDK.Extensions
{
    public static class UpdateExtensions
    {
        public static ChatId GetSenderId(this Update update)
        {
            switch (update.Type)
            {
                case UpdateType.Message:
                    return update.Message.From.Id;
                case UpdateType.InlineQuery:
                    return update.InlineQuery.From.Id;
                case UpdateType.ChosenInlineResult:
                    return update.ChosenInlineResult.From.Id;
                case UpdateType.CallbackQuery:
                    return update.CallbackQuery.From.Id;
                case UpdateType.EditedMessage:
                    return update.EditedMessage.From.Id;
                case UpdateType.ChannelPost:
                    return update.ChannelPost.From.Id;
                case UpdateType.EditedChannelPost:
                    return update.EditedChannelPost.From.Id;
                case UpdateType.ShippingQuery:
                    return update.ShippingQuery.From.Id;
                case UpdateType.PreCheckoutQuery:
                    return update.PreCheckoutQuery.From.Id;
                default:
                    return null;
            }
        }

        public static ChatId GetSenderChatId(this Update update)
        {
            switch (update.Type)
            {
                case UpdateType.Message:
                    return update.Message.Chat;
                case UpdateType.InlineQuery:
                    return update.InlineQuery.From.Id;
                case UpdateType.ChosenInlineResult:
                    return update.ChosenInlineResult.From.Id;
                case UpdateType.CallbackQuery:
                    return update.CallbackQuery.Message.Chat;
                case UpdateType.EditedMessage:
                    return update.EditedMessage.Chat;
                case UpdateType.ChannelPost:
                    return update.ChannelPost.Chat;
                case UpdateType.EditedChannelPost:
                    return update.EditedChannelPost.Chat;
                case UpdateType.ShippingQuery:
                    return update.ShippingQuery.From.Id;
                case UpdateType.PreCheckoutQuery:
                    return update.PreCheckoutQuery.From.Id;
                default:
                    return null;
            }
        }

        public static string GetGenericTypeString(this Update update)
        {
            switch (update.Type)
            {
                case UpdateType.Message:
                    return update.Message.Type.ToString();
                default:
                    return update.Type.ToString();
            }
        }
    }
}
