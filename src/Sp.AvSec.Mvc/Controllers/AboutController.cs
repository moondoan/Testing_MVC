using System.Web.Mvc;

namespace Sp.AvSec.Mvc.Controllers
{
    public class AboutController : AvSecControllerBase
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
    }
}