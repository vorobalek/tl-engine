using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.EntityFramework.Core.Folders
{
    public class FolderRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration<Folder>(new FolderConfiguration());
        }
    }
}
