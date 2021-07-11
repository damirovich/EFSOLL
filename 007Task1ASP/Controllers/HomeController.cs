using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _007Task1ASP.Models;

namespace _007Task1ASP.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index() {
            Student student = new Student()
            {
                Id = 1,
                Name = "Ashyrov Baktilek",
                Group = "SE-1-17",
                Course = 3
            };
            Student student1 = new Student()
            {
                Id = 2,
                Name = "Saryeva Klara",
                Group = "SE-(Eng)-1-18",
                Course = 3
            };
            Student student2 = new Student()
            {
                Id = 3,
                Name = "Kudaibergenov Suban",
                Group = "SE-(ISOP)-1-17",
                Course = 4
            };
            List<Student> StudentsCol = new List<Student>();
            StudentsCol.Add(student);
            StudentsCol.Add(student1);
            StudentsCol.Add(student2);
            return View(StudentsCol);
        }
    }
}
