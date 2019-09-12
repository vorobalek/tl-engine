using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.JustBot.Data.EntityFramework.Common
{
    public class HistoryRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new HistoryConfiguration());
        }
    }
}
