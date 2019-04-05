using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Api.Data.EntityFramework.Security.TokensLogs
{
    public class TokenLogRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new TokenLogConfiguration());
        }
    }
}
