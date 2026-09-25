using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Data
{
    public static class Db
    {
        // 1. Lấy chuỗi kết nối từ App.config
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["QuanLyKhachSanDB"].ConnectionString;
            }
        }

        // 2. Mở kết nối tới SQL Server
        public static SqlConnection OpenConnection()
        {
            var cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        // 3. Thực thi câu lệnh SELECT trả về bảng dữ liệu (DataTable)
        public static DataTable Query(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (ps != null && ps.Length > 0)
                    cmd.Parameters.AddRange(ps);

                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 4. Thực thi câu lệnh INSERT, UPDATE, DELETE (trả về số dòng ảnh hưởng)
        public static int Execute(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0)
                    cmd.Parameters.AddRange(ps);

                return cmd.ExecuteNonQuery();
            }
        }

        // 5. Thực thi truy vấn trả về 1 giá trị đơn (COUNT, SUM, MAX,...)
        public static object Scalar(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0)
                    cmd.Parameters.AddRange(ps);

                return cmd.ExecuteScalar();
            }
        }
    }
}