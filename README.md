# BÀI TẬP THỰC HÀNH PHƯƠNG PHÁP PHÁT TRIỂN PHẦN MỀM HƯỚNG ĐỐI TƯỢNG (OOSD)

### Thông tin sinh viên
- **Họ và tên:** Trần Nguyên
- **Mã số sinh viên (MSSV):** 1250080121
- **Lớp:** 12_ĐH_CNPM2
- **Trường:** Đại học Tài nguyên và Môi trường TP. Hồ Chí Minh (HCMUNRE)
- **Giảng viên hướng dẫn:** ThS. Phạm Trọng Huynh

---

### Danh mục các bài Lab
| Lab | Đề tài | Nội dung chính |
|---|---|---|
| [LAB 0](LAB0/) | Cài đặt và kiểm tra môi trường | JDK, Maven, Git, IntelliJ + PlantUML, starter project Maven |
| [LAB 1](LAB1/) | Phân tích thiết kế hướng đối tượng | Bài 1 – Hệ thống thư viện trực tuyến; Bài 2 – Cửa hàng nước giải khát |
| [LAB 2](LAB2/) | Hệ thống quản lý thư viện | 14 Activity + 14 Sequence Diagram, thiết kế giao diện, CSDL SQL Server, WinForms 3 lớp |
| [LAB 3](LAB3/) | Hệ thống quản lý khách sạn | CSDL SQL Server 18 bảng, WinForms 3 lớp (7 form), 15 test case |
| [LAB 4](LAB4/) | Cửa hàng online e-SHOPPING | Use case, Class, Activity, Sequence, CSDL SQL Server, WinForms 3 lớp |
| [LAB 5](LAB5/) | Công ty Du lịch Văn Hóa Việt | Class, Use case, Use case phân rã, Activity, Sequence, CSDL, WinForms |
| [LAB 6](LAB6/) | Quản lý hồ sơ bệnh án | Class, Use case, Use case phân rã 4 giai đoạn, Activity, Sequence, CSDL, WinForms |
| [LAB 7](LAB7/) | Quản lý nhân sự – Công ty Sơn Đông Á | Class, Use case, Use case phân rã 4 giai đoạn, Activity, Sequence, CSDL, WinForms |
| [LAB 8](LAB8/) | Cửa hàng nước giải khát (hiện thực LAB 1 – Bài 2) | CSDL SQL Server 13 bảng, WinForms 3 lớp, ma trận truy vết, test case |

---

### Hình vẽ phân tích – thiết kế
Toàn bộ sơ đồ UML của các Lab được vẽ bằng **draw.io (diagrams.net)** và lưu file nguồn `.drawio` trong thư mục [`IMAGES/`](IMAGES/) (mỗi Lab một thư mục con).

### Cấu trúc chung của mỗi Lab
- `*.docx`: báo cáo Word của Lab.
- `Database/*.sql`: script tạo CSDL SQL Server (các Lab có hiện thực).
- `<TenDuAn>/<TenDuAn>.sln`: solution C# WinForms (.NET Framework 4.7.2) theo kiến trúc 3 lớp `Forms → Services → Data`.
- `README.md`: mô tả chi tiết và hướng dẫn chạy.

---
*Cập nhật hoàn tất toàn bộ các bài Lab: Chủ nhật, ngày 01/11/2026.*