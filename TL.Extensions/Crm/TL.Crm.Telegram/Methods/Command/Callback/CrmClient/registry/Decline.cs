using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Extensions;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Callback.CrmClient.registry
{
    public class Decline : CrmClientBotCallbackHCommandMethod
    {
        public override string Command => "crm.registry.decline";

        public override string Description => "Сбросить введенные данные";

        public override int Priority => 65;

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var leadManager = serviceProvider.GetService<ILeadManager>();
                    var inviteManager = serviceProvider.GetService<IInviteManager>();
                    var contractorManager = serviceProvider.GetService<IContractorManager>();
                    var leadPhoneManager = serviceProvider.GetService<ILeadPhoneManager>();

                    var originalLead = user.GetOriginalLead(serviceProvider);
                    var originalContracotr = user.GetOriginalContractor(serviceProvider);

                    if (originalLead != null)
                    {
                        if (originalContracotr == null)
                        {
                            originalLead.Firstname = null;
                            originalLead.Lastname = null;
                            originalLead.Middlename = null;

                            leadManager.Update(originalLead);
                            leadPhoneManager.Delete(e => e.LeadId == originalLead.Id);

                            await Bot.SendAsync(new TlMessage()
                            {
                                MessageType = MessageType.Text,
                                ChatId = callbackQuery.From.Id,
                                
                                Text = $"‼️ <b>Данные сброшены, начните занаво!</b>",
                                ReplyMarkup = new ReplyKeyboardMarkup(new[]
                                {
                                    new[]
                                    {
                                        new KeyboardButton("👌🏻 Ок"),
                                    },
                                }, resizeKeyboard: true, oneTimeKeyboard: true),
                                ParseMode = ParseMode.Html,

                                IsEditMessage = true,
                                EditMessageId = callbackQuery.Message.MessageId,

                                IsCallbackAnswer = true,

                                CallbackQueryId = callbackQuery.Id,
                                CallbackAnswerText = $"‼️ Данные сброшены, начните занаво!",
                                CallbackShowAlert = true,
                            });
                        }
                        else
                        {
                            await Bot.SendAsync(new TlMessage()
                            {
                                MessageType = MessageType.Text,
                                ChatId = callbackQuery.From.Id,

                                Text = $"‼️ <b>Учетная карточка уже сущетвует, сброс данных невозможнен!</b>",
                                ParseMode = ParseMode.Html,

                                IsEditMessage = true,
                                EditMessageId = callbackQuery.Message.MessageId,

                                IsCallbackAnswer = true,

                                CallbackQueryId = callbackQuery.Id,
                                CallbackAnswerText = $"‼️ Учетная карточка уже сущетвует, сброс данных невозможнен!",
                                CallbackShowAlert = true,

                            });
                        }
                    }
                }
            }

            return new HandlerMethodResult(true);
        }
    }
}
