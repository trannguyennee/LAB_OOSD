# LAB 4: HỆ THỐNG CỬA HÀNG TRỰC TUYẾN "e-SHOPPING"
**Phân tích yêu cầu - Mô hình hóa UML - Thiết kế Cơ sở dữ liệu - Lập trình C# WinForms 3 lớp**

---

### 👨‍🎓 Thông tin sinh viên
- **Họ và tên:** Trần Nguyên
- **Mã số sinh viên (MSSV):** 1250080121
- **Lớp:** 12CNPM2
- **Trường:** Đại học Tài nguyên và Môi trường TP. Hồ Chí Minh (HCMUNRE)
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng (OOSD)
- **Giảng viên hướng dẫn:** Thầy Huỳnh Kòm

---

### 🏛️ Kiến trúc hệ thống 3 lớp (3-Layer Architecture)
Hệ thống được thiết kế và triển khai chặt chẽ theo mô hình phân tầng chuẩn mực trong công nghệ phần mềm trên nền tảng **.NET Framework 4.7.2 (Visual Studio 2022)** kết nối **Microsoft SQL Server**:

1. **Presentation Layer (`Forms/`):**
   - `FrmMain`: Bảng điều khiển Menu trung tâm (Dashboard 6 nút) chuẩn mẫu điều hướng các bài thực hành của Thầy.
   - `FrmTrangChu`: Màn hình xem danh mục sản phẩm, tìm kiếm, đưa sản phẩm vào giỏ hàng và cập nhật tổng tiền tạm tính thời gian thực.
   - `FrmDatHang`: Lập phiếu đặt hàng, tiếp nhận thông tin người nhận, chọn 3 loại hình giao hàng (tính phí giao hàng tự động & áp dụng chính sách Freeship), xác thực thẻ tín dụng trực tuyến và lưu đơn hàng vào CSDL.
   - `FrmLichSuDonHang`: Tra cứu tiến độ và lịch sử đơn hàng theo SĐT / Mã ĐH, hiển thị trạng thái và bảng chi tiết các sản phẩm đã mua.

2. **Business Logic Layer (`Services/`):**
   - `SanPhamService.cs`: Quản lý truy vấn danh mục nhóm sản phẩm, lọc và tìm kiếm sản phẩm theo từ khóa.
   - `DonHangService.cs`:
     - Xử lý chính sách phí giao hàng: Thường (30.000đ), Chuyển phát nhanh (50.000đ - Miễn phí khi đơn $\ge 1.000.000đ$), Chuyển phát hỏa tốc trong ngày (100.000đ - Miễn phí khi đơn $\ge 5.000.000đ$).
     - Xác thực chuẩn mực thẻ tín dụng: Visa/MasterCard (16 chữ số, CVV 3 số), American Express (15 chữ số, CVV 4 số), định dạng hạn dùng thẻ MM/YY.
     - Quản lý giao dịch `SqlTransaction` đảm bảo tính toàn vẹn ACID khi lưu đồng thời `DON_DAT_HANG` và `CHI_TIET_DON_HANG`.
   - `KetQuaXuLy.cs`: Lớp chuẩn hóa kết quả phản hồi giữa các tầng.

3. **Data Access Layer (`Data/`):**
   - `Db.cs`: Lớp tĩnh quản lý kết nối ADO.NET tới CSDL `eShoppingDB`. Tham số hóa toàn bộ câu lệnh SQL (`SqlParameter`) triệt tiêu nguy cơ SQL Injection.

---

### 🗄️ Cấu trúc Cơ sở dữ liệu (eShoppingDB)
Kịch bản T-SQL tại `Database/eShopping_Database.sql` thiết kế chuẩn hóa 6 bảng với đầy đủ khóa chính, khóa ngoại `ON DELETE CASCADE` và ràng buộc toàn vẹn:

1. `NHOM_SAN_PHAM`: Danh mục loại sản phẩm (`MaNhom`, `TenNhom`, `MoTa`).
2. `SAN_PHAM`: Thông tin sản phẩm (`MaSP`, `TenSP`, `NhaSanXuat`, `GiaHienHanh`, `TinhTrang`, `MaNhom`).
3. `KHACH_HANG`: Thông tin khách hàng vãng lai & thành viên (`MaKH`, `HoTen`, `DiaChi`, `SoDienThoai`, `Email`).
4. `KHACH_HANG_THANH_VIEN`: Kế thừa từ `KHACH_HANG` (`MaKH`, `TenDangNhap`, `MatKhau`).
5. `DON_DAT_HANG`: Hóa đơn đặt hàng (`MaDonHang`, `NgayDat`, `LoaiPhieuGiao`, `PhiGiaoHang`, `TongTien`, `TrangThai`, `TenNguoiNhan`, `DiaChiNhan`, `SdtNguoiNhan`, `MaKH`).
6. `CHI_TIET_DON_HANG`: Quan hệ hợp thành chi tiết đơn hàng (`MaDonHang`, `MaSP`, `SoLuong`, `DonGiaBan`, `ThanhTien`).

---

### 🧪 Bảng kết quả kiểm thử 17 Test Case hệ thống

| Mã TC | Phân hệ / Chức năng | Kịch bản kiểm thử | Dữ liệu đầu vào | Kết quả mong đợi | Kết quả thực tế | Trạng thái |
| :---: | :--- | :--- | :--- | :--- | :--- | :---: |
| **TC01** | Danh mục | Lọc sản phẩm theo từng nhóm danh mục | Chọn nhóm "Máy chụp hình kỹ thuật số" | Hiển thị các sản phẩm thuộc nhóm NSP01 | Hiển thị đúng 2 dòng máy ảnh | ✅ **PASS** |
| **TC02** | Tìm kiếm | Tìm kiếm sản phẩm theo tên hoặc hãng | Nhập từ khóa "Sony" | Lọc ra sản phẩm có tên hoặc hãng chứa "Sony" | Hiển thị đúng Sony Alpha A6700 | ✅ **PASS** |
| **TC03** | Giỏ hàng | Thêm sản phẩm vào giỏ với số lượng hợp lệ ($> 0$) | Chọn SP001, nhập số lượng = 1, bấm Thêm | Thêm vào bảng giỏ hàng, tổng tiền = 16.500.000 đ | Thêm thành công, tổng tiền đúng | ✅ **PASS** |
| **TC04** | Giỏ hàng | Thêm sản phẩm đã có sẵn trong giỏ | Chọn tiếp SP001, số lượng = 2, bấm Thêm | Cộng dồn số lượng thành 3, cập nhật thành tiền | Số lượng tăng lên 3, tiền tăng đúng | ✅ **PASS** |
| **TC05** | Giỏ hàng | Nhập số lượng mua không hợp lệ ($\le 0$) | Nhập số lượng = 0 | Báo lỗi số lượng phải lớn hơn 0, không thêm vào giỏ | Hệ thống chặn và báo lỗi hợp lệ | ✅ **PASS** |
| **TC06** | Giỏ hàng | Xóa một món hàng khỏi giỏ | Chọn món SP001 trong giỏ, bấm "Xóa món chọn" | Món hàng bị loại bỏ khỏi bảng giỏ, tự trừ tiền | Xóa thành công, tiền tự trừ | ✅ **PASS** |
| **TC07** | Giỏ hàng | Xóa toàn bộ giỏ hàng | Bấm nút "Xóa toàn bộ", xác nhận Đồng ý | Giỏ hàng rỗng, tổng tiền hiển thị về 0 đ | Làm rỗng giỏ và cập nhật 0 đ | ✅ **PASS** |
| **TC08** | Đặt hàng | Bấm tiến hành đặt hàng khi giỏ đang rỗng | Giỏ hàng không có sản phẩm nào, bấm Đặt hàng | Cảnh báo giỏ hàng trống, yêu cầu chọn hàng | Hiển thị thông báo cảnh báo hợp lệ | ✅ **PASS** |
| **TC09** | Đặt hàng | Bỏ trống thông tin người nhận hàng bắt buộc | Để trống ô Họ tên hoặc Số điện thoại | Báo lỗi yêu cầu điền đầy đủ thông tin người nhận | Chặn đặt hàng và báo lỗi chính xác | ✅ **PASS** |
| **TC10** | Phí ship | Chọn hình thức Giao hàng tiêu chuẩn thường | Chọn "Giao hàng tiêu chuẩn thường (3-5 ngày)" | Phí ship cố định = 30.000 đ | Phí ship hiển thị đúng 30.000 đ | ✅ **PASS** |
| **TC11** | Phí ship | Chuyển phát nhanh cho đơn $< 1.000.000 đ$ | Chọn "Chuyển phát nhanh" với đơn 500.000 đ | Phí ship = 50.000 đ | Phí ship hiển thị 50.000 đ | ✅ **PASS** |
| **TC12** | Phí ship | Chuyển phát nhanh cho đơn $\ge 1.000.000 đ$ | Chọn "Chuyển phát nhanh" với đơn 2.150.000 đ | Miễn phí ship (Phí ship = 0 đ) | Hiển thị: 0 đ (Miễn phí) | ✅ **PASS** |
| **TC13** | Phí ship | Hỏa tốc trong ngày đơn $< 5.000.000 đ$ | Chọn "Chuyển phát hỏa tốc" với đơn 2.150.000 đ | Phí ship = 100.000 đ | Phí ship hiển thị 100.000 đ | ✅ **PASS** |
| **TC14** | Phí ship | Hỏa tốc trong ngày đơn $\ge 5.000.000 đ$ | Chọn "Chuyển phát hỏa tốc" với đơn 16.500.000 đ | Miễn phí ship (Phí ship = 0 đ) | Hiển thị: 0 đ (Miễn phí) | ✅ **PASS** |
| **TC15** | Thẻ tín dụng | Thẻ Visa/Master sai 16 số hoặc CVV sai 3 số | Nhập số thẻ Visa 15 số hoặc CVV 2 số | Báo lỗi thẻ Visa phải đủ 16 số và CVV 3 số | Hệ thống báo lỗi quy chuẩn thẻ | ✅ **PASS** |
| **TC16** | Thẻ tín dụng | Thẻ American Express sai 15 số hoặc CVV sai 4 số | Chọn Amex, nhập số thẻ 16 số hoặc CVV 3 số | Báo lỗi thẻ Amex phải gồm 15 số và CVV 4 số | Hệ thống kiểm tra và báo lỗi hợp lệ | ✅ **PASS** |
| **TC17** | Giao dịch | Đặt hàng và thanh toán trực tuyến hợp lệ | Nhập đầy đủ thông tin người nhận, thẻ hợp lệ | Tạo mã đơn DH..., lưu vào CSDL, xóa giỏ hàng | Giao dịch thành công, lưu CSDL | ✅ **PASS** |

---

### 🚀 Hướng dẫn chạy chương trình
1. **Bước 1:** Mở file `Database/eShopping_Database.sql` trong SQL Server Management Studio (SSMS) và nhấn **Execute** (`F5`) để khởi tạo CSDL `eShoppingDB`.
2. **Bước 2:** Mở file `eShopping/eShopping.sln` bằng **Visual Studio 2022**.
3. **Bước 3:** Nhấn **F5** (hoặc nút **Start**) để khởi chạy ứng dụng. Màn hình Menu Trang chủ 6 nút sẽ hiển thị, chọn nút **1. Mua sắm & Đặt hàng** để trải nghiệm đầy đủ luồng nghiệp vụ!
