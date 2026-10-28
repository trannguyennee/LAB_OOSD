-- =========================================================================================
-- BÀI LAB 08: PHƯƠNG PHÁP PHÁT TRIỂN PHẦN MỀM HƯỚNG ĐỐI TƯỢNG (OOSD)
-- ĐỀ TÀI: HỆ THỐNG QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT (BÀI 2)
-- Sinh viên: Trần Nguyên - MSSV: 1250080121 - Lớp: 12_ĐH_CNPM2
-- CSDL: SQL Server - Thiết kế nhất quán 100% với Mô hình lớp (Class Diagram 13 Bảng)
-- =========================================================================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyCuaHangNGK')
BEGIN
    ALTER DATABASE QuanLyCuaHangNGK SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyCuaHangNGK;
END
GO

CREATE DATABASE QuanLyCuaHangNGK;
GO

USE QuanLyCuaHangNGK;
GO

-- -----------------------------------------------------------------------------------------
-- 1. BẢNG NHÀ CUNG ỨNG (NhaCungUng)
-- -----------------------------------------------------------------------------------------
CREATE TABLE NhaCungUng (
    MaNCU VARCHAR(20) PRIMARY KEY,
    TenNCU NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200) NOT NULL,
    SoDT VARCHAR(15) NOT NULL
);
GO

-- -----------------------------------------------------------------------------------------
-- 2. BẢNG LOẠI NƯỚC GIẢI KHÁT (LoaiNGK)
-- Ràng buộc nghiệp vụ: Mỗi loại NGK chỉ được nhập từ một nhà cung ứng duy nhất.
-- -----------------------------------------------------------------------------------------
CREATE TABLE LoaiNGK (
    MaLoai VARCHAR(20) PRIMARY KEY,
    TenLoai NVARCHAR(100) NOT NULL,
    MaNCU VARCHAR(20) NOT NULL,
    CONSTRAINT FK_LoaiNGK_NhaCungUng FOREIGN KEY (MaNCU) REFERENCES NhaCungUng(MaNCU)
);
GO

-- -----------------------------------------------------------------------------------------
-- 3. BẢNG NƯỚC GIẢI KHÁT (NuocGiaiKhat)
-- -----------------------------------------------------------------------------------------
CREATE TABLE NuocGiaiKhat (
    MaNGK VARCHAR(20) PRIMARY KEY,
    TenNGK NVARCHAR(100) NOT NULL,
    DonViTinh NVARCHAR(20) NOT NULL,
    SoLuongTon INT NOT NULL DEFAULT 0 CHECK (SoLuongTon >= 0),
    DonGiaBan DECIMAL(18, 2) NOT NULL DEFAULT 0 CHECK (DonGiaBan >= 0),
    MaLoai VARCHAR(20) NOT NULL,
    CONSTRAINT FK_NuocGiaiKhat_LoaiNGK FOREIGN KEY (MaLoai) REFERENCES LoaiNGK(MaLoai)
);
GO

-- -----------------------------------------------------------------------------------------
-- 4. BẢNG NHÂN VIÊN (NhanVien)
-- -----------------------------------------------------------------------------------------
CREATE TABLE NhanVien (
    MaNV VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    ChucVu NVARCHAR(50) NOT NULL,
    SoDT VARCHAR(15) NOT NULL,
    TaiKhoan VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(50) NOT NULL
);
GO

-- -----------------------------------------------------------------------------------------
-- 5. BẢNG KHÁCH HÀNG (KhachHang)
-- Ràng buộc: LoaiKH chỉ gồm 'KhachQuen' hoặc 'KhachVangLai'
-- -----------------------------------------------------------------------------------------
CREATE TABLE KhachHang (
    MaKH VARCHAR(20) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200) NOT NULL,
    SoDT VARCHAR(15) NOT NULL,
    LoaiKH VARCHAR(20) NOT NULL CHECK (LoaiKH IN ('KhachQuen', 'KhachVangLai')),
    TongNo DECIMAL(18, 2) NOT NULL DEFAULT 0 CHECK (TongNo >= 0)
);
GO

-- -----------------------------------------------------------------------------------------
-- 6. BẢNG ĐƠN ĐẶT HÀNG (DonDatHang)
-- Ràng buộc: Mỗi ĐĐH gởi đến một NCC, giao tối đa 3 đợt.
-- -----------------------------------------------------------------------------------------
CREATE TABLE DonDatHang (
    SoDDH VARCHAR(20) PRIMARY KEY,
    NgayDat DATETIME NOT NULL DEFAULT GETDATE(),
    NgayNhan DATETIME NOT NULL,
    TongSoLuongDat INT NOT NULL DEFAULT 0 CHECK (TongSoLuongDat >= 0),
    SoDotDaGiao INT NOT NULL DEFAULT 0 CHECK (SoDotDaGiao BETWEEN 0 AND 3),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đang xử lý',
    MaNCU VARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    CONSTRAINT FK_DDH_NhaCungUng FOREIGN KEY (MaNCU) REFERENCES NhaCungUng(MaNCU),
    CONSTRAINT FK_DDH_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

-- -----------------------------------------------------------------------------------------
-- 7. BẢNG CHI TIẾT ĐƠN ĐẶT HÀNG (ChiTietDDH)
-- -----------------------------------------------------------------------------------------
CREATE TABLE ChiTietDDH (
    SoDDH VARCHAR(20) NOT NULL,
    MaNGK VARCHAR(20) NOT NULL,
    SoLuongDat INT NOT NULL CHECK (SoLuongDat > 0),
    DonGiaNhap DECIMAL(18, 2) NOT NULL DEFAULT 0 CHECK (DonGiaNhap >= 0),
    CONSTRAINT PK_ChiTietDDH PRIMARY KEY (SoDDH, MaNGK),
    CONSTRAINT FK_CTDDH_DonDatHang FOREIGN KEY (SoDDH) REFERENCES DonDatHang(SoDDH),
    CONSTRAINT FK_CTDDH_NuocGiaiKhat FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);
GO

-- -----------------------------------------------------------------------------------------
-- 8. BẢNG PHIẾU GIAO HÀNG (PhieuGiaoHang)
-- Ràng buộc nghiệp vụ: Mỗi ĐĐH giao tối đa 3 đợt (DotGiao BETWEEN 1 AND 3).
-- -----------------------------------------------------------------------------------------
CREATE TABLE PhieuGiaoHang (
    SoPGH VARCHAR(20) PRIMARY KEY,
    NgayGiao DATETIME NOT NULL DEFAULT GETDATE(),
    SoTienPhaiTra DECIMAL(18, 2) NOT NULL DEFAULT 0 CHECK (SoTienPhaiTra >= 0),
    DotGiao INT NOT NULL CHECK (DotGiao BETWEEN 1 AND 3),
    SoDDH VARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    CONSTRAINT FK_PGH_DonDatHang FOREIGN KEY (SoDDH) REFERENCES DonDatHang(SoDDH),
    CONSTRAINT FK_PGH_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

-- -----------------------------------------------------------------------------------------
-- 9. BẢNG CHI TIẾT PHIẾU GIAO HÀNG (ChiTietPGH)
-- -----------------------------------------------------------------------------------------
CREATE TABLE ChiTietPGH (
    SoPGH VARCHAR(20) NOT NULL,
    MaNGK VARCHAR(20) NOT NULL,
    SoLuongGiao INT NOT NULL CHECK (SoLuongGiao > 0),
    DonGia DECIMAL(18, 2) NOT NULL DEFAULT 0 CHECK (DonGia >= 0),
    CONSTRAINT PK_ChiTietPGH PRIMARY KEY (SoPGH, MaNGK),
    CONSTRAINT FK_CTPGH_PhieuGiaoHang FOREIGN KEY (SoPGH) REFERENCES PhieuGiaoHang(SoPGH),
    CONSTRAINT FK_CTPGH_NuocGiaiKhat FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);
GO

-- -----------------------------------------------------------------------------------------
-- 10. BẢNG HÓA ĐƠN (HoaDon)
-- -----------------------------------------------------------------------------------------
CREATE TABLE HoaDon (
    SoHD VARCHAR(20) PRIMARY KEY,
    NgayLap DATETIME NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(18, 2) NOT NULL DEFAULT 0 CHECK (TongTien >= 0),
    HinhThucThanhToan NVARCHAR(50) NOT NULL DEFAULT N'Tiền mặt',
    DaThanhToan BIT NOT NULL DEFAULT 1,
    MaKH VARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

-- -----------------------------------------------------------------------------------------
-- 11. BẢNG CHI TIẾT HÓA ĐƠN (ChiTietHoaDon)
-- -----------------------------------------------------------------------------------------
CREATE TABLE ChiTietHoaDon (
    SoHD VARCHAR(20) NOT NULL,
    MaNGK VARCHAR(20) NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18, 2) NOT NULL DEFAULT 0 CHECK (DonGia >= 0),
    ThanhTien AS (SoLuong * DonGia),
    CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY (SoHD, MaNGK),
    CONSTRAINT FK_CTHD_HoaDon FOREIGN KEY (SoHD) REFERENCES HoaDon(SoHD),
    CONSTRAINT FK_CTHD_NuocGiaiKhat FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);
GO

-- -----------------------------------------------------------------------------------------
-- 12. BẢNG PHIẾU HẸN (PhieuHen)
-- Ràng buộc nghiệp vụ: Chỉ phát sinh khi thiếu hàng đối với Khách quen.
-- -----------------------------------------------------------------------------------------
CREATE TABLE PhieuHen (
    SoPH VARCHAR(20) PRIMARY KEY,
    NgayHenGiao DATETIME NOT NULL,
    DotGiaoHen INT NOT NULL CHECK (DotGiaoHen >= 1),
    SoLuongHen INT NOT NULL CHECK (SoLuongHen > 0),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Chờ giao',
    SoHD VARCHAR(20) NOT NULL,
    MaNGK VARCHAR(20) NOT NULL,
    CONSTRAINT FK_PhieuHen_HoaDon FOREIGN KEY (SoHD) REFERENCES HoaDon(SoHD),
    CONSTRAINT FK_PhieuHen_NuocGiaiKhat FOREIGN KEY (MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);
GO

-- -----------------------------------------------------------------------------------------
-- 13. BẢNG PHIẾU GHI NỢ (PhieuGhiNo)
-- Ràng buộc nghiệp vụ: Chỉ áp dụng cho Khách quen trả chậm.
-- -----------------------------------------------------------------------------------------
CREATE TABLE PhieuGhiNo (
    SoPGN VARCHAR(20) PRIMARY KEY,
    NgayLap DATETIME NOT NULL DEFAULT GETDATE(),
    SoTienNo DECIMAL(18, 2) NOT NULL CHECK (SoTienNo > 0),
    NgayDuKienTra DATETIME NOT NULL,
    LyDoNo NVARCHAR(200) NOT NULL,
    DaTra BIT NOT NULL DEFAULT 0,
    SoHD VARCHAR(20) NOT NULL,
    MaKH VARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    CONSTRAINT FK_PhieuGhiNo_HoaDon FOREIGN KEY (SoHD) REFERENCES HoaDon(SoHD),
    CONSTRAINT FK_PhieuGhiNo_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_PhieuGhiNo_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

-- =========================================================================================
-- NẠP DỮ LIỆU MẪU BAN ĐẦU (SEED DATA CHO KIỂM THỬ)
-- =========================================================================================

-- 1. Nhà cung ứng
INSERT INTO NhaCungUng (MaNCU, TenNCU, DiaChi, SoDT) VALUES
('NCU01', N'Công ty TNHH Nước giải khát Suntory PepsiCo Việt Nam', N'Cao ốc Sheraton, 88 Đồng Khởi, Q.1, TP.HCM', '02838219999'),
('NCU02', N'Công ty TNHH Nước giải khát Coca-Cola Việt Nam', N'Xa lộ Hà Nội, Phường Linh Trung, TP. Thủ Đức, TP.HCM', '02838961000'),
('NCU03', N'Tổng công ty Cổ phần Bia - Rượu - Nước giải khát Sài Gòn (SABECO)', N'187 Nguyễn Chí Thanh, P.12, Q.5, TP.HCM', '02838294083');

-- 2. Loại nước giải khát (Mỗi loại nhập từ 1 NCC duy nhất)
INSERT INTO LoaiNGK (MaLoai, TenLoai, MaNCU) VALUES
('LOAI_PEPSI', N'Nước ngọt có gas PepsiCo', 'NCU01'),
('LOAI_COCA',  N'Nước ngọt có gas Coca-Cola', 'NCU02'),
('LOAI_SABECO',N'Bia Sài Gòn các loại', 'NCU03'),
('LOAI_TRA',   N'Trà giải nhiệt & Trà xanh', 'NCU01'),
('LOAI_KHOANG',N'Nước khoáng đóng chai', 'NCU02');

-- 3. Nước giải khát
INSERT INTO NuocGiaiKhat (MaNGK, TenNGK, DonViTinh, SoLuongTon, DonGiaBan, MaLoai) VALUES
('NGK_PEPSI_CAN',   N'Pepsi lon 330ml',         N'Lon',   120, 10000, 'LOAI_PEPSI'),
('NGK_7UP_CAN',     N'7Up lon 330ml',           N'Lon',    80, 10000, 'LOAI_PEPSI'),
('NGK_MIRINDA_CAM', N'Mirinda vị cam 330ml',    N'Lon',    60, 10000, 'LOAI_PEPSI'),
('NGK_COCA_CAN',    N'Coca-Cola Original 330ml',N'Lon',    50, 10000, 'LOAI_COCA'),
('NGK_SPRITE_CAN',  N'Sprite chanh 330ml',      N'Lon',    75, 10000, 'LOAI_COCA'),
('NGK_FANTA_CAN',   N'Fanta vị cam 330ml',      N'Lon',    40, 10000, 'LOAI_COCA'),
('NGK_BIA_SG_EXP',  N'Bia Sài Gòn Export 330ml', N'Chai',  150, 15000, 'LOAI_SABECO'),
('NGK_BIA_SG_SPEC', N'Bia Sài Gòn Special 330ml',N'Lon',   200, 18000, 'LOAI_SABECO'),
('NGK_TRA_OOLONG',  N'Trà Ô Long Tea+ Plus',    N'Chai',   90, 12000, 'LOAI_TRA'),
('NGK_AQUAFINA_500',N'Nước tinh khiết Aquafina',N'Chai',  300,  6000, 'LOAI_PEPSI');

-- 4. Nhân viên
INSERT INTO NhanVien (MaNV, HoTen, ChucVu, SoDT, TaiKhoan, MatKhau) VALUES
('NV01', N'Trần Nguyên',         N'Quản lý cửa hàng', '0901234567', 'admin',    '123456'),
('NV02', N'Nguyễn Thị Mai',       N'Thu ngân',         '0912345678', 'thungan1', '123456'),
('NV03', N'Lê Hoàng Phúc',       N'Nhân viên kho',    '0923456789', 'kho1',     '123456'),
('NV04', N'Phạm Tuấn Anh',       N'Nhân viên giao',   '0934567890', 'giaohang1','123456');

-- 5. Khách hàng
INSERT INTO KhachHang (MaKH, TenKH, DiaChi, SoDT, LoaiKH, TongNo) VALUES
('KHQ01', N'Cửa hàng Tạp hóa Mai Linh',     N'45 Điện Biên Phủ, P.15, Bình Thạnh', '0988111222', 'KhachQuen', 500000),
('KHQ02', N'Đại lý Nước giải khát Hưng Thịnh', N'120 Xô Viết Nghệ Tĩnh, Q.Bình Thạnh', '0977222333', 'KhachQuen', 0),
('KHQ03', N'Quán ăn Gia Đình Cô Ba',       N'89 Nguyễn Thị Minh Khai, Q.1',       '0966333444', 'KhachQuen', 0),
('KHVL01', N'Nguyễn Văn An (Vãng lai)',     N'Khách mua trực tiếp tại quầy',       '0909000111', 'KhachVangLai', 0),
('KHVL02', N'Lê Thị Hoa (Vãng lai)',        N'Khách mua trực tiếp tại quầy',       '0919000222', 'KhachVangLai', 0);

-- 6. Đơn đặt hàng mẫu (Đã giao đợt 1 và đợt 2, còn đợt 3)
INSERT INTO DonDatHang (SoDDH, NgayDat, NgayNhan, TongSoLuongDat, SoDotDaGiao, TrangThai, MaNCU, MaNV) VALUES
('DDH01', '2026-10-15 08:30:00', '2026-10-25 10:00:00', 500, 2, N'Đã giao 2 đợt', 'NCU01', 'NV01'),
('DDH02', '2026-10-20 09:00:00', '2026-10-28 14:00:00', 300, 1, N'Đã giao 1 đợt', 'NCU02', 'NV01');

-- 7. Chi tiết đơn đặt hàng
INSERT INTO ChiTietDDH (SoDDH, MaNGK, SoLuongDat, DonGiaNhap) VALUES
('DDH01', 'NGK_PEPSI_CAN', 300, 7500),
('DDH01', 'NGK_7UP_CAN',   200, 7500),
('DDH02', 'NGK_COCA_CAN',  200, 7600),
('DDH02', 'NGK_SPRITE_CAN',100, 7600);

-- 8. Phiếu giao hàng (Đợt 1 và đợt 2 của DDH01)
INSERT INTO PhieuGiaoHang (SoPGH, NgayGiao, SoTienPhaiTra, DotGiao, SoDDH, MaNV) VALUES
('PGH01', '2026-10-18 09:00:00', 1875000, 1, 'DDH01', 'NV03'),
('PGH02', '2026-10-22 10:30:00', 1125000, 2, 'DDH01', 'NV03'),
('PGH03', '2026-10-23 14:00:00', 1520000, 1, 'DDH02', 'NV03');

-- 9. Chi tiết phiếu giao hàng
INSERT INTO ChiTietPGH (SoPGH, MaNGK, SoLuongGiao, DonGia) VALUES
('PGH01', 'NGK_PEPSI_CAN', 150, 7500),
('PGH01', 'NGK_7UP_CAN',   100, 7500),
('PGH02', 'NGK_PEPSI_CAN', 100, 7500),
('PGH02', 'NGK_7UP_CAN',    50, 7500),
('PGH03', 'NGK_COCA_CAN',  150, 7600),
('PGH03', 'NGK_SPRITE_CAN', 50, 7600);

-- 10. Hóa đơn mẫu
INSERT INTO HoaDon (SoHD, NgayLap, TongTien, HinhThucThanhToan, DaThanhToan, MaKH, MaNV) VALUES
('HD001', '2026-10-25 10:00:00', 1500000, N'Ghi nợ',   0, 'KHQ01', 'NV02'),
('HD002', '2026-10-26 15:30:00',  300000, N'Tiền mặt', 1, 'KHVL01', 'NV02'),
('HD003', '2026-10-27 11:00:00', 2000000, N'Tiền mặt', 1, 'KHQ02', 'NV02');

-- 11. Chi tiết hóa đơn
INSERT INTO ChiTietHoaDon (SoHD, MaNGK, SoLuong, DonGia) VALUES
('HD001', 'NGK_PEPSI_CAN', 100, 10000),
('HD001', 'NGK_7UP_CAN',    50, 10000),
('HD002', 'NGK_COCA_CAN',   30, 10000),
('HD003', 'NGK_BIA_SG_SPEC',100, 18000),
('HD003', 'NGK_TRA_OOLONG',  16, 12000);

-- 12. Phiếu hẹn giao hàng (Khách quen KHQ02 mua thiếu hàng, hẹn 2 đợt)
INSERT INTO PhieuHen (SoPH, NgayHenGiao, DotGiaoHen, SoLuongHen, TrangThai, SoHD, MaNGK) VALUES
('PH001', '2026-10-29 09:00:00', 1, 30, N'Chờ giao', 'HD003', 'NGK_TRA_OOLONG'),
('PH002', '2026-11-02 14:00:00', 2, 50, N'Chờ giao', 'HD003', 'NGK_TRA_OOLONG');

-- 13. Phiếu ghi nợ (Khách quen KHQ01 trả chậm theo HD001)
INSERT INTO PhieuGhiNo (SoPGN, NgayLap, SoTienNo, NgayDuKienTra, LyDoNo, DaTra, SoHD, MaKH, MaNV) VALUES
('PGN001', '2026-10-25 10:05:00', 500000, '2026-11-25 17:00:00', N'Khách quen thanh toán trước 1.000.000đ, nợ lại 500.000đ cuối tháng chuyển khoản', 0, 'HD001', 'KHQ01', 'NV02');
GO

PRINT N'=== KHỞI TẠO CSDL QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT THÀNH CÔNG (13 BẢNG) ===';
GO
