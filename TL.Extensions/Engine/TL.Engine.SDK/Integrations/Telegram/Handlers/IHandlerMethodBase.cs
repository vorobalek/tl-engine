using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public interface IHandlerMethodBase
    {
        IBaseBot Bot { get; }
        IHandlerBase Handler { get; set; }

        int Priority { get; }
        string Command { get; }
        string Description { get; }

        bool IsBlocker { get; }
        bool IsPrivate { get; }
        bool IsTerminated { get; }

        bool IsRelevantMethod(Update update);
        bool IsPolicyAcceptable(Update update);

        Type BotType { get; }
        Type HandlerType { get; }

        UpdateType UpdateType { get; }

        Task<IHandlerMethodResult> TryExecuteAsync(Update update);
    }
}
