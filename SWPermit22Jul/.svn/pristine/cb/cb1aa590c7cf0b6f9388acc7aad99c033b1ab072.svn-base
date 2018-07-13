using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SidewalkPermitWPF.Helper
{
    public static class EmailHelper
    {
        public static string Host = ConfigurationManager.AppSettings["Host"];
        public static string From = ConfigurationManager.AppSettings["From"];
        public static string Password = ConfigurationManager.AppSettings["Password"];
        public static int Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
        public static int TimeOut = int.Parse(ConfigurationManager.AppSettings["TimeOut"]);
        public static string Subject = ConfigurationManager.AppSettings["Subject"];
      
        public static void SendEmail(string to, string message)
        {
            NetworkCredential cred = new NetworkCredential(From, Password);
            MailMessage msg = new MailMessage();
            msg.To.Add(to);
            msg.Subject = Subject;

            msg.Body = message;
            msg.From = new MailAddress(From); // Your Email Id
            SmtpClient client = new SmtpClient(Host, Port);
            client.Credentials = cred;
            client.EnableSsl = true;
            client.Send(msg);
        }
    }
}
