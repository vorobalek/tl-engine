using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TL.Integrations.Data.Entities.Telegram.Security;
using TL.Integrations.Data.Managers;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmAdmin
{
    public class Protection : CrmAdminBotMessageHCommandMethod
    {
        public override bool IsPrivate => true;

        public override bool IsBlocker => false;

        public override string Command => "";

        public override int Priority => 10;

        public override string Description => "";

        public override bool IsRelevantMethod(Update update, params object[] args)
        {
            return true;
        }

        protected override Task<IHandlerMethodResult> ExecuteAsync(Update update, params object[] args)
        {
            var message = update.Message ?? new global::Telegram.Bot.Types.Message()
            {
                Text = "",
                From = update.GetSenderUser(),
            };
            return ExecuteAsync(message, args);
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var tgUserManager = serviceProvider.GetService<ITgUserManager>();
                    var tgRoleManager = serviceProvider.GetService<ITgRoleManager>();

                    var tgUser = tgUserManager.Get(message.From.Id);
                    if (tgUser.UserRoles.FirstOrDefault(e => e.RoleId == TgRole.Sa.Id) != null)
                    {
                        ContinueExecute();
                    }
                    else
                    {

                    }

                    return new HandlerMethodResult(true);
                }
            }

            return new HandlerMethodResult(false, null, $"{new ArgumentException($"В {nameof(args)} переданы неверные аргументы.")}");
        }
    }
}
