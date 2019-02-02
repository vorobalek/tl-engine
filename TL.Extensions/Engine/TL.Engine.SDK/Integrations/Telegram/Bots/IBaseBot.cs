using System;
using System.Threading.Tasks;
using TL.Engine.SDK.Integrations.Telegram.Messages;

namespace TL.Engine.SDK.Integrations.Telegram.Bots
{
    public interface IBaseBot
    {
        string Token { get; }

        string Username { get; }

        string NativeName { get; }

        bool IsOnline { get; }

        int RequestSumaryCount { get; set; }

        double PerformanceMs { get; }

        TimeSpan Uptime { get; }

        [Obsolete("Использование этого метода может отрицаельно сказаться на производительности системы")]
        void Send(IMessage message);

        Task SendAsync(IMessage message);

        Task StartAsync();

        Task StopAsync();
    }
}
