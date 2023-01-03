using Jegyek.Data;
using Jegyek.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jegyek.Controllers
{
    public class avargeController : Controller
    {
        private readonly UniversityContext _context;

        public avargeController(UniversityContext context)
        {
            _context = context;
        }

        // GET: jegyekInfoes
        public async Task<IActionResult> Avarge()
        {
            var grades = _context.Courses.ToList();

            // összegzés a jegyek átlagának kiszámításához
            double total = 0;
            foreach (var grade in grades)
            {
                total += grade.Grade;
            }
            double atlag = total / grades.Count;
            //ViewBag.Average = atlag;
            return View(atlag);
        }
    }
}
