using _009Task2ASP.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _009Task2ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _appEnviroment;

        public HomeController(IWebHostEnvironment appEnviroment)
        {
            _appEnviroment = appEnviroment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public VirtualFileResult FileVirtual() {
            var file = Path.Combine("~files", "TextFile.txt");
            return File(file, "Application/txt", "File.txt");
        }
        public IActionResult FileOpen()
        {
            string file_path = Path.Combine(_appEnviroment.ContentRootPath, "Files/message.txt");
            string file_type = "Application/txt";
            string file_name = "File.txt";
            return PhysicalFile(file_path, file_type, file_name);
        }

        public FileResult FileDownArray()
        {
            string path = Path.Combine(_appEnviroment.ContentRootPath, "Files/message.txt");
            byte[] mas = System.IO.File.ReadAllBytes(path);
            string file_type = "Application/txt";
            string file_name = "File.txt";
            return File(mas, file_type, file_name);
        }
        public FileResult FileDownload()
        {
            string path = Path.Combine(_appEnviroment.ContentRootPath, "Files/message.txt");
            FileStream fs = new FileStream(path, FileMode.Open);
            string file_type = "Application/txt";
            string file_name = "File.txt";
            return File(fs, file_type, file_name);
        }
    }
}
