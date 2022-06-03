using MVCFirstRun.Models;
using System;
using System.Web.Mvc;

namespace MVCFirstRun.Controllers
{
    public class FormDemoController : Controller
    {
        // GET: FormDemo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate()
        {
            string fullName = Request.Form["fullName"].ToString();
            DateTime dateOfBirth = Convert.ToDateTime(Request.Form["dateOfBirth"]);

            int age = DateTime.Now.Year - dateOfBirth.Year;
            int ageNextYear = age + 1;

            ViewBag.FullName = fullName;
            ViewBag.Age = age;
            ViewBag.AgeNextYear = ageNextYear;

            return View("Index");
        }

        [HttpPost]
        public ActionResult CalculateTwo(string fullNameTwo, string dateOfBirthTwo)
        {
            string fullName = fullNameTwo;
            DateTime dateOfBirth = Convert.ToDateTime(dateOfBirthTwo);

            int age = DateTime.Now.Year - dateOfBirth.Year;
            int ageNextYear = age + 1;

            ViewBag.FullName = fullName;
            ViewBag.Age = age;
            ViewBag.AgeNextYear = ageNextYear;

            return View("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            return View("CreatePost", person);
        }
    }
}