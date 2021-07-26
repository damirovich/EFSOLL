using _005ASPAdvancedTask2.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
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
       // private readonly IEmailService _emailService;
        public IEmailSender EmailSender { get; set; }
        public HomeController(ILogger<HomeController> logger,Service service ,IEmailSender emailSender)
        {
            _logger = logger;
            this.service = service;
            EmailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SendEmil() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendEmil(string toAddress, string subject, string body)
        {
            await EmailSender.SendEmailAsync(toAddress, subject, body);
            return View();
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
