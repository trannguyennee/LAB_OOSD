using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class ThanhToanService
    {
        // 1. Lấy danh sách phiếu khám đang chờ thanh toán
        public DataTable LayPhieuKhamChoThanhToan()
        {
            string sql = @"
                SELECT 
                    pk.MaPhieuKham,
                    hs.MaHoSo,
                    bn.HoTen,
                    bn.SoCCCD,
                    pk.NgayGioKham,
                    pk.ChanDoanCuoiCung,
                    pk.TrangThaiKham
                FROM PHIEU_KHAM_BENH pk
                JOIN HO_SO_BENH_AN hs ON pk.MaHoSo = hs.MaHoSo
                JOIN BENH_NHAN bn ON hs.MaBenhNhan = bn.MaBenhNhan
                WHERE pk.TrangThaiKham <> N'Đã hoàn tất'
                ORDER BY pk.NgayGioKham DESC";

            return Db.Query(sql);
        }

        // 2. Tính toán chi tiết viện phí (Kiểm tra miễn giảm định kỳ quý - Quy tắc #3 & #5)
        public DataTable TinhChiTietVienPhi(string maPhieuKham, out decimal tienKham, out decimal tienXN, out decimal tienThuoc, out decimal mienGiam, out decimal tongTien)
        {
            tienKham = 150000;
            tienXN = 0;
            tienThuoc = 0;
            mienGiam = 0;
            tongTien = 0;

            // Kiểm tra miễn phí khám định kỳ
            string sqlCheckMienPhi = @"
                SELECT COUNT(*) 
                FROM LICH_KHAM_DINH_KY lk
                JOIN HO_SO_BENH_AN hs ON lk.MaHoSo = hs.MaHoSo
                JOIN PHIEU_KHAM_BENH pk ON hs.MaHoSo = pk.MaHoSo
                WHERE pk.MaPhieuKham = @MaPK AND lk.MienPhiTienKham = 1 AND lk.TrangThaiLich = N'Đã đặt lịch'";
            int countMienPhi = Convert.ToInt32(Db.Scalar(sqlCheckMienPhi, new SqlParameter("@MaPK", maPhieuKham)));
            if (countMienPhi > 0)
                mienGiam = tienKham; // Miễn 100% tiền khám

            // Tiền xét nghiệm
            string sqlXN = @"
                SELECT ISNULL(SUM(kq.DonGia), 0)
                FROM KET_QUA_XET_NGHIEM kq
                JOIN CHI_DINH_XET_NGHIEM cd ON kq.MaChiDinh = cd.MaChiDinh
                WHERE cd.MaPhieuKham = @MaPK";
            object objXN = Db.Scalar(sqlXN, new SqlParameter("@MaPK", maPhieuKham));
            tienXN = (objXN != null && objXN != DBNull.Value) ? Convert.ToDecimal(objXN) : 0;

            // Tiền thuốc
            string sqlThuoc = "SELECT ISNULL(TongTienThuoc, 0) FROM TOA_THUOC WHERE MaPhieuKham = @MaPK";
            object objThuoc = Db.Scalar(sqlThuoc, new SqlParameter("@MaPK", maPhieuKham));
            tienThuoc = (objThuoc != null && objThuoc != DBNull.Value) ? Convert.ToDecimal(objThuoc) : 0;

            tongTien = (tienKham + tienXN + tienThuoc) - mienGiam;

            // Chi tiết bảng thuốc + xét nghiệm
            string sqlDetails = @"
                SELECT N'Tiền khám chuyên khoa' AS HangMuc, 1 AS SoLuong, @TienKham AS DonGia, @TienKham AS ThanhTien
                UNION ALL
                SELECT lx.TenXetNghiem, 1, kq.DonGia, kq.DonGia
                FROM KET_QUA_XET_NGHIEM kq
                JOIN CHI_DINH_XET_NGHIEM cd ON kq.MaChiDinh = cd.MaChiDinh
                JOIN LOAI_XET_NGHIEM lx ON kq.MaXetNghiem = lx.MaXetNghiem
                WHERE cd.MaPhieuKham = @MaPK
                UNION ALL
                SELECT t.TenThuoc, ct.SoLuong, ct.DonGiaBan, ct.ThanhTien
                FROM CHI_TIET_TOA_THUOC ct
                JOIN TOA_THUOC tt ON ct.MaToaThuoc = tt.MaToaThuoc
                JOIN THUOC t ON ct.MaThuoc = t.MaThuoc
                WHERE tt.MaPhieuKham = @MaPK";

            return Db.Query(sqlDetails, 
                new SqlParameter("@MaPK", maPhieuKham),
                new SqlParameter("@TienKham", tienKham));
        }

        // 3. Thực hiện thanh toán viện phí, xuất hóa đơn và khóa đóng bệnh án (Transaction SP)
        public string ThanhToanVaDongBenhAn(string maPhieuKham, string maThuNgan, string hinhThucTT, out string outMaHD)
        {
            int countHD = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM HOA_DON_VIEN_PHI"));
            outMaHD = "HD" + (countHD + 1).ToString("D3");

            using (var cn = Db.OpenConnection())
            using (var cmd = new SqlCommand("sp_ThanhToanVienPhiVaDongBenhAn", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHoaDon", outMaHD);
                cmd.Parameters.AddWithValue("@MaPhieuKham", maPhieuKham);
                cmd.Parameters.AddWithValue("@MaThuNgan", maThuNgan);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", hinhThucTT);

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

        // 4. Lấy danh sách hóa đơn đã thu
        public DataTable LayDanhSachHoaDon()
        {
            string sql = @"
                SELECT 
                    hd.MaHoaDon,
                    hd.MaPhieuKham,
                    bn.HoTen,
                    hd.NgayLap,
                    hd.TienKham,
                    hd.TienXetNghiem,
                    hd.TienThuoc,
                    hd.TienMienGiam,
                    hd.TongTienThanhToan,
                    hd.HinhThucThanhToan,
                    hd.TrangThai
                FROM HOA_DON_VIEN_PHI hd
                JOIN PHIEU_KHAM_BENH pk ON hd.MaPhieuKham = pk.MaPhieuKham
                JOIN HO_SO_BENH_AN hs ON pk.MaHoSo = hs.MaHoSo
                JOIN BENH_NHAN bn ON hs.MaBenhNhan = bn.MaBenhNhan
                ORDER BY hd.NgayLap DESC";

            return Db.Query(sql);
        }
    }
}