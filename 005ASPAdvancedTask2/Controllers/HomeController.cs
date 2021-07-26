using _005ASPAdvancedTask2.Models;
using _005ASPAdvancedTask2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _005ASPAdvancedTask2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Service service;
        private readonly IEmailService _emailService;
        public HomeController(ILogger<HomeController> logger,Service service,IEmailService emailService)
        {
            _logger = logger;
            this.service = service;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ForgetPW([FromServices] IEmailService email) {
            
            return RedirectToAction("Index");
        }
        public IActionResult SendEmailCustom() {
            service.SendEmilCustom();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
