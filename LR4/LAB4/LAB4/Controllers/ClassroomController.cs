using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB4.Data;
using Microsoft.EntityFrameworkCore;

namespace LAB4.Controllers
{
    public class ClassroomController : Controller
    {
        private TimetableContext db;
        public ClassroomController(TimetableContext context)
        {
            db = context;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            return View(db.Classrooms.Include(b => b.Building).Take(200).ToList());
        }
    }
}
