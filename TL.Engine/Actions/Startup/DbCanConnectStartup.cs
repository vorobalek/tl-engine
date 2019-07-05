using TL.Engine.SDK.Actions;
using TL.Engine.Services;

namespace TL.Engine.Actions.Startup
{
    public class DbCanConnectStartup : IStartupAction
    {
        public bool IsBlocker => false;

        public int Priority => 300;

        public string Description => "Проверка подключения к БД.";

        public IStartupActionResult Invoke()
        {
            var context = DesignTimeStorageContextFactory.StorageContext;
            if (context.Database.CanConnect())
            {
                return StartupActionResult.Good(description: Description);
            }
            return StartupActionResult.Bad("Fail", Description);
        }
    }
}
