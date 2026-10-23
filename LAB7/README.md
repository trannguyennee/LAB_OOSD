# BÀI LAB 07 - PHÁT TRIỂN PHẦN MỀM HƯỚNG ĐỐI TƯỢNG (OOSD)

## ĐỀ TÀI: HỆ THỐNG QUẢN LÝ NHÂN SỰ - CÔNG TY SƠN ĐÔNG Á

- **Sinh viên thực hiện:** Trần Nguyên
- **Mã số sinh viên (MSSV):** 1250080121
- **Lớp:** 12CNPM2
- **Trường:** Đại học Tài nguyên và Môi trường TP.HCM (HCMUNRE)
- **Giảng viên hướng dẫn:** ThS. Phạm Trọng Huynh

---

## 1. GIỚI THIỆU HỆ THỐNG
Dự án được xây dựng bám sát quy trình phân tích và thiết kế hướng đối tượng (OOSD), đáp ứng đầy đủ nghiệp vụ quản lý nhân sự chuyên sâu của nhà máy và văn phòng Công ty Sơn Đông Á:
- Quản lý hồ sơ nhân viên đa phòng ban, phân xưởng, tổ sản xuất.
- Quản lý các loại hợp đồng lao động (thử việc, xác định/không xác định thời hạn, khoán) và tham gia BHXH/BHYT/BHTN.
- Phân ca làm việc 3 ca liên tục, chấm công máy quét vân tay tự động.
- Tính lương theo ngày công chuẩn, giờ phụ trội (tăng ca ngày thường, chủ nhật, lễ) và phụ cấp độc hại cho công nhân phân xưởng sản xuất sơn.
- Lập và phê duyệt quyết định khen thưởng, kỷ luật nhân viên.

---

## 2. CẤU TRÚC THƯ MỤC
`	ext
LAB7/
├── Database/
│   └── QuanLyNhanSu_Database.sql         # Kịch bản tạo CSDL 18 bảng chuẩn 3NF, seed data và Stored Procedures
├── QuanLyNhanSu/                         # Giải pháp WinForms C# (.NET Framework 4.7.2)
│   ├── QuanLyNhanSu.sln                  # File Visual Studio Solution
│   └── QuanLyNhanSu/
│       ├── App.config                    # Chuỗi kết nối SQL Server
│       ├── Program.cs
│       ├── QuanLyNhanSu.csproj
│       ├── Data/
│       │   └── Db.cs                     # Lớp kết nối CSDL ADO.NET dùng chung
│       ├── Services/                     # 5 Lớp Service nghiệp vụ
│       │   ├── NhanVienService.cs
│       │   ├── HopDongBaoHiemService.cs
│       │   ├── PhanCaPhuTroiService.cs
│       │   ├── ChamCongLuongService.cs
│       │   └── KhenThuongKyLuatService.cs
│       └── Forms/                        # 7 Màn hình giao diện chức năng
│           ├── FrmMain.cs                # Màn hình Menu chính (Dashboard)
│           ├── FrmNhanVien.cs            # Quản lý hồ sơ nhân viên
│           ├── FrmHopDong.cs             # Hợp đồng & Bảo hiểm
│           ├── FrmPhanCaPhuTroi.cs       # Phân ca làm việc & Đăng ký phụ trội
│           ├── FrmChamCong.cs            # Bảng chấm công vân tay
│           ├── FrmBangLuong.cs           # Bảng tính lương & Phụ cấp độc hại
│           └── FrmKhenThuongKyLuat.cs    # Lập quyết định khen thưởng / kỷ luật
├── QuanLyNhanSu_Database.sql
└── README.md
`

---

## 3. HƯỚNG DẪN CÀI ĐẶT & CHẠY
1. **Cơ sở dữ liệu:**
   - Mở file Database/QuanLyNhanSu_Database.sql trong SQL Server Management Studio (SSMS).
   - Nhấn **Execute** (F5) để khởi tạo CSDL QuanLyNhanSu_SonDongA và nạp toàn bộ dữ liệu mẫu.
2. **Ứng dụng:**
   - Mở file QuanLyNhanSu/QuanLyNhanSu.sln bằng **Visual Studio 2022**.
   - Kiểm tra chuỗi kết nối trong App.config (mặc định: Data Source=.;Initial Catalog=QuanLyNhanSu_SonDongA;Integrated Security=True).
   - Nhấn **Start** (F5) hoặc Ctrl + F5 để khởi chạy phần mềm.
