namespace BI_HIGH_RISE_DAILY.Data.Dao
{
    public class CommonDao : BaseDao
    {
        //public List<Zone> GetZones()
        //{
        //    try
        //    {
        //        using (var conn = new NpgsqlConnection(DB_CONNECTION))
        //        {
        //            conn.Open();
        //            using (var cmd = new NpgsqlCommand("spl_get_zone", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("in_search", NpgsqlTypes.NpgsqlDbType.Text, string.IsNullOrEmpty("") ? (object)DBNull.Value : "");

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    return SQLDataMapper.MapToCollection<Zone>(reader);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public List<User> GetCreateContract()
        //{
        //    try
        //    {
        //        using (var conn = new NpgsqlConnection(DB_CONNECTION))
        //        {
        //            conn.Open();
        //            using (var cmd = new NpgsqlCommand("spl_get_user_create_contract", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                //cmd.Parameters.AddWithValue("in_search", NpgsqlTypes.NpgsqlDbType.Text, string.IsNullOrEmpty("") ? (object)DBNull.Value : "");

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    return SQLDataMapper.MapToCollection<User>(reader);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public List<Project> GetProjectByZone(string ZoneId)
        //{
        //    try
        //    {
        //        using (var conn = new NpgsqlConnection(DB_CONNECTION))
        //        {
        //            conn.Open();
        //            using (var cmd = new NpgsqlCommand("spl_get_project_by_zone", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("in_zone", NpgsqlTypes.NpgsqlDbType.Uuid, string.IsNullOrEmpty(ZoneId) || Guid.Parse(ZoneId).Equals(Guid.Empty) ? (object)DBNull.Value : Guid.Parse(ZoneId));

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    return SQLDataMapper.MapToCollection<Project>(reader);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public List<Project> GetProjectByUser(string UserName)
        //{
        //    try
        //    {
        //        using (var conn = new NpgsqlConnection(DB_CONNECTION))
        //        {
        //            conn.Open();
        //            using (var cmd = new NpgsqlCommand("spl_get_project", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("in_search", NpgsqlTypes.NpgsqlDbType.Text, string.IsNullOrEmpty(UserName) ? (object)DBNull.Value : UserName);

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    return SQLDataMapper.MapToCollection<Project>(reader);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public List<Menu> GetMenu()
        //{
        //    try
        //    {
        //        using (var conn = new NpgsqlConnection(DB_CONNECTION))
        //        {
        //            conn.Open();
        //            using (var cmd = new NpgsqlCommand("spl_get_menu", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("in_search", NpgsqlTypes.NpgsqlDbType.Text, (object)DBNull.Value);

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    return SQLDataMapper.MapToCollection<Menu>(reader);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public List<Dept_SMC> GetDeptSMC()
        //{
        //    try
        //    {
        //        using (var conn = new NpgsqlConnection(DB_CONNECTION))
        //        {
        //            conn.Open();
        //            using (var cmd = new NpgsqlCommand("spl_dept_smc", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("in_search", NpgsqlTypes.NpgsqlDbType.Text, (object)DBNull.Value);

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    return SQLDataMapper.MapToCollection<Dept_SMC>(reader);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public List<Project> GetProjectByProjectID(string ProjId)
        //{
        //    try
        //    {
        //        using (var conn = new NpgsqlConnection(DB_CONNECTION))
        //        {
        //            conn.Open();
        //            using (var cmd = new NpgsqlCommand("spl_get_project_by_projid", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("in_projid", NpgsqlTypes.NpgsqlDbType.Text, string.IsNullOrEmpty(ProjId) ? (object)DBNull.Value : ProjId);

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    return SQLDataMapper.MapToCollection<Project>(reader);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

    }
}