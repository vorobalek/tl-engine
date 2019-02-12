using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Crm.Data.EntityFramework.Core.Contractors
{
    public class ContractorRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new ContractorConfiguration());
        }
    }
}
