using BI_HIGH_RISE_DAILY.Data.Dao;
using System;

namespace BI_HIGH_RISE_DAILY.Data.CLS
{
    class GOOD_RECIEVE
    {
        public void exc(DateTime dt_now)
        {
            ReportDao rptDao = new ReportDao();
            var result = rptDao.GetGoodRecieve(dt_now);

            int ii = result.Count;
            if (ii > 0)
            {
                rptDao.POST_HIGH_RISE_GOOD_RECIEVE(result);
            }
        }
    }
}
