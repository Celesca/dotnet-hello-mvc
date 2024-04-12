using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloMVC.Controllers
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
            var fullname = (Firstname:"John" , Lastname:"Doe");

            ViewData["myname"] = fullname.Firstname + " " + fullname.Lastname;
            return View("Index");
        }

        public IActionResult Info()
        {
            int x = 300;
            int y = 200;
            var result = 0;

            Add(x, y);

            void Add(int x, int y)
            {
                result = x + y;
            }

            ViewData["result"] = result;
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
