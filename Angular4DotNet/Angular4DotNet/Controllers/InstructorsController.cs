using Angular4DotNet.Models.Registration;
using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class InstructorsController : Controller
    {
        private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return View("Index", "", _registrationVmBuilder.GetSerializedInstructors());
        }

    }
}
