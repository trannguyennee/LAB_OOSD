using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class DanhMucService
    {
        // 1. Các hàm lấy dữ liệu chuẩn hóa 5 cột: Mã | Tên | Loại / Vai trò | Đơn vị | Đơn giá / Mức
        public DataTable LayKhuVuc()
        {
            return Db.Query(@"SELECT MaKhuVuc, 
                                     TenKhuVuc, 
                                     MaKhuVuc AS [Ma], 
                                     TenKhuVuc AS [Ten], 
                                     CAST(NULL AS nvarchar(100)) AS [LoaiVaiTro], 
                                     CAST(NULL AS nvarchar(100)) AS [DonVi], 
                                     CAST(NULL AS decimal(18,2)) AS [DonGiaMuc] 
                              FROM KhuVuc 
                              ORDER BY MaKhuVuc");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query(@"SELECT MaNV, 
                                     HoTen, 
                                     VaiTro, 
                                     SoDienThoai, 
                                     MaNV AS [Ma], 
                                     HoTen AS [Ten], 
                                     VaiTro AS [LoaiVaiTro], 
                                     SoDienThoai AS [DonVi], 
                                     CAST(NULL AS decimal(18,2)) AS [DonGiaMuc] 
                              FROM NhanVien 
                              ORDER BY MaNV");
        }

        public DataTable LayLoaiTienNghi()
        {
            return Db.Query(@"SELECT MaLoaiTN, 
                                     TenLoaiTN, 
                                     MaLoaiTN AS [Ma], 
                                     TenLoaiTN AS [Ten], 
                                     CAST(NULL AS nvarchar(100)) AS [LoaiVaiTro], 
                                     CAST(NULL AS nvarchar(100)) AS [DonVi], 
                                     CAST(NULL AS decimal(18,2)) AS [DonGiaMuc] 
                              FROM LoaiTienNghi 
                              ORDER BY MaLoaiTN");
        }

        public DataTable LayDichVu()
        {
            return Db.Query(@"SELECT MaDV, 
                                     TenDV, 
                                     DonViTinh, 
                                     DonGia, 
                                     MaDV AS [Ma], 
                                     TenDV AS [Ten], 
                                     CAST(NULL AS nvarchar(100)) AS [LoaiVaiTro], 
                                     DonViTinh AS [DonVi], 
                                     DonGia AS [DonGiaMuc] 
                              FROM DichVu 
                              ORDER BY MaDV");
        }

        public DataTable LayQuyDinhDenBu()
        {
            return Db.Query(@"SELECT q.MaQuyDinh, 
                                     q.MaLoaiTN, 
                                     l.TenLoaiTN, 
                                     q.MucDoThietHai, 
                                     q.MucDenBu, 
                                     q.MaQuyDinh AS [Ma], 
                                     l.TenLoaiTN AS [Ten], 
                                     q.MucDoThietHai AS [LoaiVaiTro], 
                                     CAST(NULL AS nvarchar(100)) AS [DonVi], 
                                     q.MucDenBu AS [DonGiaMuc] 
                              FROM QuyDinhDenBu q 
                              JOIN LoaiTienNghi l ON q.MaLoaiTN = l.MaLoaiTN 
                              ORDER BY q.MaQuyDinh");
        }

        // 2. Thêm Khu Vực
        public KetQuaXuLy ThemKhu(string ma, string ten)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return KetQuaXuLy.Fail("Mã khu vực và tên khu vực không được để trống.");

            try
            {
                Db.Execute("INSERT INTO KhuVuc(MaKhuVuc, TenKhuVuc) VALUES(@m, @t)",
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten));
                return KetQuaXuLy.Ok("Đã thêm khu vực thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        // 3. Thêm Nhân Viên
        public KetQuaXuLy ThemNhanVien(string ma, string ten, string vaiTro, string sdt)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(vaiTro))
                return KetQuaXuLy.Fail("Thông tin nhân viên chưa đầy đủ.");

            try
            {
                Db.Execute("INSERT INTO NhanVien(MaNV, HoTen, VaiTro, SoDienThoai) VALUES(@m, @t, @v, @s)",
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten),
                    new SqlParameter("@v", vaiTro),
                    new SqlParameter("@s", (object)sdt ?? DBNull.Value));
                return KetQuaXuLy.Ok("Đã thêm nhân viên thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        // 4. Thêm Loại Tiện Nghi
        public KetQuaXuLy ThemLoaiTN(string ma, string ten)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return KetQuaXuLy.Fail("Thông tin loại tiện nghi chưa đầy đủ.");

            try
            {
                Db.Execute("INSERT INTO LoaiTienNghi(MaLoaiTN, TenLoaiTN) VALUES(@m, @t)",
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten));
                return KetQuaXuLy.Ok("Đã thêm loại tiện nghi thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        // 5. Thêm Dịch Vụ
        public KetQuaXuLy ThemDichVu(string ma, string ten, string dvt, decimal gia)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(dvt) || gia < 0)
                return KetQuaXuLy.Fail("Thông tin dịch vụ không hợp lệ.");

            try
            {
                Db.Execute("INSERT INTO DichVu(MaDV, TenDV, DonViTinh, DonGia) VALUES(@m, @t, @d, @g)",
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten),
                    new SqlParameter("@d", dvt),
                    new SqlParameter("@g", gia));
                return KetQuaXuLy.Ok("Đã thêm dịch vụ thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        // 6. Thêm Quy Định Đền Bù
        public KetQuaXuLy ThemQuyDinh(string ma, string loai, string muc, decimal tien)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(muc) || tien < 0)
                return KetQuaXuLy.Fail("Quy định đền bù không hợp lệ.");

            try
            {
                Db.Execute("INSERT INTO QuyDinhDenBu(MaQuyDinh, MaLoaiTN, MucDoThietHai, MucDenBu) VALUES(@m, @l, @u, @t)",
                    new SqlParameter("@m", ma),
                    new SqlParameter("@l", loai),
                    new SqlParameter("@u", muc),
                    new SqlParameter("@t", tien));
                return KetQuaXuLy.Ok("Đã thêm quy định đền bù thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }
    }
}