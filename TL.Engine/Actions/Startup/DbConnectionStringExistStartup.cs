using Microsoft.Extensions.Configuration;
using TL.Engine.SDK.Actions;

namespace TL.Engine.Actions.Startup
{
    public class DbConnectionStringExistStartup : IStartupAction
    {
        public int Priority => 100;

        public string Description => "Проверка существования строки подключения к БД.";

        IConfiguration Configuration { get; }

        public DbConnectionStringExistStartup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IStartupActionResult Invoke()
        {
            if (string.IsNullOrWhiteSpace(Configuration.GetConnectionString("Default")))
            {
                return StartupActionResult.Bad("Fail", "Отсутствует строка подключения к БД.");
            }

            return StartupActionResult.Good(description: Description);
        }
    }
}
