using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_High.Data.Model
{
    public class FixTransfer
    {
        public int? month { get; set; }
        public int? year { get; set; }
        public string proj_code { get; set; }
        public string proj_name { get; set; }
        public string proj_grade_code { get; set; }
        public string proj_grade_name { get; set; }
        public string proj_grade_name_en { get; set; }
        public string emp_code { get; set; }
        public string manager_name { get; set; }
        public decimal? cnt_transfer { get; set; }
        public decimal? cnt_nj { get; set; }
        public decimal? cnt_closedin10 { get; set; }
        public decimal? cnt_intime { get; set; }
        public decimal? cnt_perc_intime { get; set; }
        public decimal? cnt_overdue { get; set; }
        public decimal? cnt_perc_overdue { get; set; }
        public decimal? cnt_list_nj { get; set; }
        public decimal? cnt_rooms_nj { get; set; }
        public decimal? avg_days_fix { get; set; }
    }
}
