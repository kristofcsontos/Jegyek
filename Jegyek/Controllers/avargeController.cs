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
            var courses =_context.Courses.ToList();
            

            // összegzés a jegyek átlagának kiszámításához
            double totalGrade = 0;
            foreach (var course in courses)
            {
                totalGrade += course.Grade;
            }
            double atlag = totalGrade / courses.Count;
            //ViewBag.Average = atlag;
            return View(atlag);
        }
    }
}
