using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using eShopping.Data;

namespace eShopping.Services
{
    public class ItemGioHang
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien => DonGia * SoLuong;
    }

    public class ThongTinTheTinDung
    {
        public string LoaiThe { get; set; } // "Visa", "MasterCard", "American Express"
        public string TenChuThe { get; set; }
        public string SoThe { get; set; }
        public string NgayHetHan { get; set; } // MM/YY
        public string MaCVV { get; set; }
    }

    public class DonHangService
    {
        // 1. Tính phí giao hàng theo quy tắc nghiệp vụ đề tài
        public decimal TinhPhiGiaoHang(string loaiPhieuGiao, decimal tongTienHang)
        {
            if (string.IsNullOrEmpty(loaiPhieuGiao))
                return 0;

            switch (loaiPhieuGiao.Trim())
            {
                case "Chuyển phát nhanh":
                    // Miễn phí vận chuyển nếu tổng giá trị tiền hàng >= 1.000.000đ
                    return tongTienHang >= 1000000 ? 0 : 50000;

                case "Chuyển phát nhanh trong ngày":
                    // Miễn phí vận chuyển nếu tổng giá trị tiền hàng >= 5.000.000đ
                    return tongTienHang >= 5000000 ? 0 : 100000;

                case "Thường":
                default:
                    return 30000;
            }
        }

        // 2. Xác thực thẻ tín dụng (Thanh toán qua cổng)
        public KetQuaXuLy XacThucTheTinDung(ThongTinTheTinDung the)
        {
            if (the == null)
                return KetQuaXuLy.Loi("Vui lòng nhập thông tin thẻ tín dụng!");

            if (string.IsNullOrWhiteSpace(the.TenChuThe))
                return KetQuaXuLy.Loi("Tên chủ thẻ không được để trống!");

            string soThe = Regex.Replace(the.SoThe ?? "", @"\s+", "");
            if (string.IsNullOrEmpty(soThe) || !Regex.IsMatch(soThe, @"^\d+$"))
                return KetQuaXuLy.Loi("Số thẻ tín dụng chỉ bao gồm các chữ số!");

            string cvv = (the.MaCVV ?? "").Trim();
            if (string.IsNullOrEmpty(cvv) || !Regex.IsMatch(cvv, @"^\d+$"))
                return KetQuaXuLy.Loi("Mã CVV/CVC chỉ bao gồm các chữ số!");

            // Kiểm tra quy tắc từng loại thẻ
            if (the.LoaiThe == "American Express")
            {
                if (soThe.Length != 15)
                    return KetQuaXuLy.Loi("Thẻ American Express phải có đúng 15 chữ số!");
                if (cvv.Length != 4)
                    return KetQuaXuLy.Loi("Mã bảo mật CVV của thẻ American Express phải gồm 4 chữ số!");
            }
            else // Visa hoặc MasterCard
            {
                if (soThe.Length != 16)
                    return KetQuaXuLy.Loi($"Thẻ {the.LoaiThe} phải có đúng 16 chữ số!");
                if (cvv.Length != 3)
                    return KetQuaXuLy.Loi($"Mã bảo mật CVV của thẻ {the.LoaiThe} phải gồm 3 chữ số!");
            }

            // Kiểm tra định dạng ngày hết hạn MM/YY
            if (string.IsNullOrWhiteSpace(the.NgayHetHan) || !Regex.IsMatch(the.NgayHetHan.Trim(), @"^(0[1-9]|1[0-2])\/\d{2}$"))
                return KetQuaXuLy.Loi("Ngày hết hạn thẻ không hợp lệ! Định dạng bắt buộc: MM/YY (ví dụ: 12/28)");

            return KetQuaXuLy.OK("Thẻ tín dụng hợp lệ! Xác thực thành công.");
        }

        // 3. Xử lý tạo và lưu Đơn đặt hàng + Chi tiết đơn hàng
        public KetQuaXuLy TaoVaLuuDonHang(
            string hoTen, string soDienThoai, string email, string diaChiNhan,
            string loaiPhieuGiao, decimal phiShip, decimal tongTien,
            List<ItemGioHang> danhSachHang, ThongTinTheTinDung thongTinThe)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(hoTen))
                return KetQuaXuLy.Loi("Vui lòng nhập họ tên người nhận!");
            if (string.IsNullOrWhiteSpace(soDienThoai))
                return KetQuaXuLy.Loi("Vui lòng nhập số điện thoại người nhận!");
            if (string.IsNullOrWhiteSpace(diaChiNhan))
                return KetQuaXuLy.Loi("Vui lòng nhập địa chỉ nhận hàng!");
            if (danhSachHang == null || danhSachHang.Count == 0)
                return KetQuaXuLy.Loi("Giỏ hàng đang trống, không thể tạo đơn!");

            // Xác thực thanh toán thẻ
            var checkThe = XacThucTheTinDung(thongTinThe);
            if (!checkThe.ThanhCong)
                return checkThe;

            using (var cn = Db.OpenConnection())
            using (var trans = cn.BeginTransaction())
            {
                try
                {
                    // 1. Tìm hoặc thêm mới Khách hàng
                    string maKH = null;
                    string sqlFindKH = "SELECT TOP 1 MaKH FROM KHACH_HANG WHERE SoDienThoai = @SDT";
                    using (var cmd = new SqlCommand(sqlFindKH, cn, trans))
                    {
                        cmd.Parameters.AddWithValue("@SDT", soDienThoai.Trim());
                        var objKH = cmd.ExecuteScalar();
                        if (objKH != null)
                            maKH = objKH.ToString();
                    }

                    if (string.IsNullOrEmpty(maKH))
                    {
                        // Tạo mã khách hàng mới KH + random/timestamp
                        maKH = "KH" + DateTime.Now.ToString("yyMMddHHmm");
                        string sqlInsertKH = @"
                            INSERT INTO KHACH_HANG (MaKH, HoTen, DiaChi, SoDienThoai, Email)
                            VALUES (@MaKH, @HoTen, @DiaChi, @SDT, @Email)";
                        using (var cmd = new SqlCommand(sqlInsertKH, cn, trans))
                        {
                            cmd.Parameters.AddWithValue("@MaKH", maKH);
                            cmd.Parameters.AddWithValue("@HoTen", hoTen.Trim());
                            cmd.Parameters.AddWithValue("@DiaChi", diaChiNhan.Trim());
                            cmd.Parameters.AddWithValue("@SDT", soDienThoai.Trim());
                            cmd.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 2. Tạo Mã Đơn Hàng duy nhất (DH + yyyyMMddHHmmss)
                    string maDonHang = "DH" + DateTime.Now.ToString("yyyyMMddHHmmss");

                    // 3. Thêm vào bảng DON_DAT_HANG
                    string sqlInsertDH = @"
                        INSERT INTO DON_DAT_HANG 
                        (MaDonHang, NgayDat, LoaiPhieuGiao, PhiGiaoHang, TongTien, TrangThai, TenNguoiNhan, DiaChiNhan, SdtNguoiNhan, MaKH)
                        VALUES 
                        (@MaDH, GETDATE(), @LoaiGiao, @PhiShip, @TongTien, N'Đã thanh toán', @TenNhan, @DiaChiNhan, @SdtNhan, @MaKH)";

                    using (var cmd = new SqlCommand(sqlInsertDH, cn, trans))
                    {
                        cmd.Parameters.AddWithValue("@MaDH", maDonHang);
                        cmd.Parameters.AddWithValue("@LoaiGiao", loaiPhieuGiao);
                        cmd.Parameters.AddWithValue("@PhiShip", phiShip);
                        cmd.Parameters.AddWithValue("@TongTien", tongTien);
                        cmd.Parameters.AddWithValue("@TenNhan", hoTen.Trim());
                        cmd.Parameters.AddWithValue("@DiaChiNhan", diaChiNhan.Trim());
                        cmd.Parameters.AddWithValue("@SdtNhan", soDienThoai.Trim());
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.ExecuteNonQuery();
                    }

                    // 4. Thêm từng sản phẩm vào bảng CHI_TIET_DON_HANG
                    string sqlInsertCT = @"
                        INSERT INTO CHI_TIET_DON_HANG (MaDonHang, MaSP, SoLuong, DonGiaBan, ThanhTien)
                        VALUES (@MaDH, @MaSP, @SoLuong, @DonGia, @ThanhTien)";

                    foreach (var item in danhSachHang)
                    {
                        using (var cmd = new SqlCommand(sqlInsertCT, cn, trans))
                        {
                            cmd.Parameters.AddWithValue("@MaDH", maDonHang);
                            cmd.Parameters.AddWithValue("@MaSP", item.MaSP);
                            cmd.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                            cmd.Parameters.AddWithValue("@DonGia", item.DonGia);
                            cmd.Parameters.AddWithValue("@ThanhTien", item.ThanhTien);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    return KetQuaXuLy.OK($"Đặt hàng & Thanh toán thành công!\nMã đơn hàng của bạn là: {maDonHang}", maDonHang);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return KetQuaXuLy.Loi("Lỗi khi lưu đơn đặt hàng: " + ex.Message);
                }
            }
        }

        // 4. Tra cứu lịch sử đơn hàng (theo SĐT, Mã đơn hàng hoặc xem toàn bộ)
        public DataTable LayLichSuDonHang(string tuKhoa = null)
        {
            string sql = @"
                SELECT dh.MaDonHang, dh.NgayDat, dh.TenNguoiNhan, dh.SdtNguoiNhan, 
                       dh.LoaiPhieuGiao, dh.PhiGiaoHang, dh.TongTien, dh.TrangThai, dh.MaKH
                FROM DON_DAT_HANG dh
                WHERE 1=1";

            var pars = new List<SqlParameter>();
            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                sql += " AND (dh.MaDonHang LIKE @KW OR dh.SdtNguoiNhan LIKE @KW OR dh.TenNguoiNhan LIKE @KW OR dh.MaKH LIKE @KW)";
                pars.Add(new SqlParameter("@KW", "%" + tuKhoa.Trim() + "%"));
            }

            sql += " ORDER BY dh.NgayDat DESC";
            return Db.Query(sql, pars.ToArray());
        }

        // 5. Lấy danh sách sản phẩm chi tiết của một đơn hàng
        public DataTable LayChiTietDonHang(string maDonHang)
        {
            string sql = @"
                SELECT ct.MaSP, sp.TenSP, ct.DonGiaBan, ct.SoLuong, ct.ThanhTien
                FROM CHI_TIET_DON_HANG ct
                INNER JOIN SAN_PHAM sp ON ct.MaSP = sp.MaSP
                WHERE ct.MaDonHang = @MaDH";

            return Db.Query(sql, new SqlParameter("@MaDH", maDonHang));
        }
    }
}
