using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Integrations.SDK.Telegram.Bots;

namespace TL.Integrations.SDK.Telegram.Handlers
{
    public interface IHandlerBase
    {
        IHandlerBase Configure(Type botType);

        IBaseBot Bot { get; }

        List<IHandlerMethodBase> Methods { get; }

        Task<IHandlerResult> ExecuteAsync(Update update, params object[] args);
    }
}