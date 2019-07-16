using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Registry.Data.Entities.Core;

namespace TL.Registry.Data.EntityFramework.Core.Files
{
    public class FileRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration<File>(new FileConfiguration());
        }
    }
}
