using HomeControllerAssignment2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeControllerAssignment2.Controllers
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
            List<string> colors = new List<string>
    {
        "Red",
        "Green",
        "Blue",
        "Yellow",
        "Orange",
        "Purple"
    };

            ViewData["Colors"] = colors;
            return View();
        }

        public IActionResult Privacy()
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