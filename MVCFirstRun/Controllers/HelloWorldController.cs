using System.Web.Mvc;

namespace MVCFirstRun.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "Hello World";
        }
    }
}