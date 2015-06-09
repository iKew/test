using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class InstructorsController : JsonController
    {
        public ActionResult Index()
        {
            return Json(_registrationVmBuilder.GetInstructorsVm(), JsonRequestBehavior.AllowGet);
        }
    }
}
