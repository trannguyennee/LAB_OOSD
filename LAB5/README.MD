# BÀI LAB 05 - PHÁT TRIỂN PHẦN MỀM HƯỚNG ĐỐI TƯỢNG (OOSD)

## ĐỀ TÀI: HỆ THỐNG QUẢN LÝ CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM

- **Sinh viên thực hiện:** Trần Nguyên
- **Mã số sinh viên (MSSV):** 1250080121
- **Lớp:** 12CNPM2
- **Khoa:** Công nghệ thông tin
- **Trường:** Đại học Tài nguyên và Môi trường TP.HCM (HCMUNRE)
- **Giảng viên hướng dẫn:** ThS. Phạm Trọng Huynh

---

## 1. GIỚI THIỆU HỆ THỐNG
Dự án được xây dựng bám sát quy trình phân tích và thiết kế hướng đối tượng (OOSD), tin học hóa toàn diện hoạt động kinh doanh lữ hành của Công ty Du lịch Văn Hóa Việt TP.HCM:
- Quản lý chương trình Tour du lịch khép kín (xuất phát từ TP.HCM và kết thúc tại TP.HCM).
- Quản lý các chặng dừng chân liên hoàn (xác định đổi phương tiện máy bay/xe đò/tàu hỏa, nơi ăn uống, khách sạn lưu trú 2 đến 5 sao) và danh sách điểm tham quan di tích lịch sử, danh lam thắng cảnh.
- Quản lý chuyến đi cố định và bán vé cho Khách lẻ (< 12 người, đón tại điểm quy định, thanh toán tiền vé ngay).
- Tiếp nhận đăng ký tour theo đoàn (>= 12 người, tự do chọn ngày đi, xe đón tận nơi, thu tiền cọc trước, danh sách người tham gia bảo hiểm, quyết toán sau tour).
- Điều hành phân công Hướng dẫn viên (HDV) với thuật toán kiểm soát chống trùng lịch công tác (BR12, BR13).
- Bảng tính lương HDV hàng tháng (Lương căn bản + Lương tour thực hiện trong tháng - BR14).
- Thu thập và thống kê phiếu khảo sát đánh giá chất lượng dịch vụ từ du khách.

---

## 2. KẾT QUẢ THỰC HIỆN CÁC CÂU HỎI LAB 05

### Câu 1: Xác định danh sách 16 Class hướng đối tượng (OOSD)
Hệ thống được chuẩn hóa thành 16 lớp đối tượng chia làm 4 nhóm nghiệp vụ chính:
- **Nhóm 1 (Lớp Cơ sở & Tuyến điểm):** `TourDuLich`, `NoiDungChan`, `DiemThamQuan`, `ChuyenDi`.
- **Nhóm 2 (Lớp Khách hàng & Đăng ký):** `KhachHang`, `KhachHangDoan`, `KhachHangLe`, `PhieuDangKyDoan`, `NguoiThamGiaBaoHiem`, `VeDuLich`, `DiemBanVe`.
- **Nhóm 3 (Lớp Nhân sự & Điều hành):** `NhanVien`, `HuongDanVien`, `PhanCongHDV`, `BangLuongHDV`.
- **Nhóm 4 (Lớp Hậu mãi & Đánh giá):** `PhieuKhaoSat`.

### Câu 2: Biểu đồ lớp (Class Diagram)
- File mô hình: `So_do/So_do_Class_Diagram_Lab5.drawio`
- Bao gồm 2 trang mô hình:
  * Trang 1 (Lop_PhanTich): Mô hình 16 lớp phân tích, bản số kết hợp (1..1, 1..*, 0..*), quan hệ kết tập và phụ thuộc giữa các lớp.
  * Trang 2 (Lop_ThietKe_ChiTiet): Mô hình lớp thiết kế chi tiết, bổ sung đầy đủ thuộc tính, kiểu dữ liệu và phương thức xử lý (CRUD, Validate, Calculate).

### Câu 3: Biểu đồ Use Case tổng quát (Use Case Diagram)
- File mô hình: `So_do/So_do_Use_Case_Lab5.drawio`
- Mô hình hóa toàn bộ phạm vi hệ thống gồm 20 Use Case cốt lõi chia theo 6 nhóm nghiệp vụ.
- 6 Tác nhân người dùng: Khách hàng (đoàn và lẻ), NV bán vé, NV Điều hành tour, Hướng dẫn viên, NV kế toán, Người quản trị (Admin).
- 3 Tác nhân hệ thống ngoài: Cổng thanh toán, Website công ty, Hệ thống Email/SMS.

### Câu 4: Biểu đồ Use Case phân rã chi tiết hành trình tour
- File mô hình: `So_do/So_do_Use_Case_Phan_Ra_Cau4.drawio`
- Phân rã chi tiết chuỗi hoạt động từ khi khách đăng ký tour đến khi kết thúc qua 4 giai đoạn: Tiếp nhận đăng ký → Chuẩn bị hậu cần → Dẫn tour thực tế → Kết thúc & Quyết toán.

### Câu 5: Biểu đồ hoạt động (Activity Diagram)
- File mô hình: `So_do/So_do_Activity_Diagram_Cau5.drawio`
- Thiết kế theo mô hình 5 phân làn bơi (Swimlanes): Khách hàng, NV Bán vé & Điều hành, Hệ thống Phần mềm, Hướng dẫn viên, NV Kế toán.

### Câu 6: Biểu đồ tuần tự (Sequence Diagram)
- File mô hình: `So_do/So_do_Sequence_Diagram_Cau6.drawio`
- Mô hình hóa chi tiết nghiệp vụ "Lập phiếu đăng ký tour theo đoàn" theo kiến trúc 3 lớp / BCE chuẩn OOSD (Boundary - Control - Entity) với 27 thông điệp và khung rẽ nhánh Alt fragment.

---

## 3. CƠ SỞ DỮ LIỆU SQL SERVER & ỨNG DỤNG C# WINFORMS

### Cơ sở dữ liệu (`QuanLyDuLich_Database.sql`)
- CSDL `QuanLyDuLich_VanHoaViet` gồm 16 bảng chuẩn 3NF, đồng bộ nhất quán 100% với mô hình lớp OOSD.
- 4 Stored Procedures nghiệp vụ: `sp_KiemTraVaPhanCongHDV`, `sp_DatVeKhachLe`, `sp_LapPhieuDangKyDoan`, `sp_TinhLuongHDV`.

### Ứng dụng C# WinForms (.NET 4.7.2 - 3 Lớp)
- **Tầng Data:** `Db.cs` kết nối ADO.NET an toàn qua `App.config`.
- **Tầng Service:** `TourLichTrinhService.cs`, `ChuyenDiVeLeService.cs`, `DangKyDoanBaoHiemService.cs`, `DieuHanhHDVService.cs`, `LuongKhaoSatService.cs`.
- **Tầng UI:** 7 Forms (`FrmMain`, `FrmTourLichTrinh`, `FrmChuyenDiVeLe`, `FrmDangKyDoan`, `FrmPhanCongHDV`, `FrmBangLuongHDV`, `FrmPhieuKhaoSat`).
- File thực thi: `bin/Debug/QuanLyDuLich.exe` (Biên dịch MSBuild 0 Lỗi, 0 Cảnh báo).

---

## 4. CẤU TRÚC THƯ MỤC TRONG LAB5
```text
LAB5/
├── 1250080121_Tran_Nguyen_Lab5.docx          # Báo cáo thuyết minh hoàn chỉnh Lab 5
├── Bai_6_Quan_ly_cong_ty_du_lich.docx        # Đề bài gốc của giảng viên
├── Database/
│   └── QuanLyDuLich_Database.sql             # Kịch bản CSDL 16 bảng chuẩn 3NF & Stored Procedures
├── Docs/
│   ├── 1250080121_Tran_Nguyen_Lab5.docx      # Bản lưu trữ báo cáo Word
│   └── Bai_6_Quan_ly_cong_ty_du_lich.docx    # Đề bài gốc Bài 6
├── QuanLyDuLich/                             # Giải pháp WinForms C# (.NET Framework 4.7.2)
│   ├── QuanLyDuLich.sln                      # File Visual Studio Solution
│   └── QuanLyDuLich/
│       ├── App.config                        # Chuỗi kết nối SQL Server
│       ├── Program.cs
│       ├── QuanLyDuLich.csproj
│       ├── Data/
│       │   └── Db.cs                         # Lớp kết nối CSDL ADO.NET dùng chung
│       ├── Services/                         # 5 Lớp Service nghiệp vụ OOSD
│       │   ├── TourLichTrinhService.cs
│       │   ├── ChuyenDiVeLeService.cs
│       │   ├── DangKyDoanBaoHiemService.cs
│       │   ├── DieuHanhHDVService.cs
│       │   └── LuongKhaoSatService.cs
│       └── Forms/                            # 7 Màn hình giao diện chức năng
│           ├── FrmMain.cs                    # Màn hình Menu chính (Dashboard)
│           ├── FrmTourLichTrinh.cs           # Quản lý Tour & Lộ trình dừng chân
│           ├── FrmChuyenDiVeLe.cs            # Chuyến đi cố định & Bán vé khách lẻ
│           ├── FrmDangKyDoan.cs              # Đăng ký Tour đoàn & Bảo hiểm du lịch
│           ├── FrmPhanCongHDV.cs             # Điều hành phân công HDV chống trùng lịch
│           ├── FrmBangLuongHDV.cs            # Bảng tính lương HDV
│           └── FrmPhieuKhaoSat.cs            # Khảo sát đánh giá chất lượng dịch vụ
├── So_do/                                    # Thư mục chứa 5 sơ đồ Draw.io gốc
└── README.MD
```

---

## 5. HƯỚNG DẪN CÀI ĐẶT & CHẠY
1. **Cơ sở dữ liệu:**
   - Mở file `Database/QuanLyDuLich_Database.sql` trong SQL Server Management Studio (SSMS).
   - Nhấn **Execute** (F5) để khởi tạo CSDL `QuanLyDuLich_VanHoaViet` và nạp toàn bộ dữ liệu mẫu.
2. **Ứng dụng C# WinForms:**
   - Mở file `QuanLyDuLich/QuanLyDuLich.sln` bằng **Visual Studio 2022**.
   - Nhấn **Start** (F5) hoặc `Ctrl + F5` để khởi chạy phần mềm.
