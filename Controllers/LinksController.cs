using Microsoft.AspNetCore.Mvc;

namespace TermiConsult.Controllers
{
    public class LinksController : Controller
    {
        [HttpGet]
        [Route("link")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
