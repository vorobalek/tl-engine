using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Callback.CrmAdmin.invites
{
    public class Main : CrmAdminBotCallbackHCommandMethod
    {
        public override string Command => "invites.main";

        public override string Description => "Меню управления инвайтами";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var inviteManager = serviceProvider.GetService<IInviteManager>();
                    var invites = inviteManager.GetAll();

                    var leadManager = serviceProvider.GetService<ILeadManager>();
                    var invitedLeads = leadManager.GetAll(e => e.InviteId.HasValue);
                    var invitedContractors = invitedLeads.Where(e => e.ContractorId.HasValue);

                    await Bot.SendAsync(new TlMessage()
                    {
                        IsEditMessage = true,

                        MessageType = MessageType.Text,
                        ChatId = callbackQuery.From.Id,

                        Text = $"🔖 <b>Инвайты</b>\r\n" +
                        $"\r\n" +
                        $"Выдано инвайтов: <b>{invites.Count()}</b>\r\n" +
                        $"Привлечено лидов: <b>{invitedLeads.Count()}</b>\r\n" + 
                        $"Привлечено контрагентов: <b>{invitedContractors.Count()}</b>",
                        ReplyMarkup = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("⬅️ Назад", "main"),
                            }
                        }),
                        ParseMode = ParseMode.Html,

                        CallbackQueryId = callbackQuery.Id,
                        EditMessageId = callbackQuery.Message.MessageId,
                    });

                    return new HandlerMethodResult(true);
                }
            }

            return new HandlerMethodResult(false, null, $"{new ArgumentException($"В {nameof(args)} переданы неверные аргументы.")}");
        }
    }
}
