using Angular4DotNet.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class RegistrationController : Controller
    {
        private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();
        public ActionResult Index()
        {
            var data = _registrationVmBuilder.BuildRegistrationVm();
            return View(data);
        }

    }
}
