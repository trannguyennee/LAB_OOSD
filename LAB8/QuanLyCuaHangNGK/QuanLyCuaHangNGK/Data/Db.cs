using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangNGK.Data
{
    public static class Db
    {
        private static string _connStr = null;

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connStr))
                {
                    if (ConfigurationManager.ConnectionStrings["ConnStr"] != null)
                    {
                        _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
                    }
                    else
                    {
                        _connStr = "Data Source=.;Initial Catalog=QuanLyCuaHangNGK;Integrated Security=True";
                    }
                }
                return _connStr;
            }
            set
            {
                _connStr = value;
            }
        }

        public static SqlConnection GetConnection()
        {
            string[] candidateSources = new string[] {
                ConnectionString,
                "Data Source=.;Initial Catalog=QuanLyCuaHangNGK;Integrated Security=True",
                "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyCuaHangNGK;Integrated Security=True",
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QuanLyCuaHangNGK;Integrated Security=True"
            };

            foreach (var connStr in candidateSources)
            {
                try
                {
                    var conn = new SqlConnection(connStr);
                    conn.Open();
                    _connStr = connStr;
                    return conn;
                }
                catch
                {
                    // Thử tiếp
                }
            }

            return new SqlConnection(ConnectionString);
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static bool TestConnection(out string message)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    message = "Kết nối SQL Server thành công!\nNguồn: " + conn.DataSource + "\nCSDL: " + conn.Database;
                    return true;
                }
            }
            catch (Exception ex)
            {
                message = "Không thể kết nối SQL Server: " + ex.Message;
                return false;
            }
        }
    }
}
