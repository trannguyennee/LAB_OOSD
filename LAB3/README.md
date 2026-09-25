# LAB 3: HỆ THỐNG QUẢN LÝ KHÁCH SẠN
**Phân tích yêu cầu - Thiết kế Cơ sở dữ liệu - Lập trình C# WinForms theo Kiến trúc 3 lớp**

---

### 👨‍🎓 Thông tin sinh viên
- **Họ và tên:** Trần Nguyên
- **Mã số sinh viên (MSSV):** 1250080121
- **Lớp:** 12CNPM2
- **Trường:** Đại học Tài nguyên và Môi trường TP. Hồ Chí Minh (HCMUNRE)
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng (OOSD)
- **Giảng viên hướng dẫn:** Thầy Huynh

---

### 🏛️ Kiến trúc hệ thống 3 lớp (3-Layer Architecture)
Hệ thống được thiết kế và triển khai chặt chẽ theo mô hình phân tầng chuẩn mực trong công nghệ phần mềm:
1. **Presentation Layer (`Forms/`):**
   - Chứa 7 Windows Forms được thiết kế bám sát 100% theo bản vẽ giao diện trong tài liệu PDF của Thầy Huỳnh Kòm.
   - Quản lý tương tác người dùng, DataBinding thông minh, validation dữ liệu đầu vào và thông báo trực quan.
2. **Business Logic Layer (`Services/`):**
   - Đảm nhiệm toàn bộ quy tắc nghiệp vụ (Business Rules), tách biệt hoàn toàn khỏi tầng giao diện.
   - Quản lý giao dịch đa tác vụ an toàn bằng `SqlTransaction` để bảo đảm tính trọn vẹn dữ liệu (ACID) khi đặt phòng, sử dụng dịch vụ, lập phiếu đền bù, thanh toán và hoàn tất trả phòng.
3. **Data Access Layer (`Data/`):**
   - Lớp tĩnh `Db.cs` quản lý kết nối ADO.NET kết nối tới cơ sở dữ liệu `QuanLyKhachSan`.
   - Tham số hóa toàn bộ câu lệnh truy vấn (`SqlParameter`) giúp tối ưu hiệu năng và triệt tiêu nguy cơ tấn công SQL Injection.

---

### 🖥️ Danh mục 7 Forms trong hệ thống (Chuẩn 100% ảnh PDF của Thầy)

1. **`FrmMain` (Màn hình chính điều hướng):**
   - Giao diện trung tâm với các nút điều hướng trực quan mở từng phân hệ nghiệp vụ (`FrmDanhMuc`, `FrmPhongTienNghi`, `FrmDatPhong`, `FrmDichVu`, `FrmTraPhong`, `FrmThongKe`).
   - Hộp thoại xác nhận thoát chương trình an toàn (`MessageBoxButtons.YesNo`).

2. **`FrmDanhMuc` (Quản lý Danh mục dùng chung):**
   - Quản lý tập trung 6 nhóm danh mục: Khu vực, Loại phòng, Loại tiện nghi, Quy định đền bù, Dịch vụ, Nhân viên.
   - Bảng hiển thị dữ liệu chuẩn hóa 5 cột đồng nhất: `Mã`, `Tên`, `Loại / Vai trò`, `Đơn vị`, `Đơn giá / Mức`.
   - Đầy đủ thao tác Thêm, Sửa, Xóa, Tải lại với cơ chế tự động khóa mã khi cập nhật.

3. **`FrmPhongTienNghi` (Quản lý Phòng & Bố trí Tiện nghi):**
   - Mô hình Master - Detail giữa danh sách Phòng và Tiện nghi bố trí trong phòng.
   - Danh sách phòng hiển thị chi tiết: Mã phòng, Tên phòng, Loại phòng, Khu vực, Đơn giá/ngày, Trạng thái ('Trống', 'Đang ở', 'Đã đặt').
   - Cho phép thêm/sửa/xóa phòng, đồng thời bổ sung hoặc thu hồi từng hạng mục tiện nghi (kèm số lượng và tình trạng sử dụng).

4. **`FrmDatPhong` (Lập phiếu Đặt phòng & Chọn phòng):**
   - Giao diện tinh gọn, đúng chuẩn thiết kế của Thầy: Thông tin khách hàng, Kênh đặt (Trực tiếp, Điện thoại, Website), Tiền cọc, Ngày nhận và Ngày trả dự kiến.
   - Danh sách phòng trống tự động lọc theo loại phòng và khu vực; hỗ trợ cơ chế nhấp đúp (Double-Click) chọn phòng vào danh sách đặt.
   - Tự động tính toán tổng số ngày, tổng tiền tạm tính và số tiền cọc gợi ý; hỗ trợ lưu phiếu trong transaction.

5. **`FrmDichVu` (Ghi nhận Sử dụng Dịch vụ):**
   - Bảng 7 cột hiển thị danh sách phiếu đang ở và dịch vụ đã dùng: `Số phiếu`, `Khách hàng`, `Phòng`, `Ngày dùng`, `Dịch vụ`, `SL`, `Thành tiền`.
   - Cho phép chọn phòng đang ở, chọn dịch vụ và số lượng để lập phiếu sử dụng.
   - Tự động cộng dồn số lượng nếu phòng đã sử dụng cùng dịch vụ trong cùng ngày.

6. **`FrmTraPhong` (Quy trình Trả phòng - Đền bù - Hóa đơn):**
   - Quy trình khép kín:
     - 3 bảng song song: Danh sách phiếu đang ở $\rightarrow$ Phòng trong phiếu $\rightarrow$ Tiện nghi của phòng đang chọn.
     - Lập phiếu đền bù tiện nghi nếu có hư hỏng/mất mát dựa trên bảng Quy định đền bù.
     - Lập hóa đơn tổng hợp tự động gom tiền phòng (theo số ngày thực tế) + tiền dịch vụ đã dùng + tiền đền bù - tiền cọc đã đóng.
     - Hỗ trợ Thanh toán và Hoàn tất trả phòng (chuyển trạng thái phiếu sang 'Đã trả' và giải phóng tất cả phòng về 'Trống').

7. **`FrmThongKe` (Báo cáo Thống kê & Doanh thu):**
   - Lọc thống kê theo khoảng ngày (`Từ ngày` - `Đến ngày`).
   - Tổng hợp 5 chỉ số KPI then chốt: `Phiếu đặt`, `Đang ở`, `Hóa đơn`, `Doanh thu HĐ`, `Tổng đền bù` (định dạng tiền tệ `vi-VN`).
   - Bảng thống kê chi tiết tiêu thụ dịch vụ: `Mã DV`, `Tên dịch vụ`, `Tổng số lượng`, `Tổng tiền`.

---

### 🗄️ Cấu trúc Cơ sở dữ liệu (QuanLyKhachSan)
File kịch bản SQL tại `Database/QuanLyKhachSan.sql` tạo lập đầy đủ 18 bảng với các ràng buộc khóa ngoại, DEFAULT, CHECK và cột tính toán:
1. `KhuVuc`: Khu vực/tầng của khách sạn.
2. `LoaiPhong`: Phân loại phòng (Đơn, Đôi, VIP...) và đơn giá ngày.
3. `Phong`: Quản lý phòng, liên kết khu vực và loại phòng, ràng buộc trạng thái ('Trống', 'Đang ở', 'Đã đặt').
4. `LoaiTienNghi`: Danh mục trang thiết bị, tiện nghi.
5. `TienNghiPhong`: Bố trí tiện nghi theo từng phòng kèm số lượng và tình trạng.
6. `QuyDinhDenBu`: Bảng giá quy định bồi thường hư hỏng, mất mát.
7. `KhachHang`: Thông tin khách hàng, số điện thoại, CCCD/Passport.
8. `NhanVien`: Quản lý nhân viên và vai trò (Lễ tân, Kế toán, Quản lý...).
9. `DichVu`: Danh mục dịch vụ khách sạn và đơn giá.
10. `PhieuDatPhong`: Thông tin đặt phòng, kênh đặt, ngày nhận/trả, tiền cọc, trạng thái.
11. `ChiTietDatPhong`: Liên kết danh sách phòng được chọn trong từng phiếu đặt.
12. `PhieuNhanPhong`: Ghi nhận sự kiện khách đến nhận phòng thực tế.
13. `ChiTietNhanPhong`: Chi tiết các phòng khách đã nhận.
14. `PhieuSuDungDV`: Phiếu ghi nhận sử dụng dịch vụ theo phòng và ngày dùng.
15. `ChiTietPhieuSuDungDV`: Chi tiết dịch vụ sử dụng, số lượng, đơn giá và cột thành tiền tính toán.
16. `PhieuDenBu`: Phiếu bồi thường khi khách làm hỏng/mất tiện nghi lúc trả phòng.
17. `ChiTietPhieuDenBu`: Chi tiết tiện nghi bị hư hại và số tiền bồi thường.
18. `HoaDon`: Hóa đơn thanh toán tổng hợp tiền phòng, tiền dịch vụ và trạng thái thanh toán.

---

### 🧪 Bảng kết quả kiểm thử 15 Test Case bắt buộc (Trang 63-64 PDF)

| Mã TC | Phân hệ | Kịch bản kiểm thử | Kết quả mong đợi | Kết quả thực tế | Trạng thái |
| :---: | :--- | :--- | :--- | :--- | :---: |
| **TC01** | Đặt phòng | Đặt phòng nhưng không chọn phòng nào | Báo lỗi yêu cầu chọn ít nhất 1 phòng | Báo lỗi chính xác | ✅ **PASS** |
| **TC02** | Đặt phòng | Ngày trả dự kiến nhỏ hơn ngày nhận | Báo lỗi ngày trả phải $\ge$ ngày nhận | Báo lỗi hợp lệ | ✅ **PASS** |
| **TC03** | Đặt phòng | Nhập tiền cọc $< 0$ | Báo lỗi tiền cọc không được âm | Báo lỗi hợp lệ | ✅ **PASS** |
| **TC04** | Đặt phòng | Đặt phòng hợp lệ với 1 phòng | Phiếu trạng thái 'Đã đặt', phòng chuyển 'Đã đặt' | Lưu thành công | ✅ **PASS** |
| **TC05** | Đặt phòng | Đặt phòng hợp lệ với nhiều phòng | Lưu đủ chi tiết phòng, tất cả phòng chuyển 'Đã đặt' | Lưu thành công | ✅ **PASS** |
| **TC06** | Nhận phòng | Khách đến nhận phòng đúng hạn | Phiếu chuyển 'Đang ở', các phòng chuyển 'Đang ở' | Cập nhật chính xác | ✅ **PASS** |
| **TC07** | Nhận phòng | Nhận phòng trên phiếu đã ở hoặc đã hủy | Báo lỗi từ chối thao tác | Chặn chính xác | ✅ **PASS** |
| **TC08** | Dịch vụ | Ghi nhận dịch vụ với số lượng $\le 0$ | Báo lỗi số lượng phải $> 0$ | Báo lỗi hợp lệ | ✅ **PASS** |
| **TC09** | Dịch vụ | Thêm dịch vụ cho phòng chưa nhận/chưa ở | Báo lỗi phòng không ở trạng thái 'Đang ở' | Chặn chính xác | ✅ **PASS** |
| **TC10** | Dịch vụ | Ghi nhận dịch vụ hợp lệ | Tạo phiếu SDDV, thành tiền tự tính chính xác | Ghi nhận thành công | ✅ **PASS** |
| **TC11** | Trả phòng | Trả phòng có phát sinh hư hỏng tiện nghi | Lập phiếu đền bù, tiền đền bù cộng vào hóa đơn | Lập đền bù thành công | ✅ **PASS** |
| **TC12** | Trả phòng | Trả phòng không đền bù | Hóa đơn tính đúng tiền phòng theo ngày và tiền dịch vụ | Tính đúng 100% | ✅ **PASS** |
| **TC13** | Thanh toán | Xác nhận thanh toán hóa đơn | Hóa đơn chuyển trạng thái 'Đã thanh toán' | Cập nhật chính xác | ✅ **PASS** |
| **TC14** | Trả phòng | Hoàn tất thủ tục trả phòng | Phiếu chuyển 'Đã trả', tất cả phòng về 'Trống' | Giải phóng phòng xong | ✅ **PASS** |
| **TC15** | Thống kê | Thống kê số liệu theo khoảng thời gian | Hiển thị đúng số phiếu, doanh thu, đền bù, dịch vụ | Số liệu chính xác | ✅ **PASS** |

---

### 🚀 Hướng dẫn chạy chương trình
1. **Bước 1:** Khởi động SQL Server (LocalDB hoặc SQL Server Management Studio - SSMS).
2. **Bước 2:** Mở file `Database/QuanLyKhachSan.sql` và nhấn **Execute** (`F5`) để khởi tạo CSDL `QuanLyKhachSan` cùng dữ liệu mẫu ban đầu.
3. **Bước 3:** Mở file `QuanLyKhachSan/QuanLyKhachSan.sln` bằng **Visual Studio 2022**.
4. **Bước 4:** Kiểm tra chuỗi kết nối trong file `App.config` (mặc định cấu hình `Data Source=localhost;Initial Catalog=QuanLyKhachSan;Integrated Security=True`).
5. **Bước 5:** Nhấn **F5** (hoặc nút **Start**) để biên dịch và trải nghiệm toàn bộ hệ thống!
