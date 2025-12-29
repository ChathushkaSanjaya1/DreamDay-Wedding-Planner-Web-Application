using Microsoft.AspNetCore.Mvc;

namespace DreamDay___Wedding_Planner_Web_Application.Controllers
{
    public class PlannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Weddings()
        {
            return View();
        }
        public IActionResult Clients()
        {
            return View();
        }
        public IActionResult Messages()
        {
            return View();
        }
       
    }
}
