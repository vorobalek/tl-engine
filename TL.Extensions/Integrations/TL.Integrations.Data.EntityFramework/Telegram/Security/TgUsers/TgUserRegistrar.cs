using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgUsers
{
    public class TgUserRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new TgUserConfiguration());
        }
    }
}
