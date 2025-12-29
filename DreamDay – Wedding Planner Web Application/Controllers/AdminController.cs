using Microsoft.AspNetCore.Mvc;

namespace DreamDay___Wedding_Planner_Web_Application.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Vendors()
        {
            return View();
        }
        public IActionResult Weddings()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }

    }
}
