using Microsoft.AspNetCore.Mvc;

namespace LabCourse1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
