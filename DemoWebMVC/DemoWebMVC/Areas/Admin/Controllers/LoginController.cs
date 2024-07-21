using DemoWebMVC.Areas.Admin.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace DemoWebMVC.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserModel user)
        {
            if (Membership.ValidateUser(user.UserName, user.Password))
            {
                //SessionHelper.SetSesstion(new UserSession() { UserName = user.UserName });
                FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
                return RedirectToAction("Index", "AdminHome");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
            }
            return View(user);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}