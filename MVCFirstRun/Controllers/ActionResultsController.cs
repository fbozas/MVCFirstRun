﻿using System.Web.Mvc;

namespace MVCFirstRun.Controllers
{
    public class ActionResultsController : Controller
    {
        // GET: ActionResults
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult ViewResultMethod()
        {
            return View();
        }

        public ContentResult ContentMethod()
        {
            return Content("Hello from MVC 5");
        }

        public ActionResult ConditionalMethod()
        {
            var a = false;
            if (a)
            {
                return Content("Variable is true");
            }

            return View();
        }

        public RedirectResult GoToUrl() // Returns http status code 302
        {
            return Redirect("https://www.google.com");
        }

        public RedirectResult GoToUrlPermanently() // Returns http status code 301 (More SEO friendly)
        {
            return RedirectPermanent("https://www.google.com");
        }
    }
}