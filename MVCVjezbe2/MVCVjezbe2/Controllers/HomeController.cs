using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCVjezbe2.Models;

namespace MVCVjezbe2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Student student)
        {
            ViewBag.Ime = student.Ime;
            ViewBag.Prezime = student.Prezime;

            if (ModelState.IsValid)
            {
                Repozitorij.DodajStudenta(student);
                return View("Potvrda");
            }

            return View();
        }

        public IActionResult ListaStudenata()
        {
            return View(Repozitorij.GetStudente());
        }

    }
}