using System.Web.Mvc;

namespace DemoWebMVC.Areas.Admin.Controllers
{
    [Authorize]
    public class AdminHomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}