using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class BenhNhanService
    {
        // 1. Đăng ký bệnh nhân lần đầu + Nộp lệ phí năm + Cấp hồ sơ bệnh án (Transaction SP)
        public string DangKyVaCapHoSo(
            string maBN, string hoTen, DateTime ngaySinh, string gioiTinh,
            string diaChi, string soDienThoai, string soCCCD, string hinhAnh,
            string tienSuBenh, string diUngThuoc, decimal soTienPhiNam,
            out string outMaHS, out string outMaPT)
        {
            outMaHS = "";
            outMaPT = "";

            using (var cn = Db.OpenConnection())
            using (var cmd = new SqlCommand("sp_DangKyVaCapHoSoBenhAn", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBN", maBN);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@SoCCCD", soCCCD);
                cmd.Parameters.AddWithValue("@HinhAnh3x4", (object)hinhAnh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TienSuBenh", (object)tienSuBenh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DiUngThuoc", (object)diUngThuoc ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SoTienPhiNam", soTienPhiNam);

                var pMaHS = new SqlParameter("@MaHS", SqlDbType.VarChar, 20) { Direction = ParameterDirection.Output };
                var pMaPT = new SqlParameter("@MaPT", SqlDbType.VarChar, 20) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(pMaHS);
                cmd.Parameters.Add(pMaPT);

                try
                {
                    cmd.ExecuteNonQuery();
                    outMaHS = pMaHS.Value?.ToString();
                    outMaPT = pMaPT.Value?.ToString();
                    return "Thành công";
                }
                catch (SqlException ex)
                {
                    return "Lỗi CSDL: " + ex.Message;
                }
            }
        }

        // 2. Tra cứu lịch sử hồ sơ bệnh án theo từ khóa (Mã HS, CCCD, SĐT hoặc Họ tên)
        public DataTable TraCuuHoSo(string tuKhoa)
        {
            string sql = @"
                SELECT 
                    hs.MaHoSo,
                    bn.MaBenhNhan,
                    bn.HoTen,
                    bn.NgaySinh,
                    bn.GioiTinh,
                    bn.SoCCCD,
                    bn.SoDienThoai,
                    bn.DiaChi,
                    hs.TienSuBenh,
                    hs.DiUngThuoc,
                    hs.NgayCapHoSo,
                    hs.TrangThaiHoSo,
                    lp.NamApDung AS NamPhi,
                    lp.NgayHetHan AS HanPhi,
                    lp.TrangThai AS TrangThaiPhi
                FROM HO_SO_BENH_AN hs
                JOIN BENH_NHAN bn ON hs.MaBenhNhan = bn.MaBenhNhan
                LEFT JOIN LE_PHI_NAM lp ON hs.MaHoSo = lp.MaHoSo
                WHERE 
                    hs.MaHoSo LIKE @kw OR 
                    bn.SoCCCD LIKE @kw OR 
                    bn.SoDienThoai LIKE @kw OR 
                    bn.HoTen LIKE @kw
                ORDER BY hs.NgayCapHoSo DESC";

            return Db.Query(sql, new SqlParameter("@kw", "%" + tuKhoa.Trim() + "%"));
        }

        // 3. Lấy tất cả hồ sơ bệnh án
        public DataTable LayTatCaHoSo()
        {
            string sql = @"
                SELECT 
                    hs.MaHoSo,
                    bn.HoTen,
                    bn.SoCCCD,
                    bn.SoDienThoai,
                    hs.TrangThaiHoSo,
                    hs.NgayCapNhatCuoi
                FROM HO_SO_BENH_AN hs
                JOIN BENH_NHAN bn ON hs.MaBenhNhan = bn.MaBenhNhan
                ORDER BY hs.NgayCapHoSo DESC";
            return Db.Query(sql);
        }

        // 4. Sinh mã bệnh nhân kế tiếp
        public string SinhMaBenhNhanMoi()
        {
            object obj = Db.Scalar("SELECT COUNT(*) FROM BENH_NHAN");
            int count = (obj != null && obj != DBNull.Value) ? Convert.ToInt32(obj) : 0;
            return "BN" + (count + 1).ToString("D3");
        }
    }
}