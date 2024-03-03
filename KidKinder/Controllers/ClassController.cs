using KidKinder.Context;
using KidKinder.Entities;
using System.Linq;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ClassController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult ClassList()
        {
            var values = context.ClassRooms.ToList();
            return View(values);
        }
        //Burda kaldım
        [HttpGet]
        public ActionResult AddClass()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClass(ClassRoom classroom)
        {
            context.ClassRooms.Add(classroom);
            context.SaveChanges();
            return RedirectToAction("ClassList");
        }
        public ActionResult DeleteClass(int id)
        {
            var value = context.ClassRooms.Find(id);
            context.ClassRooms.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ClassList");
        }

        [HttpGet]
        public ActionResult UpdateClass(int id)
        {
            var values = context.ClassRooms.Find(id);
            //context.SaveChanges();
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateClass(ClassRoom p)
        {
            var value = context.ClassRooms.Find(p.ClassRoomId);
            value.Title = p.Title;
            value.Description = p.Description;
            value.AgeofKids = p.AgeofKids;
            value.TotalSeats = p.TotalSeats;
            value.ClassTime = p.ClassTime;
            value.Price = p.Price;
            value.ImageUrl = p.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("ClassList");
        }



    }
}