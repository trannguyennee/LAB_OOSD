using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class KhenThuongKyLuatService
    {
        public DataTable GetAllQuyetDinhKhenThuong()
        {
            string sql = @"
                SELECT qd.SoQuyetDinhKT, qd.NgayQuyetDinh, qd.LoaiKhenThuong, qd.MaDoiTuong,
                       CASE WHEN qd.LoaiKhenThuong = N'Cá nhân' THEN nv.HoTen ELSE pb.TenPhongBan END AS TenDoiTuong,
                       qd.LyDoKhenThuong, qd.SoTienThuong, qd.HinhThucChi, qd.TrangThaiChi, qd.NguoiKy
                FROM QuyetDinhKhenThuong qd
                LEFT JOIN NhanVien nv ON qd.MaDoiTuong = nv.MaNhanVien
                LEFT JOIN PhongBan pb ON qd.MaDoiTuong = pb.MaPhongBan
                ORDER BY qd.NgayQuyetDinh DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetAllPhieuChiKhenThuong()
        {
            string sql = @"
                SELECT pc.SoPhieuChi, pc.SoQuyetDinhKT, pc.NgayChi, pc.SoTienChi, pc.NguoiNhan, pc.NguoiChiTien, pc.GhiChu
                FROM PhieuChiKhenThuong pc
                ORDER BY pc.NgayChi DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetAllQuyetDinhKyLuat()
        {
            string sql = @"
                SELECT qd.SoQuyetDinhKL, qd.NgayQuyetDinh, qd.LoaiKyLuat, qd.MaDoiTuong,
                       CASE WHEN qd.LoaiKyLuat = N'Cá nhân' THEN nv.HoTen ELSE pb.TenPhongBan END AS TenDoiTuong,
                       qd.LyDoKyLuat, qd.HinhThucPhat, qd.SoTienPhat, qd.TrangThaiThu, qd.NguoiKy
                FROM QuyetDinhKyLuat qd
                LEFT JOIN NhanVien nv ON qd.MaDoiTuong = nv.MaNhanVien
                LEFT JOIN PhongBan pb ON qd.MaDoiTuong = pb.MaPhongBan
                ORDER BY qd.NgayQuyetDinh DESC";
            return Db.ExecuteQuery(sql);
        }

        public bool LapQuyetDinhKhenThuong(string soQD, string loaiKT, string maDoiTuong, string lyDo, decimal soTien, string hinhThucChi, string nguoiKy)
        {
            SqlParameter[] p = {
                new SqlParameter("@SoQuyetDinhKT", soQD),
                new SqlParameter("@LoaiKhenThuong", loaiKT),
                new SqlParameter("@MaDoiTuong", maDoiTuong),
                new SqlParameter("@LyDoKhenThuong", lyDo),
                new SqlParameter("@SoTienThuong", soTien),
                new SqlParameter("@HinhThucChi", hinhThucChi),
                new SqlParameter("@NguoiKy", nguoiKy)
            };
            DataTable dt = Db.ExecuteProcedure("sp_LapQuyetDinhKhenThuong", p);
            return dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["Status"]) == 1;
        }

        public bool LapQuyetDinhKyLuat(string soQD, string loaiKL, string maDoiTuong, string lyDo, string hinhThucPhat, decimal soTienPhat, string nguoiKy)
        {
            string sql = @"
                INSERT INTO QuyetDinhKyLuat (SoQuyetDinhKL, NgayQuyetDinh, LoaiKyLuat, MaDoiTuong, LyDoKyLuat, HinhThucPhat, SoTienPhat, TrangThaiThu, NguoiKy)
                VALUES (@SoQD, GETDATE(), @LoaiKL, @MaDoiTuong, @LyDo, @HinhThucPhat, @SoTien, 
                        CASE WHEN @HinhThucPhat = N'Thu tiền nộp phạt' THEN N'Đã thu' ELSE N'Chờ trừ lương' END, @NguoiKy)";
            SqlParameter[] p = {
                new SqlParameter("@SoQD", soQD),
                new SqlParameter("@LoaiKL", loaiKL),
                new SqlParameter("@MaDoiTuong", maDoiTuong),
                new SqlParameter("@LyDo", lyDo),
                new SqlParameter("@HinhThucPhat", hinhThucPhat),
                new SqlParameter("@SoTien", soTienPhat),
                new SqlParameter("@NguoiKy", nguoiKy)
            };
            return Db.ExecuteNonQuery(sql, p) > 0;
        }
    }
}
