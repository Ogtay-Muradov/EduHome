using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class BlogDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
