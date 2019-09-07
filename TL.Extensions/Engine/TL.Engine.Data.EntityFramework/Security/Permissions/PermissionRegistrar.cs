using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Engine.Data.EntityFramework.Security.Permissions
{
    public class PermissionRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new PermissionConfiguration());
        }
    }
}
