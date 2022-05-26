﻿using BI_HIGH_RISE_DAILY.Data.Dao;
using System;
using System.Linq;

namespace BI_HIGH_RISE_DAILY.Data.CLS
{
    class CHANGE_REQ
    {
        public void exc(DateTime dt_now)
        {
            ReportDao rptDao = new ReportDao();
            var result = rptDao.GetChangeReq(dt_now);

            int ii = result.Count();
            if (ii > 0)
            {
                rptDao.POST_HIGH_RISE_CHANGE_REQ(result);
            }
        }
    }
}
