using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.Data;

namespace QuanLyThuVien.Services
{
    public class ThongKeService
    {
        public ThongKeTongHop LayTongHop(DateTime tuNgay, DateTime denNgay) 
        {
            DateTime from = tuNgay.Date;
            DateTime to = denNgay.Date;
            if (to < from) { DateTime t = from; from = to; to = t; } 

            ThongKeTongHop kq = new ThongKeTongHop();
            kq.LuotSachMuon = Convert.ToInt32(Db.Scalar(@"SELECT COUNT(*) FROM ChiTietPhieuMuon ct 
                                                          JOIN PhieuMuon pm ON pm.MaPhieuMuon=ct.MaPhieuMuon 
                                                          WHERE pm.NgayMuon BETWEEN @Tu AND @Den",
                new SqlParameter("@Tu", from), new SqlParameter("@Den", to))); 

            kq.DaTraDungHan = Convert.ToInt32(Db.Scalar(@"SELECT COUNT(*) FROM ChiTietPhieuMuon ct 
                                                          JOIN PhieuMuon pm ON pm.MaPhieuMuon=ct.MaPhieuMuon 
                                                          WHERE ct.NgayTraThucTe IS NOT NULL AND ct.NgayTraThucTe <= pm.NgayHenTra 
                                                            AND pm.NgayMuon BETWEEN @Tu AND @Den",
                new SqlParameter("@Tu", from), new SqlParameter("@Den", to)));

            kq.SachQuaHan = Convert.ToInt32(Db.Scalar(@"SELECT COUNT(*) FROM ChiTietPhieuMuon ct 
                                                        JOIN PhieuMuon pm ON pm.MaPhieuMuon=ct.MaPhieuMuon 
                                                        WHERE ((ct.NgayTraThucTe IS NULL AND pm.NgayHenTra < CAST(GETDATE() AS date)) 
                                                           OR (ct.NgayTraThucTe IS NOT NULL AND ct.NgayTraThucTe > pm.NgayHenTra))
                                                          AND pm.NgayMuon BETWEEN @Tu AND @Den", 
                new SqlParameter("@Tu", from), new SqlParameter("@Den", to))); 

            kq.SachMat = Convert.ToInt32(Db.Scalar(@"SELECT COUNT(*) FROM ChiTietPhieuMuon 
                                                    WHERE NgayTraThucTe BETWEEN @Tu AND @Den AND TinhTrangTra LIKE N'%Mất%'",
                new SqlParameter("@Tu", from), new SqlParameter("@Den", to))); 

            kq.SachHuHong = Convert.ToInt32(Db.Scalar(@"SELECT COUNT(*) FROM ChiTietPhieuMuon 
                                                       WHERE NgayTraThucTe BETWEEN @Tu AND @Den
                                                         AND (TinhTrangTra LIKE N'%Rách%' OR TinhTrangTra LIKE N'%Hư hỏng%')", 
                new SqlParameter("@Tu", from), new SqlParameter("@Den", to))); 

            object tong = Db.Scalar("SELECT ISNULL(SUM(PhiPhat),0) FROM PhieuPhat WHERE NgayPhat BETWEEN @Tu AND @Den", 
                new SqlParameter("@Tu", from), new SqlParameter("@Den", to)); 
            kq.TongPhiPhat = Convert.ToDecimal(tong);
            return kq;
        }

        public DataTable LayBaoCaoTheoTheLoai(DateTime tuNgay, DateTime denNgay)
        {
            DateTime from = tuNgay.Date;
            DateTime to = denNgay.Date;
            if (to < from) { DateTime t = from; from = to; to = t; }

            string sql = @"
                WITH MuonStats AS (
                    SELECT 
                        s.MaTheLoai,
                        COUNT(ct.MaChiTiet) AS SoLuotMuon,
                        SUM(CASE WHEN ct.NgayTraThucTe IS NULL THEN 1 ELSE 0 END) AS DangMuon,
                        SUM(CASE WHEN (ct.NgayTraThucTe IS NULL AND pm.NgayHenTra < CAST(GETDATE() AS date))
                                      OR (ct.NgayTraThucTe IS NOT NULL AND ct.NgayTraThucTe > pm.NgayHenTra) THEN 1 ELSE 0 END) AS LuotTreHan
                    FROM ChiTietPhieuMuon ct
                    JOIN PhieuMuon pm ON pm.MaPhieuMuon = ct.MaPhieuMuon
                    JOIN DauSach s ON s.MaDauSach = ct.MaDauSach
                    WHERE pm.NgayMuon BETWEEN @Tu AND @Den
                    GROUP BY s.MaTheLoai
                ),
                SachStats AS (
                    SELECT MaTheLoai, COUNT(MaDauSach) AS TongSoSach
                    FROM DauSach
                    GROUP BY MaTheLoai
                )
                SELECT 
                    tl.MaTheLoai AS [Mã TL],
                    tl.TenTheLoai AS [Tên thể loại sách],
                    ISNULL(ss.TongSoSach, 0) AS [Tổng số sách],
                    ISNULL(ms.SoLuotMuon, 0) AS [Số lượt mượn],
                    ISNULL(ms.DangMuon, 0) AS [Đang mượn],
                    ISNULL(ms.LuotTreHan, 0) AS [Lượt trễ hạn],
                    CAST(0.0 AS DECIMAL(5,1)) AS [Tỷ lệ mượn (%)]
                FROM TheLoai tl
                LEFT JOIN SachStats ss ON ss.MaTheLoai = tl.MaTheLoai
                LEFT JOIN MuonStats ms ON ms.MaTheLoai = tl.MaTheLoai
                ORDER BY tl.MaTheLoai";

            DataTable dt = Db.Query(sql, new SqlParameter("@Tu", from), new SqlParameter("@Den", to));

            int totalMuon = 0;
            foreach (DataRow r in dt.Rows)
            {
                totalMuon += Convert.ToInt32(r["Số lượt mượn"]);
            }
            foreach (DataRow r in dt.Rows)
            {
                int count = Convert.ToInt32(r["Số lượt mượn"]);
                decimal pct = totalMuon > 0 ? Math.Round((decimal)count * 100m / totalMuon, 1) : 0m;
                r["Tỷ lệ mượn (%)"] = pct;
            }

            return dt;
        }

        public DataTable LayDanhSachQuaHan(string mucQuaHan, string tuKhoaDocGia)
        {
            string where = " WHERE ct.NgayTraThucTe IS NULL AND pm.NgayHenTra < CAST(GETDATE() AS date) ";
            List<SqlParameter> pars = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(tuKhoaDocGia))
            {
                where += " AND (dg.MaDocGia LIKE @TK OR (dg.Ho + ' ' + dg.Ten) LIKE @TK OR dg.SoDienThoai LIKE @TK OR dg.Email LIKE @TK) ";
                pars.Add(new SqlParameter("@TK", "%" + tuKhoaDocGia.Trim() + "%"));
            }

            if (mucQuaHan == "1-7")
            {
                where += " AND DATEDIFF(day, pm.NgayHenTra, GETDATE()) BETWEEN 1 AND 7 ";
            }
            else if (mucQuaHan == ">7")
            {
                where += " AND DATEDIFF(day, pm.NgayHenTra, GETDATE()) > 7 ";
            }

            string sql = @"
                SELECT 
                    pm.MaPhieuMuon AS [Mã PM],
                    (dg.Ho + ' ' + dg.Ten) AS [Họ tên độc giả],
                    (ISNULL(dg.SoDienThoai, '') + ' | ' + ISNULL(dg.Email, '')) AS [Số điện thoại / Email],
                    s.TenSach AS [Tên sách mượn],
                    CONVERT(VARCHAR(10), pm.NgayHenTra, 103) AS [Hạn phải trả],
                    (CAST(DATEDIFF(day, pm.NgayHenTra, GETDATE()) AS VARCHAR(10)) + ' ngày') AS [Quá hạn],
                    (FORMAT(DATEDIFF(day, pm.NgayHenTra, GETDATE()) * 5000, 'N0') + ' VNĐ') AS [Phạt dự kiến],
                    (DATEDIFF(day, pm.NgayHenTra, GETDATE()) * 5000) AS TienPhatRaw,
                    dg.Email,
                    dg.SoDienThoai
                FROM ChiTietPhieuMuon ct
                JOIN PhieuMuon pm ON pm.MaPhieuMuon = ct.MaPhieuMuon
                JOIN DocGia dg ON dg.MaDocGia = pm.MaDocGia
                JOIN DauSach s ON s.MaDauSach = ct.MaDauSach" + where + 
                " ORDER BY DATEDIFF(day, pm.NgayHenTra, GETDATE()) DESC";

            return Db.Query(sql, pars.ToArray());
        }

        public DataTable LayChiTietPhat(DateTime tuNgay, DateTime denNgay) 
        {
            return Db.Query(@"SELECT pp.MaPhieuPhat, pp.NgayPhat, pm.MaDocGia, ct.MaDauSach, 
                                    s.TenSach, pp.LyDo, pp.PhiPhat, pp.MaNhanVien
                             FROM PhieuPhat pp 
                             JOIN ChiTietPhieuMuon ct ON ct.MaChiTiet=pp.MaChiTiet 
                             JOIN PhieuMuon pm ON pm.MaPhieuMuon=ct.MaPhieuMuon 
                             JOIN DauSach s ON s.MaDauSach=ct.MaDauSach
                             WHERE pp.NgayPhat BETWEEN @Tu AND @Den
                             ORDER BY pp.NgayPhat DESC, pp.MaPhieuPhat",
                new SqlParameter("@Tu", tuNgay.Date), new SqlParameter("@Den", denNgay.Date)); 
        }
    }
}
