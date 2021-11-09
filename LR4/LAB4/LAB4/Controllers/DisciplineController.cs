using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB4.Data;

namespace LAB4.Controllers
{
    public class DisciplineController : Controller
    {
        private TimetableContext db;
        public DisciplineController(TimetableContext context)
        {
            db = context;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            return View(db.Disciplines.Take(100).ToList());
        }
    }
}
