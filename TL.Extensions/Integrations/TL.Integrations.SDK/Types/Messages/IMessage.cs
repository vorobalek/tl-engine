using System;
using System.Collections.Generic;
using System.Text;
using TL.Integrations.SDK.Types.Enums;

namespace TL.Integrations.SDK.Types.Messages
{
    public interface IMessage
    {
        MessageType Type { get; }
    }
}
