using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_High.Data.Model
{
    public class GoodRecieve
    {
        public string cat_code { get; set; }
        public string sub_cat_code { get; set; }
        public DateTime? posting_date { get; set; }
        public int? months { get; set; }
        public int? years { get; set; }
        public string proj_code { get; set; }
        public string proj_name { get; set; }
        public string gr_no { get; set; }
        public int? gr_item { get; set; }
        public string po_no { get; set; }
        public int? po_item { get; set; }
        public string pr_no { get; set; }
        public int? pr_item { get; set; }
        public string mm_code { get; set; }
        public string mm_name { get; set; }
        public decimal? amount { get; set; }
        public string sap_mat_doc_no { get; set; }
        public string vendor_code { get; set; }
        public string vendor_name { get; set; }
        public string boq_code { get; set; }
        public string boq_name { get; set; }
    }
    public class prm_gr
    {
        public string in_period { get; set; }

    }
}
