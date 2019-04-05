using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Engine.Data.EntityFramework.Security.UsersGroups
{
    public class UserGroupRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new UserGroupConfiguration());
        }
    }
}
