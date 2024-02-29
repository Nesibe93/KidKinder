using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;


namespace KidKinder.Controllers
{
    public class DashboardController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            //Branşı resim çizme olan öğretmen sayısı
            int branchIdByResimCizme = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z=>z.BranchName == "Resim Çizim").Select(y => y.BranchId).FirstOrDefault()).Count();

            ViewBag.ResimCizmeCount = context.Teachers.Where(x => x.BranchId == branchIdByResimCizme).Count();

            ViewBag.AvgPrice = context.ClassRooms.Average(x => x.Price).ToString("0.00");
            return View();
        }
    }
}