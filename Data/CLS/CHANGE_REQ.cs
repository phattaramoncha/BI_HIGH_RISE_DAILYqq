﻿using ReportCM.Data.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
