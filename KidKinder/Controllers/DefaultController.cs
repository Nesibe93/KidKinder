using KidKinder.Context;
using KidKinder.Entities;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class DefaultController : Controller
    {

        KidKinderContext context = new KidKinderContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var values = context.Features.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = context.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            //var values= context.Abouts.Select(x => x.Description.Substring(0, 100)).ToList();
            //return PartialView(values);

            var degerler = context.Abouts.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult PartialClassRooms()
        {
            var values = context.ClassRooms.OrderByDescending(x => x.ClassRoomId).Take(3).ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialBookASeat()
        {
            ViewBag.ClassRoom = new SelectList(context.ClassRooms.ToList(), "ClassRoomId", "Title");
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialBookASeat(BookASeat p)
        {
            context.BookASeats.Add(p);
            context.SaveChanges();
            return PartialView();
        }

        public PartialViewResult PartialTeacher()
        {
            var degerler = context.Teachers.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult PartialTestimonial()
        {
            var degerler = context.Testimonials.ToList();
            return PartialView(degerler);
        }
        [HttpGet]
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialFooter(MailSubscribe p)
        {
            context.MailSubscribes.Add(p);
            context.SaveChanges();
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult PartialAboutList()
        {
            var degerler = context.AboutLists.ToList();
            return PartialView(degerler);
        }
    }
}