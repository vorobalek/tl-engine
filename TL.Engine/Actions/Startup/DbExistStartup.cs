using ExtCore.Data.Abstractions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
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

        public bool IsBlocker => true;

        public int Priority => 200;

        public string Description => $"Проверка существования БД";

        public IStartupActionResult Invoke()
        {
            var context = DesignTimeStorageContextFactory.StorageContext;
            if (context.Database.GetService<IRelationalDatabaseCreator>().Exists())
            {
                return StartupActionResult.Good("Ok", "База данных существует.");
            }
            else
            {
                return StartupActionResult.Bad("Отсутствует подключение к базе данных.");
            }
        }
    }
}
