using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Crm.Data.EntityFramework.Periphery.Phones
{
    public class LeadPhoneRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new LeadPhoneConfiguration());
        }
    }
}
