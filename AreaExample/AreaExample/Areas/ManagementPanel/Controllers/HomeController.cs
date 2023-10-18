using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaExample.Areas.ManagementPanel.Controllers
{
    [Area("ManagementPanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["data"] = "sebepsiz boş yere ayrılacaksın....";
            return RedirectToAction("Index","Home",new { area = "InvoicePanel" });
        }
    }
}
