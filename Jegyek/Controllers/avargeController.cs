using Jegyek.Data;
using Jegyek.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

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
            var courses = _context.Courses.ToList();
            double creditIndex = 0;
            int semesterMax = courses.Max(c => c.Grade);
            double weightedAverage = 0;
            double totalGrade = 0;
            int curledCreditIndex = 0; //Göngyölt kredit index
            int curledGrade = 0;  //Göngyölt jegyek
            int sumKredit = 0; 
            int semesterKredit = 0; 

            foreach (var course in courses)
            {
                if (semesterMax == course.Semester)
                {
                    //átlag
                    totalGrade = totalGrade + course.Grade;
                    //Kredit index
                    creditIndex = creditIndex + (course.Credit * course.Grade);
                    //Súlyozott tanulmányi átlag
                    weightedAverage = course.Credit + weightedAverage;
                    //Teljesített kredit
                    semesterKredit = semesterKredit + course.Credit;
                }
                curledCreditIndex = curledCreditIndex + (course.Credit * course.Grade);
                curledGrade = curledGrade + course.Grade;
                sumKredit = sumKredit + course.Credit;
            }
            ViewBag.CreditIndex = creditIndex / 30;

            weightedAverage = Convert.ToInt32(creditIndex) / weightedAverage;
            ViewBag.WeightedAvarge = weightedAverage;

            ViewBag.CurledAverage = Convert.ToDouble(curledCreditIndex) / Convert.ToDouble(curledGrade);

            ViewBag.SumKredit = sumKredit;

            ViewBag.SemesterKredit = semesterKredit;

            ViewBag.a = semesterMax;
            double atlag = totalGrade / courses.Count;
            return View(atlag);
        }
    }
}
