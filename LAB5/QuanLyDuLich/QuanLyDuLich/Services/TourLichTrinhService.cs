using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyDuLich.Data;

namespace QuanLyDuLich.Services
{
    public class TourLichTrinhService
    {
        public DataTable GetAllTour()
        {
            return Db.ExecuteQuery("SELECT MaTour, TenTour, SoNgay, SoDem, DonGiaKhach, DiemXuatPhat, DiemKetThuc, TrangThai FROM TourDuLich ORDER BY MaTour");
        }

        public bool InsertTour(string maTour, string tenTour, int soNgay, int soDem, decimal donGia, string moTa)
        {
            string sql = "INSERT INTO TourDuLich (MaTour, TenTour, SoNgay, SoDem, DonGiaKhach, DiemXuatPhat, DiemKetThuc, MoTaQuangCao, TrangThai) VALUES (@Ma, @Ten, @Ngay, @Dem, @Gia, N'TP.HCM', N'TP.HCM', @MoTa, N'DangKhaiThac')";
            int r = Db.ExecuteNonQuery(sql,
                new SqlParameter("@Ma", maTour),
                new SqlParameter("@Ten", tenTour),
                new SqlParameter("@Ngay", soNgay),
                new SqlParameter("@Dem", soDem),
                new SqlParameter("@Gia", donGia),
                new SqlParameter("@MoTa", (object)moTa ?? DBNull.Value));
            return r > 0;
        }

        public bool UpdateTour(string maTour, string tenTour, int soNgay, int soDem, decimal donGia, string moTa, string trangThai)
        {
            string sql = "UPDATE TourDuLich SET TenTour = @Ten, SoNgay = @Ngay, SoDem = @Dem, DonGiaKhach = @Gia, MoTaQuangCao = @MoTa, TrangThai = @TT WHERE MaTour = @Ma";
            int r = Db.ExecuteNonQuery(sql,
                new SqlParameter("@Ma", maTour),
                new SqlParameter("@Ten", tenTour),
                new SqlParameter("@Ngay", soNgay),
                new SqlParameter("@Dem", soDem),
                new SqlParameter("@Gia", donGia),
                new SqlParameter("@MoTa", (object)moTa ?? DBNull.Value),
                new SqlParameter("@TT", trangThai));
            return r > 0;
        }

        public DataTable GetNoiDungChan(string maTour)
        {
            string sql = "SELECT MaNoiDungChan, ThuTuChang, TenDiaDanh, CoDoiPhuongTien, PhuongTienDiChuyen, CoNoiAn, CoKhachSan, TenKhachSan, HangSaoKhachSan FROM NoiDungChan WHERE MaTour = @MaTour ORDER BY ThuTuChang";
            return Db.ExecuteQuery(sql, new SqlParameter("@MaTour", maTour));
        }

        public bool InsertNoiDungChan(string maNDC, string maTour, int thuTu, string diaDanh, bool doiPT, string phuongTien, bool noiAn, bool khachSan, string tenKS, int hangSao)
        {
            string sql = "INSERT INTO NoiDungChan (MaNoiDungChan, MaTour, ThuTuChang, TenDiaDanh, CoDoiPhuongTien, PhuongTienDiChuyen, CoNoiAn, CoKhachSan, TenKhachSan, HangSaoKhachSan) VALUES (@Ma, @Tour, @ThuTu, @DiaDanh, @DoiPT, @PT, @An, @KS, @TenKS, @Sao)";
            int r = Db.ExecuteNonQuery(sql,
                new SqlParameter("@Ma", maNDC),
                new SqlParameter("@Tour", maTour),
                new SqlParameter("@ThuTu", thuTu),
                new SqlParameter("@DiaDanh", diaDanh),
                new SqlParameter("@DoiPT", doiPT),
                new SqlParameter("@PT", phuongTien),
                new SqlParameter("@An", noiAn),
                new SqlParameter("@KS", khachSan),
                new SqlParameter("@TenKS", (object)tenKS ?? DBNull.Value),
                new SqlParameter("@Sao", hangSao > 0 ? (object)hangSao : DBNull.Value));
            return r > 0;
        }

        public DataTable GetDiemThamQuan(string maTour)
        {
            string sql = "SELECT MaDiemThamQuan, TenDiemThamQuan, DiaDiemThamQuan, NoiDung, YNghia FROM DiemThamQuan WHERE MaTour = @MaTour ORDER BY MaDiemThamQuan";
            return Db.ExecuteQuery(sql, new SqlParameter("@MaTour", maTour));
        }

        public bool InsertDiemThamQuan(string maDTQ, string maTour, string ten, string diaDiem, string noiDung, string yNghia)
        {
            string sql = "INSERT INTO DiemThamQuan (MaDiemThamQuan, MaTour, TenDiemThamQuan, DiaDiemThamQuan, NoiDung, YNghia) VALUES (@Ma, @Tour, @Ten, @DiaDiem, @NoiDung, @YNghia)";
            int r = Db.ExecuteNonQuery(sql,
                new SqlParameter("@Ma", maDTQ),
                new SqlParameter("@Tour", maTour),
                new SqlParameter("@Ten", ten),
                new SqlParameter("@DiaDiem", diaDiem),
                new SqlParameter("@NoiDung", (object)noiDung ?? DBNull.Value),
                new SqlParameter("@YNghia", (object)yNghia ?? DBNull.Value));
            return r > 0;
        }
    }
}
