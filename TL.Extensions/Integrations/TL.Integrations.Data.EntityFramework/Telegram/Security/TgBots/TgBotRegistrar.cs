using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgBots
{
    public class TgBotRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new TgBotConfiguration());
        }
    }
}
