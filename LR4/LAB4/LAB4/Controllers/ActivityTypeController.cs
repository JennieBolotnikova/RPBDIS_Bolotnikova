using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB4.Data;

namespace LAB4.Controllers
{
    public class ActivityTypeController : Controller
    {
        private TimetableContext db;

        public ActivityTypeController(TimetableContext context)
        {
            db = context;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
