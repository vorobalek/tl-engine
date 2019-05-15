using System;

namespace TL.Engine.SDK.Actions
{
    public interface IStartupActionResult
    {
        string RedurectUrl { get; }
        DateTime Time { get; }
        bool IsFinal { get; }
        bool Ok { get; }
        string Message { get; }
        string Description { get; }
    }
}