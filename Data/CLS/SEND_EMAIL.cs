using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace BI_HIGH_RISE_DAILY.Data.CLS
{
    public class SEND_EMAIL
    {
        private string userName, password;

        public SEND_EMAIL()
        {
            GetUserName();
            GetPassword();
        }

        public void GetUserName()
        {
            var appSettings = ConfigurationManager.AppSettings;
            userName = appSettings["userName"];
        }

        public void GetPassword()
        {
            var appSettings = ConfigurationManager.AppSettings;
            password = appSettings["password"];
        }
        public bool SendtoEmail(string strBody)
        {
            bool flg = false;
            try
            { 
                MailMessage mailMessage = new MailMessage();
                // mailMessage.From = new MailAddress("splsys02@supalai.com", "Supalai IT (getOilPriceAPI)");
                mailMessage.From = new MailAddress(userName, "Supalai IT (BI High Rise)");
                mailMessage.To.Add(new MailAddress("it@supalai.com"));
                mailMessage.Subject = "Err: get BI High Rise";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = strBody;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                System.Net.NetworkCredential networkCredential =
                    // new NetworkCredential("splsys02@supalai.com", "pewcosiaeedagpxf");
                    new NetworkCredential(userName, password);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Send(mailMessage);
                flg = true; 
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                Console.Write(ex.ToString());
                flg = false;
            }
            return flg;
        }
    }
}
