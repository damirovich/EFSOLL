using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _006Task2ASP.Models;
using System.Threading.Tasks;

namespace _006Task2ASP.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Registr(User user)
        {
            if (user.Age < 14) {
                return NotFound("Возраст не может быть меньше 14");
            }
            return NotFound($"Добро пожаловать!\nВаши данные\nFullName: {user?.FullName}  Email:{user.Email}  Age: {user?.Age}");
        }


    }   
}