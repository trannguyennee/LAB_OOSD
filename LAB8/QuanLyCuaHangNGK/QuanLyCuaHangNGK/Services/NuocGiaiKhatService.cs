using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class NuocGiaiKhatService
    {
        public DataTable GetAllNGK()
        {
            string sql = @"SELECT n.MaNGK, n.TenNGK, n.DonViTinh, n.SoLuongTon, n.DonGiaBan, 
                                  n.MaLoai, l.TenLoai, c.TenNCU, c.MaNCU
                           FROM NuocGiaiKhat n
                           INNER JOIN LoaiNGK l ON n.MaLoai = l.MaLoai
                           INNER JOIN NhaCungUng c ON l.MaNCU = c.MaNCU
                           ORDER BY n.TenNGK";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetLoaiNGK()
        {
            string sql = "SELECT MaLoai, TenLoai, MaNCU FROM LoaiNGK ORDER BY TenLoai";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetNhaCungUng()
        {
            string sql = "SELECT MaNCU, TenNCU, DiaChi, SoDT FROM NhaCungUng ORDER BY TenNCU";
            return Db.ExecuteQuery(sql);
        }

        public bool KiemTraTonKho(string maNGK, int soLuongYeuCau, out int tonHienTai)
        {
            string sql = "SELECT SoLuongTon FROM NuocGiaiKhat WHERE MaNGK = @MaNGK";
            object res = Db.ExecuteScalar(sql, new SqlParameter("@MaNGK", maNGK));
            tonHienTai = res != null ? Convert.ToInt32(res) : 0;
            return tonHienTai >= soLuongYeuCau;
        }

        public int InsertNGK(string ma, string ten, string dvt, int ton, decimal gia, string maLoai)
        {
            string sql = @"INSERT INTO NuocGiaiKhat (MaNGK, TenNGK, DonViTinh, SoLuongTon, DonGiaBan, MaLoai)
                           VALUES (@Ma, @Ten, @Dvt, @Ton, @Gia, @MaLoai)";
            return Db.ExecuteNonQuery(sql,
                new SqlParameter("@Ma", ma),
                new SqlParameter("@Ten", ten),
                new SqlParameter("@Dvt", dvt),
                new SqlParameter("@Ton", ton),
                new SqlParameter("@Gia", gia),
                new SqlParameter("@MaLoai", maLoai));
        }

        public int UpdateNGK(string ma, string ten, string dvt, int ton, decimal gia, string maLoai)
        {
            string sql = @"UPDATE NuocGiaiKhat 
                           SET TenNGK = @Ten, DonViTinh = @Dvt, SoLuongTon = @Ton, DonGiaBan = @Gia, MaLoai = @MaLoai
                           WHERE MaNGK = @Ma";
            return Db.ExecuteNonQuery(sql,
                new SqlParameter("@Ma", ma),
                new SqlParameter("@Ten", ten),
                new SqlParameter("@Dvt", dvt),
                new SqlParameter("@Ton", ton),
                new SqlParameter("@Gia", gia),
                new SqlParameter("@MaLoai", maLoai));
        }

        public int DeleteNGK(string ma)
        {
            string sql = "DELETE FROM NuocGiaiKhat WHERE MaNGK = @Ma";
            return Db.ExecuteNonQuery(sql, new SqlParameter("@Ma", ma));
        }
    }
}
