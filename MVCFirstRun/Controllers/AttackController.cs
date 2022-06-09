using System.Web.Mvc;

namespace MVCFirstRun.Controllers
{
    public class AttackController : Controller
    {
        // GET: Attack
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CheckLoginCredentials()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckLoginCredentials(string UserName, string Password)
        {
            if(UserName.Equals("takis123") && Password.Equals("123"))
            {
                return View("Index");
            }
            return View();
        }
    }
}