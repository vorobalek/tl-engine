using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Integrations.Data.EntityFramework.Telegram.Relationships.TgConnections
{
    public class TgConnectionRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new TgConnectionConfiguration());
        }
    }
}
