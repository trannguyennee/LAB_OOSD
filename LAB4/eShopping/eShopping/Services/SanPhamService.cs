using System;
using System.Data;
using System.Data.SqlClient;
using eShopping.Data;

namespace eShopping.Services
{
    public class SanPhamService
    {
        // 1. Lấy danh sách nhóm sản phẩm
        public DataTable LayTatCaNhomSanPham()
        {
            string sql = "SELECT MaNhom, TenNhom, MoTa FROM NHOM_SAN_PHAM ORDER BY MaNhom";
            return Db.Query(sql);
        }

        // 2. Lấy danh sách sản phẩm (có thể lọc theo nhóm hoặc từ khóa tìm kiếm)
        public DataTable LayDanhSachSanPham(string maNhom = null, string tuKhoa = null)
        {
            string sql = @"
                SELECT sp.MaSP, sp.TenSP, sp.NhaSanXuat, sp.GiaHienHanh, sp.TinhTrang, 
                       sp.MaNhom, nsp.TenNhom, sp.ThongSoKyThuat, sp.MoTa
                FROM SAN_PHAM sp
                INNER JOIN NHOM_SAN_PHAM nsp ON sp.MaNhom = nsp.MaNhom
                WHERE 1=1";

            var cmdParams = new System.Collections.Generic.List<SqlParameter>();

            if (!string.IsNullOrEmpty(maNhom) && maNhom != "ALL")
            {
                sql += " AND sp.MaNhom = @MaNhom";
                cmdParams.Add(new SqlParameter("@MaNhom", maNhom));
            }

            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                sql += " AND (sp.TenSP LIKE @Keyword OR sp.NhaSanXuat LIKE @Keyword OR sp.MaSP LIKE @Keyword)";
                cmdParams.Add(new SqlParameter("@Keyword", "%" + tuKhoa.Trim() + "%"));
            }

            sql += " ORDER BY sp.MaSP";
            return Db.Query(sql, cmdParams.ToArray());
        }

        // 3. Lấy thông tin chi tiết một sản phẩm
        public DataRow LayChiTietSanPham(string maSP)
        {
            string sql = @"
                SELECT sp.MaSP, sp.TenSP, sp.NhaSanXuat, sp.GiaHienHanh, sp.TinhTrang, 
                       sp.MaNhom, nsp.TenNhom, sp.ThongSoKyThuat, sp.MoTa
                FROM SAN_PHAM sp
                INNER JOIN NHOM_SAN_PHAM nsp ON sp.MaNhom = nsp.MaNhom
                WHERE sp.MaSP = @MaSP";

            DataTable dt = Db.Query(sql, new SqlParameter("@MaSP", maSP));
            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }
    }
}
