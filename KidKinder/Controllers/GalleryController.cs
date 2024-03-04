using KidKinder.Context;
using System.Web.Mvc;
using KidKinder.Entities;
using System.Linq;

namespace KidKinder.Controllers
{
    public class GalleryController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Galleries.Where(g => g.Status == true).Take(6).ToList();
            return View(values);
        }
    }
}