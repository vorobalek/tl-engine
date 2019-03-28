using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using TL.Integrations.SDK.Telegram.Messages;

namespace TL.Integrations.SDK.Telegram.Bots
{
    public abstract class BaseBot : IBaseBot
    {
        public BaseBot(string token, string name = null, bool skipUpdates = false, int retryPeriod = 5000, int cancelTimeout = 5000)
        {
            Token = token;
            NativeName = name;
            SkipUpdates = skipUpdates;
            RetryPeriod = retryPeriod;
            CancelTimeout = cancelTimeout;

            TgClient = new TelegramBotClient(token);
            TgClient.OnUpdate += TgClient_OnUpdate;
            TgClient.OnReceiveError += TgClient_OnReceiveError;
        }

        public virtual string Token { get; }

        public virtual string Username { get; protected set; }

        public virtual string NativeName { get; }

        public bool IsOnline { get; protected set; }

        public int UpdatesSummaryCount { get; protected set; } = 0;

        public int RequestsSummaryCount { get; protected set; } = 0;

        public double PerformanceMs => RequestsSummaryTime.Sum(it => it.TotalMilliseconds) / RequestsSummaryCountTemp;

        public TimeSpan Uptime => DateTime.Now - StartTime;

        public abstract void Send(IMessage message);

        public abstract Task SendAsync(IMessage message);

        public virtual Task<bool> StartAsync()
        {
            return Task.Run(() =>
            {
                try
                {
                    WorkThread = new Thread(WorkProcess)
                    {
                        Name = Username
                    };
                    MessagesQueue = new ConcurrentQueue<IMessage>();

                    UpdatesSummaryCount = 0;
                    RequestsSummaryCount = 0;
                    RequestsSummaryCountTemp = 0;
                    RequestsSummaryTime = new TimeSpan[10];

                    IsOnline = true;
                    WorkThread.Start();
                    TgClient.StartReceiving();
                    StartTime = DateTime.Now;
                    return true;
                }
                catch
                {
                    return false;
                }
            });
        }

        public virtual Task<bool> StopAsync()
        {
            return Task.Run(() =>
            {
                try
                {
                    TgClient.StopReceiving();
                    while (!MessagesQueue.IsEmpty)
                    {
                        Thread.Sleep(1000);
                    }
                    IsOnline = false;
                    while (WorkThread.ThreadState == ThreadState.Running)
                    {
                        Thread.Sleep(1000);
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            });
        }

        protected virtual bool SkipUpdates { get; set; }

        protected virtual int SkippedUpdatesCount { get; set; }

        protected virtual void TgClient_OnUpdate(object sender, UpdateEventArgs e)
        {
            if (SkipUpdates)
            {
                if (UpdatesSummaryCount < SkippedUpdatesCount)
                {
                    ++UpdatesSummaryCount;
                    return;
                }
                else
                {
                    SkipUpdates = false;
                }
            }
        }

        protected abstract void TgClient_OnReceiveError(object sender, ReceiveErrorEventArgs e);

        protected abstract void Process();

        protected int RetryPeriod { get; set; }

        protected int CancelTimeout { get; set; }

        protected ConcurrentQueue<IMessage> MessagesQueue { get; set; }

        protected TelegramBotClient TgClient { get; }

        private DateTime StartTime { get; set; }

        private TimeSpan[] RequestsSummaryTime { get; set; } = new TimeSpan[10];

        private int RequestsSummaryCountTemp { get; set; }

        private Thread WorkThread { get; set; }

        private void WorkProcess()
        {
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

                RequestsSummaryTime[++RequestsSummaryCount % 10] = (stop - start);
                RequestsSummaryCountTemp = Math.Min(RequestsSummaryCount, 10);
            }
        }
    }
}
