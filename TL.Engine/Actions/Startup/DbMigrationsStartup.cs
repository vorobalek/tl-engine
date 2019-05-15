using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Actions;
using TL.Engine.Services;

namespace TL.Engine.Actions.Startup
{
    public class DbMigrationsStartup : IStartupAction
    {
        public bool IsBlocker => true;

        public int Priority => 400;

        public string Description => $"Проверка миграций в БД.";

        public IStartupActionResult Invoke()
        {
            var context = DesignTimeStorageContextFactory.StorageContext;
            var pendingMigrations = context.Database.GetPendingMigrations();
            var migrations = pendingMigrations as IList<string> ?? pendingMigrations.ToList();
            if (!migrations.Any())
            {
                return StartupActionResult.Good(description: Description);
            }
            return StartupActionResult.Bad($"Обновлений структуры БД: {migrations.Count}", $"{string.Join("\r\n", migrations)}");
        }
    }
}
