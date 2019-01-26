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

        void Send(IMessage message);

        Task SendAsync(IMessage message);

        Task StartAsync();

        Task StopAsync();

        TimeSpan Uptime { get; }

        double PerformanceMs { get; }
    }
}
