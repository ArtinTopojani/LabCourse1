using Microsoft.AspNetCore.Mvc;



namespace LabCourse1.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
