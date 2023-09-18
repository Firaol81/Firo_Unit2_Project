using Microsoft.AspNetCore.Mvc;
using AgeCalculatorApp.Models;
using System;

namespace AgeCalculatorApp.Controllers
{
    public class AgeCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(AgeCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                // Calculate the age based on the birthdate
                DateTime currentDate = DateTime.Now;
                TimeSpan difference = currentDate - model.Birthdate;
                model.Age = (int)(difference.TotalDays / 365);

                return View("Result", model);
            }

            return View("Index", model);
        }
    }
}
