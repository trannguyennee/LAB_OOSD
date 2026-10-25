using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;

namespace QuanLyDuLich.Services
{
    public class ChuyenDiVeLeService
    {
        public DataTable GetAllChuyenDi()
        {
            string sql = @"SELECT cd.MaChuyen, t.TenTour, cd.NgayKhoiHanh, cd.NgayVe, cd.SoChoToiDa, cd.SoChoDaDat, 
                                  (cd.SoChoToiDa - cd.SoChoDaDat) AS SoChoConLai, cd.DiemDonQuyDinh, cd.TrangThai 
                           FROM ChuyenDi cd 
                           JOIN TourDuLich t ON cd.MaTour = t.MaTour 
                           ORDER BY cd.NgayKhoiHanh DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetTours()
        {
            return Db.ExecuteQuery("SELECT MaTour, TenTour, DonGiaKhach FROM TourDuLich WHERE TrangThai = N'DangKhaiThac'");
        }

        public DataTable GetDiemBanVe()
        {
            return Db.ExecuteQuery("SELECT MaDiemBanVe, TenDiemBanVe FROM DiemBanVe");
        }

        public DataTable GetKhachHangLe()
        {
            string sql = "SELECT k.MaKH, k.HoTen, k.SoDienThoai, k.Email, kl.SoNguoiDi, kl.MaDiemDonQuyDinh FROM KhachHang k JOIN KhachHangLe kl ON k.MaKH = kl.MaKH";
            return Db.ExecuteQuery(sql);
        }

        public bool InsertChuyenDi(string maChuyen, string maTour, DateTime ngayDi, DateTime ngayVe, int soCho, string diemDon)
        {
            string sql = "INSERT INTO ChuyenDi (MaChuyen, MaTour, NgayKhoiHanh, NgayVe, SoChoToiDa, SoChoDaDat, DiemDonQuyDinh, TrangThai) VALUES (@Ma, @Tour, @NgayDi, @NgayVe, @SoCho, 0, @DiemDon, N'MoBan')";
            int r = Db.ExecuteNonQuery(sql,
                new SqlParameter("@Ma", maChuyen),
                new SqlParameter("@Tour", maTour),
                new SqlParameter("@NgayDi", ngayDi),
                new SqlParameter("@NgayVe", ngayVe),
                new SqlParameter("@SoCho", soCho),
                new SqlParameter("@DiemDon", diemDon));
            return r > 0;
        }

        public DataTable GetVeByChuyen(string maChuyen)
        {
            string sql = @"SELECT v.MaVe, k.HoTen AS TenKhach, dbv.TenDiemBanVe, v.SoLuongVe, v.DonGiaVe, v.TongTien, v.NgayMua, v.HinhThucThanhToan, v.TrangThai 
                           FROM VeDuLich v 
                           JOIN KhachHang k ON v.MaKH = k.MaKH 
                           JOIN DiemBanVe dbv ON v.MaDiemBanVe = dbv.MaDiemBanVe 
                           WHERE v.MaChuyen = @MaChuyen";
            return Db.ExecuteQuery(sql, new SqlParameter("@MaChuyen", maChuyen));
        }

        public bool DatVeKhachLe(string maVe, string maChuyen, string maKH, string maDBV, int soLuong, string hinhThucTT)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_DatVeKhachLe", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaVe", maVe);
                    cmd.Parameters.AddWithValue("@MaChuyen", maChuyen);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@MaDiemBanVe", maDBV);
                    cmd.Parameters.AddWithValue("@SoLuongVe", soLuong);
                    cmd.Parameters.AddWithValue("@HinhThucThanhToan", hinhThucTT);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
    }
}
