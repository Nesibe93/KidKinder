using KidKinder.Context;
using System.Linq;
using System.Web.Mvc;

namespace KidKinder.Controllers
{

    public class AboutController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AboutHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutIndexPartial()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }
    }
}