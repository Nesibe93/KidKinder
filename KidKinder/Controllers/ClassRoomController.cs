using KidKinder.Context;
using System.Linq;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ClassRoomController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.ClassRooms.ToList();
            return View(values);
        }
        public PartialViewResult ClassRoomHeaderPartial()
        {
            return PartialView();
        }
    }
}