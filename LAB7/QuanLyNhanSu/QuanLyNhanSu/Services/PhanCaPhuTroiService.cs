using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class PhanCaPhuTroiService
    {
        public DataTable GetKeHoachPhanCa()
        {
            string sql = @"
                SELECT kh.MaKeHoach, kh.TuanThu, kh.TuNgay, kh.DenNgay, pb.TenPhongBan, kh.NguoiLap, kh.NgayLap, kh.GhiChu
                FROM KeHoachPhanCa kh
                JOIN PhongBan pb ON kh.MaPhongBan = pb.MaPhongBan
                ORDER BY kh.TuNgay DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetChiTietPhanCa(string maKH)
        {
            string sql = @"
                SELECT ct.MaChiTietPC, nv.MaNhanVien, nv.HoTen, ct.ThuTrongTuan, ct.CaLamViec, ct.GioBatDau, ct.GioKetThuc, ct.CoPhuTroi
                FROM ChiTietPhanCa ct
                JOIN NhanVien nv ON ct.MaNhanVien = nv.MaNhanVien
                WHERE ct.MaKeHoach = @MaKH
                ORDER BY ct.MaChiTietPC";
            SqlParameter[] p = { new SqlParameter("@MaKH", maKH) };
            return Db.ExecuteQuery(sql, p);
        }

        public DataTable GetPhieuPhuTroi()
        {
            return Db.ExecuteQuery("SELECT * FROM PhieuPhuTroi ORDER BY NgayPhuTroi DESC");
        }

        public DataTable GetChiTietPhuTroi(string soPhieu)
        {
            string sql = @"
                SELECT ct.MaChiTietPT, nv.MaNhanVien, nv.HoTen, pb.TenPhongBan, ct.SoGioPhuTroi, ct.NoiDungCongViec, ct.GhiChu
                FROM ChiTietPhuTroi ct
                JOIN NhanVien nv ON ct.MaNhanVien = nv.MaNhanVien
                JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                WHERE ct.SoPhieuPT = @SoPhieu
                ORDER BY ct.MaChiTietPT";
            SqlParameter[] p = { new SqlParameter("@SoPhieu", soPhieu) };
            return Db.ExecuteQuery(sql, p);
        }

        public bool InsertPhieuPhuTroi(string soPhieu, DateTime ngayPT, string hinhThuc, decimal heSo)
        {
            string sql = @"
                INSERT INTO PhieuPhuTroi (SoPhieuPT, NgayPhuTroi, HinhThucPhuTroi, HeSoPhuTroi, NguoiLap, TrangThaiDuyet)
                VALUES (@SoPhieu, @NgayPT, @HinhThuc, @HeSo, N'Ban chấm công', N'Đã duyệt')";
            SqlParameter[] p = {
                new SqlParameter("@SoPhieu", soPhieu),
                new SqlParameter("@NgayPT", ngayPT),
                new SqlParameter("@HinhThuc", hinhThuc),
                new SqlParameter("@HeSo", heSo)
            };
            return Db.ExecuteNonQuery(sql, p) > 0;
        }

        public bool InsertChiTietPhuTroi(string soPhieu, string maNV, decimal soGio, string noiDung)
        {
            string sql = @"
                INSERT INTO ChiTietPhuTroi (SoPhieuPT, MaNhanVien, SoGioPhuTroi, NoiDungCongViec)
                VALUES (@SoPhieu, @MaNV, @SoGio, @NoiDung)";
            SqlParameter[] p = {
                new SqlParameter("@SoPhieu", soPhieu),
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@SoGio", soGio),
                new SqlParameter("@NoiDung", noiDung)
            };
            return Db.ExecuteNonQuery(sql, p) > 0;
        }
    }
}
