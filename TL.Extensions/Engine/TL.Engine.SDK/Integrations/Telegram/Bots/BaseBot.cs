using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using TL.Engine.SDK.Integrations.Telegram.Messages;

namespace TL.Engine.SDK.Integrations.Telegram.Bots
{
    public abstract class BaseBot : IBaseBot
    {
        public BaseBot(string token, string name = null, int retryPeriod = 5000, int cancelTimeout = 5000)
        {
            Token = token;
            NativeName = name;
            RetryPeriod = retryPeriod;
            CancelTimeout = cancelTimeout;
            TgClient = new TelegramBotClient(token);
        }

        public virtual string Token { get; }

        public virtual string Username { get; protected set; }

        public virtual string NativeName { get; }

        public bool IsOnline { get; protected set; }

        public abstract void Send(IMessage message);

        public abstract Task SendAsync(IMessage message);

        public virtual Task StartAsync()
        {
            return Task.Run(() =>
            {
                WorkThread = new Thread(WorkProcess)
                {
                    Name = Username
                };
                MessagesQueue = new ConcurrentQueue<IMessage>();
                TgClient.OnUpdate += TgClient_OnUpdate;
                TgClient.OnReceiveError += TgClient_OnReceiveError;

                IsOnline = true;
                WorkThread.Start();
                TgClient.StartReceiving();
                StartTime = DateTime.Now;
            });
        }

        public virtual Task StopAsync()
        {
            return Task.Run(() =>
            {
                TgClient.StopReceiving();
                TgClient.OnUpdate -= TgClient_OnUpdate;
                TgClient.OnReceiveError -= TgClient_OnReceiveError;
                while (!MessagesQueue.IsEmpty)
                {
                    Thread.Sleep(1000);
                }
                IsOnline = false;
                while (WorkThread.ThreadState == ThreadState.Running)
                {
                    Thread.Sleep(1000);
                }
            });
        }

        protected abstract void TgClient_OnUpdate(object sender, UpdateEventArgs e);

        protected abstract void TgClient_OnReceiveError(object sender, ReceiveErrorEventArgs e);

        protected abstract void Process();

        protected int RetryPeriod { get; set; }

        protected int CancelTimeout { get; set; }

        protected ConcurrentQueue<IMessage> MessagesQueue { get; set; }

        protected TelegramBotClient TgClient { get; }

        private DateTime StartTime { get; set; }

        private TimeSpan[] RequestSumaryTime { get; set; } = new TimeSpan[10];

        private int RequestSumaryCount { get; set; }

        private int RequestSumaryCountTemp { get; set; }

        private Thread WorkThread { get; set; }

        public TimeSpan Uptime => DateTime.Now - StartTime;

        public double PerformanceMs => RequestSumaryTime.Sum(it => it.TotalMilliseconds) / RequestSumaryCountTemp;

        private void WorkProcess()
        {
            int i = 0;
            while (IsOnline)
            {
                if (MessagesQueue.IsEmpty)
                {
                    Thread.Sleep(10);
                    continue;
                }

                var start = DateTime.Now;
                Process();
                var stop = DateTime.Now;

                RequestSumaryTime[++i % 10] = (stop - start);
                ++RequestSumaryCount;
                RequestSumaryCountTemp = i;
            }
        }
    }
}
