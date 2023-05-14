using DesingPatternsAsp.Configuration;
using DesingPatternsAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tools;

namespace DesingPatternsAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> config;
        public HomeController(IOptions<MyConfig> _config)
        {
            config = _config;
        }

        public IActionResult Index()
        {
            Log.GetInstance(config.Value.PathLog).Save($"Ingreso al index el {DateTime.Now}");
            ViewBag.NOMBRE = "Aldedier Alberto Martinez Bejarano";
            return View();
        }

        public IActionResult Privacy()
        {
            Log.GetInstance(config.Value.PathLog).Save($"Ingreso a privacy el {DateTime.Now}");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
