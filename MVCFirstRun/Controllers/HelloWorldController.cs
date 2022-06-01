using MVCFirstRun.Models;
using System.Web.Mvc;

namespace MVCFirstRun.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadData()
        {
            ViewBag.Message = "Hello from method";
            return View();
        }

        public ActionResult GoToUrl()
        {
            return Redirect("https://www.google.com");
        }

        public ActionResult GoToSpecificUrl(string url)
        {
            return Redirect(url);
        }

        public ActionResult LoadCustomer()
        {
            Customer customer = new Customer()
            {
                ID = 1,
                Name = "Nikos Pappas"
            };

            return View(customer);
        }

        public ActionResult GetUrlElements()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var message = $"{controller} {action}";

            ViewBag.Message = message;

            return View();
        }
    }
}