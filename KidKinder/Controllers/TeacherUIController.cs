using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class TeacherUIController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult TeacherHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult TeacherIndexPartial()
        {
            var values = context.Teachers.ToList();
            return PartialView(values);

        }
    }
}