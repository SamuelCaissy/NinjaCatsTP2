using Microsoft.AspNetCore.Mvc;
using NinjaCats.Models;
using System;
using System.Diagnostics;

namespace NinjaCats.Controllers
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

        public IActionResult Confidentialite()
        {
            return View();
        }

        public IActionResult Inscription()
        {
            return View();
        }

        public IActionResult Propos()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //TODO :ACTIVITE QUI RENVOI VERS CALENDAR 
        public IActionResult Calendar()
        {

            var data = new List<dynamic>();

            Random r = new Random();
            //generating des gens
            for (int i = 0; i < 20; i++)
            {
                data.Add(new
                {
                    Name = "le monsieur/mme #" + i,
                    Address = "sous ton lit",
                    Type = r.Next(2) == 0 ? "travailleur" : "membre",
                    Description = "description de la mort qui tue"
                }); 
            }

            
             

            return View(data);
            
        }
    }
}