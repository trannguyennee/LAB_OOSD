using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;

namespace QuanLyDuLich.Services
{
    public class DangKyDoanBaoHiemService
    {
        public DataTable GetAllPhieuDoan()
        {
            string sql = @"SELECT pd.MaPhieuDangKy, kd.TenCoQuan, kd.NguoiDaiDien, t.TenTour, pd.NgayKhoiHanh, pd.NgayKetThuc, 
                                  pd.SoLuongKhach, pd.DiaDiemDon, pd.KinhPhiDuKien, pd.TienDatCoc, pd.SoTienConLai, pd.TinhTrangCoc, pd.TrangThaiThanhToan 
                           FROM PhieuDangKyDoan pd 
                           JOIN KhachHangDoan kd ON pd.MaKH = kd.MaKH 
                           JOIN TourDuLich t ON pd.MaTour = t.MaTour 
                           ORDER BY pd.NgayLap DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetKhachHangDoan()
        {
            string sql = "SELECT k.MaKH, kd.TenCoQuan, kd.NguoiDaiDien, kd.DienThoaiCoQuan, kd.DiaDiemDonYeuCau FROM KhachHang k JOIN KhachHangDoan kd ON k.MaKH = kd.MaKH";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetBaoHiemByPhieu(string maPhieu)
        {
            string sql = "SELECT MaBaoHiem, HoTenNguoiDi, NgaySinh, CCCD, GioiTinh, QuanHeVoiDaiDien FROM NguoiThamGiaBaoHiem WHERE MaPhieuDangKy = @Ma ORDER BY MaBaoHiem";
            return Db.ExecuteQuery(sql, new SqlParameter("@Ma", maPhieu));
        }

        public bool LapPhieuDangKyDoan(string maPhieu, string maKH, string maTour, DateTime ngayDi, DateTime ngayVe, int soKhach, string diaDiemDon, bool coBaoHiem, decimal tienCoc)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_LapPhieuDangKyDoan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuDangKy", maPhieu);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@MaTour", maTour);
                    cmd.Parameters.AddWithValue("@NgayKhoiHanh", ngayDi);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ngayVe);
                    cmd.Parameters.AddWithValue("@SoLuongKhach", soKhach);
                    cmd.Parameters.AddWithValue("@DiaDiemDon", diaDiemDon);
                    cmd.Parameters.AddWithValue("@CoMuaBaoHiem", coBaoHiem);
                    cmd.Parameters.AddWithValue("@TienDatCoc", tienCoc);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public bool ThemNguoiBaoHiem(string maBH, string maPhieu, string hoTen, DateTime ngaySinh, string cccd, string gioiTinh, string quanHe)
        {
            string sql = "INSERT INTO NguoiThamGiaBaoHiem (MaBaoHiem, MaPhieuDangKy, HoTenNguoiDi, NgaySinh, CCCD, GioiTinh, QuanHeVoiDaiDien) VALUES (@MaBH, @MaPhieu, @Ten, @NgaySinh, @CCCD, @GioiTinh, @QuanHe)";
            int r = Db.ExecuteNonQuery(sql,
                new SqlParameter("@MaBH", maBH),
                new SqlParameter("@MaPhieu", maPhieu),
                new SqlParameter("@Ten", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@CCCD", cccd),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@QuanHe", (object)quanHe ?? DBNull.Value));
            return r > 0;
        }

        public bool QuyetToanKinhPhi(string maPhieu)
        {
            string sql = "UPDATE PhieuDangKyDoan SET SoTienConLai = 0, TrangThaiThanhToan = N'DaQuyetToan', TinhTrangCoc = N'HoanTat' WHERE MaPhieuDangKy = @Ma";
            int r = Db.ExecuteNonQuery(sql, new SqlParameter("@Ma", maPhieu));
            return r > 0;
        }
    }
}
