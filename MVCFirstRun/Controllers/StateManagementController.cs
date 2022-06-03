using System.Web.Mvc;

namespace MVCFirstRun.Controllers
{
    public class StateManagementController : Controller
    {
        // GET: StateManagement
        public ActionResult Index()
        {
            ViewBag.Name = "Kostas";
            ViewData["Age"] = 33;
            TempData["Message"] = "Your message";

            //return View();
            return RedirectToAction("Destination");
        }

        public ActionResult Destination()
        {
            return View();
        }
    }
}