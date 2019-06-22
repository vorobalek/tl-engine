using System;
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Services;

namespace TL.Engine.Actions.Startup
{
    public class EntityIndexerInitialiseStartup : IStartupAction
    {
        public bool IsBlocker => true;

        public int Priority => 1000;

        public string Description => "Инициализация сервиса полнотекстовой индексации сущностей";

        IEntityIndexerService EntityIndexer { get; }

        public EntityIndexerInitialiseStartup(IEntityIndexerService entityIndexer)
        {
            EntityIndexer = entityIndexer;
        }

        public IStartupActionResult Invoke()
        {
            DateTime dt = DateTime.Now;
            try
            {
                EntityIndexer.Reset();
            }
            catch (Exception ex)
            {
                return StartupActionResult.Broken($"{ex}", "Не удалость инициализировать сервис полнотекстовой индексации сущностей");
            }
            return StartupActionResult.Good(description: $"Время инициализации: {DateTime.Now - dt}");
        }
    }
}
