using Microsoft.AspNetCore.Mvc;
using ST10038389_PROG7311___POE_PART_2.Models;
using System.Diagnostics;

namespace ST10038389_PROG7311___POE_PART_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //The Logger for tracking application behaviour and debugging code logic.
        //These are all Constructors that accepts a Logger instance through dependency injection.
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Below are the 5 Controllers or in other words the Linking pages of the AGRI-ENERGY CONNECT PLATFORM SITE.
        public IActionResult Index() //This is the Home Page that shows the Landing Page of the application.
        {
            _logger.LogInformation("Visited Home/Index");
            return View();
        }

        public IActionResult AboutUs() //This is the About Us Page that gives information about the platform.
        {
            return View();
        }

        public IActionResult Farmer() //This is the Farmer Page used to display or handle Farmer-related-content.
        {
            return View();
        }

        public IActionResult Product() //This is the Product Page used to display or handle product-related-content.
        {
            return View();
        }

        public IActionResult ContactUs() //Lastly is the Contact Us Page that provides a way for users to get in touch with the application host.
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
//---------------------------------------- END OF FILE ---------------------------------------------------------------------------------