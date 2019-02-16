using ExtCore.Data.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Crm.Data.Abstractions.Core;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TLUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient
{
    public class Start : CrmClientBotMessageHCommandMethod
    {
        public override string Command => "/start";

        public override string Description => "Начать работу с ботом";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TLUser user)
                {
                    var storage = serviceProvider.GetService<IStorage>();
                    var leadRepository = storage.GetRepository<ILeadRepository>();
                    var lead = leadRepository.GetByUserId(user.Id);
                    if (lead == null)
                    {
                        lead = leadRepository.Add(new Lead()
                        {
                            User = user,
                        });
                        storage.Save();
                    }
                }
            }

            return new HandlerMethodResult(true);
        }
    }
}
