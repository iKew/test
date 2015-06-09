﻿using Angular4DotNet.Models.Registration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class CoursesController : Controller
    {
        private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();
        
        public ActionResult Index()
        {
            return View("Index", "", _registrationVmBuilder.GetSerializedCourses());
        }
    }
}
