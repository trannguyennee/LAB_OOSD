using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNGK.Data;

namespace QuanLyCuaHangNGK.Services
{
    public class ChiTietNhapDto
    {
        public string MaNGK { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }

    public class DonDatHangService
    {
        public DataTable GetAllDDH()
        {
            string sql = @"SELECT d.SoDDH, d.NgayDat, d.NgayNhan, d.TongSoLuongDat, 
                                  d.SoDotDaGiao, d.TrangThai, d.MaNCU, c.TenNCU, d.MaNV, nv.HoTen AS TenNV
                           FROM DonDatHang d
                           INNER JOIN NhaCungUng c ON d.MaNCU = c.MaNCU
                           INNER JOIN NhanVien nv ON d.MaNV = nv.MaNV
                           ORDER BY d.NgayDat DESC";
            return Db.ExecuteQuery(sql);
        }

        public DataTable GetChiTietDDH(string soDDH)
        {
            string sql = @"SELECT ct.SoDDH, ct.MaNGK, n.TenNGK, n.DonViTinh, ct.SoLuongDat, ct.DonGiaNhap,
                                  (ct.SoLuongDat * ct.DonGiaNhap) AS ThanhTien
                           FROM ChiTietDDH ct
                           INNER JOIN NuocGiaiKhat n ON ct.MaNGK = n.MaNGK
                           WHERE ct.SoDDH = @SoDDH";
            return Db.ExecuteQuery(sql, new SqlParameter("@SoDDH", soDDH));
        }

        public DataTable GetPhieuGiaoHangByDDH(string soDDH)
        {
            string sql = @"SELECT p.SoPGH, p.NgayGiao, p.SoTienPhaiTra, p.DotGiao, p.SoDDH, nv.HoTen AS NguoiNhan
                           FROM PhieuGiaoHang p
                           INNER JOIN NhanVien nv ON p.MaNV = nv.MaNV
                           WHERE p.SoDDH = @SoDDH
                           ORDER BY p.DotGiao ASC";
            return Db.ExecuteQuery(sql, new SqlParameter("@SoDDH", soDDH));
        }

        public void TaoDonDatHang(string soDDH, DateTime ngayNhan, string maNCU, string maNV, List<ChiTietNhapDto> chiTietList)
        {
            int tongSL = 0;
            foreach (var item in chiTietList) tongSL += item.SoLuong;

            string sqlDDH = @"INSERT INTO DonDatHang (SoDDH, NgayDat, NgayNhan, TongSoLuongDat, SoDotDaGiao, TrangThai, MaNCU, MaNV)
                             VALUES (@SoDDH, GETDATE(), @NgayNhan, @TongSL, 0, N'Đang xử lý', @MaNCU, @MaNV)";
            Db.ExecuteNonQuery(sqlDDH,
                new SqlParameter("@SoDDH", soDDH),
                new SqlParameter("@NgayNhan", ngayNhan),
                new SqlParameter("@TongSL", tongSL),
                new SqlParameter("@MaNCU", maNCU),
                new SqlParameter("@MaNV", maNV));

            foreach (var item in chiTietList)
            {
                string sqlCT = @"INSERT INTO ChiTietDDH (SoDDH, MaNGK, SoLuongDat, DonGiaNhap)
                                 VALUES (@SoDDH, @MaNGK, @SL, @Gia)";
                Db.ExecuteNonQuery(sqlCT,
                    new SqlParameter("@SoDDH", soDDH),
                    new SqlParameter("@MaNGK", item.MaNGK),
                    new SqlParameter("@SL", item.SoLuong),
                    new SqlParameter("@Gia", item.DonGia));
            }
        }

        // Quy tắc nghiệp vụ bắt buộc: Mỗi ĐĐH giao tối đa 3 đợt
        public void TiepNhanPhieuGiaoHang(string soPGH, string soDDH, string maNV, decimal soTien, List<ChiTietNhapDto> chiTietGiao)
        {
            // Kiểm tra số đợt giao hiện tại
            string checkSql = "SELECT SoDotDaGiao FROM DonDatHang WHERE SoDDH = @SoDDH";
            object res = Db.ExecuteScalar(checkSql, new SqlParameter("@SoDDH", soDDH));
            if (res == null) throw new Exception("Không tìm thấy Đơn đặt hàng " + soDDH);

            int soDotHienTai = Convert.ToInt32(res);
            if (soDotHienTai >= 3)
            {
                throw new Exception("QUY TẮC NGHIỆP VỤ: Đơn đặt hàng này đã giao tối đa 3 đợt! Hệ thống chặn không cho phép lập thêm phiếu giao hàng.");
            }

            int dotGiaoMoi = soDotHienTai + 1;

            // 1. Lưu Phiếu giao hàng
            string sqlPGH = @"INSERT INTO PhieuGiaoHang (SoPGH, NgayGiao, SoTienPhaiTra, DotGiao, SoDDH, MaNV)
                             VALUES (@SoPGH, GETDATE(), @Tien, @DotGiao, @SoDDH, @MaNV)";
            Db.ExecuteNonQuery(sqlPGH,
                new SqlParameter("@SoPGH", soPGH),
                new SqlParameter("@Tien", soTien),
                new SqlParameter("@DotGiao", dotGiaoMoi),
                new SqlParameter("@SoDDH", soDDH),
                new SqlParameter("@MaNV", maNV));

            // 2. Lưu Chi tiết PGH và Tăng tồn kho
            foreach (var item in chiTietGiao)
            {
                string sqlCT = @"INSERT INTO ChiTietPGH (SoPGH, MaNGK, SoLuongGiao, DonGia)
                                 VALUES (@SoPGH, @MaNGK, @SL, @Gia)";
                Db.ExecuteNonQuery(sqlCT,
                    new SqlParameter("@SoPGH", soPGH),
                    new SqlParameter("@MaNGK", item.MaNGK),
                    new SqlParameter("@SL", item.SoLuong),
                    new SqlParameter("@Gia", item.DonGia));

                // Tăng tồn kho
                string sqlKho = "UPDATE NuocGiaiKhat SET SoLuongTon = SoLuongTon + @SL WHERE MaNGK = @MaNGK";
                Db.ExecuteNonQuery(sqlKho,
                    new SqlParameter("@SL", item.SoLuong),
                    new SqlParameter("@MaNGK", item.MaNGK));
            }

            // 3. Cập nhật số đợt đã giao trong ĐĐH
            string sqlUpDDH = @"UPDATE DonDatHang 
                                SET SoDotDaGiao = @DotGiao,
                                    TrangThai = CASE WHEN @DotGiao >= 3 THEN N'Đã hoàn tất (3 đợt)' ELSE N'Đã giao đợt ' + CAST(@DotGiao AS NVARCHAR) END
                                WHERE SoDDH = @SoDDH";
            Db.ExecuteNonQuery(sqlUpDDH,
                new SqlParameter("@DotGiao", dotGiaoMoi),
                new SqlParameter("@SoDDH", soDDH));
        }
    }
}
