using System;
using TL.Engine.SDK.Services;
using TL.Integrations.Telegram.Bots;

namespace TL.Integrations.Telegram.Methods.Command.Message.Base
{
    public abstract class BaseBotMessageHCommandMethod : MessageHCommandMethod
    {
        public BaseBotMessageHCommandMethod(IActivatorService activator) : base(activator)
        {
        }

        public override Type BotType => typeof(BaseBot);

        public new BaseBot Bot => base.Bot as BaseBot;
    }
}
