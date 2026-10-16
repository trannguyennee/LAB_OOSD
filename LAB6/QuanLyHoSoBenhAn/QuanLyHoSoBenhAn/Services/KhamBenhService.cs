using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class KhamBenhService
    {
        // 1. Đặt lịch khám định kỳ theo quý
        public string DatLichDinhKy(string maHoSo, int quy, int nam, DateTime ngayHen, string gioHen, string ghiChu)
        {
            // Kiểm tra hiệu lực phí năm
            string sqlCheckPhi = @"
                SELECT COUNT(*) FROM LE_PHI_NAM 
                WHERE MaHoSo = @MaHoSo AND TrangThai = N'Còn hiệu lực' AND NgayHetHan >= CAST(GETDATE() AS DATE)";
            int phiValid = Convert.ToInt32(Db.Scalar(sqlCheckPhi, new SqlParameter("@MaHoSo", maHoSo)));
            if (phiValid == 0)
                return "Bệnh nhân chưa đóng hoặc đã hết hạn lệ phí thường niên! Vui lòng gia hạn trước.";

            // Kiểm tra trùng lịch quý
            string sqlCheckQuy = @"
                SELECT COUNT(*) FROM LICH_KHAM_DINH_KY 
                WHERE MaHoSo = @MaHoSo AND NamKham = @Nam AND QuyKham = @Quy";
            int countQuy = Convert.ToInt32(Db.Scalar(sqlCheckQuy, 
                new SqlParameter("@MaHoSo", maHoSo),
                new SqlParameter("@Nam", nam),
                new SqlParameter("@Quy", quy)));
            if (countQuy > 0)
                return $"Hồ sơ này đã đăng ký lịch định kỳ cho Quý {quy}/{nam} rồi!";

            // Sinh mã lịch hẹn
            int total = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM LICH_KHAM_DINH_KY"));
            string maLH = "LH" + (total + 1).ToString("D3");

            string sqlInsert = @"
                INSERT INTO LICH_KHAM_DINH_KY (MaLichHen, MaHoSo, QuyKham, NamKham, NgayHen, GioHen, MienPhiTienKham, GhiChu, TrangThaiLich)
                VALUES (@MaLH, @MaHoSo, @Quy, @Nam, @NgayHen, @GioHen, 1, @GhiChu, N'Đã đặt lịch')";

            Db.Execute(sqlInsert,
                new SqlParameter("@MaLH", maLH),
                new SqlParameter("@MaHoSo", maHoSo),
                new SqlParameter("@Quy", quy),
                new SqlParameter("@Nam", nam),
                new SqlParameter("@NgayHen", ngayHen.Date),
                new SqlParameter("@GioHen", gioHen),
                new SqlParameter("@GhiChu", (object)ghiChu ?? DBNull.Value));

            return "Thành công";
        }

        // 2. Lấy danh sách lịch hẹn định kỳ
        public DataTable LayDanhSachLichDinhKy(string maHoSo = null)
        {
            string sql = @"
                SELECT 
                    lh.MaLichHen,
                    lh.MaHoSo,
                    bn.HoTen,
                    lh.QuyKham,
                    lh.NamKham,
                    lh.NgayHen,
                    lh.GioHen,
                    lh.MienPhiTienKham,
                    lh.TrangThaiLich,
                    lh.GhiChu
                FROM LICH_KHAM_DINH_KY lh
                JOIN HO_SO_BENH_AN hs ON lh.MaHoSo = hs.MaHoSo
                JOIN BENH_NHAN bn ON hs.MaBenhNhan = bn.MaBenhNhan";

            if (!string.IsNullOrEmpty(maHoSo))
            {
                sql += " WHERE lh.MaHoSo = @MaHoSo ORDER BY lh.NgayHen DESC";
                return Db.Query(sql, new SqlParameter("@MaHoSo", maHoSo));
            }
            sql += " ORDER BY lh.NgayHen DESC";
            return Db.Query(sql);
        }

        // 3. Khám bệnh, Chỉ định xét nghiệm & Kê toa thuốc
        public string KhamBenhVaKeToa(
            string maPK, string maHS, string maBS, string khoa,
            string trieuChung, decimal thanNhiet, string huyetAp, string chanDoan,
            string maCD, string maXN, string chiSoKQ,
            string maToa, string maThuoc, int soLuongThuoc, string cachDung)
        {
            using (var cn = Db.OpenConnection())
            using (var cmd = new SqlCommand("sp_KhamBenhChiDinhVaKeToa", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuKham", maPK);
                cmd.Parameters.AddWithValue("@MaHoSo", maHS);
                cmd.Parameters.AddWithValue("@MaBacSi", maBS);
                cmd.Parameters.AddWithValue("@KhoaDieuTri", khoa);
                cmd.Parameters.AddWithValue("@TrieuChung", trieuChung);
                cmd.Parameters.AddWithValue("@ThanNhiet", thanNhiet);
                cmd.Parameters.AddWithValue("@HuyetAp", huyetAp);
                cmd.Parameters.AddWithValue("@ChanDoanCuoiCung", chanDoan);

                cmd.Parameters.AddWithValue("@MaChiDinh", (object)maCD ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MaXetNghiem", (object)maXN ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ChiSoKQ", (object)chiSoKQ ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@MaToaThuoc", (object)maToa ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MaThuoc", (object)maThuoc ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SoLuongThuoc", soLuongThuoc > 0 ? (object)soLuongThuoc : DBNull.Value);
                cmd.Parameters.AddWithValue("@CachDung", (object)cachDung ?? DBNull.Value);

                try
                {
                    cmd.ExecuteNonQuery();
                    return "Thành công";
                }
                catch (SqlException ex)
                {
                    return "Lỗi: " + ex.Message;
                }
            }
        }

        // 4. Lịch sử các lần khám của 1 hồ sơ
        public DataTable LayLichSuCacLanKham(string maHoSo)
        {
            string sql = @"
                SELECT 
                    pk.MaPhieuKham,
                    pk.NgayGioKham,
                    nv.HoTen AS BacSiKham,
                    pk.KhoaDieuTri,
                    pk.TrieuChung,
                    pk.ThanNhiet,
                    pk.HuyetAp,
                    pk.ChanDoanCuoiCung,
                    pk.TrangThaiKham,
                    tt.MaToaThuoc,
                    tt.TongTienThuoc,
                    cd.MaChiDinh
                FROM PHIEU_KHAM_BENH pk
                JOIN NHAN_VIEN nv ON pk.MaBacSi = nv.MaNhanVien
                LEFT JOIN TOA_THUOC tt ON pk.MaPhieuKham = tt.MaPhieuKham
                LEFT JOIN CHI_DINH_XET_NGHIEM cd ON pk.MaPhieuKham = cd.MaPhieuKham
                WHERE pk.MaHoSo = @MaHoSo
                ORDER BY pk.NgayGioKham DESC";

            return Db.Query(sql, new SqlParameter("@MaHoSo", maHoSo));
        }

        // 5. Danh mục Bác sĩ, Thuốc, Xét nghiệm
        public DataTable LayDanhSachBacSi()
        {
            return Db.Query("SELECT MaNhanVien, HoTen, ChuyenKhoa FROM NHAN_VIEN WHERE LoaiNhanVien = 'BacSi'");
        }

        public DataTable LayDanhSachThuoc()
        {
            return Db.Query("SELECT MaThuoc, TenThuoc, HoatChat, DonGia, SoLuongTon, DonViTinh FROM THUOC");
        }

        public DataTable LayDanhSachXetNghiem()
        {
            return Db.Query("SELECT MaXetNghiem, TenXetNghiem, DonGia, ChiSoThamChieuBinhThuong FROM LOAI_XET_NGHIEM");
        }

        public string SinhMaPhieuKhamMoi()
        {
            int count = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM PHIEU_KHAM_BENH"));
            return "PK" + (count + 1).ToString("D3");
        }
    }
}