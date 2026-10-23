-- =========================================================================================
-- HỆ THỐNG QUẢN LÝ NHÂN SỰ & TIỀN LƯƠNG - CÔNG TY SƠN ĐÔNG Á
-- Môn học: Phương pháp phát triển phần mềm hướng đối tượng (OOSD)
-- Giảng viên hướng dẫn: ThS. Phạm Trọng Huynh
-- Sinh viên thực hiện: Trần Nguyên - MSSV: 1250080121 - Lớp: 12CNPM2
-- CSDL: Chuẩn hóa 3NF, Khóa chính, Khóa ngoại, Unique, Check, Stored Procedures có Transaction
-- =========================================================================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyNhanSu_SonDongA')
BEGIN
    ALTER DATABASE QuanLyNhanSu_SonDongA SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyNhanSu_SonDongA;
END
GO

CREATE DATABASE QuanLyNhanSu_SonDongA
COLLATE Vietnamese_CI_AS;
GO

USE QuanLyNhanSu_SonDongA;
GO

-- =========================================================================================
-- 1. BẢNG PHÒNG BAN (PhongBan)
-- =========================================================================================
CREATE TABLE PhongBan (
    MaPhongBan VARCHAR(20) PRIMARY KEY,
    TenPhongBan NVARCHAR(100) NOT NULL UNIQUE,
    TruongPhong NVARCHAR(100) NULL,
    DienThoai VARCHAR(20) NULL,
    DiaDiem NVARCHAR(200) NULL
);
GO

-- =========================================================================================
-- 2. BẢNG CHỨC VỤ (ChucVu)
-- =========================================================================================
CREATE TABLE ChucVu (
    MaChucVu VARCHAR(20) PRIMARY KEY,
    TenChucVu NVARCHAR(100) NOT NULL UNIQUE,
    PhuCapChucVu DECIMAL(18, 2) NOT NULL DEFAULT 0,
    MoTa NVARCHAR(255) NULL
);
GO

-- =========================================================================================
-- 3. BẢNG NHÂN VIÊN (NhanVien)
-- =========================================================================================
CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NULL,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    CCCD VARCHAR(20) NOT NULL UNIQUE,
    DienThoai VARCHAR(20) NULL,
    Email VARCHAR(100) NULL,
    DiaChi NVARCHAR(255) NULL,
    NgayVaoLam DATE NOT NULL DEFAULT GETDATE(),
    MaPhongBan VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES PhongBan(MaPhongBan),
    MaChucVu VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES ChucVu(MaChucVu),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Thử việc' -- N'Thử việc', N'Chính thức', N'Đã nghỉ việc'
);
GO

-- =========================================================================================
-- 4. BẢNG QUYẾT ĐỊNH TUYỂN DỤNG / THỬ VIỆC (QuyetDinhTuyenDung)
-- =========================================================================================
CREATE TABLE QuyetDinhTuyenDung (
    SoQuyetDinhTD VARCHAR(30) PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    NgayQuyetDinh DATE NOT NULL DEFAULT GETDATE(),
    ThoiGianThuViec INT NOT NULL DEFAULT 60, -- Số ngày thử việc (30 ngày, 60 ngày)
    LuongThuViec DECIMAL(18, 2) NOT NULL, -- Tối thiểu 85% lương chính thức
    DieuKhoanThoaThuan NVARCHAR(500) NULL,
    TrangThaiDuyet NVARCHAR(50) NOT NULL DEFAULT N'Đã duyệt', -- N'Chờ duyệt', N'Đã duyệt'
    NguoiKy NVARCHAR(100) NOT NULL DEFAULT N'Giám đốc'
);
GO

-- =========================================================================================
-- 5. BẢNG HỢP ĐỒNG LAO ĐỘNG (HopDongLaoDong)
-- =========================================================================================
CREATE TABLE HopDongLaoDong (
    SoHopDong VARCHAR(30) PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    LoaiHopDong NVARCHAR(50) NOT NULL CHECK (LoaiHopDong IN (N'Ngắn hạn', N'Dài hạn', N'Không xác định thời hạn')),
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NULL, -- NULL nếu là Không xác định thời hạn
    LuongThoaThuan DECIMAL(18, 2) NOT NULL,
    CoBaoHiem BIT NOT NULL DEFAULT 0, -- 1 nếu là HĐ dài hạn, 0 nếu ngắn hạn
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Hiệu lực', -- N'Hiệu lực', N'Hết hạn', N'Đã chấm dứt'
    NguoiKy NVARCHAR(100) NOT NULL DEFAULT N'Giám đốc'
);
GO

-- =========================================================================================
-- 6. BẢNG HỒ SƠ BẢO HIỂM (HoSoBaoHiem) - Áp dụng HĐ dài hạn
-- =========================================================================================
CREATE TABLE HoSoBaoHiem (
    MaHoSoBH VARCHAR(30) PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL UNIQUE FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    SoTheBHYT VARCHAR(30) NOT NULL UNIQUE,
    MaSoBHXH VARCHAR(30) NOT NULL UNIQUE,
    NgayThamGia DATE NOT NULL,
    MucDongBHXH DECIMAL(18, 2) NOT NULL, -- Mức lương đóng bảo hiểm
    TyLeDongNV DECIMAL(5, 2) NOT NULL DEFAULT 10.5, -- % NV đóng (8% BHXH, 1.5% BHYT, 1% BHTN)
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đang tham gia'
);
GO

-- =========================================================================================
-- 7. BẢNG QUYẾT ĐỊNH CHỨC VỤ (QuyetDinhChucVu)
-- =========================================================================================
CREATE TABLE QuyetDinhChucVu (
    SoQuyetDinhCV VARCHAR(30) PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    MaChucVu VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES ChucVu(MaChucVu),
    PhuCapChucVu DECIMAL(18, 2) NOT NULL DEFAULT 0,
    NgayHieuLuc DATE NOT NULL,
    LyDoBoNhiem NVARCHAR(255) NULL,
    NguoiKy NVARCHAR(100) NOT NULL DEFAULT N'Giám đốc'
);
GO

-- =========================================================================================
-- 8. BẢNG QUYẾT ĐỊNH LƯƠNG (QuyetDinhLuong) - Có Phụ cấp độc hại cho nhân sự xưởng sơn
-- =========================================================================================
CREATE TABLE QuyetDinhLuong (
    SoQuyetDinhL VARCHAR(30) PRIMARY KEY,
    MaNhanVien VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    LuongCoBan DECIMAL(18, 2) NOT NULL,
    PhuCapLuong DECIMAL(18, 2) NOT NULL DEFAULT 0,
    PhuCapDocHai DECIMAL(18, 2) NOT NULL DEFAULT 0, -- Nhân viên xưởng sơn tiếp xúc hóa chất
    NgayHieuLuc DATE NOT NULL,
    NguoiKy NVARCHAR(100) NOT NULL DEFAULT N'Giám đốc'
);
GO

-- =========================================================================================
-- 9. BẢNG KẾ HOẠCH PHÂN CA TUẦN (KeHoachPhanCa)
-- =========================================================================================
CREATE TABLE KeHoachPhanCa (
    MaKeHoach VARCHAR(30) PRIMARY KEY,
    TuanThu INT NOT NULL,
    TuNgay DATE NOT NULL,
    DenNgay DATE NOT NULL,
    MaPhongBan VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES PhongBan(MaPhongBan),
    NguoiLap NVARCHAR(100) NOT NULL,
    NgayLap DATE NOT NULL DEFAULT GETDATE(),
    GhiChu NVARCHAR(255) NULL
);
GO

-- =========================================================================================
-- 10. BẢNG CHI TIẾT PHÂN CA (ChiTietPhanCa)
-- =========================================================================================
CREATE TABLE ChiTietPhanCa (
    MaChiTietPC INT IDENTITY(1,1) PRIMARY KEY,
    MaKeHoach VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES KeHoachPhanCa(MaKeHoach),
    MaNhanVien VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    ThuTrongTuan NVARCHAR(20) NOT NULL, -- N'Thứ Hai', N'Thứ Ba', ...
    CaLamViec NVARCHAR(50) NOT NULL, -- N'Ca 1 (06:00 - 14:00)', N'Ca 2 (14:00 - 22:00)', N'Ca 3 (22:00 - 06:00)'
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NOT NULL,
    CoPhuTroi BIT NOT NULL DEFAULT 0
);
GO

-- =========================================================================================
-- 11. BẢNG PHIẾU PHỤ TRỘI / TĂNG CA (PhieuPhuTroi) - Hệ số x1.5 ngày thường, x2.0 ngày nghỉ, x3.0 lễ
-- =========================================================================================
CREATE TABLE PhieuPhuTroi (
    SoPhieuPT VARCHAR(30) PRIMARY KEY,
    NgayPhuTroi DATE NOT NULL,
    HinhThucPhuTroi NVARCHAR(50) NOT NULL CHECK (HinhThucPhuTroi IN (N'Tăng ca ngày thường', N'Ngày nghỉ', N'Ngày lễ')),
    HeSoPhuTroi DECIMAL(4, 2) NOT NULL DEFAULT 1.5, -- 1.5 ngày thường, 2.0 ngày nghỉ, 3.0 lễ
    NguoiLap NVARCHAR(100) NOT NULL DEFAULT N'Ban chấm công',
    TrangThaiDuyet NVARCHAR(50) NOT NULL DEFAULT N'Đã duyệt'
);
GO

-- =========================================================================================
-- 12. BẢNG CHI TIẾT PHIẾU PHỤ TRỘI (ChiTietPhuTroi)
-- =========================================================================================
CREATE TABLE ChiTietPhuTroi (
    MaChiTietPT INT IDENTITY(1,1) PRIMARY KEY,
    SoPhieuPT VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES PhieuPhuTroi(SoPhieuPT),
    MaNhanVien VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    SoGioPhuTroi DECIMAL(4, 1) NOT NULL, -- Ví dụ: 2.5 giờ, 4.0 giờ
    NoiDungCongViec NVARCHAR(255) NULL,
    GhiChu NVARCHAR(255) NULL
);
GO

-- =========================================================================================
-- 13. BẢNG CHẤM CÔNG THÁNG (BangChamCong)
-- =========================================================================================
CREATE TABLE BangChamCong (
    MaChamCong VARCHAR(30) PRIMARY KEY,
    ThangNam VARCHAR(10) NOT NULL, -- '10/2026'
    MaNhanVien VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    SoNgayCongChuan DECIMAL(4, 1) NOT NULL DEFAULT 26.0,
    SoNgayLamThucTe DECIMAL(4, 1) NOT NULL DEFAULT 0,
    SoNgayNghiCoPhep DECIMAL(4, 1) NOT NULL DEFAULT 0,
    SoNgayNghiKhongPhep DECIMAL(4, 1) NOT NULL DEFAULT 0,
    TongGioPhuTroi DECIMAL(5, 1) NOT NULL DEFAULT 0,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đã khóa công'
);
GO

-- =========================================================================================
-- 14. BẢNG QUYẾT ĐỊNH KHEN THƯỞNG (QuyetDinhKhenThuong)
-- =========================================================================================
CREATE TABLE QuyetDinhKhenThuong (
    SoQuyetDinhKT VARCHAR(30) PRIMARY KEY,
    NgayQuyetDinh DATE NOT NULL DEFAULT GETDATE(),
    LoaiKhenThuong NVARCHAR(50) NOT NULL CHECK (LoaiKhenThuong IN (N'Cá nhân', N'Tập thể')),
    MaDoiTuong VARCHAR(20) NOT NULL, -- Mã NV hoặc Mã PB
    LyDoKhenThuong NVARCHAR(255) NOT NULL,
    SoTienThuong DECIMAL(18, 2) NOT NULL,
    HinhThucChi NVARCHAR(50) NOT NULL CHECK (HinhThucChi IN (N'Chi tiền mặt', N'Cộng vào bảng lương')),
    TrangThaiChi NVARCHAR(50) NOT NULL DEFAULT N'Chưa chi', -- N'Đã chi', N'Chưa chi', N'Đã cộng lương'
    NguoiKy NVARCHAR(100) NOT NULL DEFAULT N'Giám đốc'
);
GO

-- =========================================================================================
-- 15. BẢNG PHIẾU CHI KHEN THƯỞNG (PhieuChiKhenThuong) - Sinh ra khi chi tiền mặt
-- =========================================================================================
CREATE TABLE PhieuChiKhenThuong (
    SoPhieuChi VARCHAR(30) PRIMARY KEY,
    SoQuyetDinhKT VARCHAR(30) NOT NULL UNIQUE FOREIGN KEY REFERENCES QuyetDinhKhenThuong(SoQuyetDinhKT),
    NgayChi DATE NOT NULL DEFAULT GETDATE(),
    SoTienChi DECIMAL(18, 2) NOT NULL,
    NguoiNhan NVARCHAR(100) NOT NULL,
    NguoiChiTien NVARCHAR(100) NOT NULL DEFAULT N'Thủ quỹ',
    GhiChu NVARCHAR(255) NULL
);
GO

-- =========================================================================================
-- 16. BẢNG QUYẾT ĐỊNH KỶ LUẬT (QuyetDinhKyLuat)
-- =========================================================================================
CREATE TABLE QuyetDinhKyLuat (
    SoQuyetDinhKL VARCHAR(30) PRIMARY KEY,
    NgayQuyetDinh DATE NOT NULL DEFAULT GETDATE(),
    LoaiKyLuat NVARCHAR(50) NOT NULL CHECK (LoaiKyLuat IN (N'Cá nhân', N'Tập thể')),
    MaDoiTuong VARCHAR(20) NOT NULL,
    LyDoKyLuat NVARCHAR(255) NOT NULL,
    HinhThucPhat NVARCHAR(50) NOT NULL CHECK (HinhThucPhat IN (N'Thu tiền nộp phạt', N'Trừ vào bảng lương', N'Khiển trách')),
    SoTienPhat DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TrangThaiThu NVARCHAR(50) NOT NULL DEFAULT N'Chưa thu', -- N'Đã thu', N'Chưa thu', N'Đã trừ lương'
    NguoiKy NVARCHAR(100) NOT NULL DEFAULT N'Giám đốc'
);
GO

-- =========================================================================================
-- 17. BẢNG PHIẾU THU NỘP PHẠT (PhieuThuNopPhat) - Sinh ra khi thu tiền nộp phạt
-- =========================================================================================
CREATE TABLE PhieuThuNopPhat (
    SoPhieuThu VARCHAR(30) PRIMARY KEY,
    SoQuyetDinhKL VARCHAR(30) NOT NULL UNIQUE FOREIGN KEY REFERENCES QuyetDinhKyLuat(SoQuyetDinhKL),
    NgayThu DATE NOT NULL DEFAULT GETDATE(),
    SoTienThu DECIMAL(18, 2) NOT NULL,
    NguoiNop NVARCHAR(100) NOT NULL,
    NguoiThuTien NVARCHAR(100) NOT NULL DEFAULT N'Thủ quỹ',
    GhiChu NVARCHAR(255) NULL
);
GO

-- =========================================================================================
-- 18. BẢNG BẢNG LƯƠNG THÁNG (BangLuongThang)
-- =========================================================================================
CREATE TABLE BangLuongThang (
    MaBangLuong VARCHAR(30) PRIMARY KEY,
    ThangNam VARCHAR(10) NOT NULL, -- '10/2026'
    MaNhanVien VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    LuongCoBan DECIMAL(18, 2) NOT NULL DEFAULT 0,
    LuongThucTeTheoCong DECIMAL(18, 2) NOT NULL DEFAULT 0,
    PhuCapChucVu DECIMAL(18, 2) NOT NULL DEFAULT 0,
    PhuCapDocHai DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TienPhuTroi DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TienKhenThuong DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TienPhatKyLuat DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TienBaoHiem DECIMAL(18, 2) NOT NULL DEFAULT 0,
    ThucLinh DECIMAL(18, 2) NOT NULL DEFAULT 0,
    NgayLap DATE NOT NULL DEFAULT GETDATE(),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đã tính' -- N'Dự thảo', N'Đã tính', N'Đã chi trả'
);
GO

-- =========================================================================================
-- DỮ LIỆU MẪU (SEED DATA)
-- =========================================================================================

-- 1. Phòng ban
INSERT INTO PhongBan (MaPhongBan, TenPhongBan, TruongPhong, DienThoai, DiaDiem) VALUES
('PB_BGD', N'Ban Giám Đốc', N'Nguyễn Văn An', '028.3899.001', N'Tầng 3 - Tòa nhà điều hành'),
('PB_HR', N'Phòng Hành chính - Nhân sự', N'Trần Thị Mai', '028.3899.002', N'Tầng 2 - Tòa nhà điều hành'),
('PB_KT', N'Phòng Tài chính - Kế toán', N'Lê Hoàng Phúc', '028.3899.003', N'Tầng 2 - Tòa nhà điều hành'),
('PB_KCS', N'Phòng Kỹ thuật & Thí nghiệm sơn', N'Phạm Minh Tuấn', '028.3899.004', N'Phòng Lab - Khu B'),
('PB_SX1', N'Phân xưởng Sản xuất sơn gốc', N'Võ Đình Khoa', '028.3899.005', N'Nhà máy số 1 - Khu C'),
('PB_SX2', N'Phân xưởng Pha màu & Đóng gói', N'Đặng Văn Hùng', '028.3899.006', N'Nhà máy số 2 - Khu C');
GO

-- 2. Chức vụ
INSERT INTO ChucVu (MaChucVu, TenChucVu, PhuCapChucVu, MoTa) VALUES
('CV_GD', N'Giám đốc công ty', 5000000, N'Lãnh đạo và đại diện pháp luật'),
('CV_TP', N'Trưởng phòng / Quản đốc xưởng', 2500000, N'Quản lý điều hành phòng ban/phân xưởng'),
('CV_PP', N'Phó phòng / Phó quản đốc', 1500000, N'Hỗ trợ quản lý điều hành'),
('CV_KS', N'Kỹ sư hóa chất / KCS', 1000000, N'Nghiên cứu pha chế và kiểm soát chất lượng'),
('CV_CV', N'Chuyên viên nghiệp vụ', 800000, N'Nhân viên hành chính, kế toán, nhân sự'),
('CV_CN', N'Công nhân sản xuất sơn', 500000, N'Trực tiếp vận hành máy khuấy và pha sơn');
GO

-- 3. Nhân viên
INSERT INTO NhanVien (MaNhanVien, HoTen, NgaySinh, GioiTinh, CCCD, DienThoai, Email, DiaChi, NgayVaoLam, MaPhongBan, MaChucVu, TrangThai) VALUES
('NV001', N'Nguyễn Văn An', '1978-05-12', N'Nam', '079078000001', '0903111222', 'an.nguyen@sondonga.com.vn', N'Quận 1, TP.HCM', '2015-01-10', 'PB_BGD', 'CV_GD', N'Chính thức'),
('NV002', N'Trần Thị Mai', '1985-08-20', N'Nữ', '079085000002', '0903222333', 'mai.tran@sondonga.com.vn', N'Quận Bình Thạnh, TP.HCM', '2017-03-15', 'PB_HR', 'CV_TP', N'Chính thức'),
('NV003', N'Lê Hoàng Phúc', '1987-11-04', N'Nam', '079087000003', '0903333444', 'phuc.le@sondonga.com.vn', N'Quận Tân Bình, TP.HCM', '2018-06-01', 'PB_KT', 'CV_TP', N'Chính thức'),
('NV004', N'Võ Đình Khoa', '1982-03-25', N'Nam', '079082000004', '0903444555', 'khoa.vo@sondonga.com.vn', N'TP. Thủ Đức, TP.HCM', '2016-09-10', 'PB_SX1', 'CV_TP', N'Chính thức'),
('NV005', N'Phạm Minh Tuấn', '1990-12-15', N'Nam', '079090000005', '0903555666', 'tuan.pham@sondonga.com.vn', N'Quận Gò Vấp, TP.HCM', '2019-02-20', 'PB_KCS', 'CV_KS', N'Chính thức'),
('NV006', N'Trần Nguyên', '2004-09-18', N'Nam', '079204000006', '0903666777', 'nguyen.tran@sondonga.com.vn', N'Quận 12, TP.HCM', '2026-08-01', 'PB_SX1', 'CV_CN', N'Chính thức'),
('NV007', N'Lê Văn Hùng', '1995-04-10', N'Nam', '079095000007', '0903777888', 'hung.le@sondonga.com.vn', N'Quận 12, TP.HCM', '2026-09-01', 'PB_SX2', 'CV_CN', N'Chính thức'),
('NV008', N'Đặng Thị Bích', '1998-07-22', N'Nữ', '079098000008', '0903888999', 'bich.dang@sondonga.com.vn', N'Quận Phú Nhuận, TP.HCM', '2026-09-15', 'PB_HR', 'CV_CV', N'Thử việc'),
('NV009', N'Hoàng Văn Thắng', '1996-10-30', N'Nam', '079096000009', '0903999000', 'thang.hoang@sondonga.com.vn', N'Hóc Môn, TP.HCM', '2026-10-01', 'PB_SX1', 'CV_CN', N'Thử việc'),
('NV010', N'Nguyễn Thị Thu', '2000-01-15', N'Nữ', '079200000010', '0903112233', 'thu.nguyen@sondonga.com.vn', N'Quận 3, TP.HCM', '2026-10-05', 'PB_KT', 'CV_CV', N'Thử việc');
GO

-- 4. Quyết định tuyển dụng / Thử việc
INSERT INTO QuyetDinhTuyenDung (SoQuyetDinhTD, MaNhanVien, NgayQuyetDinh, ThoiGianThuViec, LuongThuViec, DieuKhoanThoaThuan, TrangThaiDuyet, NguoiKy) VALUES
('QDTD-2026-006', 'NV006', '2026-08-01', 30, 8500000, N'Thử việc vị trí công nhân sản xuất sơn xưởng 1. Lương thử việc 85% lương chính ngạch.', N'Đã duyệt', N'Nguyễn Văn An'),
('QDTD-2026-007', 'NV007', '2026-09-01', 30, 8500000, N'Thử việc vị trí công nhân pha màu đóng gói. Tuân thủ bảo hộ an toàn.', N'Đã duyệt', N'Nguyễn Văn An'),
('QDTD-2026-008', 'NV008', '2026-09-15', 60, 7650000, N'Thử việc chuyên viên nhân sự (85% lương 9,000,000đ). Thời gian thử việc 60 ngày.', N'Đã duyệt', N'Nguyễn Văn An'),
('QDTD-2026-009', 'NV009', '2026-10-01', 30, 8500000, N'Thử việc công nhân vận hành máy khuấy sơn phân xưởng 1.', N'Đã duyệt', N'Nguyễn Văn An'),
('QDTD-2026-010', 'NV010', '2026-10-05', 60, 7650000, N'Thử việc kế toán viên tiền lương và bảo hiểm.', N'Đã duyệt', N'Nguyễn Văn An');
GO

-- 5. Hợp đồng lao động
INSERT INTO HopDongLaoDong (SoHopDong, MaNhanVien, LoaiHopDong, NgayBatDau, NgayKetThuc, LuongThoaThuan, CoBaoHiem, TrangThai, NguoiKy) VALUES
('HDLD-001', 'NV001', N'Không xác định thời hạn', '2015-01-10', NULL, 35000000, 1, N'Hiệu lực', N'HĐQT'),
('HDLD-002', 'NV002', N'Dài hạn', '2017-03-15', '2027-03-15', 18000000, 1, N'Hiệu lực', N'Nguyễn Văn An'),
('HDLD-003', 'NV003', N'Dài hạn', '2018-06-01', '2028-06-01', 18000000, 1, N'Hiệu lực', N'Nguyễn Văn An'),
('HDLD-004', 'NV004', N'Dài hạn', '2016-09-10', '2026-09-10', 20000000, 1, N'Hiệu lực', N'Nguyễn Văn An'),
('HDLD-005', 'NV005', N'Dài hạn', '2019-02-20', '2025-02-20', 14000000, 1, N'Hiệu lực', N'Nguyễn Văn An'),
('HDLD-006', 'NV006', N'Dài hạn', '2026-09-01', '2029-09-01', 10000000, 1, N'Hiệu lực', N'Nguyễn Văn An'),
('HDLD-007', 'NV007', N'Ngắn hạn', '2026-10-01', '2027-04-01', 10000000, 0, N'Hiệu lực', N'Nguyễn Văn An');
GO

-- 6. Hồ sơ bảo hiểm (chỉ người có HĐ dài hạn)
INSERT INTO HoSoBaoHiem (MaHoSoBH, MaNhanVien, SoTheBHYT, MaSoBHXH, NgayThamGia, MucDongBHXH, TyLeDongNV, TrangThai) VALUES
('BH-001', 'NV001', 'DN479010000001', '7915000001', '2015-01-10', 35000000, 10.5, N'Đang tham gia'),
('BH-002', 'NV002', 'DN479010000002', '7917000002', '2017-03-15', 18000000, 10.5, N'Đang tham gia'),
('BH-003', 'NV003', 'DN479010000003', '7918000003', '2018-06-01', 18000000, 10.5, N'Đang tham gia'),
('BH-004', 'NV004', 'DN479010000004', '7916000004', '2016-09-10', 20000000, 10.5, N'Đang tham gia'),
('BH-005', 'NV005', 'DN479010000005', '7919000005', '2019-02-20', 14000000, 10.5, N'Đang tham gia'),
('BH-006', 'NV006', 'DN479010000006', '7926000006', '2026-09-01', 10000000, 10.5, N'Đang tham gia');
GO

-- 7. Quyết định chức vụ
INSERT INTO QuyetDinhChucVu (SoQuyetDinhCV, MaNhanVien, MaChucVu, PhuCapChucVu, NgayHieuLuc, LyDoBoNhiem, NguoiKy) VALUES
('QDCV-001', 'NV001', 'CV_GD', 5000000, '2015-01-10', N'Bổ nhiệm Giám đốc công ty', N'HĐQT'),
('QDCV-002', 'NV002', 'CV_TP', 2500000, '2017-03-15', N'Bổ nhiệm Trưởng phòng Nhân sự', N'Nguyễn Văn An'),
('QDCV-003', 'NV003', 'CV_TP', 2500000, '2018-06-01', N'Bổ nhiệm Kế toán trưởng', N'Nguyễn Văn An'),
('QDCV-004', 'NV004', 'CV_TP', 2500000, '2016-09-10', N'Bổ nhiệm Quản đốc phân xưởng sản xuất sơn', N'Nguyễn Văn An'),
('QDCV-005', 'NV005', 'CV_KS', 1000000, '2019-02-20', N'Bổ nhiệm Kỹ sư trưởng phòng KCS', N'Nguyễn Văn An'),
('QDCV-006', 'NV006', 'CV_CN', 500000, '2026-09-01', N'Công nhận công nhân chính thức bậc 2', N'Nguyễn Văn An'),
('QDCV-007', 'NV007', 'CV_CN', 500000, '2026-10-01', N'Công nhận công nhân đóng gói chính thức', N'Nguyễn Văn An');
GO

-- 8. Quyết định lương & Phụ cấp độc hại (Công nhân xưởng sơn tiếp xúc hóa chất dung môi)
INSERT INTO QuyetDinhLuong (SoQuyetDinhL, MaNhanVien, LuongCoBan, PhuCapLuong, PhuCapDocHai, NgayHieuLuc, NguoiKy) VALUES
('QDL-001', 'NV001', 35000000, 5000000, 0, '2026-01-01', N'HĐQT'),
('QDL-002', 'NV002', 18000000, 2000000, 0, '2026-01-01', N'Nguyễn Văn An'),
('QDL-003', 'NV003', 18000000, 2000000, 0, '2026-01-01', N'Nguyễn Văn An'),
('QDL-004', 'NV004', 20000000, 2500000, 1500000, '2026-01-01', N'Nguyễn Văn An'), -- Quản đốc xưởng sơn: Độc hại 1.5tr
('QDL-005', 'NV005', 14000000, 1500000, 1000000, '2026-01-01', N'Nguyễn Văn An'), -- Kỹ sư Lab sơn: Độc hại 1.0tr
('QDL-006', 'NV006', 10000000, 1000000, 1200000, '2026-09-01', N'Nguyễn Văn An'), -- Trần Nguyên: Độc hại xưởng 1: 1.2tr
('QDL-007', 'NV007', 10000000, 1000000, 800000, '2026-10-01', N'Nguyễn Văn An');   -- Công nhân đóng gói: Độc hại 800k
GO

-- 9. Kế hoạch phân ca tuần (Tuần 42/2026)
INSERT INTO KeHoachPhanCa (MaKeHoach, TuanThu, TuNgay, DenNgay, MaPhongBan, NguoiLap, NgayLap, GhiChu) VALUES
('KHPC-T42-SX1', 42, '2026-10-19', '2026-10-25', 'PB_SX1', N'Võ Đình Khoa', '2026-10-17', N'Kế hoạch sản xuất lô sơn công nghiệp cao cấp'),
('KHPC-T42-SX2', 42, '2026-10-19', '2026-10-25', 'PB_SX2', N'Đặng Văn Hùng', '2026-10-17', N'Đóng gói thùng 18L và lon 5L');
GO

-- 10. Chi tiết phân ca
INSERT INTO ChiTietPhanCa (MaKeHoach, MaNhanVien, ThuTrongTuan, CaLamViec, GioBatDau, GioKetThuc, CoPhuTroi) VALUES
('KHPC-T42-SX1', 'NV006', N'Thứ Hai', N'Ca 1 (Sáng)', '06:00:00', '14:00:00', 0),
('KHPC-T42-SX1', 'NV006', N'Thứ Ba', N'Ca 1 (Sáng)', '06:00:00', '14:00:00', 1), -- Có phụ trội 2h
('KHPC-T42-SX1', 'NV006', N'Thứ Tư', N'Ca 1 (Sáng)', '06:00:00', '14:00:00', 0),
('KHPC-T42-SX1', 'NV006', N'Thứ Năm', N'Ca 2 (Chiều)', '14:00:00', '22:00:00', 0),
('KHPC-T42-SX1', 'NV006', N'Thứ Sáu', N'Ca 2 (Chiều)', '14:00:00', '22:00:00', 1), -- Có phụ trội 3h
('KHPC-T42-SX1', 'NV006', N'Thứ Bảy', N'Ca 1 (Sáng)', '06:00:00', '14:00:00', 0),
('KHPC-T42-SX1', 'NV004', N'Thứ Hai', N'Ca Hành chính', '08:00:00', '17:00:00', 0),
('KHPC-T42-SX2', 'NV007', N'Thứ Hai', N'Ca 1 (Sáng)', '06:00:00', '14:00:00', 1);
GO

-- 11. Phiếu phụ trội / Tăng ca
INSERT INTO PhieuPhuTroi (SoPhieuPT, NgayPhuTroi, HinhThucPhuTroi, HeSoPhuTroi, NguoiLap, TrangThaiDuyet) VALUES
('PT-20261020', '2026-10-20', N'Tăng ca ngày thường', 1.5, N'Ban chấm công', N'Đã duyệt'),
('PT-20261023', '2026-10-23', N'Tăng ca ngày thường', 1.5, N'Ban chấm công', N'Đã duyệt'),
('PT-20261025', '2026-10-25', N'Ngày nghỉ', 2.0, N'Ban chấm công', N'Đã duyệt');
GO

-- 12. Chi tiết phiếu phụ trội
INSERT INTO ChiTietPhuTroi (SoPhieuPT, MaNhanVien, SoGioPhuTroi, NoiDungCongViec, GhiChu) VALUES
('PT-20261020', 'NV006', 2.5, N'Vận hành máy nghiền sơn mầu vàng nghệ xuất khẩu', N'Hoàn thành vượt tiến độ'),
('PT-20261020', 'NV004', 2.0, N'Giám sát an toàn kỹ thuật mẻ sơn chống rỉ', N'Đạt yêu cầu'),
('PT-20261023', 'NV006', 3.0, N'Pha chế mẻ sơn lót gốc dầu chống thấm', N'OT ngày thứ sáu'),
('PT-20261023', 'NV007', 2.5, N'Đóng gói 200 thùng sơn Epoxy giao công trình', N'Kịp tiến độ giao xe'),
('PT-20261025', 'NV006', 4.0, N'Làm thêm chủ nhật vệ sinh bồn chứa dung môi', N'Tính hệ số 2.0');
GO

-- 13. Bảng chấm công tháng 10/2026
INSERT INTO BangChamCong (MaChamCong, ThangNam, MaNhanVien, SoNgayCongChuan, SoNgayLamThucTe, SoNgayNghiCoPhep, SoNgayNghiKhongPhep, TongGioPhuTroi, TrangThai) VALUES
('CC-102026-NV001', '10/2026', 'NV001', 26.0, 26.0, 0, 0, 0, N'Đã khóa công'),
('CC-102026-NV002', '10/2026', 'NV002', 26.0, 25.0, 1.0, 0, 0, N'Đã khóa công'),
('CC-102026-NV003', '10/2026', 'NV003', 26.0, 26.0, 0, 0, 0, N'Đã khóa công'),
('CC-102026-NV004', '10/2026', 'NV004', 26.0, 26.0, 0, 0, 10.0, N'Đã khóa công'),
('CC-102026-NV005', '10/2026', 'NV005', 26.0, 26.0, 0, 0, 5.0, N'Đã khóa công'),
('CC-102026-NV006', '10/2026', 'NV006', 26.0, 26.0, 0, 0, 17.5, N'Đã khóa công'), -- Trần Nguyên: 17.5h OT
('CC-102026-NV007', '10/2026', 'NV007', 26.0, 24.0, 2.0, 0, 12.0, N'Đã khóa công'),
('CC-102026-NV008', '10/2026', 'NV008', 26.0, 26.0, 0, 0, 0, N'Đã khóa công'),
('CC-102026-NV009', '10/2026', 'NV009', 26.0, 25.0, 1.0, 0, 8.0, N'Đã khóa công'),
('CC-102026-NV010', '10/2026', 'NV010', 26.0, 26.0, 0, 0, 0, N'Đã khóa công');
GO

-- 14. Quyết định khen thưởng
INSERT INTO QuyetDinhKhenThuong (SoQuyetDinhKT, NgayQuyetDinh, LoaiKhenThuong, MaDoiTuong, LyDoKhenThuong, SoTienThuong, HinhThucChi, TrangThaiChi, NguoiKy) VALUES
('QDKT-2026-001', '2026-10-15', N'Cá nhân', 'NV006', N'Sáng kiến cải tiến van xả máy khuấy sơn giảm thất thoát dung môi', 2000000, N'Chi tiền mặt', N'Đã chi', N'Nguyễn Văn An'),
('QDKT-2026-002', '2026-10-20', N'Tập thể', 'PB_SX1', N'Hoàn thành xuất sắc chỉ tiêu sản xuất quý 3 trước hạn 10 ngày', 10000000, N'Chi tiền mặt', N'Đã chi', N'Nguyễn Văn An'),
('QDKT-2026-003', '2026-10-25', N'Cá nhân', 'NV006', N'Thưởng năng suất hoàn thành vượt mức kế hoạch tuần 42', 1500000, N'Cộng vào bảng lương', N'Chờ tính lương', N'Nguyễn Văn An'),
('QDKT-2026-004', '2026-10-25', N'Cá nhân', 'NV004', N'Trách nhiệm cao đảm bảo an toàn PCCC xưởng sản xuất sơn', 2000000, N'Cộng vào bảng lương', N'Chờ tính lương', N'Nguyễn Văn An');
GO

-- 15. Phiếu chi khen thưởng (cho các quyết định chọn Chi tiền mặt)
INSERT INTO PhieuChiKhenThuong (SoPhieuChi, SoQuyetDinhKT, NgayChi, SoTienChi, NguoiNhan, NguoiChiTien, GhiChu) VALUES
('PCKT-2026-001', 'QDKT-2026-001', '2026-10-16', 2000000, N'Trần Nguyên', N'Thủ quỹ - Nguyễn Thị Lan', N'Đã chi tiền mặt trực tiếp tại phòng kế toán'),
('PCKT-2026-002', 'QDKT-2026-002', '2026-10-21', 10000000, N'Võ Đình Khoa (Đại diện PB_SX1)', N'Thủ quỹ - Nguyễn Thị Lan', N'Đã chi tiền mặt thưởng tập thể xưởng 1');
GO

-- 16. Quyết định kỷ luật
INSERT INTO QuyetDinhKyLuat (SoQuyetDinhKL, NgayQuyetDinh, LoaiKyLuat, MaDoiTuong, LyDoKyLuat, HinhThucPhat, SoTienPhat, TrangThaiThu, NguoiKy) VALUES
('QDKL-2026-001', '2026-10-18', N'Cá nhân', 'NV007', N'Không mang mặt nạ phòng độc khi mở van xả dung môi hữu cơ', N'Thu tiền nộp phạt', 500000, N'Đã thu', N'Nguyễn Văn An'),
('QDKL-2026-002', '2026-10-22', N'Cá nhân', 'NV009', N'Đi làm trễ 3 lần trong tuần không có lý do chính đáng', N'Trừ vào bảng lương', 300000, N'Chờ trừ lương', N'Nguyễn Văn An');
GO

-- 17. Phiếu thu nộp phạt (khi nộp tiền mặt)
INSERT INTO PhieuThuNopPhat (SoPhieuThu, SoQuyetDinhKL, NgayThu, SoTienThu, NguoiNop, NguoiThuTien, GhiChu) VALUES
('PTNP-2026-001', 'QDKL-2026-001', '2026-10-19', 500000, N'Lê Văn Hùng', N'Thủ quỹ - Nguyễn Thị Lan', N'Đã nộp phạt trực tiếp vào quỹ an toàn');
GO

-- 18. Bảng lương tháng 10/2026 (Đã tính tự động)
-- Công thức:
-- Lương 1 giờ bình thường = LươngCoBan / 26 / 8
-- Tiền phụ trội = SoGioPT * (LuongCoBan / 26 / 8) * HeSo (1.5)
-- Thực lĩnh = LươngThựcTế + PhụCấpCV + PhụCấpĐộcHại + TiềnPhụTrội + ThưởngCộngLương - PhạtTrừLương - TiềnBảoHiểm (10.5% nếu có BH)
INSERT INTO BangLuongThang (MaBangLuong, ThangNam, MaNhanVien, LuongCoBan, LuongThucTeTheoCong, PhuCapChucVu, PhuCapDocHai, TienPhuTroi, TienKhenThuong, TienPhatKyLuat, TienBaoHiem, ThucLinh, NgayLap, TrangThai) VALUES
('BL-102026-NV001', '10/2026', 'NV001', 35000000, 35000000, 5000000, 0, 0, 0, 0, 3675000, 36325000, '2026-10-26', N'Đã tính'),
('CC-102026-NV004', '10/2026', 'NV004', 20000000, 20000000, 2500000, 1500000, 1442308, 2000000, 0, 2100000, 25342308, '2026-10-26', N'Đã tính'),
('CC-102026-NV006', '10/2026', 'NV006', 10000000, 10000000, 500000, 1200000, 1262019, 1500000, 0, 1050000, 13412019, '2026-10-26', N'Đã tính'); -- Trần Nguyên
GO

-- =========================================================================================
-- STORED PROCEDURES (THỦ TỤC NGHIỆP VỤ CÓ GIAO TÁC TRANSACTION)
-- =========================================================================================

-- 1. Thủ tục lập quyết định khen thưởng (Khớp với Sequence Diagram Câu 6)
CREATE OR ALTER PROCEDURE sp_LapQuyetDinhKhenThuong
    @SoQuyetDinhKT VARCHAR(30),
    @LoaiKhenThuong NVARCHAR(50),
    @MaDoiTuong VARCHAR(20),
    @LyDoKhenThuong NVARCHAR(255),
    @SoTienThuong DECIMAL(18, 2),
    @HinhThucChi NVARCHAR(50),
    @NguoiKy NVARCHAR(100),
    @MaPhieuChi VARCHAR(30) = NULL,
    @NguoiNhan NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- 1. Kiểm tra tồn tại mã quyết định
        IF EXISTS (SELECT 1 FROM QuyetDinhKhenThuong WHERE SoQuyetDinhKT = @SoQuyetDinhKT)
        BEGIN
            RAISERROR(N'Số quyết định khen thưởng đã tồn tại trong hệ thống!', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- 2. Thêm quyết định khen thưởng
        INSERT INTO QuyetDinhKhenThuong (SoQuyetDinhKT, NgayQuyetDinh, LoaiKhenThuong, MaDoiTuong, LyDoKhenThuong, SoTienThuong, HinhThucChi, TrangThaiChi, NguoiKy)
        VALUES (@SoQuyetDinhKT, GETDATE(), @LoaiKhenThuong, @MaDoiTuong, @LyDoKhenThuong, @SoTienThuong, @HinhThucChi, 
                CASE WHEN @HinhThucChi = N'Chi tiền mặt' THEN N'Đã chi' ELSE N'Chờ tính lương' END, @NguoiKy);

        -- 3. Rẽ nhánh theo hình thức chi (Khung ALT trong Sequence Diagram Câu 6)
        IF (@HinhThucChi = N'Chi tiền mặt')
        BEGIN
            IF (@MaPhieuChi IS NULL OR @MaPhieuChi = '')
            BEGIN
                SET @MaPhieuChi = 'PCKT-' + REPLACE(CONVERT(VARCHAR(10), GETDATE(), 112) + RIGHT(REPLACE(@SoQuyetDinhKT, '-', ''), 4), ' ', '');
            END
            
            IF (@NguoiNhan IS NULL OR @NguoiNhan = '')
            BEGIN
                IF (@LoaiKhenThuong = N'Cá nhân')
                    SELECT @NguoiNhan = HoTen FROM NhanVien WHERE MaNhanVien = @MaDoiTuong;
                ELSE
                    SELECT @NguoiNhan = N'Đại diện ' + TenPhongBan FROM PhongBan WHERE MaPhongBan = @MaDoiTuong;
            END

            INSERT INTO PhieuChiKhenThuong (SoPhieuChi, SoQuyetDinhKT, NgayChi, SoTienChi, NguoiNhan, NguoiChiTien, GhiChu)
            VALUES (@MaPhieuChi, @SoQuyetDinhKT, GETDATE(), @SoTienThuong, ISNULL(@NguoiNhan, N'Người nhận'), N'Thủ quỹ', N'Tự động xuất phiếu chi tiền mặt theo QĐ');
        END

        COMMIT TRANSACTION;
        SELECT 1 AS Status, N'Lập quyết định khen thưởng thành công!' AS Message;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 0 AS Status, ERROR_MESSAGE() AS Message;
    END CATCH
END;
GO

-- 2. Thủ tục tính bảng lương tháng tự động (Khớp với nghiệp vụ toàn bài)
CREATE OR ALTER PROCEDURE sp_TinhBangLuongThang
    @ThangNam VARCHAR(10), -- '10/2026'
    @MaNhanVien VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @LuongCoBan DECIMAL(18, 2) = 0;
        DECLARE @PhuCapChucVu DECIMAL(18, 2) = 0;
        DECLARE @PhuCapDocHai DECIMAL(18, 2) = 0;
        DECLARE @SoNgayCongChuan DECIMAL(4, 1) = 26.0;
        DECLARE @SoNgayLamThucTe DECIMAL(4, 1) = 0;
        DECLARE @TongGioPhuTroi DECIMAL(5, 1) = 0;
        DECLARE @TienPhuTroi DECIMAL(18, 2) = 0;
        DECLARE @TienKhenThuong DECIMAL(18, 2) = 0;
        DECLARE @TienPhatKyLuat DECIMAL(18, 2) = 0;
        DECLARE @TienBaoHiem DECIMAL(18, 2) = 0;
        DECLARE @LuongThucTeTheoCong DECIMAL(18, 2) = 0;
        DECLARE @ThucLinh DECIMAL(18, 2) = 0;
        DECLARE @CoBaoHiem BIT = 0;
        DECLARE @MaBangLuong VARCHAR(30) = 'BL-' + REPLACE(@ThangNam, '/', '') + '-' + @MaNhanVien;

        -- 1. Lấy thông tin lương & phụ cấp độc hại từ Quyết định lương mới nhất
        SELECT TOP 1 @LuongCoBan = LuongCoBan, @PhuCapDocHai = PhuCapDocHai
        FROM QuyetDinhLuong
        WHERE MaNhanVien = @MaNhanVien
        ORDER BY NgayHieuLuc DESC;

        -- Nếu không có QĐ lương riêng, lấy lương thỏa thuận từ HĐLĐ hoặc QĐ thử việc
        IF (@LuongCoBan = 0)
        BEGIN
            SELECT TOP 1 @LuongCoBan = LuongThoaThuan, @CoBaoHiem = CoBaoHiem
            FROM HopDongLaoDong
            WHERE MaNhanVien = @MaNhanVien AND TrangThai = N'Hiệu lực'
            ORDER BY NgayBatDau DESC;

            IF (@LuongCoBan = 0)
            BEGIN
                SELECT TOP 1 @LuongCoBan = LuongThuViec
                FROM QuyetDinhTuyenDung
                WHERE MaNhanVien = @MaNhanVien
                ORDER BY NgayQuyetDinh DESC;
            END
        END
        ELSE
        BEGIN
            SELECT TOP 1 @CoBaoHiem = CoBaoHiem
            FROM HopDongLaoDong
            WHERE MaNhanVien = @MaNhanVien AND TrangThai = N'Hiệu lực'
            ORDER BY NgayBatDau DESC;
        END

        -- 2. Lấy phụ cấp chức vụ
        SELECT TOP 1 @PhuCapChucVu = PhuCapChucVu
        FROM QuyetDinhChucVu
        WHERE MaNhanVien = @MaNhanVien
        ORDER BY NgayHieuLuc DESC;

        -- 3. Lấy dữ liệu chấm công tháng
        SELECT TOP 1 
            @SoNgayCongChuan = ISNULL(SoNgayCongChuan, 26.0),
            @SoNgayLamThucTe = ISNULL(SoNgayLamThucTe, 0),
            @TongGioPhuTroi = ISNULL(TongGioPhuTroi, 0)
        FROM BangChamCong
        WHERE MaNhanVien = @MaNhanVien AND ThangNam = @ThangNam;

        -- Tính lương thực tế theo ngày công
        IF (@SoNgayCongChuan > 0)
            SET @LuongThucTeTheoCong = ROUND((@LuongCoBan / @SoNgayCongChuan) * @SoNgayLamThucTe, 0);
        ELSE
            SET @LuongThucTeTheoCong = @LuongCoBan;

        -- 4. Tính tiền phụ trội (giờ tăng ca x 1.5 ngày thường)
        IF (@SoNgayCongChuan > 0)
        BEGIN
            DECLARE @Luong1Gio DECIMAL(18, 4) = (@LuongCoBan / @SoNgayCongChuan / 8.0);
            SET @TienPhuTroi = ROUND(@TongGioPhuTroi * @Luong1Gio * 1.5, 0);
        END

        -- 5. Lấy tiền khen thưởng (chỉ tính những quyết định chọn 'Cộng vào bảng lương')
        SELECT @TienKhenThuong = ISNULL(SUM(SoTienThuong), 0)
        FROM QuyetDinhKhenThuong
        WHERE MaDoiTuong = @MaNhanVien 
          AND HinhThucChi = N'Cộng vào bảng lương' 
          AND MONTH(NgayQuyetDinh) = CAST(LEFT(@ThangNam, 2) AS INT)
          AND YEAR(NgayQuyetDinh) = CAST(RIGHT(@ThangNam, 4) AS INT);

        -- 6. Lấy tiền phạt kỷ luật (chỉ tính những quyết định chọn 'Trừ vào bảng lương')
        SELECT @TienPhatKyLuat = ISNULL(SUM(SoTienPhat), 0)
        FROM QuyetDinhKyLuat
        WHERE MaDoiTuong = @MaNhanVien 
          AND HinhThucPhat = N'Trừ vào bảng lương' 
          AND MONTH(NgayQuyetDinh) = CAST(LEFT(@ThangNam, 2) AS INT)
          AND YEAR(NgayQuyetDinh) = CAST(RIGHT(@ThangNam, 4) AS INT);

        -- 7. Tính bảo hiểm (10.5% mức đóng BHXH nếu là HĐ dài hạn có bảo hiểm)
        IF (@CoBaoHiem = 1)
        BEGIN
            DECLARE @MucDongBH DECIMAL(18, 2) = 0;
            SELECT TOP 1 @MucDongBH = MucDongBHXH FROM HoSoBaoHiem WHERE MaNhanVien = @MaNhanVien AND TrangThai = N'Đang tham gia';
            IF (@MucDongBH = 0) SET @MucDongBH = @LuongCoBan;
            SET @TienBaoHiem = ROUND(@MucDongBH * 0.105, 0);
        END
        ELSE
        BEGIN
            SET @TienBaoHiem = 0;
        END

        -- 8. Tính thực lĩnh
        SET @ThucLinh = @LuongThucTeTheoCong + @PhuCapChucVu + @PhuCapDocHai + @TienPhuTroi + @TienKhenThuong - @TienPhatKyLuat - @TienBaoHiem;

        -- 9. Lưu vào bảng BangLuongThang (Insert hoặc Update)
        IF EXISTS (SELECT 1 FROM BangLuongThang WHERE MaBangLuong = @MaBangLuong)
        BEGIN
            UPDATE BangLuongThang
            SET LuongCoBan = @LuongCoBan,
                LuongThucTeTheoCong = @LuongThucTeTheoCong,
                PhuCapChucVu = @PhuCapChucVu,
                PhuCapDocHai = @PhuCapDocHai,
                TienPhuTroi = @TienPhuTroi,
                TienKhenThuong = @TienKhenThuong,
                TienPhatKyLuat = @TienPhatKyLuat,
                TienBaoHiem = @TienBaoHiem,
                ThucLinh = @ThucLinh,
                NgayLap = GETDATE(),
                TrangThai = N'Đã tính'
            WHERE MaBangLuong = @MaBangLuong;
        END
        ELSE
        BEGIN
            INSERT INTO BangLuongThang (MaBangLuong, ThangNam, MaNhanVien, LuongCoBan, LuongThucTeTheoCong, PhuCapChucVu, PhuCapDocHai, TienPhuTroi, TienKhenThuong, TienPhatKyLuat, TienBaoHiem, ThucLinh, NgayLap, TrangThai)
            VALUES (@MaBangLuong, @ThangNam, @MaNhanVien, @LuongCoBan, @LuongThucTeTheoCong, @PhuCapChucVu, @PhuCapDocHai, @TienPhuTroi, @TienKhenThuong, @TienPhatKyLuat, @TienBaoHiem, @ThucLinh, GETDATE(), N'Đã tính');
        END

        COMMIT TRANSACTION;
        SELECT 1 AS Status, N'Tính lương thành công!' AS Message, @ThucLinh AS ThucLinh;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 0 AS Status, ERROR_MESSAGE() AS Message, 0 AS ThucLinh;
    END CATCH
END;
GO

PRINT N'Cơ sở dữ liệu QuanLyNhanSu_SonDongA đã được tạo và khởi tạo dữ liệu mẫu thành công 100%!';
GO
