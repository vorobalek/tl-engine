using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.JustBot.Data.EntityFramework.Security
{
    public class PersonRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new PersonConfiguration());
        }
    }
}
