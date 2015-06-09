using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class CoursesController : JsonController
    {
        public ActionResult Index()
        {
            return Json(_registrationVmBuilder.GetCoursesVm(),JsonRequestBehavior.AllowGet);
        }

    }
}
