using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace RiotApiDAL
{
    public static class MailControl
    {
        public static void SendMail(string subject, string body)
        {
            using (SmtpClient client = new SmtpClient("mail.gmx.com"))
            {
                MailMessage message = new MailMessage("EMAIL_FROM", "EMAIL_TO");
                message.Body = body; message.Subject = subject;
                
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("EMAIL_FROM", "PASSWORD");
                client.Send(message);
            }
        }
    }
}
