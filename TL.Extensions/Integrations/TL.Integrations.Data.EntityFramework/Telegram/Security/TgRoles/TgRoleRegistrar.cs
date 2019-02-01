using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgRoles
{
    public class TgRoleRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new TgRoleConfiguration());
        }
    }
}
