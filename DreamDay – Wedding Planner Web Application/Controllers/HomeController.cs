using System.Diagnostics;
using DreamDay___Wedding_Planner_Web_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace DreamDay___Wedding_Planner_Web_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Features()
        {
            return View();
        }

        public IActionResult Vendors()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Checklist()
        {
            return View();
        }
        public IActionResult Budget()
        {
            return View();
        }

        public IActionResult Guests()
        {
            return View();
        }
        public IActionResult Dahboard_Vendors()
        {
            return View();
        }

        public IActionResult Timeline()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
