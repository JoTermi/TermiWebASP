using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TermiConsult.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TermiConsult.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class MailController : Controller
    {
        ContactModel contactModel = new ContactModel();

        // GET: api/<MailController>
        [HttpGet]
        [Route("api")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/ContactMe")]
        public IActionResult Index()
        {
            return View("ContactMe");
        }

        // POST api/<MailController>
        [HttpPost]
        [Route("api/ContactMe")]
        public void Post([FromBody] string value)
        {
            SendMessageLogic sendMessageLogic = new SendMessageLogic();
            if (!string.IsNullOrEmpty(contactModel.FromEmail) && !string.IsNullOrEmpty(contactModel.Betreff) && !string.IsNullOrEmpty(contactModel.Message))
            {
                sendMessageLogic.Send(contactModel);
            }
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult SendMessage()
        {
            try
            {
                SendMessageLogic sendMessageLogic = new SendMessageLogic();

                if (!string.IsNullOrEmpty(contactModel.FromEmail) && !string.IsNullOrEmpty(contactModel.Betreff) && !string.IsNullOrEmpty(contactModel.Message))
                {
                    sendMessageLogic.Send(contactModel);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // PUT api/<MailController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<MailController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
