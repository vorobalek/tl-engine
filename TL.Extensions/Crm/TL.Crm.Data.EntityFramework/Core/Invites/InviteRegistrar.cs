using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Crm.Data.EntityFramework.Core.Invites
{
    public class InviteRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new InviteConfiguration());
        }
    }
}
