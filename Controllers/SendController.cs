using Microsoft.AspNetCore.Mvc;

namespace TermiConsult.Controllers
{
    public class SendController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
