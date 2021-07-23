using Microsoft.AspNetCore.Mvc;
using _004ASPAdvancedTask1V2.Service;
using System.Collections.Generic;

namespace _004ASPAdvancedTask1V2.Controllers
{
    public class HomeController:Controller
    {
        private IWeeks _weeks;
        private IMonth _month;
        public HomeController(IWeeks weeks, IMonth month) {
            _weeks = weeks;
            _month = month;
        }
        public IActionResult Index() {
            foreach(var name in _weeks.GetWeeks())
            {
                ViewData["Weeks"] += name + " ";
            }
            foreach (var NameMonth in _month.GetMonths()) {
                ViewData["Months"] += NameMonth + " ";
            }
             
            return View();
        }
    }
}
