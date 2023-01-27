using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MyWebsite.Models;

namespace MyWebsite.Controllers
{
    public class CountdownsController : Controller
    {
        private readonly ILogger<CountdownsController> _logger;

        public CountdownsController(ILogger<CountdownsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("EventsMenu");
        }

        public IActionResult EventsMenu()
        {
            ViewBag.Message = "EventsMenu";
            return View();
        }

        public IActionResult Spring()
        {
            ViewBag.Message = "Spring";
            return View();
            
        }

        public IActionResult Summer()
        {
            ViewBag.Message = "Summer";
            return View();
        }

        public IActionResult Autumn()
        {
            ViewBag.Message = "Autumn";
            return View();
        }

        public IActionResult Winter()
        {
            ViewBag.Message = "Winter";
            return View();
        }

        public IActionResult NewYears()
        {
            ViewBag.Message = "NewYears";
            return View();
        }

        public IActionResult Valentines()
        {
            ViewBag.Message = "Valentines";
            return View();
        }

        public IActionResult Easter()
        {
            ViewBag.Message = "Easter";
            return View();
        }

        public IActionResult Mothers()
        {
            ViewBag.Message = "Mothers";
            return View();
        }

        public IActionResult Memorial()
        {
            ViewBag.Message = "Memorial";
            return View();
        }

        public IActionResult Independence()
        {
            ViewBag.Message = "Independence";
            return View();
        }

        public IActionResult Labor()
        {
            ViewBag.Message = "Labor";
            return View();
        }        

        public IActionResult Veterans()
        {
            ViewBag.Message = "Veterans";
            return View();
        }
        
        public IActionResult Halloween()
        {
            ViewBag.Message = "Halloween";
            return View();
        }

        public IActionResult Elections()
        {
            ViewBag.Message = "Elections";
            return View();
        }

        public IActionResult Christmas()
        {
            ViewBag.Message = "Christmas";
            return View();
        }

        public IActionResult Thanksgiving()
        {
            ViewBag.Message = "Thanksgiving";
            return View();
        }

        public IActionResult MartinLutherKing()
        {
            ViewBag.Message = "MartinLutherKing";
            return View();
        }

        public IActionResult Fathers()
        {
            ViewBag.Message = "Fathers";
            return View();
        }

        public IActionResult Presidents()
        {
            ViewBag.Message = "Presidents";
            return View();
        }

        public IActionResult Lincoln()
        {
            ViewBag.Message = "Lincoln";
            return View();
        }

        public IActionResult Washington()
        {
            ViewBag.Message = "Washington";
            return View();
        }

        public IActionResult Jefferson()
        {
            ViewBag.Message = "Jefferson";
            return View();
        }

        public IActionResult Army()
        {
            ViewBag.Message = "Army";
            return View();
        }

        public IActionResult AirForce()
        {
            ViewBag.Message = "AirForce";
            return View();
        }

        public IActionResult Navy()
        {
            ViewBag.Message = "Navy";
            return View();
        }

        public IActionResult MarineCorp()
        {
            ViewBag.Message = "MarineCorp";
            return View();
        }

        public IActionResult NationalGuard()
        {
            ViewBag.Message = "NationalGuard";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

