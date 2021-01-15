using Microsoft.AspNetCore.Mvc;

namespace TermiConsult.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
