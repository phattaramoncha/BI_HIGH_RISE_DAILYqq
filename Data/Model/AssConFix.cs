using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_HIGH_RISE_DAILY.Data.Model
{
    public class AssConFix
    {
        public string proj_code { get; set; }
        public string proj_name { get; set; }
        public DateTime? closed_at { get; set; }
        public int? months { get; set; }
        public int? years { get; set; }
        public Guid fix_work_order_id { get; set; }
        public string fix_work_code { get; set; }
        public string fix_code { get; set; }
        public string contractor_code { get; set; }
        public string contractor_name { get; set; }
        public string types { get; set; }
        public decimal? score_1 { get; set; }
        public string grade_1 { get; set; }
        public decimal? score_2 { get; set; }
        public string grade_2 { get; set; }
        public decimal? score_3 { get; set; }
        public string grade_3 { get; set; }
        public decimal? score_4 { get; set; }
        public string grade_4 { get; set; }
        public decimal? score_5 { get; set; }
        public string grade_5 { get; set; }
        public decimal? score_6 { get; set; }
        public string grade_6 { get; set; }
        public decimal? score_7 { get; set; }
        public string grade_7 { get; set; }
        public decimal? score_assessment { get; set; }
        public string grade_assessment { get; set; }
    }
}
