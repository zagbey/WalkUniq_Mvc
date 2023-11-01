using Microsoft.AspNetCore.Mvc;

namespace WalkUniq.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
