using System.Web.Mvc;

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
    }
}