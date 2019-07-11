using ExtCore.Data.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using TL.Engine.SDK.Actions;
using TL.Engine.Services;

namespace TL.Engine.Actions.Startup
{
    public class DbExistStartup : IStartupAction
    {
        IStorage Storage { get; }

        public DbExistStartup(IStorage storage)
        {
            Storage = storage;
        }

        public int Priority => 200;

        public string Description => $"Проверка существования БД";

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
