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
    }
}