using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class BaoCaoService
    {
        public DataTable GetBaoCaoDoanhThu()
        {
            string sql = @"SELECT CONVERT(VARCHAR(10), NgayLap, 103) AS Ngay,
                                  COUNT(*) AS SoHoaDon,
                                  SUM(TongTien) AS TongDoanhThu
                           FROM HoaDon
                           GROUP BY CONVERT(VARCHAR(10), NgayLap, 103)
                           ORDER BY Ngay DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetBaoCaoCongNo()
        {
            string sql = @"SELECT MaKH, TenKH, LoaiKH, SoDT, TongNo
                           FROM KhachHang
                           WHERE TongNo > 0
                           ORDER BY TongNo DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetBaoCaoTonKhoCanhBao(int dinhMuc = 50)
        {
            string sql = @"SELECT n.MaNGK, n.TenNGK, n.DonViTinh, n.SoLuongTon, n.DonGiaBan, l.TenLoai
                           FROM NuocGiaiKhat n
                           INNER JOIN LoaiNGK l ON n.MaLoai = l.MaLoai
                           WHERE n.SoLuongTon <= @DinhMuc
                           ORDER BY n.SoLuongTon ASC";
            return Db.ExecuteQuery(sql, new SqlParameter("@DinhMuc", dinhMuc));
        }

        public void GetThongKeTongQuan(out int tongNGK, out decimal doanhThu, out decimal tongCongNo, out int donChoGiao)
        {
            try
            {
                object r1 = Db.ExecuteScalar("SELECT COUNT(*) FROM NuocGiaiKhat");
                tongNGK = r1 != null ? Convert.ToInt32(r1) : 0;

                object r2 = Db.ExecuteScalar("SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon");
                doanhThu = r2 != null ? Convert.ToDecimal(r2) : 0;

                object r3 = Db.ExecuteScalar("SELECT ISNULL(SUM(TongNo), 0) FROM KhachHang");
                tongCongNo = r3 != null ? Convert.ToDecimal(r3) : 0;

                object r4 = Db.ExecuteScalar("SELECT COUNT(*) FROM PhieuHen WHERE TrangThai = N'Chờ giao'");
                donChoGiao = r4 != null ? Convert.ToInt32(r4) : 0;
            }
            catch
            {
                tongNGK = 0; doanhThu = 0; tongCongNo = 0; donChoGiao = 0;
            }
        }
    }
}
