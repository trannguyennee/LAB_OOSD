# LAB 3: HỆ THỐNG QUẢN LÝ KHÁCH SẠN
**Thiết kế Cơ sở dữ liệu - Lập trình C# WinForms theo Kiến trúc 3 lớp - Kiểm thử**

---

### 👨‍🎓 Thông tin sinh viên
- **Họ và tên:** Trần Nguyên
- **Mã số sinh viên (MSSV):** 1250080121
- **Lớp:** 12_ĐH_CNPM2
- **Trường:** Đại học Tài nguyên và Môi trường TP. Hồ Chí Minh (HCMUNRE)
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng (OOSD)
- **Giảng viên hướng dẫn:** ThS. Phạm Trọng Huynh

---

### 📄 Tài liệu
- **Báo cáo Word:** `LAB3_1250080121_Tran_Nguyen_12CNPM2.docx` – kiến trúc, CSDL (danh sách bảng, ràng buộc, script tạo bảng), 15 ảnh giao diện WinForms và bảng 15 test case với kết quả thực tế.
- **Đề bài:** `Bai_3_He_thong_quan_ly_khach_san.pdf` – phần phân tích yêu cầu và các sơ đồ UML (use case, lớp, trạng thái, tuần tự, hoạt động, ERD) theo tài liệu của giảng viên.
- **Ảnh giao diện:** thư mục [`IMAGES/LAB3/`](../IMAGES/LAB3/).

---

### 🏛️ Kiến trúc hệ thống 3 lớp (3-Layer Architecture)
`WinForms UI (Forms/) → Service/Business Logic (Services/) → Data/Db → SQL Server`
1. **Presentation Layer (`Forms/`):** 7 form; form không viết SQL trực tiếp, chỉ gọi Service.
2. **Business Logic Layer (`Services/`):** `DanhMucService`, `PhongTienNghiService`, `DatPhongService`, `DichVuService`, `TraPhongService`, `ThongKeService`; kết quả trả về qua `KetQuaXuLy`. Các nghiệp vụ ghi nhiều bảng (đặt phòng, nhận phòng, ghi dịch vụ, đền bù, hóa đơn, thanh toán, trả phòng) dùng `SqlTransaction`.
3. **Data Access Layer (`Data/Db.cs`):** kết nối ADO.NET tới CSDL `QuanLyKhachSan`, mọi câu lệnh dùng `SqlParameter`.

---

### 🖥️ Danh mục 7 Forms
| Form | Actor chính | Chức năng |
|---|---|---|
| `FrmMain` | Nhân viên | Màn hình chính, điều hướng 6 chức năng và Thoát |
| `FrmDanhMuc` | Nhân viên | 5 tab: Khu vực, Nhân viên, Loại tiện nghi, Dịch vụ, Quy định đền bù |
| `FrmPhongTienNghi` | Phục vụ phòng | 3 tab: Phòng, Tiện nghi, Lắp đặt / luân chuyển (một thiết bị không lắp 2 phòng trong cùng ngày) |
| `FrmDatPhong` | Lễ tân | 3 tab: Khách hàng, Đặt phòng (chọn nhiều phòng, kiểm tra sức chứa và trùng lịch), Nhận phòng / Người lưu trú, No-show |
| `FrmDichVu` | Nhân viên | Ghi nhận dịch vụ cho phiếu đang ở; cùng dịch vụ cùng ngày thì cộng dồn số lượng |
| `FrmTraPhong` | Phục vụ / Thanh toán | Kiểm tra tiện nghi, lập phiếu đền bù, lập hóa đơn (tiền phòng + dịch vụ), thanh toán nhiều lần, hoàn tất trả phòng |
| `FrmThongKe` | Quản lý | Thống kê theo khoảng ngày: số phiếu đặt, đang ở, hóa đơn, doanh thu, tổng đền bù và dịch vụ đã dùng |

---

### 🗄️ Cơ sở dữ liệu (QuanLyKhachSan) – 18 bảng
Script `Database/QuanLyKhachSan.sql`:

| Nhóm | Bảng |
|---|---|
| Danh mục | `NhanVien`, `KhuVuc`, `Phong`, `LoaiTienNghi`, `TienNghi`, `DichVu`, `QuyDinhDenBu` |
| Lắp đặt tiện nghi | `PhieuLapDat` (UNIQUE `MaTienNghi` + `NgayLap`) |
| Đặt / nhận phòng | `KhachHang`, `PhieuDatPhong`, `ChiTietDatPhong`, `NguoiLuuTru` |
| Dịch vụ | `PhieuSuDungDV` (UNIQUE phiếu đặt + phòng + ngày), `ChiTietPhieuSuDungDV` |
| Trả phòng | `PhieuDenBu`, `ChiTietPhieuDenBu`, `HoaDon`, `ThanhToan` (Tiền mặt / Chuyển khoản / Thẻ / Ví điện tử) |

---

### 🧪 Kết quả kiểm thử 15 test case (mục 9 của đề)
Chạy ngày 01/11/2026 trên các Service của chương trình với CSDL `QuanLyKhachSan` thật.

| Mã TC | Điều kiện | Thao tác | Kết quả thực tế | Đánh giá |
| :---: | :--- | :--- | :--- | :---: |
| TC01 | Phòng trống, số người ≤ sức chứa | Lập phiếu đặt phòng | Lập phiếu thành công | ✅ Đạt |
| TC02 | Số người vượt sức chứa (B201: 5 > 4) | Lập phiếu đặt phòng | Từ chối, báo vượt sức chứa | ✅ Đạt |
| TC03 | Phòng trùng lịch với phiếu khác | Lập phiếu đặt phòng | Từ chối, báo trùng lịch | ✅ Đạt |
| TC04 | Thiết bị đã lắp trong cùng ngày | Lập phiếu lắp đặt | Từ chối | ✅ Đạt |
| TC05 | Phiếu đang "Đã đặt" | Nhận phòng | Phiếu chuyển "Đang ở" | ✅ Đạt |
| TC06 | Phòng đã đủ số người đăng ký | Thêm người lưu trú | Từ chối | ✅ Đạt |
| TC07 | Cùng dịch vụ, cùng phòng, cùng ngày | Ghi nhận lần 2 | Cộng dồn số lượng (1 + 2 = 3) | ✅ Đạt |
| TC08 | Phiếu không ở trạng thái "Đang ở" | Ghi nhận dịch vụ | Từ chối | ✅ Đạt |
| TC09 | Có tiện nghi hư hỏng | Lập phiếu đền bù | Lưu chi tiết, tổng đền bù 500.000 đ | ✅ Đạt |
| TC10 | Phiếu đang ở có dùng dịch vụ | Lập hóa đơn | Tiền phòng 1.600.000 đ + dịch vụ 360.000 đ | ✅ Đạt |
| TC11 | Thanh toán một phần | Ghi thanh toán | Hóa đơn vẫn "Chưa thanh toán" | ✅ Đạt |
| TC12 | Thanh toán đủ | Ghi thanh toán | Hóa đơn "Đã thanh toán" | ✅ Đạt |
| TC13 | Hóa đơn chưa thanh toán đủ | Hoàn tất trả phòng | Từ chối | ✅ Đạt |
| TC14 | Hóa đơn đã thanh toán đủ | Hoàn tất trả phòng | Phiếu "Đã trả", phòng "Trống" | ✅ Đạt |
| TC15 | Khoảng ngày hợp lệ | Thống kê | Có số liệu tổng hợp | ✅ Đạt |

---

### 🚀 Hướng dẫn chạy chương trình
1. Mở `Database/QuanLyKhachSan.sql` trong SQL Server Management Studio và nhấn **Execute** (`F5`) để tạo CSDL `QuanLyKhachSan` cùng dữ liệu mẫu.
2. Mở `QuanLyKhachSan/QuanLyKhachSan.sln` bằng **Visual Studio 2022**.
3. Kiểm tra chuỗi kết nối trong `App.config` (mặc định `Data Source=localhost;Initial Catalog=QuanLyKhachSan;Integrated Security=True`).
4. Nhấn **F5** để chạy.
