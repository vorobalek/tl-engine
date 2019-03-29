using ExtCore.Data.Abstractions;
using TL.Blog.SDK.Controllers;

namespace TL.Blog.Web.Areas.Blog.Controllers
{
    public abstract class __BlogController__ : BaseBlogController
    {
        public __BlogController__(IStorage storage) : base(storage)
        {
        }
    }
}
