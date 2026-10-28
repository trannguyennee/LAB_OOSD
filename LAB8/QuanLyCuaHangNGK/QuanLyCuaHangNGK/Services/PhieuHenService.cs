using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class PhieuHenService
    {
        public DataTable GetAllPhieuHen()
        {
            string sql = @"SELECT p.SoPH, p.NgayHenGiao, p.DotGiaoHen, p.SoLuongHen, p.TrangThai,
                                  p.SoHD, p.MaNGK, n.TenNGK, n.DonViTinh, k.TenKH, k.SoDT
                           FROM PhieuHen p
                           INNER JOIN NuocGiaiKhat n ON p.MaNGK = n.MaNGK
                           INNER JOIN HoaDon h ON p.SoHD = h.SoHD
                           INNER JOIN KhachHang k ON h.MaKH = k.MaKH
                           ORDER BY p.NgayHenGiao ASC";
            return Db.ExecuteQuery(sql);
        }

        public void XacNhanGiaoHang(string soPH)
        {
            // Lấy thông tin phiếu hẹn
            string sqlSelect = "SELECT SoLuongHen, MaNGK, TrangThai FROM PhieuHen WHERE SoPH = @SoPH";
            DataTable dt = Db.ExecuteQuery(sqlSelect, new SqlParameter("@SoPH", soPH));
            if (dt.Rows.Count == 0) throw new Exception("Không tìm thấy Phiếu hẹn!");

            string trangThai = dt.Rows[0]["TrangThai"].ToString();
            if (trangThai == "Đã giao") throw new Exception("Phiếu hẹn này đã được giao trước đó!");

            int sl = Convert.ToInt32(dt.Rows[0]["SoLuongHen"]);
            string maNGK = dt.Rows[0]["MaNGK"].ToString();

            // Kiểm tra tồn kho có đủ để xuất giao đợt hẹn không
            string sqlKho = "SELECT SoLuongTon FROM NuocGiaiKhat WHERE MaNGK = @Ma";
            int ton = Convert.ToInt32(Db.ExecuteScalar(sqlKho, new SqlParameter("@Ma", maNGK)));
            if (ton < sl)
            {
                throw new Exception("Tồn kho hiện tại (" + ton + ") chưa đủ để giao đợt hẹn (" + sl + ")! Vui lòng nhập hàng thêm.");
            }

            // Trừ kho và cập nhật trạng thái phiếu hẹn
            string sqlSub = "UPDATE NuocGiaiKhat SET SoLuongTon = SoLuongTon - @SL WHERE MaNGK = @Ma";
            Db.ExecuteNonQuery(sqlSub, new SqlParameter("@SL", sl), new SqlParameter("@Ma", maNGK));

            string sqlUp = "UPDATE PhieuHen SET TrangThai = N'Đã giao' WHERE SoPH = @SoPH";
            Db.ExecuteNonQuery(sqlUp, new SqlParameter("@SoPH", soPH));
        }
    }
}
