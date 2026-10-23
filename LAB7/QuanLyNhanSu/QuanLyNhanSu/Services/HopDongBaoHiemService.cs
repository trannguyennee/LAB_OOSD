using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class HopDongBaoHiemService
    {
        public DataTable GetAllHopDong()
        {
            string sql = @"
                SELECT hd.SoHopDong, nv.MaNhanVien, nv.HoTen, pb.TenPhongBan, hd.LoaiHopDong, 
                       hd.NgayBatDau, hd.NgayKetThuc, hd.LuongThoaThuan, hd.CoBaoHiem, hd.TrangThai
                FROM HopDongLaoDong hd
                JOIN NhanVien nv ON hd.MaNhanVien = nv.MaNhanVien
                JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                ORDER BY hd.NgayBatDau DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetAllBaoHiem()
        {
            string sql = @"
                SELECT bh.MaHoSoBH, nv.MaNhanVien, nv.HoTen, bh.SoTheBHYT, bh.MaSoBHXH, 
                       bh.NgayThamGia, bh.MucDongBHXH, bh.TyLeDongNV, bh.TrangThai
                FROM HoSoBaoHiem bh
                JOIN NhanVien nv ON bh.MaNhanVien = nv.MaNhanVien
                ORDER BY bh.NgayThamGia DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetAllQuyetDinhLuong()
        {
            string sql = @"
                SELECT qdl.SoQuyetDinhL, nv.MaNhanVien, nv.HoTen, pb.TenPhongBan, qdl.LuongCoBan, 
                       qdl.PhuCapLuong, qdl.PhuCapDocHai, qdl.NgayHieuLuc, qdl.NguoiKy
                FROM QuyetDinhLuong qdl
                JOIN NhanVien nv ON qdl.MaNhanVien = nv.MaNhanVien
                JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                ORDER BY qdl.NgayHieuLuc DESC";
            return Db.ExecuteQuery(sql);
        }

        public bool InsertHopDong(string soHD, string maNV, string loaiHD, DateTime ngayBD, DateTime? ngayKT, decimal luong, bool coBH)
        {
            string sql = @"
                INSERT INTO HopDongLaoDong (SoHopDong, MaNhanVien, LoaiHopDong, NgayBatDau, NgayKetThuc, LuongThoaThuan, CoBaoHiem, TrangThai, NguoiKy)
                VALUES (@SoHD, @MaNV, @LoaiHD, @NgayBD, @NgayKT, @Luong, @CoBH, N'Hiệu lực', N'Giám đốc');
                UPDATE NhanVien SET TrangThai = N'Chính thức' WHERE MaNhanVien = @MaNV;";
            SqlParameter[] p = {
                new SqlParameter("@SoHD", soHD),
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@LoaiHD", loaiHD),
                new SqlParameter("@NgayBD", ngayBD),
                new SqlParameter("@NgayKT", (object)ngayKT ?? DBNull.Value),
                new SqlParameter("@Luong", luong),
                new SqlParameter("@CoBH", coBH)
            };
            return Db.ExecuteNonQuery(sql, p) > 0;
        }

        public bool InsertHoSoBaoHiem(string maBH, string maNV, string soBHYT, string soBHXH, decimal mucDong)
        {
            string sql = @"
                INSERT INTO HoSoBaoHiem (MaHoSoBH, MaNhanVien, SoTheBHYT, MaSoBHXH, NgayThamGia, MucDongBHXH, TyLeDongNV, TrangThai)
                VALUES (@MaBH, @MaNV, @SoBHYT, @SoBHXH, GETDATE(), @MucDong, 10.5, N'Đang tham gia')";
            SqlParameter[] p = {
                new SqlParameter("@MaBH", maBH),
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@SoBHYT", soBHYT),
                new SqlParameter("@SoBHXH", soBHXH),
                new SqlParameter("@MucDong", mucDong)
            };
            return Db.ExecuteNonQuery(sql, p) > 0;
        }

        public bool InsertQuyetDinhLuong(string soQDL, string maNV, decimal luongCB, decimal phuCapDocHai)
        {
            string sql = @"
                INSERT INTO QuyetDinhLuong (SoQuyetDinhL, MaNhanVien, LuongCoBan, PhuCapLuong, PhuCapDocHai, NgayHieuLuc, NguoiKy)
                VALUES (@SoQDL, @MaNV, @LuongCB, 0, @DocHai, GETDATE(), N'Giám đốc')";
            SqlParameter[] p = {
                new SqlParameter("@SoQDL", soQDL),
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@LuongCB", luongCB),
                new SqlParameter("@DocHai", phuCapDocHai)
            };
            return Db.ExecuteNonQuery(sql, p) > 0;
        }
    }
}
