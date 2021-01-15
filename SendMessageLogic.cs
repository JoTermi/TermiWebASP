using Microsoft.Extensions.Options;
using System;
using System.Net.Mail;
using TermiConsult.Models;

namespace TermiConsult
{
    public class SendMessageLogic
    {
        private string termiHostMailAddress = null;
        private string termiHostPWD = null;

        private ContactModel contactdata = null;
        private string ToEmail = $"info@termiconsult.com";


        public SendMessageLogic(IOptions<CredentialModel> config)
        {
            contactdata = new ContactModel();

            termiHostMailAddress = config.Value.UserName;
            termiHostPWD = config.Value.Password;
        }

        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="cm">contact informations</param>
        public void Send(ContactModel cm)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(ToEmail);
            mail.From = new MailAddress(termiHostMailAddress, String.Format("Neue Email von: {0}: ", cm.Nachname), System.Text.Encoding.UTF8);

            mail.Subject = cm.Betreff;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;

            string NachrichtInhalt = String.Format("Neue Nachricht empfangen von: {0}, {1}, <br/>Sender-Email: {2} ", cm.Vorname, cm.Nachname, cm.FromEmail);

            NachrichtInhalt += "<br/><br/><strong>Message</strong> : <br/></br> " + cm.Message;

            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;

            mail.Body = NachrichtInhalt;

            mail.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();

            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(termiHostMailAddress, termiHostPWD);

            client.Port = 25; // Default port for outlook
            client.Host = "smtp.live.com"; // Host or outlook
            client.EnableSsl = true;

            //MailAddress mailAddress = new MailAddress("jocelin.tiemegni@hotmail.de");

            try
            {
                client.Send(mail);
            }

            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
            }

        }

    }
}
