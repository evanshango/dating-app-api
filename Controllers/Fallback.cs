using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    public class Fallback : Controller
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");
        }

        private IActionResult PhysicalFile(string v)
        {
            throw new NotImplementedException();
        }
    }
}