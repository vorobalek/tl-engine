using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Extensions;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Callback.CrmClient.invites
{
    public class New : CrmClientBotCallbackHCommandMethod
    {
        public override string Command => "crm.invites.new";

        public override string Description => "Отправить новый инвайт";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var leadManager = serviceProvider.GetService<ILeadManager>();
                    var contractorManager = serviceProvider.GetService<IContractorManager>();
                    var inviteManager = serviceProvider.GetService<IInviteManager>();

                    var lead = leadManager.GetOriginal(e => e.UserId == user.Id);
                    var contractor = contractorManager.GetOriginal(e => e.Id == lead.ContractorId);

                    var invite = inviteManager.Create(new Invite()
                    {
                        ReferrerId = contractor.Id,
                    });

                    await Bot.SendAsync(new TlMessage()
                    {
                        IsEditMessage = true,

                        MessageType = MessageType.Text,
                        ChatId = callbackQuery.From.Id,

                        Text = $"🖖🏻 <b>{lead.Firstname}, этот инвайт вы можете подарить своиему другу или подруге.</b>\r\n" +
                        $"\r\n" +
                        $"Ссылка на бота: t.me/{Bot.Username}\r\n" +
                        $"Код инвайта: <code>{invite.Id.ToString()}</code>",

                        ParseMode = ParseMode.Html,

                        CallbackQueryId = callbackQuery.Id,
                        EditMessageId = callbackQuery.Message.MessageId,
                    });

                    await Bot.SendAsync(new TlMessage()
                    {
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
                    });
                }

                return new HandlerMethodResult(true);
            }

            return new HandlerMethodResult(false, null, $"{new ArgumentException($"В {nameof(args)} переданы неверные аргументы.")}");
        }
    }
}
