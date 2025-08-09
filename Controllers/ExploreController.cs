using Microsoft.AspNetCore.Mvc;

namespace DevPrompt.Controllers
{
    public class ExploreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
