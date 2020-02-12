
using CodeFirst.Models;
using System.Linq;
using System.Web.Mvc;

namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public EmployeeDBContext employeeDBContext = new EmployeeDBContext();

        public ActionResult Index()
        {
            return View(employeeDBContext.Departments.ToList());
        }

        /*public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}