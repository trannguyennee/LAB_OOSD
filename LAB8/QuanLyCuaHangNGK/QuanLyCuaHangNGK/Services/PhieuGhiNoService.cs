using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class PhieuGhiNoService
    {
        public DataTable GetAllPhieuGhiNo()
        {
            string sql = @"SELECT p.SoPGN, p.NgayLap, p.SoTienNo, p.NgayDuKienTra, p.LyDoNo, p.DaTra,
                                  p.SoHD, p.MaKH, k.TenKH, k.LoaiKH, k.SoDT, nv.HoTen AS NhanVienLap
                           FROM PhieuGhiNo p
                           INNER JOIN KhachHang k ON p.MaKH = k.MaKH
                           INNER JOIN NhanVien nv ON p.MaNV = nv.MaNV
                           ORDER BY p.NgayLap DESC";
            return Db.ExecuteQuery(sql);
        }

        public void ThanhToanNo(string soPGN)
        {
            string sqlSelect = "SELECT SoTienNo, MaKH, DaTra FROM PhieuGhiNo WHERE SoPGN = @SoPGN";
            DataTable dt = Db.ExecuteQuery(sqlSelect, new SqlParameter("@SoPGN", soPGN));
            if (dt.Rows.Count == 0) throw new Exception("Không tìm thấy Phiếu ghi nợ!");

            bool daTra = Convert.ToBoolean(dt.Rows[0]["DaTra"]);
            if (daTra) throw new Exception("Phiếu ghi nợ này đã được thanh toán rồi!");

            decimal soTienNo = Convert.ToDecimal(dt.Rows[0]["SoTienNo"]);
            string maKH = dt.Rows[0]["MaKH"].ToString();

            // 1. Cập nhật phiếu nợ thành đã trả
            string sqlUpPGN = "UPDATE PhieuGhiNo SET DaTra = 1 WHERE SoPGN = @SoPGN";
            Db.ExecuteNonQuery(sqlUpPGN, new SqlParameter("@SoPGN", soPGN));

            // 2. Giảm trừ tổng nợ khách hàng
            string sqlUpKH = "UPDATE KhachHang SET TongNo = CASE WHEN TongNo >= @Tien THEN TongNo - @Tien ELSE 0 END WHERE MaKH = @MaKH";
            Db.ExecuteNonQuery(sqlUpKH, new SqlParameter("@Tien", soTienNo), new SqlParameter("@MaKH", maKH));
        }
    }
}
