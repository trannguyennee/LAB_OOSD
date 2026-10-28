using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class ChiTietBanDto
    {
        public string MaNGK { get; set; }
        public string TenNGK { get; set; }
        public int SoLuongMua { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongGiaoNgay { get; set; }
        public int SoLuongHenGiao { get; set; }
    }

    public class PhieuHenDto
    {
        public string SoPH { get; set; }
        public DateTime NgayHenGiao { get; set; }
        public int DotGiaoHen { get; set; }
        public int SoLuongHen { get; set; }
        public string MaNGK { get; set; }
    }

    public class PhieuGhiNoDto
    {
        public string SoPGN { get; set; }
        public decimal SoTienNo { get; set; }
        public DateTime NgayDuKienTra { get; set; }
        public string LyDoNo { get; set; }
    }

    public class HoaDonService
    {
        public DataTable GetAllHoaDon()
        {
            string sql = @"SELECT h.SoHD, h.NgayLap, h.TongTien, h.HinhThucThanhToan, 
                                  h.DaThanhToan, h.MaKH, k.TenKH, k.LoaiKH, h.MaNV, nv.HoTen AS TenNV
                           FROM HoaDon h
                           INNER JOIN KhachHang k ON h.MaKH = k.MaKH
                           INNER JOIN NhanVien nv ON h.MaNV = nv.MaNV
                           ORDER BY h.NgayLap DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetChiTietHoaDon(string soHD)
        {
            string sql = @"SELECT ct.SoHD, ct.MaNGK, n.TenNGK, n.DonViTinh, ct.SoLuong, ct.DonGia, ct.ThanhTien
                           FROM ChiTietHoaDon ct
                           INNER JOIN NuocGiaiKhat n ON ct.MaNGK = n.MaNGK
                           WHERE ct.SoHD = @SoHD";
            return Db.ExecuteQuery(sql, new SqlParameter("@SoHD", soHD));
        }

        public DataTable GetKhachHangList()
        {
            string sql = "SELECT MaKH, TenKH, LoaiKH, SoDT, TongNo FROM KhachHang ORDER BY TenKH";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetNhanVienList()
        {
            string sql = "SELECT MaNV, HoTen, ChucVu FROM NhanVien ORDER BY HoTen";
            return Db.ExecuteQuery(sql);
        }

        // Xử lý logic lập hóa đơn theo đúng đặc tả và ràng buộc nghiệp vụ
        public void LapHoaDon(string soHD, string maKH, string maNV, string hinhThucTT, bool daThanhToan,
                              decimal tongTien, List<ChiTietBanDto> chiTietList,
                              List<PhieuHenDto> phieuHenList, PhieuGhiNoDto phieuGhiNo)
        {
            // 1. Kiểm tra loại khách hàng
            string sqlKH = "SELECT LoaiKH FROM KhachHang WHERE MaKH = @MaKH";
            object resKH = Db.ExecuteScalar(sqlKH, new SqlParameter("@MaKH", maKH));
            if (resKH == null) throw new Exception("Không tìm thấy thông tin khách hàng!");
            string loaiKH = resKH.ToString();

            // 2. Ràng buộc nghiệp vụ đối với THIẾU HÀNG:
            // Khách vãng lai: Nếu thiếu hàng thì không được hẹn đợt, từ chối
            bool coThieuHang = false;
            foreach (var item in chiTietList)
            {
                if (item.SoLuongHenGiao > 0)
                {
                    coThieuHang = true;
                    break;
                }
            }

            if (coThieuHang && loaiKH == "KhachVangLai")
            {
                throw new Exception("QUY TẮC NGHIỆP VỤ: Khách vãng lai không được phép hẹn giao hàng nhiều đợt khi kho không đủ hàng! Cửa hàng chỉ bán và giao ngay số lượng sẵn có trong kho.");
            }

            // 3. Ràng buộc nghiệp vụ đối với TRẢ CHẬM / GHI NỢ:
            // Khách vãng lai: Phải thanh toán ngay 100%, không cho phép ghi nợ
            if ((!daThanhToan || phieuGhiNo != null) && loaiKH == "KhachVangLai")
            {
                throw new Exception("QUY TẮC NGHIỆP VỤ: Khách vãng lai bắt buộc thanh toán 100% tại quầy! Không áp dụng chính sách ghi nợ.");
            }

            // 4. Lưu Hóa đơn
            string sqlHD = @"INSERT INTO HoaDon (SoHD, NgayLap, TongTien, HinhThucThanhToan, DaThanhToan, MaKH, MaNV)
                            VALUES (@SoHD, GETDATE(), @TongTien, @HTTT, @DaTT, @MaKH, @MaNV)";
            Db.ExecuteNonQuery(sqlHD,
                new SqlParameter("@SoHD", soHD),
                new SqlParameter("@TongTien", tongTien),
                new SqlParameter("@HTTT", hinhThucTT),
                new SqlParameter("@DaTT", daThanhToan),
                new SqlParameter("@MaKH", maKH),
                new SqlParameter("@MaNV", maNV));

            // 5. Lưu Chi tiết hóa đơn và Trừ kho đối với hàng giao ngay
            foreach (var item in chiTietList)
            {
                string sqlCT = @"INSERT INTO ChiTietHoaDon (SoHD, MaNGK, SoLuong, DonGia)
                                 VALUES (@SoHD, @MaNGK, @SL, @Gia)";
                Db.ExecuteNonQuery(sqlCT,
                    new SqlParameter("@SoHD", soHD),
                    new SqlParameter("@MaNGK", item.MaNGK),
                    new SqlParameter("@SL", item.SoLuongMua),
                    new SqlParameter("@Gia", item.DonGia));

                if (item.SoLuongGiaoNgay > 0)
                {
                    string sqlKho = "UPDATE NuocGiaiKhat SET SoLuongTon = SoLuongTon - @SL WHERE MaNGK = @MaNGK";
                    Db.ExecuteNonQuery(sqlKho,
                        new SqlParameter("@SL", item.SoLuongGiaoNgay),
                        new SqlParameter("@MaNGK", item.MaNGK));
                }
            }

            // 6. Lưu các Phiếu hẹn (nếu là Khách quen có thiếu hàng)
            if (phieuHenList != null && phieuHenList.Count > 0 && loaiKH == "KhachQuen")
            {
                foreach (var ph in phieuHenList)
                {
                    string sqlPH = @"INSERT INTO PhieuHen (SoPH, NgayHenGiao, DotGiaoHen, SoLuongHen, TrangThai, SoHD, MaNGK)
                                     VALUES (@SoPH, @NgayHen, @Dot, @SL, N'Chờ giao', @SoHD, @MaNGK)";
                    Db.ExecuteNonQuery(sqlPH,
                        new SqlParameter("@SoPH", ph.SoPH),
                        new SqlParameter("@NgayHen", ph.NgayHenGiao),
                        new SqlParameter("@Dot", ph.DotGiaoHen),
                        new SqlParameter("@SL", ph.SoLuongHen),
                        new SqlParameter("@SoHD", soHD),
                        new SqlParameter("@MaNGK", ph.MaNGK));
                }
            }

            // 7. Lưu Phiếu ghi nợ và Cập nhật tổng nợ (nếu là Khách quen ghi nợ)
            if (phieuGhiNo != null && loaiKH == "KhachQuen")
            {
                string sqlPGN = @"INSERT INTO PhieuGhiNo (SoPGN, NgayLap, SoTienNo, NgayDuKienTra, LyDoNo, DaTra, SoHD, MaKH, MaNV)
                                  VALUES (@SoPGN, GETDATE(), @TienNo, @NgayTra, @LyDo, 0, @SoHD, @MaKH, @MaNV)";
                Db.ExecuteNonQuery(sqlPGN,
                    new SqlParameter("@SoPGN", phieuGhiNo.SoPGN),
                    new SqlParameter("@TienNo", phieuGhiNo.SoTienNo),
                    new SqlParameter("@NgayTra", phieuGhiNo.NgayDuKienTra),
                    new SqlParameter("@LyDo", phieuGhiNo.LyDoNo),
                    new SqlParameter("@SoHD", soHD),
                    new SqlParameter("@MaKH", maKH),
                    new SqlParameter("@MaNV", maNV));

                // Tăng tổng nợ khách hàng
                string sqlUpKH = "UPDATE KhachHang SET TongNo = TongNo + @TienNo WHERE MaKH = @MaKH";
                Db.ExecuteNonQuery(sqlUpKH,
                    new SqlParameter("@TienNo", phieuGhiNo.SoTienNo),
                    new SqlParameter("@MaKH", maKH));
            }
        }
    }
}
