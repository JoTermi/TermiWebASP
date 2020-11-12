using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TermiConsult.Models;

namespace TermiConsult.Controllers
{
    public class ContactController : Controller
    {

        private SendMessageLogic sendMessageLogic = new SendMessageLogic();
        public IActionResult Index(ContactModel cm)
        {
            if (!string.IsNullOrEmpty(cm.FromEmail) && !string.IsNullOrEmpty(cm.Betreff) && !string.IsNullOrEmpty(cm.Message))
            {
                SendMessage(cm);
            }
            return View();
        }

        private void SendMessage(ContactModel contactModel)
        {
            sendMessageLogic.Send(contactModel);
        }
    }
}
