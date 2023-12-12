using Microsoft.AspNetCore.Mvc;
using Online_Exam1._0.Models;
using System.Diagnostics;

namespace Online_Exam1._0.Controllers
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
            var Name = HttpContext.Session.GetString("U_Email");
            if (string.IsNullOrEmpty(Name))
            {
                return RedirectToAction("Signin", "Login");
            }
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