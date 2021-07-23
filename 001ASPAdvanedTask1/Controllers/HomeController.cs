using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;

namespace _001ASPAdvanedTask1.Controllers
{
    public class HomeController:Controller
    { 
        public IActionResult Index() 
        {
            var osNameAndVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            
            ViewData["VersionOS"] = osNameAndVersion;
            var os = Environment.OSVersion;
            ViewData["OSPlatform"] = os.Platform;
            ViewData["Ver"] = os.Version;
            ViewData["VerString"] = os.VersionString;
            ViewData["VerMajor"] = os.Version.Major;
            ViewData["VerMinor"] = os.Version.Minor;
            ViewData["ServicePack"] = os.ServicePack;
            return View();
        }
    }
}
