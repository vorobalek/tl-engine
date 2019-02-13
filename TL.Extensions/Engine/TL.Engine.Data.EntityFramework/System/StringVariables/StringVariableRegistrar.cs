using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Engine.Data.EntityFramework.System.StringVariables
{
    public class StringVariableRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new StringVariableConfiguration());
        }
    }
}
