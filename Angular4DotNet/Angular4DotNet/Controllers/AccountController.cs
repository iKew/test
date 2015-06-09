using Angular4DotNet.Models.Account;
using System.Net;
using System.Web.Mvc;


namespace Angular4DotNet.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Save(StudentVm student)
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}
