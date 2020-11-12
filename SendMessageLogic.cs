using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using TermiConsult.Models;

namespace TermiConsult
{
    public class SendMessageLogic
    {
        private ContactModel contactdata = null;
        private string ToEmail = $"info@termiconsult.com";

        public SendMessageLogic()
        {
            contactdata = new ContactModel();
        }
        public SendMessageLogic(string SMTPServer, string fromEmail)
        {
            this.SMTPServer = SMTPServer;
            contactdata.FromEmail = fromEmail;
        }

        public SendMessageLogic(string SMTPServer, string fromEmail, string Username, string Password) : this(SMTPServer, fromEmail)
        {
            contactdata.Vorname = Username;
            this.Password = Password;
        }

        public string SMTPServer { get; set; } = "smtp.strato.de";

        public string Password { get; set; } = "TermiWant@007";

        public void Send(ContactModel cm)
        {
            MailMessage mailMsg = new MailMessage();
            mailMsg.To.Add(ToEmail);

            MailAddress mailAddress = new MailAddress(cm.FromEmail);

            mailMsg.From = mailAddress;

            mailMsg.Subject = cm.Betreff;
            mailMsg.Body = cm.Message;
            mailMsg.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient(SMTPServer, 465);

            if (cm.Vorname.Length > 0)
            {
                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("info@termiconsult.com", "TermiWant@007");
                smtpClient.Credentials = credentials;
            }

            smtpClient.Send(mailMsg);
        }

    }
}
