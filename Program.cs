using System;
using BI_HIGH_RISE_DAILY.Data.CLS;

namespace BI_HIGH_RISE_DAILY
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt_prev = DateTime.Now.AddMonths(-1);
            DateTime dt_now = DateTime.Now;

            DateTime dt = DateTime.Now.AddDays(-1);

            #region MyRegion

            //Set First Day of Month
            //dt_prev = new DateTime(dt_prev.Year, dt_prev.Month, 1);
            //dt_now = new DateTime(dt_now.Year, dt_now.Month, 1);
            //string text = "excBIChange_Req: " + ex.Message.ToString();
            //bool flgBIChange_Req = send_mail.SendtoEmail(text);

            #endregion

            #region change_req

            var CHANGE_REQ = new CHANGE_REQ();
            CHANGE_REQ.exc(dt_now);

            #endregion

            #region GoodsRecieve

            var GOOD_RECIEVE = new GOOD_RECIEVE();
            GOOD_RECIEVE.exc(dt); //dt_now

            #endregion

            #region GoodsRecieve Cancel

            var GOOD_RECIEVE_CANCEL = new GOOD_RECIEVE_CANCEL();
            GOOD_RECIEVE_CANCEL.exc(dt); //dt_now

            #endregion

            #region Fix after transfer

            var FIX_AFTER_TRANSFER = new FIX_AFTER_TRANSFER();
            FIX_AFTER_TRANSFER.exc(dt);

            #endregion

            #region Assessment_Contractor_Fix ประเมินผู้รับเหมา งานซ่อม

            var ASSESSMENT_CONTRACTOR_FIX = new ASSESSMENT_CONTRACTOR_FIX();
            ASSESSMENT_CONTRACTOR_FIX.exc(dt);

            #endregion

            #region PR_PO_GR

            var PR_PO_GR = new PR_PO_GR();
            PR_PO_GR.exc(dt);

            #endregion
        }
    }
}