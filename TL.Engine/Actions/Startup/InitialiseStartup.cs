using TL.Engine.SDK.Actions;

namespace TL.Engine.Actions
{
    public class InitialiseStartup : IStartupAction
    {
        public int Priority => int.MinValue;

        public string Description => "Инициализация загрузчика.";

        public IStartupActionResult Invoke()
        {
            return StartupActionResult.Good(description: Description);
        }
    }
}
