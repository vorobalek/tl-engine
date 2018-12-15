using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Account.Data.Entities.Secutiry;

namespace TL.Account.Data.EntityFramework.Sqlite.Security.Roles
{
    public class RoleRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Role>(etb =>
            {
                etb.HasKey(e => e.Id);
                etb.Property(e => e.Id);

                etb.HasIndex(e => e.Name).IsUnique();
                etb.Property(e => e.Name);

                etb.ToTable("Roles");
            });
        }
    }
}
