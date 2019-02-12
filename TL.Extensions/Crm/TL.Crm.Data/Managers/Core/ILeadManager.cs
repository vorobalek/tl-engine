using System;
using TL.Crm.Data.Entities.Core;

namespace TL.Crm.Data.Managers
{
    public interface ILeadManager
    {
        Lead Get(Guid guid);

        Lead Create();
    }
}
