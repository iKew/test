using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class HelloController : Controller
    {
        public ActionResult Index()
        {
            return View("Index","","you");
        }

    }
}
