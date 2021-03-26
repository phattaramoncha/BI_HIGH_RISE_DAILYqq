using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BI_HIGH_RISE_DAILY.Data.CLS;

namespace BI_HIGH_RISE_DAILY
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();

            DateTime dt_prev = DateTime.Now.AddMonths(-1);
            DateTime dt_now = DateTime.Now;

            DateTime dt = DateTime.Now.AddDays(-1);

            //Set First Day of Month
            //dt_prev = new DateTime(dt_prev.Year, dt_prev.Month, 1);
            //dt_now = new DateTime(dt_now.Year, dt_now.Month, 1);


            #region change_req
            try
            {
                var cls = new CHANGE_REQ();
                cls.exc(dt_now);//
            }
            catch (Exception ex)
            {
                string text = "excBIChange_Req: " + ex.Message.ToString();
                bool flgBIChange_Req = pg.SendtoEmail(text);
            }

            #endregion

            #region GoodsRecieve
            try
            {
                var cls = new GOOD_RECIEVE();
                cls.exc(dt);//dt_now
            }
            catch (Exception ex)
            {
                string text = "excBIGoodsRecieve: " + ex.Message.ToString();
                bool flgBIGoodsRecieve = pg.SendtoEmail(text);
            }


            #endregion

            #region Fix after transfer
            try
            {
                var cls = new FIX_AFTER_TRANSFER();
                cls.exc(dt);
            }
            catch (Exception ex)
            {
                string text = "excBIFix_after_Transfer: " + ex.Message.ToString();
                bool flgBIFixaftertransfer = pg.SendtoEmail(text);
            }

            #endregion




        }
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
