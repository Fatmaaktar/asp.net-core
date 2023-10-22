using EnvironmentExample.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentExample.Controllers
{
    public class HomeController : Controller
    {
        IWebHostEnvironment _webHostEnvironment;
        IConfiguration _configuration;
        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            if (_webHostEnvironment.IsDevelopment())
            {
                ViewBag.Env = "Development";
            }
            else if (_webHostEnvironment.IsProduction())
            {
                ViewBag.Env = "Production";
            }
            else if (_webHostEnvironment.IsStaging())
            {
                ViewBag.Env = "Staging";
            }
            if (_webHostEnvironment.IsEnvironment("Ahmet"))
            {
                ViewBag.Env = "Ahmet";
            }

            _webHostEnvironment.IsDevelopment();
            _webHostEnvironment.IsEnvironment("Ahmet");
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
