using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BI_HIGH_RISE_DAILY.Data.CLS
{
    public class SEND_EMAIL
    {
        public bool SendtoEmail(string strBody)
        {
            bool flg = false;
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //for gmail host 
                smtp.Port = 587;

                smtp.Credentials = new NetworkCredential("system@supalai.com", "SPL@cm#1!");
                smtp.EnableSsl = true;

                MailMessage message = new MailMessage();
                ///FromMailAddress
                //message.From = new MailAddress("phattaramon.cha@supalai.com", "Mine");

                message.From = new MailAddress("erp@supalai.com", "Supalai IT (BI High Rise)");
                ///ToMailAddress
                message.To.Add(new MailAddress("it@supalai.com"));
                message.Subject = "Error : BI High Rise";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = strBody;

                smtp.Send(message);
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
