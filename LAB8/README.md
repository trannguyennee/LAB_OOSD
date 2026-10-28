# LAB 8: HIỆN THỰC HÓA HỆ THỐNG PHẦN MỀM HƯỚNG ĐỐI TƯỢNG (OOSD)

## ĐỀ TÀI: HỆ THỐNG QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT (BÀI 2)

- **Sinh viên thực hiện:** Trần Nguyên
- **Mã số sinh viên (MSSV):** 1250080121
- **Lớp:** 12_ĐH_CNPM2
- **Trường:** Đại học Công nghệ TP.HCM (HUTECH)
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng (OOSD)
- **Giảng viên hướng dẫn:** ThS. Phạm Trọng Huynh

---

## 1. TỔNG QUAN DỰ ÁN

Dự án hiện thực hóa trọn vẹn nghiệp vụ mua bán nước giải khát từ mô hình phân tích thiết kế hướng đối tượng (UML ở Lab 1) sang cơ sở dữ liệu SQL Server và ứng dụng C# Windows Forms (.NET Framework 4.7.2) theo kiến trúc 3 lớp: `UI -> Service -> Data`.

### Các quy tắc nghiệp vụ trọng tâm (Business Rules):
1. **Ràng buộc Nhà cung ứng (BR01):** Mỗi loại nước giải khát chỉ được nhập từ một nhà cung ứng duy nhất.
2. **Ràng buộc Đơn đặt hàng (BR02):** Mỗi ĐĐH gửi NCC có thể giao tối đa 3 đợt. Mỗi đợt có kèm Phiếu giao hàng (PGH), tự động cộng dồn tồn kho khi tiếp nhận.
3. **Ràng buộc Bán hàng & Tồn kho (BR03):** Khi khách mua hàng, hệ thống kiểm tra tồn kho:
   - *Nếu đủ hàng:* Xuất hàng và lập hóa đơn thanh toán ngay.
   - *Nếu thiếu hàng:*
     - Khách vãng lai: Cảnh báo thiếu hàng, từ chối hẹn đợt giao và từ chối ghi nợ.
     - Khách quen: Cho phép lập hóa đơn và phát sinh các Phiếu hẹn giao hàng nhiều đợt.
4. **Ràng buộc Thanh toán & Ghi nợ (BR04):**
   - Khách vãng lai bắt buộc thanh toán 100% tại quầy ngay khi nhận hàng.
   - Khách quen cho phép trả chậm bằng cách lập Phiếu ghi nợ (ghi rõ hạn trả, lý do nợ, nhân viên lập) và cộng vào công nợ của khách.

---

## 2. KIẾN TRÚC GIẢI PHÁP (3-TIER ARCHITECTURE)

Solution được tổ chức bài bản theo kiến trúc 3 lớp độc lập:

```text
QuanLyCuaHangNGK/
├── QuanLyCuaHangNGK.sln                   # Visual Studio Solution File
└── QuanLyCuaHangNGK/
    ├── App.config                          # Cấu hình chuỗi kết nối SQL Server
    ├── Program.cs                          # Điểm khởi chạy ứng dụng
    ├── Properties/AssemblyInfo.cs          # Thông tin bản quyền sinh viên
    ├── Data/
    │   └── Db.cs                           # Data Access Layer: Kết nối SQL, ExecuteQuery, NonQuery, Scalar
    ├── Services/                           # Business Logic Layer:
    │   ├── NuocGiaiKhatService.cs          # Quản lý danh mục NGK, loại hàng, kiểm tra tồn kho
    │   ├── DonDatHangService.cs            # Lập ĐĐH, tiếp nhận PGH (kiểm soát tối đa 3 đợt giao)
    │   ├── HoaDonService.cs                # Lập hóa đơn, phân nhánh Khách quen / Vãng lai, rẽ nhánh đủ/thiếu
    │   ├── PhieuHenService.cs              # Quản lý phiếu hẹn giao hàng theo đợt cho khách quen
    │   ├── PhieuGhiNoService.cs            # Lập phiếu nợ, quản lý công nợ, thu nợ / tất toán
    │   └── BaoCaoService.cs                # Báo cáo doanh thu, công nợ và cảnh báo tồn kho
    └── Forms/                              # Presentation Layer (UI WinForms):
        ├── FrmMain.cs                      # Dashboard tổng quan điều hướng hệ thống
        ├── FrmNuocGiaiKhat.cs              # Quản lý nước giải khát, loại NGK và tồn kho
        ├── FrmDonDatHang.cs                # Đặt hàng NCC và tiếp nhận PGH (tối đa 3 đợt)
        ├── FrmHoaDon.cs                    # Bán hàng trọng tâm (kiểm kho, hẹn đợt, ghi nợ)
        ├── FrmPhieuHen.cs                  # Quản lý và xử lý giao các đợt hẹn
        ├── FrmPhieuGhiNo.cs                # Quản lý phiếu ghi nợ và thu nợ
        └── FrmBaoCao.cs                    # Báo cáo doanh thu, công nợ và cảnh báo tồn kho
```

---

## 3. THIẾT KẾ CƠ SỞ DỮ LIỆU SQL SERVER (13 BẢNG)

Tập tin kịch bản SQL Server: `Database/QuanLyCuaHangNGK_Database.sql`

CSDL bao gồm 13 bảng nhất quán 100% với Class Diagram:
1. `NhaCungUng`: Quản lý thông tin nhà cung ứng (`MaNCU`, `TenNCU`, `DiaChi`, `SoDT`).
2. `LoaiNGK`: Nhãn hiệu/loại NGK (`MaLoai`, `TenLoai`, `MaNCU`).
3. `NuocGiaiKhat`: Mặt hàng NGK (`MaNGK`, `TenNGK`, `DonViTinh`, `SoLuongTon`, `DonGiaBan`, `MaLoai`).
4. `NhanVien`: Nhân sự cửa hàng (`MaNV`, `HoTen`, `ChucVu`, `SoDT`, `TaiKhoan`, `MatKhau`).
5. `KhachHang`: Thông tin khách hàng (`MaKH`, `TenKH`, `DiaChi`, `SoDT`, `LoaiKH`, `TongNo`) với `LoaiKH IN ('KhachQuen', 'KhachVangLai')`.
6. `DonDatHang`: Đơn đặt hàng NCC (`SoDDH`, `NgayDat`, `NgayNhan`, `TongSoLuongDat`, `SoDotDaGiao`, `TrangThai`, `MaNCU`, `MaNV`).
7. `ChiTietDDH`: Chi tiết mặt hàng và giá nhập từng ĐĐH (`SoDDH`, `MaNGK`, `SoLuongDat`, `DonGiaNhap`).
8. `PhieuGiaoHang`: Phiếu giao hàng từ NCC với `CHECK (DotGiao BETWEEN 1 AND 3)`.
9. `ChiTietPGH`: Chi tiết số lượng giao thực tế để cộng kho (`SoPGH`, `MaNGK`, `SoLuongGiao`, `DonGia`).
10. `HoaDon`: Hóa đơn bán lẻ (`SoHD`, `NgayLap`, `TongTien`, `HinhThucThanhToan`, `DaThanhToan`, `MaKH`, `MaNV`).
11. `ChiTietHoaDon`: Chi tiết mặt hàng bán (`SoHD`, `MaNGK`, `SoLuong`, `DonGia`, `ThanhTien`).
12. `PhieuHen`: Phiếu hẹn giao nhiều đợt cho khách quen (`SoPH`, `NgayHenGiao`, `DotGiaoHen`, `SoLuongHen`, `TrangThai`, `SoHD`, `MaNGK`).
13. `PhieuGhiNo`: Phiếu ghi nợ trả chậm cho khách quen (`SoPGN`, `NgayLap`, `SoTienNo`, `NgayDuKienTra`, `LyDoNo`, `DaTra`, `SoHD`, `MaKH`, `MaNV`).

---

## 4. MA TRẬN TRUY VẾT & KỊCH BẢN KIỂM THỬ (TEST CASES)

| Mã TC | Yêu cầu nghiệp vụ | UML Traceability | Form / Service xử lý | Bảng CSDL | Kết quả kiểm thử |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **TC01** | Bán hàng đủ tồn kho xuất ngay | UC1.4, UC4.1, UC4.4 | `FrmHoaDon` / `HoaDonService` | `HoaDon`, `ChiTietHoaDon`, `NuocGiaiKhat` | **Đạt (Pass):** Lập HĐ thành công, trừ tồn kho ngay. |
| **TC02** | Khách vãng lai thiếu hàng | UC4.3, BR03, Lane 2 | `FrmHoaDon` / `HoaDonService` | `KhachHang`, `HoaDon` | **Đạt (Pass):** Hệ thống chặn, từ chối hẹn đợt giao và từ chối ghi nợ. |
| **TC03** | Khách quen thiếu hàng hẹn giao đợt | UC4.7, UC4.8, Lane 3 | `FrmHoaDon` / `PhieuHenService` | `HoaDon`, `PhieuHen`, `ChiTietHoaDon` | **Đạt (Pass):** Tạo 2 Phiếu hẹn: Đợt 1 (giao ngay) và Đợt 2 (hẹn giao). |
| **TC04** | Khách quen trả chậm (ghi nợ) | UC1.7, Sequence Diagram | `FrmHoaDon` / `PhieuGhiNoService` | `HoaDon`, `PhieuGhiNo`, `KhachHang.TongNo` | **Đạt (Pass):** Lập Phiếu ghi nợ thành công, tăng tổng nợ khách hàng. |
| **TC05** | ĐĐH gửi NCC giao vượt quá 3 đợt | UC1.2, BR02, Class Diagram | `FrmDonDatHang` / `DonDatHangService` | `DonDatHang`, `PhieuGiaoHang` | **Đạt (Pass):** Hệ thống chặn đợt thứ 4, báo lỗi vượt quá 3 đợt giao. |

---

## 5. HƯỚNG DẪN CÀI ĐẶT & CHẠY ỨNG DỤNG

1. **Khởi tạo CSDL:** Mở SQL Server Management Studio (SSMS), mở tập tin `Database/QuanLyCuaHangNGK_Database.sql` và nhấn **Execute (F5)** để tạo CSDL và nạp dữ liệu mẫu ban đầu.
2. **Mở dự án:** Khởi động Visual Studio 2022, mở tập tin `QuanLyCuaHangNGK/QuanLyCuaHangNGK.sln`.
3. **Biên dịch và chạy:** Nhấn phím **F5** (hoặc `Ctrl + F5`) để khởi chạy ứng dụng.
