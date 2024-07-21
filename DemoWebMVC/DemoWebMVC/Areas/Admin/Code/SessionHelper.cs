using System.Web;

namespace DemoWebMVC.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void SetSesstion(UserSession session)
        {
            HttpContext.Current.Session["LoginSesstion"] = session;
        }
        public static UserSession GetCurrentSession()
        {
            var session = HttpContext.Current.Session["LoginSesstion"];
            if (session == null)
            {
                return null;
            }
            return session as UserSession;
        }
    }
}