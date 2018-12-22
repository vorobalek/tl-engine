using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Engine.Data.Entities.System;

namespace TL.Engine.Data.EntityFramework.System
{
    public class StringVariableRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new StringVariableConfig());
        }
    }
}
