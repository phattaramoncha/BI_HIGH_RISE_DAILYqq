using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI_HIGH_RISE_DAILY.Data.Model
{
    public class ChangeReq
    {
        public string proj_code { get; set; }
        public string proj_name { get; set; }
        public string po_no { get; set; }
        public string contractor_code { get; set; }
        public string contractor_full_name_snap { get; set; }
        public string budget_name { get; set; }
        public decimal? contract_amount_inc_vat { get; set; }
        public string doc_reference { get; set; }
        public int? ctime { get; set; }
        public string changetype { get; set; }
        public string title { get; set; }
        public decimal? increase_amount { get; set; }
        public decimal? decrease_amount { get; set; }
        public string cause_description { get; set; }
        public string cause_desc_now { get; set; }
        public string years { get; set; }
        public string months { get; set; }
        public string status { get; set; }
        public Guid? id { get; set; }
        public DateTime? approve_at { get; set; }
    }
}
