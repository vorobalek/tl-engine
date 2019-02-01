using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TL.Integrations.Data.EntityFramework.Telegram.Security.TgUsersRoles
{
    public class TgUserRoleRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new TgUserRoleConfiguration());
        }
    }
}
