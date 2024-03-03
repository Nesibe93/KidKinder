using KidKinder.Context;
using KidKinder.Entities;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;


namespace KidKinder.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        KidKinderContext context = new KidKinderContext();

        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            var result = context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(admin.Username, true);
                Session["Username"] = result.Username.ToString();
                return RedirectToAction("TeacherList", "Teacher");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // Abandon: Terk Etmek 
            return RedirectToAction("AdminLogin", "Login");
        }
    }
}