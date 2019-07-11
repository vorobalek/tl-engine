using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Services;
using TL.Engine.Services;

namespace TL.Engine.Actions.Startup
{
    public class DbMigrationsStartup : IStartupAction
    {
        public int Priority => 400;

        public string Description => $"Проверка миграций в БД.";

        IStartupService StartupService { get; }

        public DbMigrationsStartup(IStartupService startupService)
        {
            StartupService = startupService;
        }

        public IStartupActionResult Invoke()
        {
            var context = DesignTimeStorageContextFactory.StorageContext;
            var pendingMigrations = context.Database.GetPendingMigrations();
            var migrations = pendingMigrations as IList<string> ?? pendingMigrations.ToList();
            if (!migrations.Any())
            {
                return StartupActionResult.Good(description: Description);
            }
            else
            {
                var message = $"Применение обновлений структуры БД: {string.Join("\r\n", migrations)}";
                try
                {
                    context.Database.Migrate();
                    return StartupActionResult.Good(description: message);
                }
                catch (Exception ex)
                {
                    return StartupActionResult.Broken(message, ex.ToString());
                }
            }
        }
    }
}
