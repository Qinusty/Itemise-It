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
                MailMessage message = new MailMessage("ItemiseLogger@gmx.co.uk", "jrsmith9822@gmail.com");
                message.Body = body; message.Subject = subject;
                
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("ItemiseLogger@gmx.co.uk", "BravoTesco123");
                client.Send(message);
            }
        }
    }
}
