using Angular4DotNet.Models.Registration;
using Angular4DotNet.Models.Courses;
using System.Web.Http;

namespace Angular4DotNet.Controllers
{
    public class CoursesController : ApiController
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public CourseVm[] Get()
        {
            return _registrationVmBuilder.GetCoursesVm();
        }

    }
}
