using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB4.Data;

namespace LAB4.Controllers
{
    public class FacultyController : Controller
    {
        private TimetableContext db;
        public FacultyController(TimetableContext context)
        {
            db = context;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            return View(db.Faculties.Take(10).ToList());
        }
    }
}
