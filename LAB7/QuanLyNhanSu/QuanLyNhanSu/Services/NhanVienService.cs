using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class NhanVienService
    {
        public DataTable GetAllNhanVien()
        {
            string sql = @"
                SELECT nv.MaNhanVien, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.CCCD, nv.DienThoai, nv.Email,
                       pb.TenPhongBan, cv.TenChucVu, nv.NgayVaoLam, nv.TrangThai, nv.MaPhongBan, nv.MaChucVu
                FROM NhanVien nv
                JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                JOIN ChucVu cv ON nv.MaChucVu = cv.MaChucVu
                ORDER BY nv.MaNhanVien";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetAllPhongBan()
        {
            return Db.ExecuteQuery("SELECT MaPhongBan, TenPhongBan FROM PhongBan ORDER BY TenPhongBan");
        }

        public DataTable GetAllChucVu()
        {
            return Db.ExecuteQuery("SELECT MaChucVu, TenChucVu, PhuCapChucVu FROM ChucVu ORDER BY MaChucVu");
        }

        public bool InsertNhanVien(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string cccd, 
                                  string sdt, string email, string diaChi, string maPB, string maCV, string trangThai)
        {
            string sql = @"
                INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, CCCD, DienThoai, Email, DiaChi, NgayVaoLam, MaPhongBan, MaChucVu, TrangThai)
                VALUES (@MaNV, @HoTen, @NgaySinh, @GioiTinh, @CCCD, @DienThoai, @Email, @DiaChi, GETDATE(), @MaPB, @MaCV, @TrangThai)";
            SqlParameter[] p = {
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@CCCD", cccd),
                new SqlParameter("@DienThoai", sdt),
                new SqlParameter("@Email", email),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@MaPB", maPB),
                new SqlParameter("@MaCV", maCV),
                new SqlParameter("@TrangThai", trangThai)
            };
            return Db.ExecuteNonQuery(sql, p) > 0;
        }

        public bool UpdateNhanVien(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string cccd, 
                                  string sdt, string email, string diaChi, string maPB, string maCV, string trangThai)
        {
            string sql = @"
                UPDATE NhanVien 
                SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, CCCD = @CCCD,
                    DienThoai = @DienThoai, Email = @Email, DiaChi = @DiaChi, 
                    MaPhongBan = @MaPB, MaChucVu = @MaCV, TrangThai = @TrangThai
                WHERE MaNhanVien = @MaNV";
            SqlParameter[] p = {
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@CCCD", cccd),
                new SqlParameter("@DienThoai", sdt),
                new SqlParameter("@Email", email),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@MaPB", maPB),
                new SqlParameter("@MaCV", maCV),
                new SqlParameter("@TrangThai", trangThai)
            };
            return Db.ExecuteNonQuery(sql, p) > 0;
        }

        public bool DeleteNhanVien(string maNV)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNV";
            SqlParameter[] p = { new SqlParameter("@MaNV", maNV) };
            return Db.ExecuteNonQuery(sql, p) > 0;
        }

        public DataTable GetQuyetDinhTuyenDung(string maNV)
        {
            string sql = "SELECT * FROM QuyetDinhTuyenDung WHERE MaNhanVien = @MaNV ORDER BY NgayQuyetDinh DESC";
            SqlParameter[] p = { new SqlParameter("@MaNV", maNV) };
            return Db.ExecuteQuery(sql, p);
        }

        public bool InsertQuyetDinhTuyenDung(string soQD, string maNV, int thoiGianThuViec, decimal luongThuViec, string dieuKhoan)
        {
            string sql = @"
                INSERT INTO QuyetDinhTuyenDung (SoQuyetDinhTD, MaNhanVien, NgayQuyetDinh, ThoiGianThuViec, LuongThuViec, DieuKhoanThoaThuan, TrangThaiDuyet, NguoiKy)
                VALUES (@SoQD, @MaNV, GETDATE(), @ThoiGian, @Luong, @DieuKhoan, N'Đã duyệt', N'Giám đốc')";
            SqlParameter[] p = {
                new SqlParameter("@SoQD", soQD),
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@ThoiGian", thoiGianThuViec),
                new SqlParameter("@Luong", luongThuViec),
                new SqlParameter("@DieuKhoan", dieuKhoan)
            };
            return Db.ExecuteNonQuery(sql, p) > 0;
        }
    }
}
