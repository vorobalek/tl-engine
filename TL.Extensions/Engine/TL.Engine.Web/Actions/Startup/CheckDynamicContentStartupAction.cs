using System;
using TL.Engine.SDK.Actions;

namespace TL.Engine.Web.Actions.Startup
{
    public class CheckDynamicContentStartupAction : IStartupAction
    {
        public int Priority => 1000;

        public string Description => "Проверка динамического контента.";

        public IStartupActionResult Invoke()
        {
            return StartupActionResult.Good();
        }
    }
}
