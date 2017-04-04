using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExploreCalifornia.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ExploreCalifornia.Controllers
{
    public class HomeController : Controller
    {
        private readonly SpecialsDataContext _db;

        public HomeController(SpecialsDataContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var specials = _db.Specials.OrderByDescending(x => x.Key).Take(4).ToArray();
             
            return View(specials);
            //return new ContentResult { Content = "Hello, ASP.NET Core MVC!" };
            //return "Hello, ASP .NET Core MVC!";
        }
    }
}
