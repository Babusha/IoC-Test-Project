using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class EMailInputOutput : IInputOutput
    {
        private string Email { get; set; }
        public EMailInputOutput(string email)
        {
            
        }
        public string Input()
        {
            throw new NotImplementedException();
        }

        public void Output(string message)
        {
            var client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("maximkony@gmail.com", "password");

            MailMessage mm = new MailMessage("nikitanikitenko@gmail.com", "sendtomyemail@domain.co.uk", "Logs", message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }
    }
}
