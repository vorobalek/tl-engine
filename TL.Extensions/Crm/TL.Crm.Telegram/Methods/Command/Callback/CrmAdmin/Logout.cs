using ExtCore.Data.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.Security;
using TL.Integrations.Data.Managers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Callback.CrmAdmin
{
    public class Logout : CrmAdminBotCallbackHCommandMethod
    {
        public override string Command => "logout";

        public override string Description => "Снять привелегии администратора";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var tgUserManager = serviceProvider.GetService<ITgUserManager>();
                    var tgRoleManager = serviceProvider.GetService<ITgRoleManager>();

                    var tgUser = tgUserManager.Get(callbackQuery.From.Id);
                    if (tgUser.UserRoles.FirstOrDefault(e => e.RoleId == TgRole.Admin.Id) != null)
                    {
                        var tgUserRole = serviceProvider.GetService<ITgUserRoleManager>().Get(e => e.UserId == tgUser.Id && e.RoleId == TgRole.Admin.Id);

                        if (tgUserRole != null)
                        {
                            var storage = serviceProvider.GetService<IStorage>();
                            var tgUserRoleRepository = storage.GetRepository<ITgUserRoleRepository>();
                            tgUserRoleRepository.Remove(tgUserRole);
                            storage.Save();
                        }

                        await Bot.SendAsync(new TlMessage()
                        {
                            IsEditMessage = true,

                            MessageType = MessageType.Text,
                            ChatId = callbackQuery.From.Id,

                            Text = $"👋🏻 <b>Вы сняли с себя полномочия администратора!</b>",
                            ParseMode = ParseMode.Html,

                            CallbackQueryId = callbackQuery.Id,
                            EditMessageId = callbackQuery.Message.MessageId,
                        });
                    }

                    return new HandlerMethodResult(true);
                }
            }

            return new HandlerMethodResult(false, null, $"{new ArgumentException($"В {nameof(args)} переданы неверные аргументы.")}");
        }
    }
}
