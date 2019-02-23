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

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var leadManager = serviceProvider.GetService<ILeadManager>();
                    var leadPhoneManager = serviceProvider.GetService<ILeadPhoneManager>();

                    var originalLead = user.GetOriginalLead(serviceProvider);

                    if (originalLead != null)
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

                            IsEditMessage = true,
                            IsCallbackAnswer = true,

                            CallbackQueryId = callbackQuery.Id,
                            CallbackAnswerText = $"‼️ Данные сброшены, начните занаво!",
                            CallbackShowAlert = true,

                        });
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
                        });
                    }
                }
            }

            return new HandlerMethodResult(true);
        }
    }
}
