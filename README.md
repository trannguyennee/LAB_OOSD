# PHƯƠNG PHÁP PHÁT TRIỂN PHẦN MỀM HƯỚNG ĐỐI TƯỢNG (OOSD)
**Trường Đại học Tài nguyên và Môi trường TP. Hồ Chí Minh (HCMUNRE)**  
**Khoa Công nghệ Thông tin**

---

### Thông tin sinh viên
- **Họ và tên:** Trần Nguyên
- **Mã số sinh viên (MSSV):** 1250080121
- **Lớp:** 12CNPM2
- **Giảng viên hướng dẫn:** Thầy Huynh

---

### Cấu trúc Repository

```text
LAB_OOSD/
├── LAB1/
│   ├── README.md
│   ├── LAB1_BAI_1_1250080121_Tran_Nguyen_12CNPM2.docx
│   └── LAB1_BAI_2_1250080121_Tran_Nguyen_12CNPM2.docx
├── LAB2/
│   ├── README.md
│   ├── Database/
│   │   └── QuanLyThuVien.sql
│   ├── QuanLyThuVien/
│   │   ├── QuanLyThuVien.sln
│   │   └── QuanLyThuVien/
│   │       ├── Data/
│   │       ├── Services/
│   │       ├── Forms/
│   │       ├── Models.cs
│   │       └── Program.cs
│   ├── QuanLyThuVien_ThietKeGiaoDien_14UC.xlsx
│   ├── LAB2_He_thong_quan_ly_thu_vien.pdf
│   └── Sơ đồ thiết kế (Activity, Sequence, GUI Mockup)
├── LAB3/
│   ├── README.md
│   ├── Database/
│   │   └── QuanLyKhachSan.sql
│   ├── QuanLyKhachSan/
│   │   ├── QuanLyKhachSan.sln
│   │   └── QuanLyKhachSan/
│   │       ├── Data/
│   │       ├── Services/
│   │       ├── Forms/
│   │       └── Program.cs
│   └── Bai_3_He_thong_quan_ly_khach_san.pdf
└── LAB4/
    ├── README.md
    ├── Database/
    │   └── eShopping_Database.sql
    ├── eShopping/
    │   ├── eShopping.sln
    │   └── eShopping/
    │       ├── Data/
    │       ├── Services/
    │       ├── Forms/
    │       └── Program.cs
    └── Docs/
        ├── Trần Nguyên.docx
        ├── Bai_9_GOC.docx
        └── Images/ (Các sơ đồ phân tích UML)
```

---

### 📌 Danh mục bài thực hành
1. **[LAB 1](./LAB1/):** Phân tích và thiết kế hướng đối tượng:
   - Bài 1: Hệ thống thư viện trực tuyến.
   - Bài 2: Hệ thống quản lý bệnh viện.
2. **[LAB 2](./LAB2/):** Hệ thống Quản lý Thư viện hoàn chỉnh:
   - Kiến trúc 3 lớp (3-Layer Architecture): Presentation (WinForms), Business Logic (Services), Data Access (ADO.NET Db).
   - Cơ sở dữ liệu SQL Server với 9 bảng và các ràng buộc toàn vẹn nghiêm ngặt.
   - 6 Form giao diện chuẩn hóa: `FrmMain`, `FrmDanhMuc`, `FrmSach`, `FrmDocGia`, `FrmMuonTra`, `FrmThongKe`.
   - Vượt qua 100% 14 Test Case bắt buộc của đề bài.
3. **[LAB 3](./LAB3/):** Hệ thống Quản lý Khách sạn hoàn chỉnh:
   - Kiến trúc 3 lớp (3-Layer Architecture): Presentation (WinForms), Business Logic (Services), Data Access (ADO.NET Db).
   - Cơ sở dữ liệu SQL Server với 18 bảng chuẩn hóa, bảo toàn tính toàn vẹn dữ liệu.
   - 7 Form giao diện chuẩn 100% theo bản vẽ của Thầy Huỳnh Kòm: `FrmMain`, `FrmDanhMuc`, `FrmPhongTienNghi`, `FrmDatPhong`, `FrmDichVu`, `FrmTraPhong`, `FrmThongKe`.
   - Vượt qua 100% 15 Test Case bắt buộc của đề bài.
4. **[LAB 4](./LAB4/):** Hệ thống Cửa hàng trực tuyến "e-SHOPPING":
   - Phân tích và mô hình hóa hướng đối tượng UML toàn diện: Sơ đồ Use Case tổng quát & chi tiết, Bảng đặc tả Use Case, Sơ đồ lớp phân tích, Biểu đồ hoạt động phân làn, Biểu đồ tuần tự có Activation Bar, Biểu đồ trạng thái vòng đời đơn hàng.
   - Cơ sở dữ liệu SQL Server `eShoppingDB` gồm 6 bảng chuẩn hóa quan hệ kế thừa và hợp thành.
   - Ứng dụng C# WinForms kiến trúc 3 lớp theo mô hình Dashboard điều hướng của Thầy (`FrmMain`), màn hình mua sắm giỏ hàng (`FrmTrangChu`), lập phiếu đặt hàng & thanh toán thẻ tín dụng trực tuyến (`FrmDatHang`), và tra cứu lịch sử đơn hàng (`FrmLichSuDonHang`).
   - Cài đặt đầy đủ chính sách miễn phí vận chuyển tự động và xác thực thẻ tín dụng ngân hàng (Visa, MasterCard, American Express).
   - Vượt qua 100% 17 Test Case hệ thống bắt buộc.

