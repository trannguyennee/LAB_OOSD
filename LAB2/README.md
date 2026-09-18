# LAB 2: HỆ THỐNG QUẢN LÝ THƯ VIỆN
**Từ Phân tích yêu cầu - UML - Cơ sở dữ liệu - Giao diện - Đến Lập trình C# WinForms**

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
Dự án được xây dựng theo mô hình phân tầng chuẩn mực trong công nghệ phần mềm:
1. **Presentation Layer (`Forms/`):**
   - Chứa 6 Windows Forms giao diện người dùng kế thừa từ `System.Windows.Forms.Form`.
   - Xử lý tương tác, binding dữ liệu, hỗ trợ validation nhanh và phản hồi hộp thoại trực quan.
2. **Business Logic Layer (`Services/`):**
   - Tập trung toàn bộ quy tắc nghiệp vụ (Business Rules).
   - Độc lập với giao diện, quản lý giao dịch an toàn dữ liệu bằng `SqlTransaction` với mức cô lập `Serializable`.
3. **Data Access Layer (`Data/`):**
   - Lớp tĩnh `Db.cs` quản lý kết nối ADO.NET, tham số hóa an toàn (`SqlParameter`) chống tấn công SQL Injection.
   - Hỗ trợ các hàm tiện ích thực thi truy vấn: `OpenConnection()`, `Query()`, `Execute()`, `Scalar()`.

---

### 🖥️ Danh mục 6 Forms trong hệ thống
1. **`FrmMain` (Màn hình chính):**
   - Điều hướng người dùng tới các phân hệ chức năng bằng cơ chế hộp thoại Modal (`ShowDialog(this)`).
   - Nút xác nhận thoát chương trình an toàn (`MessageBoxButtons.YesNo`).
2. **`FrmDanhMuc` (Quản lý Danh mục & Nhân viên):**
   - Gồm 3 Tab: Nhân viên, Thể loại, Nhà xuất bản.
   - Thao tác CRUD hoàn chỉnh, tự động khóa mã khi đang cập nhật (ReadOnly), ngăn ngừa xóa dữ liệu đang được tham chiếu ràng buộc khóa ngoại (Foreign Key).
3. **`FrmSach` (Quản lý Đầu sách & Tra cứu):**
   - Quản lý danh mục sách, năm xuất bản, phân loại thể loại và nhà xuất bản qua ComboBox.
   - Kiểm soát tồn kho `SoLuongHienCo >= 0`, tìm kiếm nhanh theo mã sách hoặc tên sách.
4. **`FrmDocGia` (Quản lý Độc giả & Cấp thẻ thư viện):**
   - Quản lý hồ sơ độc giả, kiểm tra định dạng email.
   - Cấp thẻ thư viện: Bảo đảm mỗi thời điểm mỗi độc giả chỉ có duy nhất 1 thẻ hoạt động (`TrangThai = 1`).
   - Gia hạn thẻ: Cập nhật hạn sử dụng mới lớn hơn hạn cũ và ghi nhận trạng thái đóng lệ phí.
5. **`FrmMuonTra` (Mượn - Trả sách & Thu phạt):**
   - **Tab Mượn sách:** Kiểm tra điều kiện mượn (thẻ còn hạn, đã đóng lệ phí, không có sách quá hạn, tổng sách mượn $\le 3$ cuốn). Lưu phiếu mượn và chi tiết trong transaction; trừ tồn kho tức thì.
   - **Tab Trả sách:** Tải sách đang mượn của độc giả, nhận diện trả trễ hạn, rách hỏng hoặc mất sách. Tự động gợi ý mức phí phạt và lập phiếu phạt `PhieuPhat` khi vi phạm.
6. **`FrmThongKe` (Báo cáo Thống kê & Quá hạn):**
   - Thiết kế chuẩn 100% theo bản vẽ **`GUI_UC13_TaoBaoCaoThongKe.png`** và **`GUI_UC10_TraCuuMuonQuaHan.png`**.
   - **Tab 1 (UC13):** Lọc theo ngày, hiển thị 4 KPI Cards (Tổng lượt mượn, Đã trả đúng hạn %, Quá hạn %, Tổng tiền phạt), bảng thống kê theo thể loại, xuất dữ liệu Excel/CSV, xem biểu đồ trực quan.
   - **Tab 2 (UC10 & UC14):** Tra cứu danh sách nợ sách quá hạn theo mức ngày, lọc theo độc giả, gửi email/SMS nhắc hạn bạn đọc và in giấy báo nợ sách.

---

### 🗄️ Cấu trúc Cơ sở dữ liệu (QuanLyThuVienDB)
Script tạo CSDL tại `Database/QuanLyThuVien.sql` gồm 9 bảng chuẩn hóa:
* `NhanVien`: Quản lý nhân viên thư viện.
* `TheLoai`: Phân loại danh mục sách.
* `NhaXuatBan`: Quản lý nhà xuất bản.
* `DauSach`: Lưu trữ đầu sách, năm xuất bản, tồn kho và các khóa ngoại.
* `DocGia`: Lưu hồ sơ độc giả.
* `TheDocGia`: Quản lý thẻ thư viện kèm Unique Filtered Index `WHERE TrangThai = 1`.
* `PhieuMuon`: Quản lý thông tin mượn sách, ngày mượn, ngày hẹn trả.
* `ChiTietPhieuMuon`: Lưu từng đầu sách trong phiếu mượn kèm ràng buộc `UNIQUE(MaPhieuMuon, MaDauSach)`.
* `PhieuPhat`: Lưu thông tin phạt trễ hạn, mất sách, sách hư hỏng.

---

### 🧪 Bảng kết quả kiểm thử 14 Test Case bắt buộc (Trang 26 PDF)

| Mã TC | Nghiệp vụ kiểm thử | Điều kiện kiểm thử | Kết quả thực tế | Trạng thái |
| :---: | :--- | :--- | :--- | :---: |
| **TC01** | Cấp thẻ | Độc giả chưa có thẻ hoạt động | Tạo thẻ mới thành công | ✅ **PASS** |
| **TC02** | Cấp thẻ | Độc giả đang có thẻ còn hạn | Từ chối cấp thẻ thứ 2 | ✅ **PASS** |
| **TC03** | Mượn sách | Độc giả có thẻ đã hết hạn | Báo lỗi thẻ hết hạn, từ chối mượn | ✅ **PASS** |
| **TC04** | Mượn sách | Độc giả chưa đóng lệ phí năm | Báo lỗi chưa đóng phí, từ chối mượn | ✅ **PASS** |
| **TC05** | Mượn sách | Độc giả có sách quá hạn chưa trả | Báo lỗi nợ quá hạn, từ chối mượn | ✅ **PASS** |
| **TC06** | Mượn sách | Đang mượn 2 cuốn + chọn thêm 2 cuốn | Báo lỗi vượt quá 3 cuốn, từ chối | ✅ **PASS** |
| **TC07** | Mượn sách | Chọn 2 đầu sách hợp lệ | Lập phiếu thành công, tồn kho mỗi cuốn giảm 1 | ✅ **PASS** |
| **TC08** | Mượn sách | Chọn sách có số lượng hiện có = 0 | Báo lỗi hết sách trong kho, rollback | ✅ **PASS** |
| **TC09** | Trả sách | Trả đúng hạn + tình trạng Bình thường | Trả thành công, tồn kho tăng 1, không phạt | ✅ **PASS** |
| **TC10** | Trả sách | Trả trễ hạn nhưng nhập phí phạt = 0 | Báo lỗi bắt buộc nhập phí phạt $> 0$ | ✅ **PASS** |
| **TC11** | Trả sách | Trả trễ hạn + nhập phí phạt > 0 | Trả thành công, tự động lập phiếu phạt | ✅ **PASS** |
| **TC12** | Trả sách | Báo mất sách + phí phạt > 0 | Tạo phiếu phạt, không tăng tồn kho | ✅ **PASS** |
| **TC13** | Trả sách | Báo rách/hư hỏng + phí phạt > 0 | Tạo phiếu phạt, không tăng tồn kho | ✅ **PASS** |
| **TC14** | Thống kê | Chọn khoảng ngày có giao dịch mượn/trả | Số liệu mượn/quá hạn/phạt hiển thị chính xác | ✅ **PASS** |

---

### 🚀 Hướng dẫn chạy chương trình
1. **Bước 1:** Mở SQL Server Management Studio (SSMS) hoặc SQL Server Object Explorer trong Visual Studio, mở file `Database/QuanLyThuVien.sql` và nhấn **Execute** để tạo CSDL và dữ liệu mẫu.
2. **Bước 2:** Mở file `QuanLyThuVien/QuanLyThuVien.sln` bằng **Visual Studio 2022**.
3. **Bước 3:** Kiểm tra chuỗi kết nối trong file `App.config` (mặc định trỏ tới `(LocalDB)\MSSQLLocalDB` hoặc `localhost`).
4. **Bước 4:** Nhấn **F5** (hoặc nút **Start**) để khởi động và trải nghiệm toàn bộ ứng dụng!
