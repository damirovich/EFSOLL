using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _006Task1ASP.Models;

namespace _006Task1ASP.Controllers
{
    public class ProgrammingLanguageController:Controller
    {
        public IActionResult ProgrammingLanguage()
        {
            List<ProgrammingLanguage> programmings = new List<ProgrammingLanguage>()
            {
                new ProgrammingLanguage(){
                    Id = 1,
                    Name="C#",
                    Popularity="Второе место по миру",
                    Date= new DateTime(1975,5,25)
                },
                 new ProgrammingLanguage(){
                    Id = 2,
                    Name="Java",
                    Popularity="Первое место по миру",
                    Date= new DateTime(1968,9,18)
                 },
                  new ProgrammingLanguage(){
                    Id = 3,
                    Name="PHP",
                    Popularity="Третьое место по миру",
                    Date= new DateTime(1991,1,28)
                },
                  new ProgrammingLanguage(){
                    Id = 4,
                    Name="Kotlin",
                    Popularity="Четвертое место по миру",
                    Date= new DateTime(2000,7,1)
                },
                  new ProgrammingLanguage(){
                    Id = 5,
                    Name="C++",
                    Popularity="Пятое место по миру",
                    Date= new DateTime(1960,10,3)
                },
            };
            return View(programmings);
        }
    }
}
