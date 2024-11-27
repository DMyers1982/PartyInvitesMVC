using Microsoft.AspNetCore.Mvc;
using PartyInvitesMVC.Models;
using System.Diagnostics;

namespace PartyInvitesMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        // Begin Default code added by Visual Studio
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        // End Default code added by Visual Studio

        // Begin Default code added by Visual Studio
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        // End Default code added by Visual Studio
    }
}
