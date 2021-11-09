using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB4.Data;

namespace LAB4.Controllers
{
    public class BellController : Controller
    {
        private TimetableContext db;
        public BellController(TimetableContext context)
        {
            db = context;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Index()
        {
            return View(db.Bells.Take(6).ToList());
        }
    }
}
