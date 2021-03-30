using BI_HIGH_RISE_DAILY.Data.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_HIGH_RISE_DAILY.Data.CLS
{
    public class ASSESSMENT_CONTRACTOR_FIX
    {
        public void exc(DateTime dt_now)
        {
            ReportDao rptDao = new ReportDao();
            var result = rptDao.GetAssConFix(dt_now);

            int ii = result.Count;
            if (ii > 0)
            {
                rptDao.POST_HIGH_RISE_ASSESSMENT_CONTRACTOR_FIX(result);
            }
        }
    }
}
