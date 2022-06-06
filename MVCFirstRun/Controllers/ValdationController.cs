using MVCFirstRun.Models;
using System.Web.Mvc;

namespace MVCFirstRun.Controllers
{
    public class ValdationController : Controller
    {
        // GET: Valdation
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User user)
        {
            if (ModelState.IsValid)
            {
                return Content("Success!");
            }

            return View(user);
        }
    }
}