using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Integrations.SDK.Telegram.Bots;

namespace TL.Integrations.SDK.Telegram.Handlers
{
    public interface IHandlerMethodBase
    {
        IHandlerMethodBase Configure(Type handlerType);

        IBaseBot Bot { get; }
        IHandlerBase Handler { get; set; }

        int Priority { get; }
        string Command { get; }
        string Description { get; }

        bool CanInvokeNext { get; }
        bool IsBlocker { get; }
        bool IsPrivate { get; }
        bool IsTerminated { get; }

        bool IsRelevantMethod(Update update, params object[] args);
        bool IsPolicyAcceptable(Update update, params object[] args);

        Type BotType { get; }
        Type HandlerType { get; }

        UpdateType UpdateType { get; }

        Task<IHandlerMethodResult> TryExecuteAsync(Update update, params object[] args);
    }
}
