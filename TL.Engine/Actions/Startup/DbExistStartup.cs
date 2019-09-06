using ExtCore.Data.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Services;
using TL.Engine.Services;

namespace TL.Engine.Actions.Startup
{
    public class DbExistStartup : IStartupAction
    {
        IStorage Storage { get; }

        IStartupService Service { get; }

        public DbExistStartup(IStorage storage, IStartupService service)
        {
            Storage = storage;
            Service = service;
        }

        public int Priority => 200;

        public string Description => $"Проверка существования БД.";

        public IStartupActionResult Invoke()
        {
            var context = DesignTimeStorageContextFactory.StorageContext;
            if (context.Database.GetService<IRelationalDatabaseCreator>().Exists())
            {
                return StartupActionResult.Good(description: Description);
            }
            else
            {
                try
                {
                    Service.InvokeCallback("База данных не обнаружена. Попытка создать базу данных автоматически.", 50.0);
                    context.Database.Migrate();
                    return StartupActionResult.Good(description: "База данных создана автоматически согласно строке подключения.");
                }
                catch (Exception ex)
                {
                    return StartupActionResult.Broken($"База данных не обнаружена. Попытка создать базу данных автоматически завершена с ошибкой {ex}");
                }
            }
        }
    }
}
