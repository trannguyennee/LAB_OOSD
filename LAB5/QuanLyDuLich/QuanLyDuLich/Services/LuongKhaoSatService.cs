using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;

namespace QuanLyDuLich.Services
{
    public class LuongKhaoSatService
    {
        public DataTable GetBangLuongByThang(string thangNam)
        {
            string sql = @"SELECT bl.MaBangLuong, nv.HoTen AS TenHDV, bl.ThangNam, bl.LuongCanBan, bl.SoTourThucHien, 
                                  bl.TongThuLaoTour, bl.PhuCapKhac, bl.TongLuongThucNhan, bl.NgayTinh, bl.TrangThai 
                           FROM BangLuongHDV bl 
                           JOIN NhanVien nv ON bl.MaNV = nv.MaNV 
                           WHERE bl.ThangNam = @ThangNam 
                           ORDER BY bl.MaBangLuong";
            return Db.ExecuteQuery(sql, new SqlParameter("@ThangNam", thangNam));
        }

        public bool TinhLuongHDV(string maBL, string maNV, string thangNam, decimal phuCap)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_TinhLuongHDV", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBangLuong", maBL);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@ThangNam", thangNam);
                    cmd.Parameters.AddWithValue("@PhuCapKhac", phuCap);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public bool XacNhanChiLuong(string maBL)
        {
            string sql = "UPDATE BangLuongHDV SET TrangThai = N'DaChi' WHERE MaBangLuong = @Ma";
            int r = Db.ExecuteNonQuery(sql, new SqlParameter("@Ma", maBL));
            return r > 0;
        }

        public DataTable GetAllPhieuKhaoSat()
        {
            string sql = @"SELECT pks.MaPhieuKhaoSat, k.HoTen AS TenKhach, t.TenTour, pks.LoaiLichTrinh, 
                                  pks.DiemPhuongTien, pks.DiemKhachSan, pks.DiemAnUong, pks.DiemHDV, pks.DiemTongQuan, 
                                  pks.YKienDongGop, pks.NgayKhaoSat 
                           FROM PhieuKhaoSat pks 
                           JOIN KhachHang k ON pks.MaKH = k.MaKH 
                           JOIN TourDuLich t ON pks.MaTour = t.MaTour 
                           ORDER BY pks.NgayKhaoSat DESC";
            return Db.ExecuteQuery(sql);
        }

        public bool ThemPhieuKhaoSat(string maPKS, string maKH, string loaiLichTrinh, string maChuyen, string maPhieu, string maTour, int diemPT, int diemKS, int diemAn, int diemHDV, int diemTong, string yKien)
        {
            string sql = @"INSERT INTO PhieuKhaoSat (MaPhieuKhaoSat, MaKH, LoaiLichTrinh, MaChuyen, MaPhieuDangKy, MaTour, DiemPhuongTien, DiemKhachSan, DiemAnUong, DiemHDV, DiemTongQuan, YKienDongGop, NgayKhaoSat) 
                           VALUES (@Ma, @KH, @Loai, @Chuyen, @Phieu, @Tour, @D1, @D2, @D3, @D4, @D5, @YKien, GETDATE())";
            int r = Db.ExecuteNonQuery(sql,
                new SqlParameter("@Ma", maPKS),
                new SqlParameter("@KH", maKH),
                new SqlParameter("@Loai", loaiLichTrinh),
                new SqlParameter("@Chuyen", (object)maChuyen ?? DBNull.Value),
                new SqlParameter("@Phieu", (object)maPhieu ?? DBNull.Value),
                new SqlParameter("@Tour", maTour),
                new SqlParameter("@D1", diemPT),
                new SqlParameter("@D2", diemKS),
                new SqlParameter("@D3", diemAn),
                new SqlParameter("@D4", diemHDV),
                new SqlParameter("@D5", diemTong),
                new SqlParameter("@YKien", (object)yKien ?? DBNull.Value));
            return r > 0;
        }
    }
}
