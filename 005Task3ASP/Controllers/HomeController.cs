using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _005Task3ASP.Models;

namespace _005Task3ASP.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Employees() {
            List<Employees> employees = new List<Employees>()
            {
                new Employees(){
                    Id = 1,
                    FullName = "Ashyrov Baktiilek",
                    Email = "baktilekashyrov8@gmail.com",
                    Position = "Senior C# Developer",
                    Salary = 178000.500
                },
                 new Employees(){
                    Id = 2,
                    FullName = "Kudaibergenov Suban",
                    Email = "suban@gmail.com",
                    Position = "Senior Java Developer",
                    Salary = 188000.500
                }
            };
            return View(employees);
        }
    }
}
