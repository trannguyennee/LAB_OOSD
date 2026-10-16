USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyHoSoBenhAnDB')
BEGIN
    ALTER DATABASE QuanLyHoSoBenhAnDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyHoSoBenhAnDB;
END
GO

CREATE DATABASE QuanLyHoSoBenhAnDB;
GO

USE QuanLyHoSoBenhAnDB;
GO

-- =============================================================================
-- PHẦN 1: TẠO CÁC BẢNG CSDL (CÓ PK, FK, UNIQUE, CHECK CONSTRAINTS)
-- =============================================================================

-- 1. BẢNG BỆNH NHÂN (Lưu thông tin đăng ký cơ bản)
CREATE TABLE BENH_NHAN (
    MaBenhNhan VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    DiaChi NVARCHAR(255) NOT NULL,
    SoDienThoai VARCHAR(15) NOT NULL,
    SoCCCD VARCHAR(20) NOT NULL UNIQUE, -- Ràng buộc UNIQUE chống trùng lặp bệnh nhân
    HinhAnh3x4 NVARCHAR(255) NULL,       -- Đường dẫn file ảnh 3x4
    NgayTao DATETIME DEFAULT GETDATE()
);
GO

-- 2. BẢNG HỒ SƠ BỆNH ÁN (Trang bìa có Mã hồ sơ phân biệt các bệnh nhân)
CREATE TABLE HO_SO_BENH_AN (
    MaHoSo VARCHAR(20) PRIMARY KEY,
    MaBenhNhan VARCHAR(20) NOT NULL UNIQUE, -- Ràng buộc UNIQUE quan hệ 1-1 với Bệnh nhân
    NgayCapHoSo DATETIME DEFAULT GETDATE(),
    NgayCapNhatCuoi DATETIME DEFAULT GETDATE(),
    TienSuBenh NVARCHAR(MAX) NULL,
    DiUngThuoc NVARCHAR(MAX) NULL,
    TrangThaiHoSo NVARCHAR(50) DEFAULT N'Đang theo dõi', -- 'Đang theo dõi', 'Đã đóng đợt khám'
    CONSTRAINT FK_HoSo_BenhNhan FOREIGN KEY (MaBenhNhan) 
        REFERENCES BENH_NHAN(MaBenhNhan) ON DELETE CASCADE
);
GO

-- 3. BẢNG LỆ PHÍ NĂM (Quản lý lệ phí thường niên và theo dõi sức khỏe)
CREATE TABLE LE_PHI_NAM (
    MaPhieuThu VARCHAR(20) PRIMARY KEY,
    MaHoSo VARCHAR(20) NOT NULL,
    NamApDung INT NOT NULL,
    NgayDong DATETIME DEFAULT GETDATE(),
    NgayHetHan DATE NOT NULL,
    SoTien DECIMAL(18, 2) NOT NULL DEFAULT 500000,
    TrangThai NVARCHAR(50) DEFAULT N'Còn hiệu lực', -- 'Còn hiệu lực', 'Hết hiệu lực'
    CONSTRAINT FK_LePhi_HoSo FOREIGN KEY (MaHoSo) 
        REFERENCES HO_SO_BENH_AN(MaHoSo) ON DELETE CASCADE,
    CONSTRAINT UQ_HoSo_Nam UNIQUE (MaHoSo, NamApDung) -- Ràng buộc UNIQUE: Mỗi năm đóng 1 lần
);
GO

-- 4. BẢNG LỊCH KHÁM ĐỊNH KỲ THEO QUÝ (Quyền lợi miễn phí tiền khám 1 lần/quý)
CREATE TABLE LICH_KHAM_DINH_KY (
    MaLichHen VARCHAR(20) PRIMARY KEY,
    MaHoSo VARCHAR(20) NOT NULL,
    QuyKham INT NOT NULL CHECK (QuyKham BETWEEN 1 AND 4),
    NamKham INT NOT NULL,
    NgayHen DATE NOT NULL,
    GioHen VARCHAR(10) NOT NULL,
    MienPhiTienKham BIT DEFAULT 1, -- 1: Miễn phí tiền khám theo quyền lợi phí năm
    GhiChu NVARCHAR(255) NULL,
    TrangThaiLich NVARCHAR(50) DEFAULT N'Đã đặt lịch', -- 'Đã đặt lịch', 'Đã khám', 'Hủy hẹn'
    CONSTRAINT FK_LichHen_HoSo FOREIGN KEY (MaHoSo) 
        REFERENCES HO_SO_BENH_AN(MaHoSo) ON DELETE CASCADE,
    CONSTRAINT UQ_HoSo_Quy UNIQUE (MaHoSo, NamKham, QuyKham) -- Ràng buộc UNIQUE: Mỗi quý 1 lịch hẹn định kỳ
);
GO

-- 5. BẢNG KHOA PHÒNG
CREATE TABLE KHOA_PHONG (
    MaKhoa VARCHAR(20) PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL,
    ViTri NVARCHAR(100) NULL
);
GO

-- 6. BẢNG NHÂN VIÊN Y TẾ (Bác sĩ, Tiếp nhận/CSKH, Thu ngân)
CREATE TABLE NHAN_VIEN (
    MaNhanVien VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NULL,
    SoDienThoai VARCHAR(15) NOT NULL,
    Email VARCHAR(100) NULL,
    LoaiNhanVien NVARCHAR(50) NOT NULL, -- 'BacSi', 'CSKH', 'ThuNgan'
    ChuyenKhoa NVARCHAR(100) NULL,
    MaKhoa VARCHAR(20) NULL,
    CONSTRAINT FK_NhanVien_Khoa FOREIGN KEY (MaKhoa) 
        REFERENCES KHOA_PHONG(MaKhoa)
);
GO

-- 7. BẢNG PHIẾU KHÁM BỆNH (Các trang sau của hồ sơ bệnh án ghi nhận đợt khám)
CREATE TABLE PHIEU_KHAM_BENH (
    MaPhieuKham VARCHAR(20) PRIMARY KEY,
    MaHoSo VARCHAR(20) NOT NULL,
    MaBacSi VARCHAR(20) NOT NULL,
    NgayGioKham DATETIME DEFAULT GETDATE(),
    KhoaDieuTri NVARCHAR(100) NOT NULL,
    TrieuChung NVARCHAR(MAX) NOT NULL,  -- Nhức đầu, sốt, thân nhiệt, huyết áp...
    ThanNhiet DECIMAL(4, 1) NULL,       -- Ví dụ: 37.5
    HuyetAp VARCHAR(20) NULL,           -- Ví dụ: '120/80'
    ChanDoanSoBo NVARCHAR(MAX) NULL,
    ChanDoanCuoiCung NVARCHAR(MAX) NULL,
    TienKham DECIMAL(18, 2) DEFAULT 150000,
    TrangThaiKham NVARCHAR(50) DEFAULT N'Đang khám', -- 'Đang khám', 'Chờ xét nghiệm', 'Đã có kết quả', 'Đã kê toa', 'Đã hoàn tất'
    CONSTRAINT FK_PhieuKham_HoSo FOREIGN KEY (MaHoSo) 
        REFERENCES HO_SO_BENH_AN(MaHoSo),
    CONSTRAINT FK_PhieuKham_BacSi FOREIGN KEY (MaBacSi) 
        REFERENCES NHAN_VIEN(MaNhanVien)
);
GO

-- 8. BẢNG DANH MỤC LOẠI XÉT NGHIỆM
CREATE TABLE LOAI_XET_NGHIEM (
    MaXetNghiem VARCHAR(20) PRIMARY KEY,
    TenXetNghiem NVARCHAR(150) NOT NULL,
    DonGia DECIMAL(18, 2) NOT NULL,
    DonViTinh NVARCHAR(50) DEFAULT N'Lần',
    ChiSoThamChieuBinhThuong NVARCHAR(100) NULL
);
GO

-- 9. BẢNG CHỈ ĐỊNH XÉT NGHIỆM (Bác sĩ yêu cầu xét nghiệm)
CREATE TABLE CHI_DINH_XET_NGHIEM (
    MaChiDinh VARCHAR(20) PRIMARY KEY,
    MaPhieuKham VARCHAR(20) NOT NULL,
    NgayChiDinh DATETIME DEFAULT GETDATE(),
    YeuCauBacSi NVARCHAR(255) NULL,
    TrangThaiChiDinh NVARCHAR(50) DEFAULT N'Chờ xét nghiệm',
    CONSTRAINT FK_ChiDinh_PhieuKham FOREIGN KEY (MaPhieuKham) 
        REFERENCES PHIEU_KHAM_BENH(MaPhieuKham) ON DELETE CASCADE
);
GO

-- 10. BẢNG KẾT QUẢ XÉT NGHIỆM (Chi tiết các chỉ số trả về)
CREATE TABLE KET_QUA_XET_NGHIEM (
    MaKetQua VARCHAR(20) PRIMARY KEY,
    MaChiDinh VARCHAR(20) NOT NULL,
    MaXetNghiem VARCHAR(20) NOT NULL,
    ChiSoKetQua NVARCHAR(100) NOT NULL,
    GiaTriThamChieu NVARCHAR(100) NULL,
    DanhGia NVARCHAR(50) DEFAULT N'Bình thường', -- 'Bình thường', 'Bất thường'
    DonGia DECIMAL(18, 2) NOT NULL,
    NgayGioThucHien DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_KetQua_ChiDinh FOREIGN KEY (MaChiDinh) 
        REFERENCES CHI_DINH_XET_NGHIEM(MaChiDinh) ON DELETE CASCADE,
    CONSTRAINT FK_KetQua_LoaiXN FOREIGN KEY (MaXetNghiem) 
        REFERENCES LOAI_XET_NGHIEM(MaXetNghiem)
);
GO

-- 11. BẢNG DANH MỤC THUỐC
CREATE TABLE THUOC (
    MaThuoc VARCHAR(20) PRIMARY KEY,
    TenThuoc NVARCHAR(150) NOT NULL,
    HoatChat NVARCHAR(150) NOT NULL,
    DonViTinh NVARCHAR(50) NOT NULL,
    DonGia DECIMAL(18, 2) NOT NULL,
    SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0),
    ChongChiDinh NVARCHAR(MAX) NULL
);
GO

-- 12. BẢNG TOA THUỐC (Đơn thuốc liên kết với phiếu khám)
CREATE TABLE TOA_THUOC (
    MaToaThuoc VARCHAR(20) PRIMARY KEY,
    MaPhieuKham VARCHAR(20) NOT NULL UNIQUE, -- Ràng buộc UNIQUE: 1 Phiếu khám chỉ liên kết 1 Toa thuốc
    NgayKeToa DATETIME DEFAULT GETDATE(),
    LoiDanBacSi NVARCHAR(MAX) NULL,
    TongTienThuoc DECIMAL(18, 2) DEFAULT 0,
    CONSTRAINT FK_ToaThuoc_PhieuKham FOREIGN KEY (MaPhieuKham) 
        REFERENCES PHIEU_KHAM_BENH(MaPhieuKham) ON DELETE CASCADE
);
GO

-- 13. BẢNG CHI TIẾT TOA THUỐC (Hợp thành Composition với ToaThuoc)
CREATE TABLE CHI_TIET_TOA_THUOC (
    MaChiTietToa INT IDENTITY(1,1) PRIMARY KEY,
    MaToaThuoc VARCHAR(20) NOT NULL,
    MaThuoc VARCHAR(20) NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    CachDung NVARCHAR(255) NOT NULL,
    UongSang INT DEFAULT 1,
    UongTrua INT DEFAULT 0,
    UongChieu INT DEFAULT 1,
    UongToi INT DEFAULT 0,
    DonGiaBan DECIMAL(18, 2) NOT NULL,
    ThanhTien DECIMAL(18, 2) NOT NULL,
    CONSTRAINT FK_ChiTiet_ToaThuoc FOREIGN KEY (MaToaThuoc) 
        REFERENCES TOA_THUOC(MaToaThuoc) ON DELETE CASCADE,
    CONSTRAINT FK_ChiTiet_Thuoc FOREIGN KEY (MaThuoc) 
        REFERENCES THUOC(MaThuoc)
);
GO

-- 14. BẢNG HÓA ĐƠN VIỆN PHÍ (Thanh toán viện phí và hoàn tất đợt khám)
CREATE TABLE HOA_DON_VIEN_PHI (
    MaHoaDon VARCHAR(20) PRIMARY KEY,
    MaPhieuKham VARCHAR(20) NOT NULL UNIQUE, -- Ràng buộc UNIQUE: 1 Phiếu khám có 1 Hóa đơn viện phí
    MaThuNgan VARCHAR(20) NOT NULL,
    NgayLap DATETIME DEFAULT GETDATE(),
    TienKham DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TienXetNghiem DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TienThuoc DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TienMienGiam DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TongTienThanhToan DECIMAL(18, 2) NOT NULL,
    HinhThucThanhToan NVARCHAR(50) DEFAULT N'Tiền mặt', -- 'Tiền mặt', 'Chuyển khoản', 'Thẻ POS'
    TrangThai NVARCHAR(50) DEFAULT N'Đã thanh toán',
    CONSTRAINT FK_HoaDon_PhieuKham FOREIGN KEY (MaPhieuKham) 
        REFERENCES PHIEU_KHAM_BENH(MaPhieuKham),
    CONSTRAINT FK_HoaDon_ThuNgan FOREIGN KEY (MaThuNgan) 
        REFERENCES NHAN_VIEN(MaNhanVien)
);
GO


-- =============================================================================
-- PHẦN 2: CÁC STORED PROCEDURES SỬ DỤNG TRANSACTION CHO NGHIỆP VỤ NHIỀU BẢNG
-- =============================================================================

-- TRANSACTION 1: Đăng ký lần đầu + Đóng lệ phí năm + Cấp hồ sơ bệnh án tự động
CREATE OR ALTER PROCEDURE sp_DangKyVaCapHoSoBenhAn
    @MaBN VARCHAR(20),
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(255),
    @SoDienThoai VARCHAR(15),
    @SoCCCD VARCHAR(20),
    @HinhAnh3x4 NVARCHAR(255),
    @TienSuBenh NVARCHAR(MAX),
    @DiUngThuoc NVARCHAR(MAX),
    @SoTienPhiNam DECIMAL(18, 2),
    @MaHS VARCHAR(20) OUTPUT,
    @MaPT VARCHAR(20) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Kiểm tra số CCCD đã tồn tại chưa
        IF EXISTS (SELECT 1 FROM BENH_NHAN WHERE SoCCCD = @SoCCCD)
        BEGIN
            RAISERROR(N'Lỗi: Số CCCD này đã được đăng ký trong hệ thống!', 16, 1);
        END

        -- 2. Thêm vào bảng BENH_NHAN
        INSERT INTO BENH_NHAN (MaBenhNhan, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, SoCCCD, HinhAnh3x4, NgayTao)
        VALUES (@MaBN, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @SoCCCD, @HinhAnh3x4, GETDATE());

        -- 3. Tự sinh Mã hồ sơ
        SET @MaHS = 'HS' + SUBSTRING(@MaBN, 3, LEN(@MaBN));
        INSERT INTO HO_SO_BENH_AN (MaHoSo, MaBenhNhan, NgayCapHoSo, NgayCapNhatCuoi, TienSuBenh, DiUngThuoc, TrangThaiHoSo)
        VALUES (@MaHS, @MaBN, GETDATE(), GETDATE(), @TienSuBenh, @DiUngThuoc, N'Đang theo dõi');

        -- 4. Tạo Phiếu thu lệ phí năm
        SET @MaPT = 'PT' + SUBSTRING(@MaBN, 3, LEN(@MaBN));
        DECLARE @NamHienTai INT = YEAR(GETDATE());
        DECLARE @NgayHetHan DATE = DATEADD(YEAR, 1, CAST(GETDATE() AS DATE));

        INSERT INTO LE_PHI_NAM (MaPhieuThu, MaHoSo, NamApDung, NgayDong, NgayHetHan, SoTien, TrangThai)
        VALUES (@MaPT, @MaHS, @NamHienTai, GETDATE(), @NgayHetHan, @SoTienPhiNam, N'Còn hiệu lực');

        COMMIT TRANSACTION;
        SELECT N'Thành công: Đã đăng ký bệnh nhân, nộp phí năm và cấp hồ sơ bệnh án thành công!' AS KetQua;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- TRANSACTION 2: Lập đợt khám + Chỉ định xét nghiệm + Kê toa thuốc (Liên kết nhiều bảng)
CREATE OR ALTER PROCEDURE sp_KhamBenhChiDinhVaKeToa
    @MaPhieuKham VARCHAR(20),
    @MaHoSo VARCHAR(20),
    @MaBacSi VARCHAR(20),
    @KhoaDieuTri NVARCHAR(100),
    @TrieuChung NVARCHAR(MAX),
    @ThanNhiet DECIMAL(4, 1),
    @HuyetAp VARCHAR(20),
    @ChanDoanCuoiCung NVARCHAR(MAX),
    @MaChiDinh VARCHAR(20) = NULL,
    @MaXetNghiem VARCHAR(20) = NULL,
    @ChiSoKQ NVARCHAR(100) = NULL,
    @MaToaThuoc VARCHAR(20) = NULL,
    @MaThuoc VARCHAR(20) = NULL,
    @SoLuongThuoc INT = NULL,
    @CachDung NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Tạo phiếu khám bệnh
        INSERT INTO PHIEU_KHAM_BENH (MaPhieuKham, MaHoSo, MaBacSi, NgayGioKham, KhoaDieuTri, TrieuChung, ThanNhiet, HuyetAp, ChanDoanCuoiCung, TrangThaiKham)
        VALUES (@MaPhieuKham, @MaHoSo, @MaBacSi, GETDATE(), @KhoaDieuTri, @TrieuChung, @ThanNhiet, @HuyetAp, @ChanDoanCuoiCung, N'Đang khám');

        -- 2. Nếu có chỉ định xét nghiệm
        IF @MaChiDinh IS NOT NULL AND @MaXetNghiem IS NOT NULL
        BEGIN
            INSERT INTO CHI_DINH_XET_NGHIEM (MaChiDinh, MaPhieuKham, NgayChiDinh, YeuCauBacSi, TrangThaiChiDinh)
            VALUES (@MaChiDinh, @MaPhieuKham, GETDATE(), N'Kiểm tra cận lâm sàng theo triệu chứng', N'Đã có kết quả');

            DECLARE @DonGiaXN DECIMAL(18, 2);
            DECLARE @ThamChieu NVARCHAR(100);
            SELECT @DonGiaXN = DonGia, @ThamChieu = ChiSoThamChieuBinhThuong FROM LOAI_XET_NGHIEM WHERE MaXetNghiem = @MaXetNghiem;

            INSERT INTO KET_QUA_XET_NGHIEM (MaKetQua, MaChiDinh, MaXetNghiem, ChiSoKetQua, GiaTriThamChieu, DanhGia, DonGia, NgayGioThucHien)
            VALUES ('KQ_' + @MaChiDinh, @MaChiDinh, @MaXetNghiem, ISNULL(@ChiSoKQ, N'Bình thường'), @ThamChieu, N'Bình thường', @DonGiaXN, GETDATE());
        END

        -- 3. Nếu có kê toa thuốc
        IF @MaToaThuoc IS NOT NULL AND @MaThuoc IS NOT NULL AND @SoLuongThuoc > 0
        BEGIN
            -- Kiểm tra tồn kho
            DECLARE @TonHienTai INT;
            DECLARE @DonGiaThuoc DECIMAL(18, 2);
            SELECT @TonHienTai = SoLuongTon, @DonGiaThuoc = DonGia FROM THUOC WHERE MaThuoc = @MaThuoc;

            IF @TonHienTai < @SoLuongThuoc
            BEGIN
                RAISERROR(N'Lỗi: Thuốc này trong kho không đủ số lượng để kê toa!', 16, 1);
            END

            DECLARE @ThanhTien DECIMAL(18, 2) = @DonGiaThuoc * @SoLuongThuoc;

            INSERT INTO TOA_THUOC (MaToaThuoc, MaPhieuKham, NgayKeToa, LoiDanBacSi, TongTienThuoc)
            VALUES (@MaToaThuoc, @MaPhieuKham, GETDATE(), N'Uống thuốc đúng giờ, kiêng đồ uống có cồn', @ThanhTien);

            INSERT INTO CHI_TIET_TOA_THUOC (MaToaThuoc, MaThuoc, SoLuong, CachDung, UongSang, UongTrua, UongChieu, UongToi, DonGiaBan, ThanhTien)
            VALUES (@MaToaThuoc, @MaThuoc, @SoLuongThuoc, ISNULL(@CachDung, N'Uống sau ăn 30 phút'), 1, 0, 1, 0, @DonGiaThuoc, @ThanhTien);

            -- Trừ tồn kho thuốc
            UPDATE THUOC SET SoLuongTon = SoLuongTon - @SoLuongThuoc WHERE MaThuoc = @MaThuoc;

            -- Cập nhật trạng thái phiếu khám
            UPDATE PHIEU_KHAM_BENH SET TrangThaiKham = N'Đã kê toa' WHERE MaPhieuKham = @MaPhieuKham;
        END

        COMMIT TRANSACTION;
        SELECT N'Thành công: Đã ghi nhận phiếu khám, kết quả xét nghiệm và đơn thuốc!' AS KetQua;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

-- TRANSACTION 3: Thanh toán viện phí và hoàn tất xuất viện, khóa bệnh án
CREATE OR ALTER PROCEDURE sp_ThanhToanVienPhiVaDongBenhAn
    @MaHoaDon VARCHAR(20),
    @MaPhieuKham VARCHAR(20),
    @MaThuNgan VARCHAR(20),
    @HinhThucThanhToan NVARCHAR(50) = N'Tiền mặt'
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Kiểm tra phiếu khám có hợp lệ và chưa thanh toán
        IF NOT EXISTS (SELECT 1 FROM PHIEU_KHAM_BENH WHERE MaPhieuKham = @MaPhieuKham)
        BEGIN
            RAISERROR(N'Lỗi: Phiếu khám không tồn tại!', 16, 1);
        END

        IF EXISTS (SELECT 1 FROM HOA_DON_VIEN_PHI WHERE MaPhieuKham = @MaPhieuKham)
        BEGIN
            RAISERROR(N'Lỗi: Phiếu khám này đã được thanh toán trước đó!', 16, 1);
        END

        -- 2. Lấy tiền khám (kiểm tra có thuộc đợt khám định kỳ miễn phí hay không)
        DECLARE @TienKham DECIMAL(18, 2) = 150000;
        DECLARE @MaHoSo VARCHAR(20);
        SELECT @MaHoSo = MaHoSo FROM PHIEU_KHAM_BENH WHERE MaPhieuKham = @MaPhieuKham;

        -- Nếu bệnh nhân có lịch khám định kỳ trong quý này được miễn phí
        DECLARE @TienMienGiam DECIMAL(18, 2) = 0;
        IF EXISTS (
            SELECT 1 FROM LICH_KHAM_DINH_KY 
            WHERE MaHoSo = @MaHoSo AND MienPhiTienKham = 1 AND TrangThaiLich = N'Đã đặt lịch'
        )
        BEGIN
            SET @TienMienGiam = @TienKham; -- Miễn phí 100% tiền khám
            UPDATE LICH_KHAM_DINH_KY SET TrangThaiLich = N'Đã khám' 
            WHERE MaHoSo = @MaHoSo AND MienPhiTienKham = 1 AND TrangThaiLich = N'Đã đặt lịch';
        END

        -- 3. Tính tiền xét nghiệm
        DECLARE @TienXetNghiem DECIMAL(18, 2) = 0;
        SELECT @TienXetNghiem = ISNULL(SUM(kq.DonGia), 0)
        FROM KET_QUA_XET_NGHIEM kq
        JOIN CHI_DINH_XET_NGHIEM cd ON kq.MaChiDinh = cd.MaChiDinh
        WHERE cd.MaPhieuKham = @MaPhieuKham;

        -- 4. Tính tiền thuốc
        DECLARE @TienThuoc DECIMAL(18, 2) = 0;
        SELECT @TienThuoc = ISNULL(TongTienThuoc, 0)
        FROM TOA_THUOC
        WHERE MaPhieuKham = @MaPhieuKham;

        -- 5. Tổng tiền phải trả
        DECLARE @TongTien DECIMAL(18, 2) = (@TienKham + @TienXetNghiem + @TienThuoc) - @TienMienGiam;

        -- 6. Xuất hóa đơn
        INSERT INTO HOA_DON_VIEN_PHI (MaHoaDon, MaPhieuKham, MaThuNgan, NgayLap, TienKham, TienXetNghiem, TienThuoc, TienMienGiam, TongTienThanhToan, HinhThucThanhToan, TrangThai)
        VALUES (@MaHoaDon, @MaPhieuKham, @MaThuNgan, GETDATE(), @TienKham, @TienXetNghiem, @TienThuoc, @TienMienGiam, @TongTien, @HinhThucThanhToan, N'Đã thanh toán');

        -- 7. Hoàn tất đợt khám (Đổi trạng thái Phiếu khám và Hồ sơ bệnh án)
        UPDATE PHIEU_KHAM_BENH SET TrangThaiKham = N'Đã hoàn tất' WHERE MaPhieuKham = @MaPhieuKham;
        UPDATE HO_SO_BENH_AN SET NgayCapNhatCuoi = GETDATE(), TrangThaiHoSo = N'Đã đóng đợt khám' WHERE MaHoSo = @MaHoSo;

        COMMIT TRANSACTION;
        SELECT N'Thành công: Đã thanh toán viện phí, xuất hóa đơn và đóng đợt khám bệnh án an toàn!' AS KetQua;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO


-- =============================================================================
-- PHẦN 3: DỮ LIỆU MẪU KIỂM THỬ (SEED DATA - TEST 5 QUY TẮC)
-- =============================================================================

-- 1. Khoa phòng
INSERT INTO KHOA_PHONG (MaKhoa, TenKhoa, ViTri) VALUES
('K01', N'Khoa Khám Bệnh', N'Tầng 1 - Khu A'),
('K02', N'Khoa Nội Tổng Quát', N'Tầng 2 - Khu B'),
('K03', N'Khoa Tim Mạch', N'Tầng 3 - Khu B'),
('K04', N'Khoa Xét Nghiệm', N'Tầng 1 - Khu C'),
('K05', N'Khoa Dược', N'Tầng trệt - Khu A');
GO

-- 2. Nhân viên y tế
INSERT INTO NHAN_VIEN (MaNhanVien, HoTen, NgaySinh, SoDienThoai, Email, LoaiNhanVien, ChuyenKhoa, MaKhoa) VALUES
('BS001', N'BS.CKII Trần Đình Nam', '1980-04-12', '0903112233', 'nam.tran@bvqt.vn', 'BacSi', N'Nội tổng quát', 'K02'),
('BS002', N'ThS.BS Nguyễn Lan Anh', '1985-08-20', '0908223344', 'lananh@bvqt.vn', 'BacSi', N'Tim mạch', 'K03'),
('NV001', N'Lê Thị Thu Thảo', '1995-02-15', '0912345678', 'thao.le@bvqt.vn', 'CSKH', NULL, 'K01'),
('TN001', N'Phạm Minh Tuấn', '1992-11-10', '0987654321', 'tuan.pham@bvqt.vn', 'ThuNgan', NULL, 'K01');
GO

-- 3. Danh mục xét nghiệm
INSERT INTO LOAI_XET_NGHIEM (MaXetNghiem, TenXetNghiem, DonGia, DonViTinh, ChiSoThamChieuBinhThuong) VALUES
('XN01', N'Tổng phân tích tế bào máu (CBC)', 150000, N'Lần', N'WBC: 4.0 - 10.0 K/uL; RBC: 4.0 - 5.5 M/uL'),
('XN02', N'Đường huyết lúc đói (Glucose máu)', 80000, N'Lần', N'3.9 - 6.4 mmol/L'),
('XN03', N'Chức năng gan (AST / ALT)', 120000, N'Lần', N'AST < 40 U/L; ALT < 40 U/L'),
('XN04', N'Chụp X-quang phổi thẳng', 200000, N'Lần', N'Phổi sáng đều, không tổn thương khu trú');
GO

-- 4. Danh mục thuốc
INSERT INTO THUOC (MaThuoc, TenThuoc, HoatChat, DonViTinh, DonGia, SoLuongTon, ChongChiDinh) VALUES
('TH01', N'Panadol Extra', N'Paracetamol 500mg + Caffeine 65mg', N'Viên', 2500, 5000, N'Mẫn cảm Paracetamol, suy gan nặng'),
('TH02', N'Amoxicillin 500mg', N'Amoxicillin', N'Viên', 3000, 2000, N'Dị ứng nhóm Penicillin'),
('TH03', N'Amlodipin 5mg', N'Amlodipin besylat', N'Viên', 4500, 1500, N'Hạ huyết áp nặng, sốc tim'),
('TH04', N'Metformin 850mg', N'Metformin hydroclorid', N'Viên', 3500, 3000, N'Suy thận cấp, nhiễm toan ceton'),
('TH05', N'Berberin 100mg', N'Berberin clorid', N'Viên', 1200, 4000, N'Phụ nữ có thai');
GO

-- 5. Bệnh nhân mẫu kiểm thử (TEST QUY TẮC 1: Đăng ký lần đầu + Cấp hồ sơ + Phí năm)
DECLARE @OutHS VARCHAR(20);
DECLARE @OutPT VARCHAR(20);

EXEC sp_DangKyVaCapHoSoBenhAn 
    @MaBN = 'BN001',
    @HoTen = N'Trần Nguyên',
    @NgaySinh = '2004-05-15',
    @GioiTinh = N'Nam',
    @DiaChi = N'123 Lê Duẩn, Bến Nghé, Quận 1, TP.HCM',
    @SoDienThoai = '0908123456',
    @SoCCCD = '079204001234',
    @HinhAnh3x4 = N'avatar_trannguyen.jpg',
    @TienSuBenh = N'Đau dạ dày nhẹ',
    @DiUngThuoc = N'Không dị ứng',
    @SoTienPhiNam = 500000,
    @MaHS = @OutHS OUTPUT,
    @MaPT = @OutPT OUTPUT;

EXEC sp_DangKyVaCapHoSoBenhAn 
    @MaBN = 'BN002',
    @HoTen = N'Nguyễn Thị Mai',
    @NgaySinh = '1998-10-20',
    @GioiTinh = N'Nữ',
    @DiaChi = N'45 Hai Bà Trưng, Quận 3, TP.HCM',
    @SoDienThoai = '0912345678',
    @SoCCCD = '079198005678',
    @HinhAnh3x4 = N'avatar_nguyenmai.jpg',
    @TienSuBenh = N'Tăng huyết áp vô căn',
    @DiUngThuoc = N'Dị ứng Penicillin',
    @SoTienPhiNam = 500000,
    @MaHS = @OutHS OUTPUT,
    @MaPT = @OutPT OUTPUT;
GO

-- 6. Đặt lịch khám định kỳ theo quý (TEST QUY TẮC 3: Miễn phí tiền khám theo quý)
INSERT INTO LICH_KHAM_DINH_KY (MaLichHen, MaHoSo, QuyKham, NamKham, NgayHen, GioHen, MienPhiTienKham, GhiChu) VALUES
('LH001', 'HS001', 4, 2026, '2026-10-20', '08:30', 1, N'Khám sức khỏe tổng quát định kỳ quý 4'),
('LH002', 'HS002', 4, 2026, '2026-10-22', '09:00', 1, N'Khám định kỳ huyết áp & tim mạch');
GO

-- 7. Phiếu khám + Xét nghiệm + Kê toa thuốc (TEST QUY TẮC 4: Liên kết XN/Toa với Phiếu khám)
EXEC sp_KhamBenhChiDinhVaKeToa
    @MaPhieuKham = 'PK001',
    @MaHoSo = 'HS001',
    @MaBacSi = 'BS001',
    @KhoaDieuTri = N'Khoa Nội Tổng Quát',
    @TrieuChung = N'Nhức đầu ê ẩm vùng trán, sốt nhẹ 37.8 độ C',
    @ThanNhiet = 37.8,
    @HuyetAp = '120/80',
    @ChanDoanCuoiCung = N'Cảm cúm siêu vi kèm nhức đầu căng thẳng',
    @MaChiDinh = 'CD001',
    @MaXetNghiem = 'XN01',
    @ChiSoKQ = N'WBC: 7.2 K/uL (Bình thường)',
    @MaToaThuoc = 'TT001',
    @MaThuoc = 'TH01',
    @SoLuongThuoc = 20,
    @CachDung = N'Uống mỗi lần 1 viên khi sốt trên 38 độ hoặc đau đầu';
GO

-- 8. Thanh toán viện phí và đóng bệnh án (TEST QUY TẮC 5: Miễn giảm định kỳ, xuất hóa đơn, khóa bệnh án)
EXEC sp_ThanhToanVienPhiVaDongBenhAn
    @MaHoaDon = 'HD001',
    @MaPhieuKham = 'PK001',
    @MaThuNgan = 'TN001',
    @HinhThucThanhToan = N'Chuyển khoản';
GO


-- =============================================================================
-- KIỂM TRA TOÀN BỘ KẾT QUẢ CSDL
-- =============================================================================
SELECT 'BENH_NHAN' AS Bang, COUNT(*) AS SoDong FROM BENH_NHAN
UNION ALL
SELECT 'HO_SO_BENH_AN', COUNT(*) FROM HO_SO_BENH_AN
UNION ALL
SELECT 'LE_PHI_NAM', COUNT(*) FROM LE_PHI_NAM
UNION ALL
SELECT 'LICH_KHAM_DINH_KY', COUNT(*) FROM LICH_KHAM_DINH_KY
UNION ALL
SELECT 'NHAN_VIEN', COUNT(*) FROM NHAN_VIEN
UNION ALL
SELECT 'PHIEU_KHAM_BENH', COUNT(*) FROM PHIEU_KHAM_BENH
UNION ALL
SELECT 'CHI_DINH_XET_NGHIEM', COUNT(*) FROM CHI_DINH_XET_NGHIEM
UNION ALL
SELECT 'KET_QUA_XET_NGHIEM', COUNT(*) FROM KET_QUA_XET_NGHIEM
UNION ALL
SELECT 'THUOC', COUNT(*) FROM THUOC
UNION ALL
SELECT 'TOA_THUOC', COUNT(*) FROM TOA_THUOC
UNION ALL
SELECT 'CHI_TIET_TOA_THUOC', COUNT(*) FROM CHI_TIET_TOA_THUOC
UNION ALL
SELECT 'HOA_DON_VIEN_PHI', COUNT(*) FROM HOA_DON_VIEN_PHI;
GO

-- XEM CHI TIẾT HÓA ĐƠN VỪA HOÀN TẤT THANH TOÁN
SELECT 
    hd.MaHoaDon,
    bn.HoTen,
    bn.SoCCCD,
    pk.MaPhieuKham,
    pk.ChanDoanCuoiCung,
    hd.TienKham,
    hd.TienXetNghiem,
    hd.TienThuoc,
    hd.TienMienGiam,
    hd.TongTienThanhToan,
    hd.HinhThucThanhToan,
    pk.TrangThaiKham,
    hs.TrangThaiHoSo
FROM HOA_DON_VIEN_PHI hd
JOIN PHIEU_KHAM_BENH pk ON hd.MaPhieuKham = pk.MaPhieuKham
JOIN HO_SO_BENH_AN hs ON pk.MaHoSo = hs.MaHoSo
JOIN BENH_NHAN bn ON hs.MaBenhNhan = bn.MaBenhNhan;
GO
