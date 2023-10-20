using configurationExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace configurationExample.Controllers
{
    public class HomeController : Controller
    {
        readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var v1 = _configuration["ExampleText"];
            var v2 = _configuration["Person"];
            var v3 = _configuration["Person:Name"];
            var v4 = _configuration["Person: Surname"];
            var v5 = _configuration["Loggin:LogLavel:Microsoft.Hosting.Lifetime:Person"];

            var v6 = _configuration.GetSection("Person");
            var v7 = _configuration.GetSection("Person:Name");
            var v8 = _configuration.GetSection("Person").Get(typeof(Person));

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
