# BÁO CÁO THỰC HÀNH LAB 6: BÀI 5 - QUẢN LÝ HỒ SƠ BỆNH ÁN CỦA BỆNH NHÂN (BỆNH VIỆN ĐA KHOA QUỐC TẾ)

Môn học: Phương pháp phát triển phần mềm hướng đối tượng (OOSD)

---

### Thông tin sinh viên và Giảng viên hướng dẫn
- Họ và tên: Trần Nguyên
- Mã số sinh viên (MSSV): 1250080121
- Lớp: 12CNPM2
- Khoa: Công nghệ thông tin
- Trường: Đại học Tài nguyên và Môi trường TP. Hồ Chí Minh (HCMUNRE)
- Giảng viên hướng dẫn: ThS. Phạm Trọng Huynh

---

### 1. Tổng quan đề tài và Phạm vi nghiệp vụ (Bài 5)
Hệ thống quản lý hồ sơ bệnh án điện tử (EMR) của Bệnh viện Đa khoa Quốc tế tin học hóa toàn diện quy trình tiếp nhận, quản lý hồ sơ sức khỏe trọn đời, khám chữa bệnh lâm sàng, thực hiện cận lâm sàng, kê toa thuốc và thanh toán viện phí:
- Tiếp nhận và cấp hồ sơ lần đầu: Thu thập đầy đủ thông tin định danh (họ tên, ngày sinh, địa chỉ, CCCD, số điện thoại, ảnh 3x4). Thu lệ phí năm để duy trì dịch vụ chăm sóc và kích hoạt quyền lợi khám định kỳ miễn phí. Cấp mã hồ sơ bệnh án duy nhất nhận dạng bệnh nhân trọn đời.
- Khám bệnh lâm sàng và ghi nhận diễn biến: Bác sĩ điều trị ghi nhận triệu chứng thực thể (nhiệt độ, huyết áp, nhịp tim...), chẩn đoán sơ bộ, tiền sử dị ứng thuốc và hướng điều trị vào các trang tiếp theo của hồ sơ bệnh án.
- Chỉ định và trả kết quả cận lâm sàng: Bác sĩ lập phiếu chỉ định xét nghiệm (công thức máu, sinh hóa, X-quang, siêu âm...). Kỹ thuật viên xét nghiệm tiếp nhận mẫu, thực hiện đo đạc, nhập kết quả, chỉ số tham chiếu và kết luận vào hệ thống để hỗ trợ bác sĩ chẩn đoán chính xác.
- Kê toa thuốc điều trị: Bác sĩ lập đơn thuốc điện tử, kiểm tra tồn kho dược phẩm, hướng dẫn liều dùng, ghi lời dặn và hẹn ngày tái khám.
- Khám sức khỏe định kỳ theo quý: Tự động quản lý lịch hẹn 4 quý trong năm cho bệnh nhân đã hoàn thành nghĩa vụ nộp phí thường niên, miễn phí 100% tiền công khám lâm sàng.
- Tra cứu lịch sử bệnh án: Cho phép bác sĩ và bệnh nhân tra cứu toàn bộ tiến trình điều trị, tiền sử bệnh án cũ qua Mã hồ sơ, CCCD hoặc số điện thoại.
- Thanh toán viện phí và đóng hồ sơ an toàn: Quầy thu ngân tổng hợp toàn bộ chi phí đợt khám (tiền khám + tiền xét nghiệm + tiền thuốc - tiền miễn giảm định kỳ), thực hiện xuất hóa đơn viện phí và đóng đợt khám bệnh an toàn bằng Transaction.

---

### 2. Danh mục kết quả thực hiện các câu hỏi Lab 6

#### Câu 1: Xác định danh sách 16 Class hướng đối tượng (OOSD)
Hệ thống được chuẩn hóa thành 16 lớp đối tượng chia theo 4 phân hệ chính:
- Nhóm 1 (Hồ sơ & Bệnh nhân): BenhNhan, HoSoBenhAn, LePhiNam, LichKhamDinhKy.
- Nhóm 2 (Khám bệnh & Cận lâm sàng): PhieuKhamBenh, LoaiXetNghiem, ChiDinhXetNghiem, KetQuaXetNghiem.
- Nhóm 3 (Dược phẩm & Điều trị): Thuoc, ToaThuoc, ChiTietToaThuoc.
- Nhóm 4 (Nhân sự & Viện phí): NhanVien (abstract), BacSi, NhanVienCSKH, NhanVienThuNgan, HoaDonVienPhi.

#### Câu 2: Biểu đồ lớp (Class Diagram)
- File mô hình: So_do/So_do_Class_Diagram_Lab6.drawio
- Bao gồm 2 trang mô hình chuẩn mực:
  * Trang 1 (Lop_PhanTich): Mô hình 16 lớp phân tích, đánh dấu khóa chính # màu đỏ, thể hiện đầy đủ quan hệ Kế thừa (Generalization), Hợp thành (Composition) và 26 nhãn bản số multiplicity (1..1, 1..*, 0..*, 0..1).
  * Trang 2 (Lop_ThietKe_ChiTiet): Mô hình 16 lớp thiết kế chi tiết với cấu trúc 3 ngăn rõ ràng: Tên lớp, Thuộc tính kèm tầm vực riêng tư (-) và kiểu dữ liệu, Phương thức nghiệp vụ kèm tầm vực công khai (+) với danh sách tham số và kiểu trả về. Toàn bộ 26 nhãn bản số hiển thị bằng màu đỏ đậm nổi bật.

#### Câu 3: Biểu đồ Use Case tổng quát (Use Case Diagram)
- File mô hình: So_do/So_do_Use_Case_Lab6.drawio
- Mô hình hóa theo chuẩn đề cương giảng dạy của ThS. Phạm Trọng Huynh:
  * 4 Tác nhân (Actor) đặt tại 4 góc: Bệnh nhân, Nhân viên tiếp nhận & CSKH, Bác sĩ điều trị, Nhân viên thu ngân.
  * 11 Use Case cốt lõi chia thành 2 cột cân đối ở trung tâm.
  * 100% sử dụng quan hệ Association trực tiếp giữa tác nhân và Use Case tương ứng, không dùng Include/Extend gây rối mắt.

#### Câu 4: Biểu đồ Use Case phân rã chi tiết quy trình khám chữa bệnh
- File mô hình: So_do/So_do_Use_Case_Phan_Ra_Cau4.drawio
- Được chia thành 4 trang (Tab) Draw.io riêng biệt thể hiện 4 giai đoạn nghiệp vụ:
  * Trang 1 (TiepNhan_CapHSBA): Quy trình tiếp nhận bệnh nhân mới, nộp lệ phí năm và cấp hồ sơ bệnh án trọn đời.
  * Trang 2 (KhamBenh_LamSang): Quy trình khám lâm sàng, tra cứu lý lịch bệnh án cũ và khám định kỳ miễn phí theo quý.
  * Trang 3 (XetNghiem_CanLamSang): Quy trình chỉ định xét nghiệm, thực hiện đo đạc và cập nhật kết quả cận lâm sàng.
  * Trang 4 (KeToa_DongBenhAn): Quy trình lập đơn thuốc điều trị, thu viện phí và khóa hoàn tất đợt khám.

#### Câu 5: Biểu đồ hoạt động (Activity Diagram)
- File mô hình: So_do/So_do_Activity_Diagram_Cau5.drawio
- Thiết kế theo mô hình 4 phân làn bơi (Swimlanes) ngang chuẩn OOSD:
  1. BỆNH NHÂN
  2. NHÂN VIÊN TIẾP NHẬN & CSKH
  3. BÁC SĨ ĐIỀU TRỊ
  4. KỸ THUẬT VIÊN XÉT NGHIỆM
- Bao quát toàn bộ luồng quy trình từ khi đăng ký, rẽ nhánh khám lần đầu/tái khám, rẽ nhánh có/không xét nghiệm cận lâm sàng, kê toa và thanh toán viện phí xuất viện.

#### Câu 6: Biểu đồ tuần tự (Sequence Diagram)
- File mô hình: So_do/So_do_Sequence_Diagram_Cau6.drawio
- Mô hình hóa chi tiết nghiệp vụ "Khám bệnh, xét nghiệm, kê toa và hoàn tất thanh toán đợt khám" theo mô hình 3 lớp Boundary - Control - Entity (BCE):
  * Actor: BacSi, NhanVienThuNgan
  * Boundary: FrmKhamBenh, FrmThanhToan
  * Control: KhamBenhService, ThanhToanService
  * Entity: HoSoBenhAn, PhieuKhamBenh, ChiDinhXetNghiem, ToaThuoc, HoaDonVienPhi
  * 26 thông điệp nghiệp vụ liên tục, khung loop kê thuốc, alt rẽ nhánh kiểm tra xét nghiệm và transaction commit thanh toán viện phí an toàn.

#### Câu 7: Cơ sở dữ liệu SQL Server (QuanLyHoSoBenhAnDB)
- File script: Database/QuanLyHoSoBenhAn_Database.sql
- Thiết kế 12 bảng chuẩn hóa bậc 3 (3NF) có khóa chính (PRIMARY KEY), khóa ngoại (FOREIGN KEY) và ràng buộc duy nhất (UNIQUE SoCCCD).
- Hỗ trợ lưu trữ tiếng Việt có dấu 100% bằng kiểu dữ liệu NVARCHAR và bảng mã UTF-8 BOM.
- Xây dựng 3 Stored Procedure cốt lõi kết hợp Transaction (BEGIN TRAN, COMMIT, ROLLBACK):
  * sp_DangKyBenhNhanVaCapHoSo: Thực thi đồng thời thêm bệnh nhân, thu lệ phí năm, tạo hồ sơ bệnh án và lên lịch khám 4 quý.
  * sp_GhiNhanKhamBenhVaToaThuoc: Ghi nhận phiếu khám, kết quả cận lâm sàng và toa thuốc chi tiết.
  * sp_ThanhToanVienPhiVaDongHoSo: Tính tổng viện phí, trừ tiền miễn giảm định kỳ, xuất hóa đơn và khóa đóng đợt khám an toàn.

#### Câu 8: Ứng dụng WinForms C# (.NET Framework 4.7.2)
- Thư mục dự án: QuanLyHoSoBenhAn/
- Thiết kế giao diện hiện đại với 6 module chức năng:
  1. Đăng ký & Cấp hồ sơ bệnh án
  2. Tra cứu lịch sử bệnh án
  3. Quản lý lịch khám định kỳ
  4. Khám bệnh, xét nghiệm & Kê toa
  5. Thanh toán viện phí & Đóng hồ sơ
  6. Thoát chương trình (hộp thoại xác nhận an toàn)
- Toàn bộ chuỗi văn bản giao diện đã được chuẩn hóa, loại bỏ hoàn toàn các ký hiệu quy tắc thừa, bố cục lưới 2x3 cân đối và hiển thị tiếng Việt hoàn hảo.

---

### 3. Cấu trúc thư mục trong LAB6
```text
LAB6/
├── README.md                                 # Tài liệu tổng quan chi tiết bài Lab 6
├── 1250080121_Tran_Nguyen_Lab6.docx          # Báo cáo Word thuyết minh chi tiết Lab 6
├── QuanLyHoSoBenhAn_Database.sql             # Script khởi tạo CSDL SQL Server có Transaction
├── Database/
│   └── QuanLyHoSoBenhAn_Database.sql         # Bản lưu trữ CSDL SQL Server
├── Docs/
│   ├── 1250080121_Tran_Nguyen_Lab6.docx      # Bản lưu trữ báo cáo Word
│   └── Bai_5_Quan_ly_ho_so_benh_an.pdf       # Đề bài gốc Bài 5 của giảng viên
├── So_do/
│   ├── So_do_Class_Diagram_Lab6.drawio       # Sơ đồ Class Diagram (2 Tab: Phân tích & Thiết kế)
│   ├── So_do_Use_Case_Lab6.drawio            # Sơ đồ Use Case tổng quát (4 Actor, 11 Use Case)
│   ├── So_do_Use_Case_Phan_Ra_Cau4.drawio    # Sơ đồ Use Case phân rã 4 giai đoạn (4 Tab)
│   ├── So_do_Activity_Diagram_Cau5.drawio    # Sơ đồ Activity Diagram 4 làn bơi
│   └── So_do_Sequence_Diagram_Cau6.drawio    # Sơ đồ Sequence Diagram BCE 26 thông điệp
└── QuanLyHoSoBenhAn/                         # Dự án WinForms C# .NET Framework 4.7.2
    ├── QuanLyHoSoBenhAn.sln                  # File Solution Visual Studio
    └── QuanLyHoSoBenhAn/                     # Project mã nguồn C#
        ├── App.config                        # Cấu hình chuỗi kết nối SQL Server
        ├── Program.cs                        # Điểm khởi chạy ứng dụng
        ├── QuanLyHoSoBenhAn.csproj           # Cấu hình project Visual Studio
        ├── Data/
        │   └── Db.cs                         # Lớp tiện ích mở kết nối ADO.NET
        ├── Forms/
        │   ├── FrmMain.cs                    # Menu chính hệ thống (6 chức năng)
        │   ├── FrmDangKyHoSo.cs              # Form Đăng ký & Cấp hồ sơ bệnh án
        │   ├── FrmTraCuuLichSu.cs            # Form Tra cứu lịch sử bệnh án
        │   ├── FrmLichDinhKy.cs              # Form Quản lý lịch khám định kỳ
        │   ├── FrmKhamBenh.cs                # Form Khám bệnh, xét nghiệm & Kê toa
        │   └── FrmThanhToan.cs               # Form Thanh toán viện phí & Đóng hồ sơ
        └── Services/
            ├── BenhNhanService.cs            # Xử lý đăng ký, cấp hồ sơ và lịch định kỳ
            ├── KhamBenhService.cs            # Xử lý khám, xét nghiệm và đơn thuốc
            └── ThanhToanService.cs           # Xử lý tính viện phí, hóa đơn và đóng hồ sơ
```

---

### 4. Hướng dẫn cài đặt và sử dụng

#### 4.1. Khởi tạo Cơ sở dữ liệu SQL Server
1. Mở SQL Server Management Studio (SSMS) và kết nối vào máy chủ SQL Server của bạn (ví dụ: localhost hoặc .).
2. Mở file `Database/QuanLyHoSoBenhAn_Database.sql`.
3. Nhấn F5 (Execute) để tự động tạo cơ sở dữ liệu `QuanLyHoSoBenhAnDB`, tạo 12 bảng dữ liệu kèm các ràng buộc toàn vẹn, các Stored Procedure có Transaction và nạp sẵn dữ liệu mẫu tiếng Việt chuẩn.

#### 4.2. Mở và biên dịch ứng dụng WinForms
1. Khởi động Visual Studio 2022 (hoặc VS 2019).
2. Mở file giải pháp `QuanLyHoSoBenhAn/QuanLyHoSoBenhAn.sln`.
3. Kiểm tra chuỗi kết nối trong file `App.config` để đảm bảo Server Name phù hợp với máy của bạn.
4. Nhấn tổ hợp phím Ctrl + Shift + B để biên dịch (Build Solution).
5. Nhấn F5 để khởi chạy phần mềm và thực hiện các thao tác tiếp nhận, khám bệnh, xét nghiệm và thanh toán.

#### 4.3. Xem và chỉnh sửa các sơ đồ mô hình
1. Truy cập trang web trực tuyến https://app.diagrams.net (Draw.io) hoặc mở phần mềm Draw.io Desktop.
2. Chọn Open Existing Diagram và duyệt đến các file tương ứng trong thư mục `So_do/`.
3. Có thể chuyển đổi qua lại giữa các Tab (trang) trong các file có nhiều phân rã hoặc phân tích/thiết kế chi tiết.
