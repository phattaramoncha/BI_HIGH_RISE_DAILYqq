using BI_HIGH_RISE_DAILY.Data.CLS;
using BI_HIGH_RISE_DAILY.Data.Model;
using CJRPortal.App_Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ReportCM.Data.Dao
{
    public class ReportDao : BaseDao
    {
        SEND_EMAIL send_mail = new SEND_EMAIL();

        public List<GoodRecieve> GetGoodRecieve(DateTime dt_now)
        {
            try
            {
                using (var conn = new NpgsqlConnection(DB_CONNECTION))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("spl_get_bi_high_rise_good_recieve", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("in_period", NpgsqlTypes.NpgsqlDbType.Date, dt_now);

                        using (var reader = cmd.ExecuteReader())
                        {
                            return SQLDataMapper.MapToCollection<GoodRecieve>(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string text = "GetGoodRecieve => spl_get_bi_high_rise_good_recieve: " + ex.Message.ToString();
                send_mail.SendtoEmail(text);
                throw new Exception(ex.Message);
            }
        }

        public void POST_HIGH_RISE_ASSESSMENT_CONTRACTOR_FIX(List<AssConFix> fix)
        {
            bool flg = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(CRMDB_CONNECTION))
                {
                    using (SqlCommand cmd = new SqlCommand("POST_HIGH_RISE_ASSESSMENT_CONTRACTOR_FIX", conn))
                    {
                        conn.Open();

                        foreach (var item in fix)
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@proj_code", ((object)item.proj_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@proj_name", ((object)item.proj_name) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@closed_at", ((object)item.closed_at) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@months", ((object)item.months) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@years", ((object)item.years) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@fix_work_order_id", ((object)item.fix_work_order_id) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@fix_work_code", ((object)item.fix_work_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@fix_code", ((object)item.fix_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@contractor_code", ((object)item.contractor_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@contractor_name", ((object)item.contractor_name) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@types", ((object)item.types) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@quality", ((object)item.score_1) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@g_quality", ((object)item.grade_1) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@mandays", ((object)item.score_2) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@g_mandays", ((object)item.grade_2) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@personnel", ((object)item.score_3) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@g_personnel", ((object)item.grade_3) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@coordination", ((object)item.score_4) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@g_coordination", ((object)item.grade_4) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@management", ((object)item.score_5) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@g_management", ((object)item.grade_5) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@service", ((object)item.score_6) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@g_service", ((object)item.grade_6) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@safety_hygiene", ((object)item.score_7) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@g_safety_hygiene", ((object)item.grade_7) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@assessment", ((object)item.score_assessment) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@g_assessment", ((object)item.grade_assessment) ?? DBNull.Value);

                            int result = cmd.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                                Console.WriteLine("Error inserting data into Database!");
                            else flg = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string text = "Stroed P. => POST_HIGH_RISE_ASSESSMENT_CONTRACTOR_FIX: " + ex.Message.ToString();
                send_mail.SendtoEmail(text);
                throw new Exception(ex.Message);
            }
        }

        public List<AssConFix> GetAssConFix(object dt_now)
        {
            try
            {
                using (var conn = new NpgsqlConnection(DB_CONNECTION))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("spl_get_bi_high_rise_assessment_contractor_fix_v2", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("in_date", NpgsqlTypes.NpgsqlDbType.Date, dt_now);

                        using (var reader = cmd.ExecuteReader())
                        {
                            return SQLDataMapper.MapToCollection<AssConFix>(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string text = "GetAssConFix => spl_get_bi_high_rise_assessment_contractor_fix_v2: " + ex.Message.ToString();
                send_mail.SendtoEmail(text);
                throw new Exception(ex.Message);
            }
        }

        public void POST_HIGH_RISE_FIX_AFTER_TRANSFER(List<FixTransfer> fix)
        {
            bool flg = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(CRMDB_CONNECTION))
                {
                    using (SqlCommand cmd = new SqlCommand("POST_HIGH_RISE_FIX_AFTER_TRANSFER", conn))
                    {
                        conn.Open();

                        foreach (var item in fix)
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@month", ((object)item.month) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@year", ((object)item.year) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@proj_code", ((object)item.proj_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@proj_name", ((object)item.proj_name) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@proj_grade_code", ((object)item.proj_grade_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@proj_grade_name", ((object)item.proj_grade_name) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@proj_grade_name_en", ((object)item.proj_grade_name_en) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@emp_code", ((object)item.emp_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@manager_name", ((object)item.manager_name) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cnt_transfer", ((object)item.cnt_transfer) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cnt_nj", ((object)item.cnt_nj) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cnt_closedin10", ((object)item.cnt_closedin10) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cnt_intime", ((object)item.cnt_intime) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cnt_perc_intime", ((object)item.cnt_perc_intime) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cnt_overdue", ((object)item.cnt_overdue) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cnt_perc_overdue", ((object)item.cnt_perc_overdue) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cnt_list_nj", ((object)item.cnt_list_nj) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cnt_rooms_nj", ((object)item.cnt_rooms_nj) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@avg_days_fix", ((object)item.avg_days_fix) ?? DBNull.Value);

                            int result = cmd.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                                Console.WriteLine("Error inserting data into Database!");
                            else flg = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string text = "Stroed P. => POST_HIGH_RISE_FIX_AFTER_TRANSFER: " + ex.Message.ToString();
                send_mail.SendtoEmail(text);
                throw new Exception(ex.Message);
            }
        }

        public void POST_HIGH_RISE_CHANGE_REQ(List<ChangeReq> change_Req)
        {
            bool flg = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(CRMDB_CONNECTION))
                {
                    using (SqlCommand cmd = new SqlCommand("POST_HIGH_RISE_CHANGE_REQ", conn))
                    {
                        conn.Open();

                        foreach (var item in change_Req)
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@proj_code", ((object)item.proj_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@proj_name", ((object)item.proj_name) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@po_no", ((object)item.po_no) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@contractor_code", ((object)item.contractor_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@contractor_full_name_snap", ((object)item.contractor_full_name_snap) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@budget_name", ((object)item.budget_name) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@contract_amount_inc_vat", ((object)item.contract_amount_inc_vat) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@doc_reference", ((object)item.doc_reference) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@ctime", ((object)item.ctime) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@changetype", ((object)item.changetype) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@title", ((object)item.title) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@increase_amount", ((object)item.increase_amount) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@decrease_amount", ((object)item.decrease_amount) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cause_description", ((object)item.cause_description) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@cause_desc_now", ((object)item.cause_desc_now) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@years", ((object)item.years) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@months", ((object)item.months) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@status", ((object)item.status) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@id", ((object)item.id) ?? DBNull.Value); //uuid,
                            cmd.Parameters.AddWithValue("@approve_at", ((object)item.approve_at) ?? DBNull.Value);


                            int result = cmd.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                                Console.WriteLine("Error inserting data into Database!");
                            else flg = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string text = "Stroed P. => POST_HIGH_RISE_CHANGE_REQ: " + ex.Message.ToString();
                send_mail.SendtoEmail(text);
                throw new Exception(ex.Message);
            }
        }

        public void POST_HIGH_RISE_GOOD_RECIEVE(List<GoodRecieve> goodRecieves)
        {
            bool flg = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(CRMDB_CONNECTION))
                {
                    using (SqlCommand cmd = new SqlCommand("POST_HIGH_RISE_GOOD_RECIEVE", conn))
                    {
                        conn.Open();

                        foreach (var item in goodRecieves)
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@cat_code", ((object)item.cat_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@sub_cat_code", ((object)item.sub_cat_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@posting_date", ((object)item.posting_date) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@months", ((object)item.months) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@years", ((object)item.years) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@proj_code", ((object)item.proj_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@proj_name", ((object)item.proj_name) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@gr_no", ((object)item.gr_no) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@gr_item", ((object)item.gr_item) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@po_no", ((object)item.po_no) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@po_item", ((object)item.po_item) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@pr_no", ((object)item.pr_no) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@pr_item", ((object)item.pr_item) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@mm_code", ((object)item.mm_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@mm_name", ((object)item.mm_name) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@amount", ((object)item.amount) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@sap_mat_doc_no", ((object)item.sap_mat_doc_no) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@vendor_code", ((object)item.vendor_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@vendor_name", ((object)item.vendor_name) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@boq_code", ((object)item.boq_code) ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@boq_name", ((object)item.boq_name) ?? DBNull.Value);


                            int result = cmd.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                                Console.WriteLine("Error inserting data into Database!");
                            else flg = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string text = "Stroed P. => POST_HIGH_RISE_GOOD_RECIEVE: " + ex.Message.ToString();
                send_mail.SendtoEmail(text);
                throw new Exception(ex.Message);
            }
        }

        public List<ChangeReq> GetChangeReq(DateTime dt_now)
        {
            try
            {
                using (var conn = new NpgsqlConnection(DB_CONNECTION))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("spl_get_bi_change_req_high_rise", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("sdate", NpgsqlTypes.NpgsqlDbType.Date, dt_now); //XXXX,XXXX,XXXX

                        using (var reader = cmd.ExecuteReader())
                        {
                            return SQLDataMapper.MapToCollection<ChangeReq>(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string text = "GetChangeReq => spl_get_bi_change_req_high_rise: " + ex.Message.ToString();
                send_mail.SendtoEmail(text);
                throw new Exception(ex.Message);

            }
        }

        public List<FixTransfer> GetFixAfterTransfer(DateTime dt_now)
        {
            try
            {
                using (var conn = new NpgsqlConnection(DB_CONNECTION))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("spl_get_bi_high_rise_fix_after_transfer_v2", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("in_closed_date", NpgsqlTypes.NpgsqlDbType.Date, dt_now); //XXXX,XXXX,XXXX

                        using (var reader = cmd.ExecuteReader())
                        {
                            return SQLDataMapper.MapToCollection<FixTransfer>(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string text = "GetFixAfterTransfer => spl_get_bi_high_rise_fix_after_transfer_v2: " + ex.Message.ToString();
                send_mail.SendtoEmail(text);
                throw new Exception(ex.Message);
            }
        }


    }
}