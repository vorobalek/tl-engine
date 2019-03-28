using System;
using System.Threading.Tasks;
using TL.Integrations.SDK.Telegram.Messages;

namespace TL.Integrations.SDK.Telegram.Bots
{
    public interface IBaseBot
    {
        string Token { get; }

        string Username { get; }

        string NativeName { get; }

        bool IsOnline { get; }

        int UpdatesSummaryCount { get; }

        int RequestsSummaryCount { get; }

        double PerformanceMs { get; }

        TimeSpan Uptime { get; }

        [Obsolete("Использование этого метода может отрицаельно сказаться на производительности системы")]
        void Send(IMessage message);

        Task SendAsync(IMessage message);

        Task<bool> StartAsync();

        Task<bool> StopAsync();
    }
}
