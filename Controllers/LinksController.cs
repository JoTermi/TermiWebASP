using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TermiConsult.Controllers
{
    public class LinksController : Controller
    { 
        [HttpGet]
        [Route("termi/api/link")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
