using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DevTest.Codacy.Models;

namespace DevTest.Codacy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDesignTimeMvcBuilderConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IDesignTimeMvcBuilderConfiguration configuration)
        {

            var anotherClassButNotReally = new AnotherClassButNotReally();
            string red = anotherClassButNotReally.Something;
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            string howLovely = "Oh Piece of Candy".IsANightmare();

            return View();
        }

        public IActionResult Privacy()
        {
            string howLovely = "Oh Piece of Candy".IsANightmare();

            _logger.LogInformation("WooHoo!!!");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            string howLovely = "Oh Piece of Candy".IsANightmare();
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
