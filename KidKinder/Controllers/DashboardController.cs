using KidKinder.Context;
using System.Linq;
using System.Web.Mvc;


namespace KidKinder.Controllers
{
    public class DashboardController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            //Branşı resim çizme olan öğretmen sayısı
            int branchIdByResimCizme = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.BranchName == "Resim Çizim").Select(y => y.BranchId).FirstOrDefault()).Count();

            ViewBag.ResimCizmeCount = context.Teachers.Where(x => x.BranchId == branchIdByResimCizme).Count();

            ViewBag.AvgPrice = context.ClassRooms.Average(x => x.Price).ToString("0.00");

            //Charts
            var totalSeatsData = context.ClassRooms
                                    .Select(x => new { ClassName = x.Title, TotalSeats = x.TotalSeats })
                                    .ToList();

            ViewBag.TotalSeatsData = totalSeatsData;

            return View();



        }
    }
}