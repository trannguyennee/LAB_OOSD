using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class PhongDatItem
    {
        public string SoPhong { get; set; }
        public int SoNguoi { get; set; }
        public decimal DonGiaNgay { get; set; }
    }

    public class DatPhongService
    {
        public DataTable LayKhach()
        {
            return Db.Query("SELECT * FROM KhachHang ORDER BY HoTen");
        }

        public DataTable LayPhong()
        {
            return Db.Query(@"SELECT p.SoPhong, k.TenKhuVuc, p.SoNguoiToiDa, p.DonGiaNgay, p.TrangThai, p.MaKhuVuc 
                             FROM Phong p 
                             JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc 
                             ORDER BY p.SoPhong");
        }

        public DataTable LayPhieuDat()
        {
            return Db.Query(@"SELECT d.SoPhieuDat, k.HoTen AS TenKhach, d.NgayNhan, d.NgayTraDuKien, 
                                     d.TienCoc, d.KenhDat, d.TrangThai, d.NgayLap, d.MaNVLeTan, d.MaKhach
                             FROM PhieuDatPhong d 
                             JOIN KhachHang k ON d.MaKhach = k.MaKhach 
                             ORDER BY d.NgayLap DESC");
        }

        public DataTable LayChiTiet(string soPhieu)
        {
            return Db.Query(@"SELECT c.SoPhieuDat, c.SoPhong, p.SoNguoiToiDa, c.SoNguoi, p.DonGiaNgay 
                             FROM ChiTietDatPhong c 
                             JOIN Phong p ON c.SoPhong = p.SoPhong 
                             WHERE c.SoPhieuDat = @s", 
                             new SqlParameter("@s", soPhieu));
        }

        public DataTable LayNguoiLuuTru(string soPhieu)
        {
            return Db.Query(@"SELECT MaNguoiLT, SoPhong, HoTen, SoCMND, QuocTich 
                             FROM NguoiLuuTru 
                             WHERE SoPhieuDat = @s 
                             ORDER BY SoPhong, MaNguoiLT", 
                             new SqlParameter("@s", soPhieu));
        }

        public KetQuaXuLy ThemKhach(string ma, string ten, string cmnd, string qt, string sdt)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || 
                string.IsNullOrWhiteSpace(cmnd) || string.IsNullOrWhiteSpace(qt))
                return KetQuaXuLy.Fail("Thông tin khách chưa đầy đủ.");

            try
            {
                Db.Execute("INSERT INTO KhachHang(MaKhach, HoTen, SoCMND, QuocTich, SoDienThoai) VALUES(@m, @t, @c, @q, @s)",
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten),
                    new SqlParameter("@c", cmnd),
                    new SqlParameter("@q", qt),
                    new SqlParameter("@s", (object)sdt ?? DBNull.Value));
                return KetQuaXuLy.Ok("Đã lưu khách hàng thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        private bool PhongTrungLich(SqlConnection cn, SqlTransaction tx, string phong, DateTime nhan, DateTime tra)
        {
            var cmd = new SqlCommand(@"SELECT COUNT(*) FROM ChiTietDatPhong c 
                                      JOIN PhieuDatPhong d ON c.SoPhieuDat = d.SoPhieuDat 
                                      WHERE c.SoPhong = @p 
                                        AND d.TrangThai IN (N'Đã đặt', N'Đang ở') 
                                        AND @nhan <= d.NgayTraDuKien 
                                        AND @tra >= d.NgayNhan", cn, tx);
            cmd.Parameters.AddWithValue("@p", phong);
            cmd.Parameters.AddWithValue("@nhan", nhan.Date);
            cmd.Parameters.AddWithValue("@tra", tra.Date);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public KetQuaXuLy TaoDatPhong(string so, string maKhach, string maNV, DateTime ngayLap, DateTime nhan, DateTime tra, decimal coc, string kenh, List<PhongDatItem> ds)
        {
            if (string.IsNullOrWhiteSpace(so) || string.IsNullOrWhiteSpace(maKhach) || 
                string.IsNullOrWhiteSpace(maNV) || ds == null || ds.Count == 0)
                return KetQuaXuLy.Fail("Phiếu đặt phòng chưa đủ thông tin hoặc chưa chọn phòng.");

            if (tra.Date < nhan.Date)
                return KetQuaXuLy.Fail("Ngày trả dự kiến không được trước ngày nhận.");

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 1. Kiểm tra sức chứa và trùng lịch từng phòng
                    foreach (var x in ds)
                    {
                        var q = new SqlCommand("SELECT SoNguoiToiDa FROM Phong WHERE SoPhong = @p", cn, tx);
                        q.Parameters.AddWithValue("@p", x.SoPhong);
                        var o = q.ExecuteScalar();
                        if (o == null)
                            return KetQuaXuLy.Fail("Không tìm thấy phòng " + x.SoPhong);

                        int maxNguoi = Convert.ToInt32(o);
                        if (x.SoNguoi <= 0 || x.SoNguoi > maxNguoi)
                            return KetQuaXuLy.Fail($"Số người của phòng {x.SoPhong} ({x.SoNguoi} người) vượt sức chứa tối đa ({maxNguoi} người).");

                        if (PhongTrungLich(cn, tx, x.SoPhong, nhan, tra))
                            return KetQuaXuLy.Fail("Phòng " + x.SoPhong + " bị trùng lịch đặt trong khoảng thời gian đã chọn.");
                    }

                    // 2. Tạo PhieuDatPhong
                    var h = new SqlCommand(@"INSERT INTO PhieuDatPhong(SoPhieuDat, MaKhach, MaNVLeTan, NgayLap, NgayNhan, NgayTraDuKien, TienCoc, KenhDat, TrangThai) 
                                             VALUES(@s, @k, @nv, @lap, @nhan, @tra, @c, @kenh, N'Đã đặt')", cn, tx);
                    h.Parameters.AddWithValue("@s", so);
                    h.Parameters.AddWithValue("@k", maKhach);
                    h.Parameters.AddWithValue("@nv", maNV);
                    h.Parameters.AddWithValue("@lap", ngayLap);
                    h.Parameters.AddWithValue("@nhan", nhan.Date);
                    h.Parameters.AddWithValue("@tra", tra.Date);
                    h.Parameters.AddWithValue("@c", coc);
                    h.Parameters.AddWithValue("@kenh", kenh);
                    h.ExecuteNonQuery();

                    // 3. Thêm chi tiết và cập nhật trạng thái phòng
                    foreach (var x in ds)
                    {
                        var c = new SqlCommand("INSERT INTO ChiTietDatPhong(SoPhieuDat, SoPhong, SoNguoi) VALUES(@s, @p, @n)", cn, tx);
                        c.Parameters.AddWithValue("@s", so);
                        c.Parameters.AddWithValue("@p", x.SoPhong);
                        c.Parameters.AddWithValue("@n", x.SoNguoi);
                        c.ExecuteNonQuery();

                        var u = new SqlCommand("UPDATE Phong SET TrangThai = N'Đã đặt' WHERE SoPhong = @p", cn, tx);
                        u.Parameters.AddWithValue("@p", x.SoPhong);
                        u.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã lập phiếu đặt phòng thành công.");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
                }
            }
        }

        public KetQuaXuLy ThemNguoiLuuTru(string so, string phong, string ten, string cmnd, string qt)
        {
            if (string.IsNullOrWhiteSpace(so) || string.IsNullOrWhiteSpace(phong) || 
                string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(cmnd) || string.IsNullOrWhiteSpace(qt))
                return KetQuaXuLy.Fail("Thông tin người lưu trú chưa đầy đủ.");

            try
            {
                object objMax = Db.Scalar("SELECT SoNguoi FROM ChiTietDatPhong WHERE SoPhieuDat = @s AND SoPhong = @p",
                    new SqlParameter("@s", so), new SqlParameter("@p", phong));

                if (objMax == null)
                    return KetQuaXuLy.Fail("Phòng này không thuộc phiếu đặt đã chọn.");

                int max = Convert.ToInt32(objMax);
                int dem = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM NguoiLuuTru WHERE SoPhieuDat = @s AND SoPhong = @p",
                    new SqlParameter("@s", so), new SqlParameter("@p", phong)));

                if (dem >= max)
                    return KetQuaXuLy.Fail($"Phòng {phong} đã đủ số người đăng ký ({max} người).");

                Db.Execute("INSERT INTO NguoiLuuTru(SoPhieuDat, SoPhong, HoTen, SoCMND, QuocTich) VALUES(@s, @p, @t, @c, @q)",
                    new SqlParameter("@s", so),
                    new SqlParameter("@p", phong),
                    new SqlParameter("@t", ten),
                    new SqlParameter("@c", cmnd),
                    new SqlParameter("@q", qt));

                return KetQuaXuLy.Ok("Đã thêm người lưu trú thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }

        public KetQuaXuLy NhanPhong(string so, DateTime thucTe)
        {
            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    var c = new SqlCommand("UPDATE PhieuDatPhong SET TrangThai = N'Đang ở', NgayNhanThucTe = @n WHERE SoPhieuDat = @s AND TrangThai = N'Đã đặt'", cn, tx);
                    c.Parameters.AddWithValue("@n", thucTe);
                    c.Parameters.AddWithValue("@s", so);
                    if (c.ExecuteNonQuery() == 0)
                        return KetQuaXuLy.Fail("Phiếu không ở trạng thái 'Đã đặt' để có thể nhận phòng.");

                    var u = new SqlCommand("UPDATE Phong SET TrangThai = N'Đang ở' WHERE SoPhong IN (SELECT SoPhong FROM ChiTietDatPhong WHERE SoPhieuDat = @s)", cn, tx);
                    u.Parameters.AddWithValue("@s", so);
                    u.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã nhận phòng thành công.");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
                }
            }
        }

        public KetQuaXuLy DanhDauNoShow(string so)
        {
            try
            {
                Db.Execute("UPDATE PhieuDatPhong SET TrangThai = N'No-show' WHERE SoPhieuDat = @s AND TrangThai = N'Đã đặt'",
                    new SqlParameter("@s", so));
                Db.Execute("UPDATE Phong SET TrangThai = N'Trống' WHERE SoPhong IN (SELECT SoPhong FROM ChiTietDatPhong WHERE SoPhieuDat = @s)",
                    new SqlParameter("@s", so));
                return KetQuaXuLy.Ok("Đã xác nhận No-show (khách không đến). Phòng đã được chuyển về trạng thái Trống.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }
    }
}
