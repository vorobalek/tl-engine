using ExtCore.Data.Abstractions;
using TL.Crm.SDK.Controllers;

namespace TL.Crm.Web.Areas.Crm.Controllers
{
    public abstract class __CrmController__ : BaseCrmController
    {
        public __CrmController__(IStorage storage) : base(storage)
        {
        }
    }
}
