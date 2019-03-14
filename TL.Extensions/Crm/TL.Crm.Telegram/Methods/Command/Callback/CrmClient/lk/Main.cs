using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Callback.CrmClient.lk
{
    public class Main : CrmClientBotCallbackHCommandMethod
    {
        public override string Command => "crm.lk.main";

        public override string Description => "Перейти в личный кабинет";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var lead = user.GetOriginalLead(serviceProvider);

                    await Bot.SendAsync(new TlMessage()
                    {
                        IsEditMessage = true,

                        MessageType = MessageType.Text,
                        ChatId = callbackQuery.From.Id,

                        Text = $"🖖🏻 <b>{lead.Firstname}, это Ваш личный кабинет</b>",
                        ReplyMarkup = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("📝 Записаться", "crm.trainings.signup"),
                                InlineKeyboardButton.WithCallbackData("🔖 Отправить инвайт", "crm.invites.new")
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("✏️ Изменить запись", "crm.trainings.edit"),
                                InlineKeyboardButton.WithCallbackData("📞 Связаться с клубом", "crm.call.main"),
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("📆 Абонимент", "crm.subscribtions.main"),
                            }
                        }),
                        ParseMode = ParseMode.Html,

                        CallbackQueryId = callbackQuery.Id,
                        EditMessageId = callbackQuery.Message.MessageId,
                    });
                }

                return new HandlerMethodResult(true);
            }

            return new HandlerMethodResult(false, null, $"{new ArgumentException($"В {nameof(args)} переданы неверные аргументы.")}");
        }
    }
}
