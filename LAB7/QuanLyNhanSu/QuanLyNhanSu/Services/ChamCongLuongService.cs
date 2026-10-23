using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Services
{
    public class ChamCongLuongService
    {
        public DataTable GetBangChamCong(string thangNam)
        {
            string sql = @"
                SELECT cc.MaChamCong, cc.ThangNam, nv.MaNhanVien, nv.HoTen, pb.TenPhongBan, 
                       cc.SoNgayCongChuan, cc.SoNgayLamThucTe, cc.SoNgayNghiCoPhep, cc.SoNgayNghiKhongPhep, 
                       cc.TongGioPhuTroi, cc.TrangThai
                FROM BangChamCong cc
                JOIN NhanVien nv ON cc.MaNhanVien = nv.MaNhanVien
                JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                WHERE cc.ThangNam = @ThangNam
                ORDER BY nv.MaNhanVien";
            SqlParameter[] p = { new SqlParameter("@ThangNam", thangNam) };
            return Db.ExecuteQuery(sql, p);
        }

        public DataTable GetBangLuongThang(string thangNam)
        {
            string sql = @"
                SELECT bl.MaBangLuong, bl.ThangNam, nv.MaNhanVien, nv.HoTen, pb.TenPhongBan, cv.TenChucVu,
                       bl.LuongCoBan, bl.LuongThucTeTheoCong, bl.PhuCapChucVu, bl.PhuCapDocHai,
                       bl.TienPhuTroi, bl.TienKhenThuong, bl.TienPhatKyLuat, bl.TienBaoHiem, bl.ThucLinh, bl.NgayLap, bl.TrangThai
                FROM BangLuongThang bl
                JOIN NhanVien nv ON bl.MaNhanVien = nv.MaNhanVien
                JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
                JOIN ChucVu cv ON nv.MaChucVu = cv.MaChucVu
                WHERE bl.ThangNam = @ThangNam
                ORDER BY nv.MaNhanVien";
            SqlParameter[] p = { new SqlParameter("@ThangNam", thangNam) };
            return Db.ExecuteQuery(sql, p);
        }

        public bool TinhLuongNhanVien(string thangNam, string maNV)
        {
            SqlParameter[] p = {
                new SqlParameter("@ThangNam", thangNam),
                new SqlParameter("@MaNhanVien", maNV)
            };
            DataTable dt = Db.ExecuteProcedure("sp_TinhBangLuongThang", p);
            return dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["Status"]) == 1;
        }

        public void TinhLuongToanCongTy(string thangNam)
        {
            DataTable dtNV = Db.ExecuteQuery("SELECT MaNhanVien FROM NhanVien WHERE TrangThai <> N'Đã nghỉ việc'");
            foreach (DataRow row in dtNV.Rows)
            {
                string maNV = row["MaNhanVien"].ToString();
                TinhLuongNhanVien(thangNam, maNV);
            }
        }
    }
}
