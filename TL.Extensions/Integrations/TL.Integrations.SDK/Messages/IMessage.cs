using System;
using System.Collections.Generic;
using System.Text;

namespace TL.Integrations.SDK.Messages
{
    public enum MessageType
    {
        Text,


    }

    public interface IMessage
    {
        MessageType Type { get; set; }
    }
}
