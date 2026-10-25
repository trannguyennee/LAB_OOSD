using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;

namespace QuanLyDuLich.Services
{
    public class DieuHanhHDVService
    {
        public DataTable GetAllHDV()
        {
            string sql = @"SELECT h.MaNV, nv.HoTen, nv.SoDienThoai, nv.Email, h.NgoaiNgu, h.KinhNghiemNam, h.LuongCanBan, h.ThuLaoMoiTour, h.TrangThaiLich 
                           FROM HuongDanVien h 
                           JOIN NhanVien nv ON h.MaNV = nv.MaNV 
                           ORDER BY h.MaNV";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetAllPhanCong()
        {
            string sql = @"SELECT pc.MaPhanCong, nv.HoTen AS TenHDV, pc.LoaiTourDung, 
                                  ISNULL(pc.MaChuyen, pc.MaPhieuDangKy) AS MaTourThamGia, 
                                  pc.NgayBatDau, pc.NgayKetThuc, pc.VaiTroHDV, pc.GhiChu 
                           FROM PhanCongHDV pc 
                           JOIN NhanVien nv ON pc.MaNV = nv.MaNV 
                           ORDER BY pc.NgayBatDau DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetChuyenDiList()
        {
            return Db.ExecuteQuery("SELECT MaChuyen, MaTour, NgayKhoiHanh, NgayVe FROM ChuyenDi WHERE TrangThai != N'Huy'");
        }

        public DataTable GetPhieuDoanList()
        {
            return Db.ExecuteQuery("SELECT MaPhieuDangKy, MaTour, NgayKhoiHanh, NgayKetThuc FROM PhieuDangKyDoan");
        }

        public bool PhanCongTour(string maPC, string maNV, string loaiTour, string maChuyen, string maPhieu, DateTime ngayBD, DateTime ngayKT, string vaiTro, string ghiChu)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_KiemTraVaPhanCongHDV", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhanCong", maPC);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@LoaiTourDung", loaiTour);
                    cmd.Parameters.AddWithValue("@MaChuyen", (object)maChuyen ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaPhieuDangKy", (object)maPhieu ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@NgayBatDau", ngayBD);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKT);
                    cmd.Parameters.AddWithValue("@VaiTroHDV", vaiTro);
                    cmd.Parameters.AddWithValue("@GhiChu", (object)ghiChu ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
    }
}
