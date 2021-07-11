using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _006Task1ASP.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index() {
            return View();
        }
    }
}
