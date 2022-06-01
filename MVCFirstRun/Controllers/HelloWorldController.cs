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
    }
}