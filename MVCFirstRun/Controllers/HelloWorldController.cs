using System.Web.Mvc;

namespace MVCFirstRun.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View("InitialView");
        }
    }
}