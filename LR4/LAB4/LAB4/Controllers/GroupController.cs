using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB4.Data;
using Microsoft.EntityFrameworkCore;

namespace LAB4.Controllers
{
    public class GroupController : Controller
    {
        private TimetableContext db;
        public GroupController(TimetableContext context)
        {
            db = context;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            return View(db.Groups.Include(f => f.Faculty).Take(200).ToList());
        }
    }
}
