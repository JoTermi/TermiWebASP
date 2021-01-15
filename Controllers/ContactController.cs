using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using TermiConsult.Models;

namespace TermiConsult.Controllers
{
    public class ContactController : Controller
    {
        ContactModel contactModel = new ContactModel();

        private SendMessageLogic sendMessageLogic;
        public ContactController(IOptions<CredentialModel> config)
        {
            sendMessageLogic = new SendMessageLogic(config);
        }

        [HttpPost]
        public IActionResult Index(ContactModel cm)
        {
            if (ModelState.IsValid)
            {
                if (cm.PruefWert != 12)
                {
                    ViewBag.Message = "Bitte, verifizieren Sie den Prüfwert";
                    return View();
                }
                try
                {
                    sendMessageLogic.Send(cm);
                    ViewBag.Message = "Vielen Dank! Ihre Nachricht wurde gesendet.";
                    ModelState.Clear();
                }
                catch (Exception ex)
                {
                    ViewBag.Message = ex.Message.ToString();
                }

            }
            else
            {
                ViewBag.Message = "Bitte ergänzen Sie die rot markierten Felder..";
            }

            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("api/ContactMe")]
        private ActionResult SendMessage(ContactModel contactModel)
        {
            sendMessageLogic.Send(contactModel);

            return RedirectToAction("./Views/Send/Index.cshtml");
        }
    }
}
