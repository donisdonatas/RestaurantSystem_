using System;
using System.Net.Mail;
using System.Net;

namespace Aeroplanes.Servises
{
    public class EmailService
    {
        public void SendEmail(string reportContext)
        {
            var fromAddress = new MailAddress("donisdonatas@gmail.com", "Donatas");
            var toAddress = new MailAddress("d2b@dr.com", "Donatas");
            const string fromPassword = "oqdtnnytijhqtowt";
            const string subject = "Arriving airplanes report";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 2000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = reportContext,
                IsBodyHtml = true
            })
            {
                smtp.Send(message);
            }
            Console.WriteLine("The eMail was sent out.");
        }
    }
}
