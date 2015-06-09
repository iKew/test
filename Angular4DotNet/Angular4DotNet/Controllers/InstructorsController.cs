using Angular4DotNet.Models.Registration;
using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class InstructorsController : JsonController
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return Json(_registrationVmBuilder.GetInstructorsVm(), JsonRequestBehavior.AllowGet);
        }
    }
}
