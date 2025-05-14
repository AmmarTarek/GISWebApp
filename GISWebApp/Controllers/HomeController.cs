using GISWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GISWebApp.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string SayHi()
        {
            string x = "Hello World!";

            return x;
        }

        public ViewResult FirstView()
        {
            ViewResult No1 = new ViewResult();
            No1.ViewName = "Home";

            return No1;
        }

        public ActionResult Mix(int x)
        {
            if (x == 0)
            {
                ViewResult No2 = new ViewResult();
                No2.ViewName = "Home";

                return No2;
            }
            else  if (x == 1)
            {
                ContentResult salem = new ContentResult();
                salem.Content = "My name is Salem";

                return salem;
            }
            else
            {
                ContentResult wrong = new ContentResult();
                wrong.Content = "wrong input";

                return wrong;
            }
            
        }


    }
}
