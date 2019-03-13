using System;
using System.Collections.Generic;
using System.Text;
using TL.Integrations.SDK.Types.Enums;

namespace TL.Integrations.SDK.Types.Messages
{
    public class TextMessage : IMessage
    {
        public MessageType Type => MessageType.Text;

        public ParseMode ParseMode { get; set; }

        public string Text { get; set; }
    }
}
