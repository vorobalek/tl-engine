using System;

namespace TL.Engine.SDK.Actions
{
    public class StartupActionResult : IStartupActionResult
    {
        public bool IsFinal { get; private set; }

        public bool Ok { get; private set; }

        public string Message { get; private set; }

        public string Description { get; private set; }

        public DateTime Time { get; private set; }

        public string RedurectUrl { get; private set; }

        public StartupActionResult()
        {
            Time = DateTime.Now.ToUniversalTime();
        }

        public static StartupActionResult Good(string message = "Ok", string description = null, string redirectUrl = "/runtime") => new StartupActionResult()
        {
            IsFinal = true,
            Ok = true,
            Message = message,
            Description = description,
            RedurectUrl = redirectUrl,
        };

        public static StartupActionResult Broken(string message, string description = null, string redirectUrl = "/runtime") => new StartupActionResult()
        {
            IsFinal = false,
            Ok = false,
            Message = message,
            Description = description,
            RedurectUrl = redirectUrl,
        };

        public static StartupActionResult Bad(string message, string description = null, string redirectUrl = "/runtime") => new StartupActionResult()
        {
            IsFinal = true,
            Ok = false,
            Message = message,
            Description = description,
            RedurectUrl = redirectUrl,
        };
    }
}
