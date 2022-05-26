using BI_HIGH_RISE_DAILY.Data.Dao;
using System;

namespace BI_HIGH_RISE_DAILY.Data.CLS
{
    class FIX_AFTER_TRANSFER
    {
        public void exc(DateTime dt_now)
        {
            ReportDao rptDao = new ReportDao();
            var result = rptDao.GetFixAfterTransfer(dt_now);

            int ii = result.Count;
            if (ii > 0)
            {
                rptDao.POST_HIGH_RISE_FIX_AFTER_TRANSFER(result);
            }
        }
    }
}
