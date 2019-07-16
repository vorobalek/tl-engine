using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.EntityFramework.Core.RegistryFolders
{
    public class RegistryFolderRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration<RegistryFolder>(new RegistryFolderConfiguration());
        }
    }
}
