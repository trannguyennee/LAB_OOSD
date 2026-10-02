
USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'eShoppingDB')
BEGIN
    ALTER DATABASE eShoppingDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE eShoppingDB;
END
GO

CREATE DATABASE eShoppingDB;
GO

USE eShoppingDB;
GO

-- 1. BẢNG NHÓM SẢN PHẨM (Quy tắc #1: Lớp thực thể danh mục)
CREATE TABLE NHOM_SAN_PHAM (
    MaNhom VARCHAR(20) PRIMARY KEY,
    TenNhom NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(255) NULL
);
GO

-- 2. BẢNG SẢN PHẨM (Quy tắc #3: Quan hệ 1-n từ NHOM_SAN_PHAM)
CREATE TABLE SAN_PHAM (
    MaSP VARCHAR(20) PRIMARY KEY,
    TenSP NVARCHAR(150) NOT NULL,
    NhaSanXuat NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(MAX) NULL,
    ThongSoKyThuat NVARCHAR(MAX) NULL,
    GiaHienHanh DECIMAL(18, 2) NOT NULL,
    TinhTrang NVARCHAR(50) DEFAULT N'Còn hàng',
    MaNhom VARCHAR(20) NOT NULL,
    CONSTRAINT FK_SanPham_NhomSanPham FOREIGN KEY (MaNhom) 
        REFERENCES NHOM_SAN_PHAM(MaNhom) ON DELETE CASCADE
);
GO

-- 3. BẢNG KHÁCH HÀNG (Quy tắc #1: Lớp cha chung)
CREATE TABLE KHACH_HANG (
    MaKH VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NULL,
    SoCMND_Passport VARCHAR(25) NULL,
    DiaChi NVARCHAR(255) NULL,
    SoDienThoai VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NULL
);
GO

-- 4. BẢNG THÀNH VIÊN (Quy tắc #5 - Kế thừa: PK vừa là FK tham chiếu đến KHACH_HANG)
CREATE TABLE KHACH_HANG_THANH_VIEN (
    MaKH VARCHAR(20) PRIMARY KEY,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(255) NOT NULL,
    CONSTRAINT FK_ThanhVien_KhachHang FOREIGN KEY (MaKH) 
        REFERENCES KHACH_HANG(MaKH) ON DELETE CASCADE
);
GO

-- 5. BẢNG ĐƠN ĐẶT HÀNG (Quy tắc #3: Quan hệ 1-n từ KHACH_HANG)
CREATE TABLE DON_DAT_HANG (
    MaDonHang VARCHAR(20) PRIMARY KEY,
    NgayDat DATETIME DEFAULT GETDATE(),
    LoaiPhieuGiao NVARCHAR(50) NOT NULL, -- 'Thường', 'Chuyển phát nhanh', 'Chuyển phát nhanh trong ngày'
    PhiGiaoHang DECIMAL(18, 2) DEFAULT 0,
    TongTien DECIMAL(18, 2) NOT NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Chờ thanh toán', -- 'Chờ thanh toán', 'Đã thanh toán', 'Đang giao hàng', 'Đã giao hàng', 'Đã hủy'
    TenNguoiNhan NVARCHAR(100) NOT NULL,
    DiaChiNhan NVARCHAR(255) NOT NULL,
    SdtNguoiNhan VARCHAR(15) NOT NULL,
    MaKH VARCHAR(20) NOT NULL,
    CONSTRAINT FK_DonDatHang_KhachHang FOREIGN KEY (MaKH) 
        REFERENCES KHACH_HANG(MaKH)
);
GO

-- 6. BẢNG CHI TIẾT ĐƠN HÀNG (Quy tắc #4 & Hợp thành Composition)
CREATE TABLE CHI_TIET_DON_HANG (
    MaDonHang VARCHAR(20) NOT NULL,
    MaSP VARCHAR(20) NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGiaBan DECIMAL(18, 2) NOT NULL,
    ThanhTien DECIMAL(18, 2) NOT NULL,
    PRIMARY KEY (MaDonHang, MaSP),
    CONSTRAINT FK_ChiTiet_DonHang FOREIGN KEY (MaDonHang) 
        REFERENCES DON_DAT_HANG(MaDonHang) ON DELETE CASCADE,
    CONSTRAINT FK_ChiTiet_SanPham FOREIGN KEY (MaSP) 
        REFERENCES SAN_PHAM(MaSP)
);
GO


-- 1. Nhóm sản phẩm
INSERT INTO NHOM_SAN_PHAM (MaNhom, TenNhom, MoTa) VALUES
('NSP01', N'Máy chụp hình kỹ thuật số', N'Máy ảnh DSLR, mirrorless và phụ kiện ống kính'),
('NSP02', N'Thiết bị máy tính', N'Laptop, PC, linh kiện và thiết bị ngoại vi'),
('NSP03', N'Thiết bị điện gia dụng', N'Tủ lạnh mini, nồi chiên không dầu, máy lọc không khí'),
('NSP04', N'Đồ chơi thông minh', N'Đồ chơi giáo dục STEM, đồ chơi lắp ráp mô hình');
GO

-- 2. Sản phẩm
INSERT INTO SAN_PHAM (MaSP, TenSP, NhaSanXuat, MoTa, ThongSoKyThuat, GiaHienHanh, TinhTrang, MaNhom) VALUES
('SP001', N'Canon EOS R50 Mirrorless', N'Canon', N'Máy ảnh cảm biến APS-C gọn nhẹ', N'24.2MP, 4K video, Dual Pixel AF', 16500000, N'Còn hàng', 'NSP01'),
('SP002', N'Sony Alpha A6700', N'Sony', N'Máy ảnh cao cấp chuyên nghiệp', N'26MP, Chống rung 5 trục, AI Tracking', 32990000, N'Còn hàng', 'NSP01'),
('SP003', N'Laptop Dell XPS 13 Plus', N'Dell', N'Laptop mỏng nhẹ doanh nhân cao cấp', N'Core i7 1360P, 16GB RAM, 512GB SSD', 38500000, N'Còn hàng', 'NSP02'),
('SP004', N'Chuột Logitech MX Master 3S', N'Logitech', N'Chuột công thái học văn phòng', N'Cảm biến 8000 DPI, Yên tĩnh Quiet Click', 2150000, N'Còn hàng', 'NSP02');
GO

-- 3. Khách hàng
INSERT INTO KHACH_HANG (MaKH, HoTen, NgaySinh, SoCMND_Passport, DiaChi, SoDienThoai, Email) VALUES
('KH001', N'Trần Nguyên', '2004-05-15', '079204001234', N'123 Lê Duẩn, Quận 1, TP.HCM', '0908123456', 'trannguyen@gmail.com'),
('KH002', N'Lê Văn Hùng', '1998-10-20', '079198005678', N'45 Nguyễn Trãi, Quận 5, TP.HCM', '0912345678', 'hung.le@gmail.com'),
('KH003', N'Nguyễn Thị Mai', '2001-03-12', '079201009876', N'78 Quang Trung, Gò Vấp, TP.HCM', '0987654321', 'mai.nguyen@gmail.com');
GO

-- 4. Khách hàng thành viên
INSERT INTO KHACH_HANG_THANH_VIEN (MaKH, TenDangNhap, MatKhau) VALUES
('KH001', 'trannguyen', 'MatKhau@123'),
('KH002', 'hunglevan', 'SecurePass#456');
GO

-- 5. Đơn đặt hàng
INSERT INTO DON_DAT_HANG (MaDonHang, NgayDat, LoaiPhieuGiao, PhiGiaoHang, TongTien, TrangThai, TenNguoiNhan, DiaChiNhan, SdtNguoiNhan, MaKH) VALUES
('DH001', '2026-10-02 14:30:00', N'Chuyển phát nhanh trong ngày', 0, 16500000, N'Đã thanh toán', N'Trần Văn An', N'123 Lê Duẩn, Q.1, TP.HCM', '0909111222', 'KH001'),
('DH002', '2026-10-02 16:15:00', N'Chuyển phát nhanh', 0, 2150000, N'Đã thanh toán', N'Lê Văn Hùng', N'45 Nguyễn Trãi, Q.5, TP.HCM', '0912345678', 'KH002');
GO

-- 6. Chi tiết đơn hàng
INSERT INTO CHI_TIET_DON_HANG (MaDonHang, MaSP, SoLuong, DonGiaBan, ThanhTien) VALUES
('DH001', 'SP001', 1, 16500000, 16500000),
('DH002', 'SP004', 1, 2150000, 2150000);
GO


-- KIỂM TRA DỮ LIỆU VỪA TẠO
SELECT 'NHOM_SAN_PHAM' AS Bang, COUNT(*) AS SoLuong FROM NHOM_SAN_PHAM
UNION ALL
SELECT 'SAN_PHAM', COUNT(*) FROM SAN_PHAM
UNION ALL
SELECT 'KHACH_HANG', COUNT(*) FROM KHACH_HANG
UNION ALL
SELECT 'KHACH_HANG_THANH_VIEN', COUNT(*) FROM KHACH_HANG_THANH_VIEN
UNION ALL
SELECT 'DON_DAT_HANG', COUNT(*) FROM DON_DAT_HANG
UNION ALL
SELECT 'CHI_TIET_DON_HANG', COUNT(*) FROM CHI_TIET_DON_HANG;
GO
