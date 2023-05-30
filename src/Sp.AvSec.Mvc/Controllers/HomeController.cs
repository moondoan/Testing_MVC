using Abp.Web.Mvc.Authorization;
using System.Web.Mvc;

namespace Sp.AvSec.Mvc.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AvSecControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}