using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Registry.Data.EntityFramework.Core.Registries
{
    public class RegistryRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration<Entities.Core.Registry>(new RegistryConfiguration());
        }
    }
}
