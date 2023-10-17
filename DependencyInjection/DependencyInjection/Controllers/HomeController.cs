using DependencyInjection.Models;
using DependencyInjection.Services;
using DependencyInjection.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        // public ILog Log { get; } 
        readonly ILog _log;

        public HomeController(ILog log)
        {
            _log = log;
        }
        public IActionResult Index()
        {
            TextLog log = new TextLog();
            log.Log();
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
