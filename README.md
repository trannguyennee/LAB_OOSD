# PHƯƠNG PHÁP PHÁT TRIỂN PHẦN MỀM HƯỚNG ĐỐI TƯỢNG (OOSD)
**Trường Đại học Tài nguyên và Môi trường TP. Hồ Chí Minh (HCMUNRE)**  
**Khoa Công nghệ Thông tin**

---

### 👨‍🎓 Thông tin sinh viên
- **Họ và tên:** Trần Nguyên
- **Mã số sinh viên (MSSV):** 1250080121
- **Lớp:** 12CNPM2
- **Giảng viên hướng dẫn:** Thầy Huỳnh Kòm

---

### 📁 Cấu trúc Repository

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
└── ...
```

---

### 📌 Danh mục bài thực hành
1. **[LAB 1](./LAB1/):** Phân tích và thiết kế hướng đối tượng:
   - Bài 1: Hệ thống thư viện trực tuyến.
   - Bài 2: Hệ thống quản lý bệnh viện.
2. **[LAB 2](./LAB2/):** Hệ thống Quản lý Thư viện hoàn chỉnh:
   - Kiến trúc 3 lớp (3-Layer Architecture): Presentation (WinForms), Business Logic (Services), Data Access (ADO.NET Db).
   - Cơ sở dữ liệu SQL Server LocalDB với 9 bảng và các ràng buộc toàn vẹn nghiêm ngặt.
   - 6 Form giao diện chuẩn hóa: `FrmMain`, `FrmDanhMuc`, `FrmSach`, `FrmDocGia`, `FrmMuonTra`, `FrmThongKe`.
   - Vượt qua 100% 14 Test Case bắt buộc của đề bài.
