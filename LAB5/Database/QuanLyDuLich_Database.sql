/* =========================================================================
   HỆ THỐNG QUẢN LÝ CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM
   Môn học: Phương pháp phát triển phần mềm hướng đối tượng (OOSD)
   Sinh viên thực hiện: Trần Nguyên - MSSV: 1250080121 - Lớp: 12CNPM2
   Trường: Đại học Tài nguyên và Môi trường TP.HCM (HCMUNRE)
   Giảng viên hướng dẫn: ThS. Phạm Trọng Huynh
   Đề tài: BÀI 6 - QUẢN LÝ CÔNG TY DU LỊCH (LAB 05)
   Kiến trúc: CSDL 16 bảng chuẩn 3NF, đồng bộ nhất quán 100% với Mô hình lớp OOSD
========================================================================= */

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QuanLyDuLich_VanHoaViet')
BEGIN
    ALTER DATABASE QuanLyDuLich_VanHoaViet SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyDuLich_VanHoaViet;
END
GO

CREATE DATABASE QuanLyDuLich_VanHoaViet;
GO

USE QuanLyDuLich_VanHoaViet;
GO

-- =========================================================================
-- PHẦN 1: TẠO BẢNG CSDL (16 BẢNG CHUẨN 3NF)
-- =========================================================================

-- 1. Bảng Điểm bán vé (DiemBanVe)
CREATE TABLE DiemBanVe (
    MaDiemBanVe VARCHAR(20) PRIMARY KEY,
    TenDiemBanVe NVARCHAR(150) NOT NULL,
    DiaChi NVARCHAR(250) NOT NULL,
    SoDienThoai VARCHAR(20) NOT NULL,
    NguoiQuanLy NVARCHAR(100) NOT NULL
);
GO

-- 2. Bảng Tour du lịch (TourDuLich)
CREATE TABLE TourDuLich (
    MaTour VARCHAR(20) PRIMARY KEY,
    TenTour NVARCHAR(200) NOT NULL,
    SoNgay INT NOT NULL CHECK (SoNgay > 0),
    SoDem INT NOT NULL CHECK (SoDem >= 0),
    DonGiaKhach DECIMAL(18,2) NOT NULL CHECK (DonGiaKhach > 0),
    DiemXuatPhat NVARCHAR(100) NOT NULL DEFAULT N'TP.HCM',
    DiemKetThuc NVARCHAR(100) NOT NULL DEFAULT N'TP.HCM',
    MoTaQuangCao NVARCHAR(MAX) NULL,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'DangKhaiThac' CHECK (TrangThai IN (N'DangKhaiThac', N'TamNgung'))
);
GO

-- 3. Bảng Nơi dừng chân (NoiDungChan - Composition với TourDuLich)
CREATE TABLE NoiDungChan (
    MaNoiDungChan VARCHAR(20) PRIMARY KEY,
    MaTour VARCHAR(20) NOT NULL,
    ThuTuChang INT NOT NULL CHECK (ThuTuChang > 0),
    TenDiaDanh NVARCHAR(150) NOT NULL,
    CoDoiPhuongTien BIT NOT NULL DEFAULT 0,
    PhuongTienDiChuyen NVARCHAR(100) NOT NULL, -- Máy bay, xe đò, tàu hỏa...
    CoNoiAn BIT NOT NULL DEFAULT 1,
    CoKhachSan BIT NOT NULL DEFAULT 1,
    TenKhachSan NVARCHAR(150) NULL,
    HangSaoKhachSan INT NULL CHECK (HangSaoKhachSan BETWEEN 2 AND 5),
    CONSTRAINT FK_NoiDungChan_Tour FOREIGN KEY (MaTour) REFERENCES TourDuLich(MaTour) ON DELETE CASCADE
);
GO

-- 4. Bảng Điểm tham quan (DiemThamQuan - Thuộc Tour hoặc Tuyến điểm)
CREATE TABLE DiemThamQuan (
    MaDiemThamQuan VARCHAR(20) PRIMARY KEY,
    MaTour VARCHAR(20) NOT NULL,
    TenDiemThamQuan NVARCHAR(200) NOT NULL,
    DiaDiemThamQuan NVARCHAR(250) NOT NULL,
    NoiDung NVARCHAR(MAX) NULL,
    YNghia NVARCHAR(MAX) NULL,
    CONSTRAINT FK_DiemThamQuan_Tour FOREIGN KEY (MaTour) REFERENCES TourDuLich(MaTour) ON DELETE CASCADE
);
GO

-- 5. Bảng Khách hàng cha (KhachHang)
CREATE TABLE KhachHang (
    MaKH VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NULL,
    DiaChi NVARCHAR(250) NOT NULL,
    LoaiKhach VARCHAR(10) NOT NULL CHECK (LoaiKhach IN ('DOAN', 'LE'))
);
GO

-- 6. Bảng Khách hàng theo đoàn (KhachHangDoan - Kế thừa KhachHang)
CREATE TABLE KhachHangDoan (
    MaKH VARCHAR(20) PRIMARY KEY,
    TenCoQuan NVARCHAR(200) NOT NULL,
    NguoiDaiDien NVARCHAR(100) NOT NULL,
    DienThoaiCoQuan VARCHAR(20) NOT NULL,
    DiaDiemDonYeuCau NVARCHAR(250) NOT NULL,
    CONSTRAINT FK_KhachDoan_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) ON DELETE CASCADE
);
GO

-- 7. Bảng Khách hàng lẻ (KhachHangLe - Kế thừa KhachHang)
CREATE TABLE KhachHangLe (
    MaKH VARCHAR(20) PRIMARY KEY,
    SoNguoiDi INT NOT NULL DEFAULT 1 CHECK (SoNguoiDi < 12),
    MaDiemDonQuyDinh NVARCHAR(150) NOT NULL,
    CONSTRAINT FK_KhachLe_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) ON DELETE CASCADE
);
GO

-- 8. Bảng Phiếu đăng ký tour theo đoàn (PhieuDangKyDoan - Cho đoàn >= 12 người)
CREATE TABLE PhieuDangKyDoan (
    MaPhieuDangKy VARCHAR(20) PRIMARY KEY,
    MaKH VARCHAR(20) NOT NULL,
    MaTour VARCHAR(20) NOT NULL,
    NgayKhoiHanh DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    SoLuongKhach INT NOT NULL CHECK (SoLuongKhach >= 12),
    DiaDiemDon NVARCHAR(250) NOT NULL,
    CoMuaBaoHiem BIT NOT NULL DEFAULT 1,
    KinhPhiDuKien DECIMAL(18,2) NOT NULL,
    TienDatCoc DECIMAL(18,2) NOT NULL,
    NgayDatCoc DATE NOT NULL,
    TinhTrangCoc NVARCHAR(50) NOT NULL DEFAULT N'DaCoc' CHECK (TinhTrangCoc IN (N'DaCoc', N'MatCoc', N'HoanTat')),
    SoTienConLai DECIMAL(18,2) NOT NULL,
    TrangThaiThanhToan NVARCHAR(50) NOT NULL DEFAULT N'ChuaThanhToan' CHECK (TrangThaiThanhToan IN (N'ChuaThanhToan', N'DaQuyetToan')),
    NgayLap DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_PhieuDoan_KhachDoan FOREIGN KEY (MaKH) REFERENCES KhachHangDoan(MaKH),
    CONSTRAINT FK_PhieuDoan_Tour FOREIGN KEY (MaTour) REFERENCES TourDuLich(MaTour)
);
GO

-- 9. Bảng Người tham gia bảo hiểm (NguoiThamGiaBaoHiem - Composition với PhieuDangKyDoan)
CREATE TABLE NguoiThamGiaBaoHiem (
    MaBaoHiem VARCHAR(20) PRIMARY KEY,
    MaPhieuDangKy VARCHAR(20) NOT NULL,
    HoTenNguoiDi NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    CCCD VARCHAR(20) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    QuanHeVoiDaiDien NVARCHAR(50) NULL,
    CONSTRAINT FK_BaoHiem_PhieuDoan FOREIGN KEY (MaPhieuDangKy) REFERENCES PhieuDangKyDoan(MaPhieuDangKy) ON DELETE CASCADE
);
GO

-- 10. Bảng Chuyến đi lịch cố định cho khách lẻ (ChuyenDi)
CREATE TABLE ChuyenDi (
    MaChuyen VARCHAR(20) PRIMARY KEY,
    MaTour VARCHAR(20) NOT NULL,
    NgayKhoiHanh DATE NOT NULL,
    NgayVe DATE NOT NULL,
    SoChoToiDa INT NOT NULL DEFAULT 40 CHECK (SoChoToiDa > 0),
    SoChoDaDat INT NOT NULL DEFAULT 0 CHECK (SoChoDaDat >= 0),
    DiemDonQuyDinh NVARCHAR(250) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'MoBan' CHECK (TrangThai IN (N'MoBan', N'HetCho', N'HoanTat', N'Huy')),
    CONSTRAINT FK_ChuyenDi_Tour FOREIGN KEY (MaTour) REFERENCES TourDuLich(MaTour)
);
GO

-- 11. Bảng Vé du lịch cho khách lẻ (VeDuLich)
CREATE TABLE VeDuLich (
    MaVe VARCHAR(20) PRIMARY KEY,
    MaChuyen VARCHAR(20) NOT NULL,
    MaKH VARCHAR(20) NOT NULL,
    MaDiemBanVe VARCHAR(20) NOT NULL,
    SoLuongVe INT NOT NULL DEFAULT 1 CHECK (SoLuongVe > 0),
    DonGiaVe DECIMAL(18,2) NOT NULL CHECK (DonGiaVe > 0),
    TongTien DECIMAL(18,2) NOT NULL,
    NgayMua DATETIME NOT NULL DEFAULT GETDATE(),
    HinhThucThanhToan NVARCHAR(50) NOT NULL DEFAULT N'TienMat' CHECK (HinhThucThanhToan IN (N'TienMat', N'ChuyenKhoan', N'The')),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'DaXuatVe' CHECK (TrangThai IN (N'DaXuatVe', N'DaHuy')),
    CONSTRAINT FK_VeDuLich_ChuyenDi FOREIGN KEY (MaChuyen) REFERENCES ChuyenDi(MaChuyen),
    CONSTRAINT FK_VeDuLich_KhachLe FOREIGN KEY (MaKH) REFERENCES KhachHangLe(MaKH),
    CONSTRAINT FK_VeDuLich_DiemBanVe FOREIGN KEY (MaDiemBanVe) REFERENCES DiemBanVe(MaDiemBanVe)
);
GO

-- 12. Bảng Nhân viên công ty cha (NhanVien)
CREATE TABLE NhanVien (
    MaNV VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    SoDienThoai VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NULL,
    ChucVu NVARCHAR(50) NOT NULL CHECK (ChucVu IN (N'HuongDanVien', N'BanVe', N'DieuHanh', N'KeToan')),
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(100) NOT NULL DEFAULT '123456'
);
GO

-- 13. Bảng Hướng dẫn viên du lịch (HuongDanVien - Kế thừa NhanVien)
CREATE TABLE HuongDanVien (
    MaNV VARCHAR(20) PRIMARY KEY,
    NgoaiNgu NVARCHAR(100) NOT NULL DEFAULT N'Tiếng Anh',
    KinhNghiemNam INT NOT NULL DEFAULT 1,
    LuongCanBan DECIMAL(18,2) NOT NULL DEFAULT 7000000,
    ThuLaoMoiTour DECIMAL(18,2) NOT NULL DEFAULT 800000,
    TrangThaiLich NVARCHAR(50) NOT NULL DEFAULT N'RanhRoi' CHECK (TrangThaiLich IN (N'RanhRoi', N'DangDanTour')),
    CONSTRAINT FK_HuongDanVien_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE CASCADE
);
GO

-- 14. Bảng Phân công Hướng dẫn viên (PhanCongHDV)
CREATE TABLE PhanCongHDV (
    MaPhanCong VARCHAR(20) PRIMARY KEY,
    MaNV VARCHAR(20) NOT NULL,
    LoaiTourDung VARCHAR(15) NOT NULL CHECK (LoaiTourDung IN ('CHUYEN_LE', 'DOAN')),
    MaChuyen VARCHAR(20) NULL,
    MaPhieuDangKy VARCHAR(20) NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    VaiTroHDV NVARCHAR(50) NOT NULL DEFAULT N'TruongDoan' CHECK (VaiTroHDV IN (N'TruongDoan', N'PhuTa')),
    GhiChu NVARCHAR(250) NULL,
    CONSTRAINT FK_PhanCong_HDV FOREIGN KEY (MaNV) REFERENCES HuongDanVien(MaNV),
    CONSTRAINT FK_PhanCong_Chuyen FOREIGN KEY (MaChuyen) REFERENCES ChuyenDi(MaChuyen),
    CONSTRAINT FK_PhanCong_PhieuDoan FOREIGN KEY (MaPhieuDangKy) REFERENCES PhieuDangKyDoan(MaPhieuDangKy)
);
GO

-- 15. Bảng Tính lương HDV theo tháng (BangLuongHDV)
CREATE TABLE BangLuongHDV (
    MaBangLuong VARCHAR(20) PRIMARY KEY,
    MaNV VARCHAR(20) NOT NULL,
    ThangNam VARCHAR(10) NOT NULL, -- Định dạng: MM/yyyy
    LuongCanBan DECIMAL(18,2) NOT NULL,
    SoTourThucHien INT NOT NULL DEFAULT 0,
    TongThuLaoTour DECIMAL(18,2) NOT NULL DEFAULT 0,
    PhuCapKhac DECIMAL(18,2) NOT NULL DEFAULT 0,
    TongLuongThucNhan DECIMAL(18,2) NOT NULL,
    NgayTinh DATE NOT NULL DEFAULT GETDATE(),
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'ChuaChi' CHECK (TrangThai IN (N'ChuaChi', N'DaChi')),
    CONSTRAINT FK_BangLuong_HDV FOREIGN KEY (MaNV) REFERENCES HuongDanVien(MaNV)
);
GO

-- 16. Bảng Phiếu khảo sát chất lượng sau tour (PhieuKhaoSat)
CREATE TABLE PhieuKhaoSat (
    MaPhieuKhaoSat VARCHAR(20) PRIMARY KEY,
    MaKH VARCHAR(20) NOT NULL,
    LoaiLichTrinh VARCHAR(15) NOT NULL CHECK (LoaiLichTrinh IN ('CHUYEN_LE', 'DOAN')),
    MaChuyen VARCHAR(20) NULL,
    MaPhieuDangKy VARCHAR(20) NULL,
    MaTour VARCHAR(20) NOT NULL,
    DiemPhuongTien INT NOT NULL CHECK (DiemPhuongTien BETWEEN 1 AND 5),
    DiemKhachSan INT NOT NULL CHECK (DiemKhachSan BETWEEN 1 AND 5),
    DiemAnUong INT NOT NULL CHECK (DiemAnUong BETWEEN 1 AND 5),
    DiemHDV INT NOT NULL CHECK (DiemHDV BETWEEN 1 AND 5),
    DiemTongQuan INT NOT NULL CHECK (DiemTongQuan BETWEEN 1 AND 5),
    YKienDongGop NVARCHAR(MAX) NULL,
    NgayKhaoSat DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_KhaoSat_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_KhaoSat_Tour FOREIGN KEY (MaTour) REFERENCES TourDuLich(MaTour)
);
GO

-- =========================================================================
-- PHẦN 2: DỮ LIỆU MẪU (SEED DATA TIẾNG VIỆT THỰC TẾ)
-- =========================================================================

-- 1. Thêm Điểm bán vé
INSERT INTO DiemBanVe VALUES
('DBV01', N'Trụ sở chính Văn Hóa Việt', N'123 Nguyễn Thị Minh Khai, Q.1, TP.HCM', '02838221199', N'Lê Minh Tuấn'),
('DBV02', N'Văn phòng Chi nhánh Tân Bình', N'45 Cộng Hòa, P.4, Q.Tân Bình, TP.HCM', '02838112233', N'Nguyễn Thị Kim Loan'),
('DBV03', N'Đại lý vé Bến Thành', N'12 Lê Lợi, P.Bến Nghé, Q.1, TP.HCM', '02838997755', N'Trần Đình Trọng');
GO

-- 2. Thêm Tour du lịch
INSERT INTO TourDuLich VALUES
('TOUR01', N'Khám phá Đảo Ngọc Phú Quốc - Thiên đường nhiệt đới', 3, 2, 4500000, N'TP.HCM', N'TP.HCM', N'Trải nghiệm lặn ngắm san hô, tắm biển Bãi Sao và ngắm hoàng hôn Sunset Sanato.', N'DangKhaiThac'),
('TOUR02', N'Đà Lạt - Xứ sở sương mù & Ngàn hoa rực rỡ', 4, 3, 3200000, N'TP.HCM', N'TP.HCM', N'Tham quan Thung lũng Tình Yêu, đỉnh Langbiang hùng vĩ và đồi chè Cầu Đất.', N'DangKhaiThac'),
('TOUR03', N'Hành trình Di sản Miền Trung: Đà Nẵng - Bà Nà - Hội An', 4, 3, 5800000, N'TP.HCM', N'TP.HCM', N'Chiêm ngưỡng Cầu Vàng, khám phá phố cổ Hội An lung linh hoa đăng ban đêm.', N'DangKhaiThac'),
('TOUR04', N'Sông nước Miền Tây: Mỹ Tho - Bến Tre - Cần Thơ', 2, 1, 1950000, N'TP.HCM', N'TP.HCM', N'Thưởng thức trái cây miệt vườn, nghe đờn ca tài tử và họp chợ nổi Cái Răng.', N'DangKhaiThac'),
('TOUR05', N'Nha Trang Biển Gọi - VinWonders & Vịnh Nha Phu', 3, 2, 3850000, N'TP.HCM', N'TP.HCM', N'Du ngoạn 4 đảo, tắm khoáng bùn nóng I-Resort và vui chơi thỏa thích tại Vinpearl.', N'DangKhaiThac');
GO

-- 3. Thêm Nơi dừng chân
INSERT INTO NoiDungChan VALUES
('NDC01_1', 'TOUR01', 1, N'Sân bay Tân Sơn Nhất (TP.HCM)', 1, N'Máy bay (Vietnam Airlines)', 0, 0, NULL, NULL),
('NDC01_2', 'TOUR01', 2, N'Đảo Phú Quốc (Kiên Giang)', 1, N'Xe du lịch chất lượng cao', 1, 1, N'Khách sạn Novotel Resort', 5),
('NDC01_3', 'TOUR01', 3, N'Sân bay Quốc tế Phú Quốc', 1, N'Máy bay bay về TP.HCM', 0, 0, NULL, NULL),

('NDC02_1', 'TOUR02', 1, N'Ngã ba Dầu Giây (Đồng Nai)', 0, N'Xe ô tô giường nằm VIP', 1, 0, NULL, NULL),
('NDC02_2', 'TOUR02', 2, N'TP. Đà Lạt (Lâm Đồng)', 1, N'Xe ô tô tham quan nội thành', 1, 1, N'Khách sạn Colline Đà Lạt', 4),
('NDC02_3', 'TOUR02', 3, N'Trạm dừng Madagui (Lâm Đồng)', 0, N'Xe ô tô chạy về TP.HCM', 1, 0, NULL, NULL),

('NDC03_1', 'TOUR03', 1, N'Sân bay Quốc tế Đà Nẵng', 1, N'Máy bay (Vietjet Air)', 0, 0, NULL, NULL),
('NDC03_2', 'TOUR03', 2, N'Bán đảo Sơn Trà & Biển Mỹ Khê', 1, N'Xe ô tô cao cấp', 1, 1, N'Khách sạn Mường Thanh Luxury', 5),
('NDC03_3', 'TOUR03', 3, N'Phố cổ Hội An (Quảng Nam)', 0, N'Xe ô tô di chuyển về Đà Nẵng', 1, 1, N'Hội An Historic Hotel', 4);
GO

-- 4. Thêm Điểm tham quan
INSERT INTO DiemThamQuan VALUES
('DTQ01_1', 'TOUR01', N'Bãi Sao Phú Quốc', N'An Thới, Phú Quốc', N'Bãi biển cát trắng mịn màng hình cánh cung uốn lượn', N'Danh lam thắng cảnh bãi biển đẹp nhất Phú Quốc'),
('DTQ01_2', 'TOUR01', N'Nhà tù Phú Quốc', N'Xã An Thới, Phú Quốc', N'Khu di tích lịch sử giam giữ chiến sĩ cách mạng kiên trung', N'Di tích lịch sử quốc gia đặc biệt'),
('DTQ02_1', 'TOUR02', N'Thung lũng Tình Yêu', N'Đường Mai Anh Đào, TP. Đà Lạt', N'Không gian xanh thơ mộng ngập tràn sắc hoa và hồ Đa Thiện', N'Biểu tượng du lịch lãng mạn xứ sở sương mù'),
('DTQ02_2', 'TOUR02', N'Đỉnh núi Langbiang', N'Huyện Lạc Dương, Lâm Đồng', N'Đỉnh núi cao nhất vùng Tây Nguyên huyền thoại gắn với tình chàng Lang nàng Biang', N'Khu dự trữ sinh quyển thế giới'),
('DTQ03_1', 'TOUR03', N'Bà Nà Hills - Cầu Vàng', N'Hòa Vang, TP. Đà Nẵng', N'Khu du lịch trên đỉnh núi Chúa với Cầu Vàng bàn tay khổng lồ nổi tiếng thế giới', N'Kỳ quan kiến trúc hiện đại hàng đầu thế giới'),
('DTQ03_2', 'TOUR03', N'Chùa Cầu & Phố cổ Hội An', N'TP. Hội An, Quảng Nam', N'Thương cảng cổ truyền thống thế kỷ 17 với đèn lồng rực rỡ', N'Di sản văn hóa thế giới UNESCO công nhận');
GO

-- 5. Thêm Nhân viên & Hướng dẫn viên
INSERT INTO NhanVien VALUES
('NV001', N'Trần Minh Khang', '1992-05-14', N'Nam', '0903112233', 'khangtm@vanhoaviet.vn', N'HuongDanVien', 'khangtm', '123456'),
('NV002', N'Nguyễn Thúy Hằng', '1995-09-20', N'Nữ', '0918223344', 'hangnt@vanhoaviet.vn', N'HuongDanVien', 'hangnt', '123456'),
('NV003', N'Võ Hoàng Sơn', '1989-11-12', N'Nam', '0933445566', 'sonvh@vanhoaviet.vn', N'HuongDanVien', 'sonvh', '123456'),
('NV004', N'Phạm Phương Thảo', '1996-03-08', N'Nữ', '0944556677', 'thaopp@vanhoaviet.vn', N'BanVe', 'thaopp', '123456'),
('NV005', N'Đỗ Quốc Hưng', '1988-07-25', N'Nam', '0988776655', 'hungdq@vanhoaviet.vn', N'DieuHanh', 'hungdq', '123456'),
('NV006', N'Bùi Bích Ngọc', '1993-12-30', N'Nữ', '0977665544', 'ngocbb@vanhoaviet.vn', N'KeToan', 'ngocbb', '123456');
GO

INSERT INTO HuongDanVien VALUES
('NV001', N'Tiếng Anh, Tiếng Pháp', 6, 8500000, 1000000, N'RanhRoi'),
('NV002', N'Tiếng Anh, Tiếng Hàn', 4, 7500000, 850000, N'RanhRoi'),
('NV003', N'Tiếng Anh, Tiếng Trung', 8, 9500000, 1200000, N'DangDanTour');
GO

-- 6. Thêm Khách hàng, Khách đoàn, Khách lẻ
INSERT INTO KhachHang VALUES
('KH001', N'Trần Văn Long', '0908123456', 'longtv@vietcombank.com.vn', N'Công ty CP Dược phẩm SaPa, 120 Hai Bà Trưng, Q.1', 'DOAN'),
('KH002', N'Nguyễn Hồng Phúc', '0919876543', 'phucnh@fpt.com.vn', N'Tập đoàn Công nghệ FPT Chi nhánh Miền Nam', 'DOAN'),
('KH003', N'Lê Thị Thu Thủy', '0938111222', 'thuy.le@gmail.com', N'45 Lê Trọng Tấn, P.Tây Thạnh, Q.Tân Phú, TP.HCM', 'LE'),
('KH004', N'Hoàng Trọng Nghĩa', '0979333444', 'nghiaht@gmail.com', N'78 Xô Viết Nghệ Tĩnh, P.25, Q.Bình Thạnh, TP.HCM', 'LE');
GO

INSERT INTO KhachHangDoan VALUES
('KH001', N'Công ty Cổ phần Dược phẩm SaPa', N'Trần Văn Long (Trưởng phòng HCNS)', '02838228899', N'Trụ sở công ty SaPa, 120 Hai Bà Trưng, Q.1, TP.HCM'),
('KH002', N'Tập đoàn Công nghệ FPT Miền Nam', N'Nguyễn Hồng Phúc (Chủ tịch Công đoàn)', '02873006666', N'Khu Công nghệ cao, TP.Thủ Đức, TP.HCM');
GO

INSERT INTO KhachHangLe VALUES
('KH003', 2, N'Điểm đón Nhà hát Thành Phố, Q.1'),
('KH004', 4, N'Điểm đón Cây xăng Comeco Hàng Xanh, Bình Thạnh');
GO

-- 7. Thêm Phiếu đăng ký đoàn (>= 12 khách) & Danh sách bảo hiểm
INSERT INTO PhieuDangKyDoan VALUES
('PDK001', 'KH001', 'TOUR01', '2026-11-15', '2026-11-17', 25, N'120 Hai Bà Trưng, Q.1, TP.HCM', 1, 112500000, 40000000, '2026-10-20', N'DaCoc', 72500000, N'ChuaThanhToan', '2026-10-20'),
('PDK002', 'KH002', 'TOUR03', '2026-12-05', '2026-12-08', 30, N'Khu Công nghệ cao, TP.Thủ Đức', 1, 174000000, 60000000, '2026-10-22', N'DaCoc', 114000000, N'ChuaThanhToan', '2026-10-22');
GO

INSERT INTO NguoiThamGiaBaoHiem VALUES
('BH001', 'PDK001', N'Trần Văn Long', '1982-04-10', '079082001122', N'Nam', N'Trưởng đoàn'),
('BH002', 'PDK001', N'Nguyễn Thị Mai', '1985-08-22', '079085003344', N'Nữ', N'Phó đoàn'),
('BH003', 'PDK001', N'Lê Minh Quân', '1990-12-05', '079090005566', N'Nam', N'Nhân viên'),
('BH004', 'PDK002', N'Nguyễn Hồng Phúc', '1980-02-15', '079080009988', N'Nam', N'Trưởng đoàn'),
('BH005', 'PDK002', N'Đặng Thu Trang', '1988-11-19', '079088007766', N'Nữ', N'Nhân viên');
GO

-- 8. Thêm Chuyến đi khách lẻ & Vé du lịch
INSERT INTO ChuyenDi VALUES
('CD001', 'TOUR01', '2026-11-06', '2026-11-08', 40, 18, N'Nhà hát Lớn TP.HCM, Q.1', N'MoBan'),
('CD002', 'TOUR02', '2026-11-12', '2026-11-15', 35, 26, N'Cây xăng Comeco Hàng Xanh, Bình Thạnh', N'MoBan'),
('CD003', 'TOUR04', '2026-11-01', '2026-11-02', 45, 45, N'Bến xe Miền Tây, Q.Bình Tân', N'HetCho');
GO

INSERT INTO VeDuLich VALUES
('VE001', 'CD001', 'KH003', 'DBV01', 2, 4500000, 9000000, '2026-10-23 09:30:00', N'ChuyenKhoan', N'DaXuatVe'),
('VE002', 'CD002', 'KH004', 'DBV02', 4, 3200000, 12800000, '2026-10-24 14:15:00', N'TienMat', N'DaXuatVe');
GO

-- 9. Thêm Phân công Hướng dẫn viên
INSERT INTO PhanCongHDV VALUES
('PC001', 'NV001', 'CHUYEN_LE', 'CD001', NULL, '2026-11-06', '2026-11-08', N'TruongDoan', N'Phân công dẫn chuyến lẻ Phú Quốc'),
('PC002', 'NV002', 'CHUYEN_LE', 'CD002', NULL, '2026-11-12', '2026-11-15', N'TruongDoan', N'Phân công dẫn chuyến lẻ Đà Lạt'),
('PC003', 'NV003', 'DOAN', NULL, 'PDK001', '2026-11-15', '2026-11-17', N'TruongDoan', N'Đoàn đông 25 người, chỉ định làm Trưởng đoàn'),
('PC004', 'NV001', 'DOAN', NULL, 'PDK001', '2026-11-15', '2026-11-17', N'PhuTa', N'Phụ tá hỗ trợ chăm sóc đoàn khách SaPa');
GO

-- 10. Thêm Bảng lương HDV
INSERT INTO BangLuongHDV VALUES
('BL001', 'NV001', '10/2026', 8500000, 3, 3000000, 500000, 12000000, '2026-10-25', N'DaChi'),
('BL002', 'NV002', '10/2026', 7500000, 2, 1700000, 300000, 9500000, '2026-10-25', N'DaChi'),
('BL003', 'NV003', '10/2026', 9500000, 4, 4800000, 700000, 15000000, '2026-10-25', N'DaChi');
GO

-- 11. Thêm Phiếu khảo sát chất lượng dịch vụ
INSERT INTO PhieuKhaoSat VALUES
('PKS001', 'KH003', 'CHUYEN_LE', 'CD001', NULL, 'TOUR01', 5, 5, 4, 5, 5, N'Chuyến đi rất vui, hướng dẫn viên nhiệt tình và khách sạn sạch sẽ!', '2026-10-24'),
('PKS002', 'KH001', 'DOAN', NULL, 'PDK001', 'TOUR01', 5, 4, 5, 5, 5, N'Dịch vụ đưa đón tận nơi rất chu đáo, công ty sẽ tiếp tục ủng hộ Văn Hóa Việt.', '2026-10-25');
GO

-- =========================================================================
-- PHẦN 3: CÁC STORED PROCEDURES NGHIỆP VỤ CỐT LÕI (BLL SUPPORT)
-- =========================================================================

-- SP 1: Kiểm tra chống trùng lịch và phân công HDV (Quy tắc BR12, BR13)
CREATE OR ALTER PROCEDURE sp_KiemTraVaPhanCongHDV
    @MaPhanCong VARCHAR(20),
    @MaNV VARCHAR(20),
    @LoaiTourDung VARCHAR(15),
    @MaChuyen VARCHAR(20) = NULL,
    @MaPhieuDangKy VARCHAR(20) = NULL,
    @NgayBatDau DATE,
    @NgayKetThuc DATE,
    @VaiTroHDV NVARCHAR(50) = N'TruongDoan',
    @GhiChu NVARCHAR(250) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra HDV có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM HuongDanVien WHERE MaNV = @MaNV)
    BEGIN
        RAISERROR(N'Lỗi: Mã Hướng dẫn viên không tồn tại trong hệ thống!', 16, 1);
        RETURN;
    END

    -- Kiểm tra chồng chéo lịch công tác (BR12)
    IF EXISTS (
        SELECT 1 FROM PhanCongHDV
        WHERE MaNV = @MaNV
          AND NOT (NgayKetThuc < @NgayBatDau OR NgayBatDau > @NgayKetThuc)
    )
    BEGIN
        RAISERROR(N'Lỗi: Hướng dẫn viên này đã có lịch dẫn tour khác trùng trong khoảng thời gian đã chọn!', 16, 1);
        RETURN;
    END

    -- Thêm phân công
    INSERT INTO PhanCongHDV (MaPhanCong, MaNV, LoaiTourDung, MaChuyen, MaPhieuDangKy, NgayBatDau, NgayKetThuc, VaiTroHDV, GhiChu)
    VALUES (@MaPhanCong, @MaNV, @LoaiTourDung, @MaChuyen, @MaPhieuDangKy, @NgayBatDau, @NgayKetThuc, @VaiTroHDV, @GhiChu);

    -- Cập nhật trạng thái lịch HDV
    UPDATE HuongDanVien SET TrangThaiLich = N'DangDanTour' WHERE MaNV = @MaNV;
END;
GO

-- SP 2: Bán vé khách lẻ & Cập nhật số chỗ trống của chuyến đi
CREATE OR ALTER PROCEDURE sp_DatVeKhachLe
    @MaVe VARCHAR(20),
    @MaChuyen VARCHAR(20),
    @MaKH VARCHAR(20),
    @MaDiemBanVe VARCHAR(20),
    @SoLuongVe INT,
    @HinhThucThanhToan NVARCHAR(50) = N'TienMat'
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    DECLARE @SoChoToiDa INT, @SoChoDaDat INT, @DonGia DECIMAL(18,2), @TongTien DECIMAL(18,2);

    -- Lấy thông tin chuyến đi và đơn giá tour
    SELECT @SoChoToiDa = cd.SoChoToiDa, @SoChoDaDat = cd.SoChoDaDat, @DonGia = t.DonGiaKhach
    FROM ChuyenDi cd
    JOIN TourDuLich t ON cd.MaTour = t.MaTour
    WHERE cd.MaChuyen = @MaChuyen;

    IF @SoChoToiDa IS NULL
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR(N'Lỗi: Chuyến đi không tồn tại!', 16, 1);
        RETURN;
    END

    -- Kiểm tra số chỗ còn trống
    IF (@SoChoDaDat + @SoLuongVe) > @SoChoToiDa
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR(N'Lỗi: Chuyến đi không đủ số chỗ trống cho số lượng vé yêu cầu!', 16, 1);
        RETURN;
    END

    SET @TongTien = @SoLuongVe * @DonGia;

    -- Thêm vé du lịch
    INSERT INTO VeDuLich (MaVe, MaChuyen, MaKH, MaDiemBanVe, SoLuongVe, DonGiaVe, TongTien, NgayMua, HinhThucThanhToan, TrangThai)
    VALUES (@MaVe, @MaChuyen, @MaKH, @MaDiemBanVe, @SoLuongVe, @DonGia, @TongTien, GETDATE(), @HinhThucThanhToan, N'DaXuatVe');

    -- Cập nhật số chỗ đã đặt và trạng thái chuyến đi
    UPDATE ChuyenDi
    SET SoChoDaDat = SoChoDaDat + @SoLuongVe,
        TrangThai = CASE WHEN (SoChoDaDat + @SoLuongVe) >= SoChoToiDa THEN N'HetCho' ELSE TrangThai END
    WHERE MaChuyen = @MaChuyen;

    COMMIT TRANSACTION;
END;
GO

-- SP 3: Lập phiếu đăng ký đoàn & Tự động tính cọc/kinh phí
CREATE OR ALTER PROCEDURE sp_LapPhieuDangKyDoan
    @MaPhieuDangKy VARCHAR(20),
    @MaKH VARCHAR(20),
    @MaTour VARCHAR(20),
    @NgayKhoiHanh DATE,
    @NgayKetThuc DATE,
    @SoLuongKhach INT,
    @DiaDiemDon NVARCHAR(250),
    @CoMuaBaoHiem BIT = 1,
    @TienDatCoc DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra điều kiện đoàn >= 12 khách (Quy tắc BR01)
    IF @SoLuongKhach < 12
    BEGIN
        RAISERROR(N'Lỗi: Khách đăng ký theo đoàn bắt buộc phải từ 12 người trở lên!', 16, 1);
        RETURN;
    END

    DECLARE @DonGia DECIMAL(18,2), @KinhPhiDuKien DECIMAL(18,2), @SoTienConLai DECIMAL(18,2);

    SELECT @DonGia = DonGiaKhach FROM TourDuLich WHERE MaTour = @MaTour;
    IF @DonGia IS NULL
    BEGIN
        RAISERROR(N'Lỗi: Mã Tour không tồn tại!', 16, 1);
        RETURN;
    END

    SET @KinhPhiDuKien = @SoLuongKhach * @DonGia;
    SET @SoTienConLai = @KinhPhiDuKien - @TienDatCoc;

    INSERT INTO PhieuDangKyDoan (MaPhieuDangKy, MaKH, MaTour, NgayKhoiHanh, NgayKetThuc, SoLuongKhach, DiaDiemDon, CoMuaBaoHiem, KinhPhiDuKien, TienDatCoc, NgayDatCoc, TinhTrangCoc, SoTienConLai, TrangThaiThanhToan, NgayLap)
    VALUES (@MaPhieuDangKy, @MaKH, @MaTour, @NgayKhoiHanh, @NgayKetThuc, @SoLuongKhach, @DiaDiemDon, @CoMuaBaoHiem, @KinhPhiDuKien, @TienDatCoc, GETDATE(), N'DaCoc', @SoTienConLai, N'ChuaThanhToan', GETDATE());
END;
GO

-- SP 4: Tính bảng lương tháng cho Hướng dẫn viên (Quy tắc BR14)
CREATE OR ALTER PROCEDURE sp_TinhLuongHDV
    @MaBangLuong VARCHAR(20),
    @MaNV VARCHAR(20),
    @ThangNam VARCHAR(10),
    @PhuCapKhac DECIMAL(18,2) = 0
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @LuongCanBan DECIMAL(18,2), @ThuLaoMoiTour DECIMAL(18,2), @SoTour INT, @TongThuLao DECIMAL(18,2), @TongLuong DECIMAL(18,2);

    SELECT @LuongCanBan = LuongCanBan, @ThuLaoMoiTour = ThuLaoMoiTour
    FROM HuongDanVien
    WHERE MaNV = @MaNV;

    IF @LuongCanBan IS NULL
    BEGIN
        RAISERROR(N'Lỗi: Hướng dẫn viên không tồn tại!', 16, 1);
        RETURN;
    END

    -- Đếm số tour HDV đã hoàn thành trong tháng
    SELECT @SoTour = COUNT(1)
    FROM PhanCongHDV
    WHERE MaNV = @MaNV
      AND FORMAT(NgayKetThuc, 'MM/yyyy') = @ThangNam;

    SET @TongThuLao = @SoTour * @ThuLaoMoiTour;
    SET @TongLuong = @LuongCanBan + @TongThuLao + @PhuCapKhac;

    -- Thêm hoặc cập nhật bảng lương
    IF EXISTS (SELECT 1 FROM BangLuongHDV WHERE MaBangLuong = @MaBangLuong)
    BEGIN
        UPDATE BangLuongHDV
        SET LuongCanBan = @LuongCanBan,
            SoTourThucHien = @SoTour,
            TongThuLaoTour = @TongThuLao,
            PhuCapKhac = @PhuCapKhac,
            TongLuongThucNhan = @TongLuong,
            NgayTinh = GETDATE()
        WHERE MaBangLuong = @MaBangLuong;
    END
    ELSE
    BEGIN
        INSERT INTO BangLuongHDV (MaBangLuong, MaNV, ThangNam, LuongCanBan, SoTourThucHien, TongThuLaoTour, PhuCapKhac, TongLuongThucNhan, NgayTinh, TrangThai)
        VALUES (@MaBangLuong, @MaNV, @ThangNam, @LuongCanBan, @SoTour, @TongThuLao, @PhuCapKhac, @TongLuong, GETDATE(), N'ChuaChi');
    END
END;
GO

PRINT N'=== KHỞI TẠO CSDL QuanLyDuLich_VanHoaViet THÀNH CÔNG RỰC RỠ! ===';
