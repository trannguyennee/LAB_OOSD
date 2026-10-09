# LAB 5: HỆ THỐNG QUẢN LÝ CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM
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

### 1. Tổng quan đề tài và Phạm vi nghiệp vụ (Bài 6)
Hệ thống quản lý công ty du lịch Văn Hóa Việt TP.HCM tập trung tin học hóa toàn diện quy trình tổ chức, vận hành và kinh doanh tour du lịch nội địa và quốc tế xuất phát từ TP.HCM, bao gồm:
- Quản lý danh mục tour mẫu: Thiết kế lộ trình tuyến điểm, các nơi dừng chân (thay đổi phương tiện, nhà hàng, khách sạn lưu trú từ 2 đến 5 sao), điểm tham quan di tích lịch sử, danh lam thắng cảnh.
- Mở đợt tour (tour mở): Thiết lập ngày khởi hành, ngày về, số chỗ tối đa, đơn giá chuyến và công bố thông tin trên Website.
- Bán vé du lịch cho khách lẻ: Tra cứu số chỗ trống theo chuyến đi, bán vé và thu tiền, in vé du lịch, tiếp nhận hủy vé và tính phí phạt hoàn vé trước hạn theo quy định.
- Tổ chức tour cho khách đoàn (từ 12 người trở lên): Cho phép đoàn tự chọn ngày khởi hành, lộ trình và điểm đón riêng; lập dự toán kinh phí; tiếp nhận danh sách nhân khẩu mua bảo hiểm du lịch bắt buộc; thu tiền đặt cọc và thanh lý quyết toán hợp đồng.
- Điều phối hậu cần và nhân sự: Phân công Hướng dẫn viên (HDV) phù hợp; liên hệ đặt phương tiện vận chuyển (xe du lịch, tàu hỏa, máy bay), phòng khách sạn, nhà hàng; tự động gửi thông báo hẹn giờ và điểm đón cho khách hàng.
- Vận hành tour thực tế: Điểm danh đón khách tại điểm hẹn, thuyết minh hướng dẫn, linh hoạt xử lý chuyển đổi phương tiện trên cung đường, cập nhật nhật ký hành trình mỗi ngày.
- Hậu mãi và quyết toán: Đưa khách về điểm trả an toàn kết thúc hành trình tại TP.HCM, phát và thu thập phiếu khảo sát đánh giá chất lượng để nâng cao dịch vụ, quyết toán kinh phí đoàn, đối soát nhật ký để chi trả thù lao và công tác phí cho HDV.

---

### 2. Danh mục kết quả thực hiện các câu hỏi Lab 5

#### Câu 1: Xác định danh sách 16 Class hướng đối tượng (OOSD)
Hệ thống được chuẩn hóa thành 16 lớp đối tượng chia làm 4 nhóm nghiệp vụ chính:
- Nhóm 1 (Lớp Cơ sở & Tuyến điểm): TourDuLich, NoiDungChan, DiemThamQuan, ChuyenDi.
- Nhóm 2 (Lớp Khách hàng & Đăng ký): KhachHang, VeDuLich, PhieuDangKyDoan, KhachDiTour, DiemBanVe.
- Nhóm 3 (Lớp Vận hành & Hậu cần): PhuongTien, DichVuLuuTru, NhanVien, PhanCongHDV, NhatKyTour.
- Nhóm 4 (Lớp Tài chính & Đánh giá): PhieuThu, PhieuKhaoSat.

#### Câu 2: Biểu đồ lớp (Class Diagram)
- File mô hình: `So_do/So_do_Class_Diagram_Lab5.drawio`
- Bao gồm 2 trang mô hình:
  * Trang 1 (Lop_PhanTich): Mô hình 16 lớp phân tích, bản số kết hợp (1..1, 1..*, 0..*), quan hệ kết tập và phụ thuộc giữa các lớp.
  * Trang 2 (Lop_ThietKe_ChiTiet): Mô hình lớp thiết kế chi tiết, bổ sung đầy đủ thuộc tính, kiểu dữ liệu và phương thức xử lý (CRUD, Validate, Calculate).

#### Câu 3: Biểu đồ Use Case tổng quát (Use Case Diagram)
- File mô hình: `So_do/So_do_Use_Case_Lab5.drawio`
- Mô hình hóa toàn bộ phạm vi hệ thống gồm 20 Use Case cốt lõi chia theo 6 nhóm nghiệp vụ.
- 6 Tác nhân người dùng: Khách hàng (đại diện cả đoàn và lẻ), Nhân viên bán vé, NV Điều hành tour, Hướng dẫn viên, Nhân viên kế toán, Người quản trị (Admin).
- 3 Tác nhân hệ thống ngoài: Cổng thanh toán, Website công ty, Hệ thống Email/SMS.
- Bố cục chuẩn mực, thoáng đãng, dùng đường nối thẳng (straight line), nhãn include và extend rõ ràng trên nền trắng kèm bảng chú thích Legend trực quan.

#### Câu 4: Biểu đồ Use Case phân rã chi tiết quy trình hành trình tour
- File mô hình: `So_do/So_do_Use_Case_Phan_Ra_Cau4.drawio`
- Phân rã chi tiết toàn bộ chuỗi hoạt động từ khi khách đăng ký tour (theo đoàn hoặc theo chuyến) cho đến khi kết thúc tour qua 4 giai đoạn xuyên suốt:
  * Giai đoạn 1: Tiếp nhận đăng ký (nhánh khách lẻ và nhánh khách đoàn, đặt cọc, bảo hiểm).
  * Giai đoạn 2: Chuẩn bị và điều phối dịch vụ hậu cần (phân công HDV, đặt xe, khách sạn, gửi thông báo).
  * Giai đoạn 3: Vận hành dẫn tour thực tế (điểm danh, thuyết minh, đổi phương tiện, ghi nhật ký).
  * Giai đoạn 4: Kết thúc tour, đánh giá hậu mãi và quyết toán (trả khách tại TP.HCM, khảo sát chất lượng, thanh lý hợp đồng đoàn, tính thù lao HDV).

#### Câu 5: Biểu đồ hoạt động (Activity Diagram)
- File mô hình: `So_do/So_do_Activity_Diagram_Cau5.drawio`
- Thiết kế theo mô hình 5 phân làn bơi (Swimlanes):
  1. Khách hàng (Đoàn / Lẻ)
  2. Nhân viên Bán vé & Điều hành
  3. Hệ thống Phần mềm
  4. Hướng dẫn viên (HDV)
  5. Nhân viên Kế toán
- Thể hiện đầy đủ luồng công việc (Workflow), các nút quyết định rẽ nhánh (Decision node), nút hợp nhất (Merge node) và các hành động tương tác liên phòng ban.

#### Câu 6: Biểu đồ tuần tự (Sequence Diagram)
- File mô hình: `So_do/So_do_Sequence_Diagram_Cau6.drawio`
- Mô hình hóa chi tiết nghiệp vụ "Lập phiếu đăng ký tour theo đoàn" theo kiến trúc 3 lớp / BCE chuẩn OOSD:
  * Actor: NhanVien / KhachHang
  * Boundary: FrmDangKyTourDoan
  * Control: TourDoanService
  * Entity: TourDuLich, KhachHang, PhieuDangKyDoan, KhachDiTour (Bảo hiểm), PhieuThu (Đặt cọc)
- Kịch bản 27 thông điệp hoàn chỉnh, thể hiện lời gọi đồng bộ, thông điệp phản hồi và khung rẽ nhánh Alt fragment (Hợp lệ: số lượng >= 12 và tiền cọc >= 30% vs Không hợp lệ).

---

### 3. Cấu trúc thư mục trong LAB5
```text
LAB5/
├── README.MD                                 # Tài liệu tổng quan bài Lab 5
├── 1250080121_Tran_Nguyen_Lab5.docx          # Báo cáo thuyết minh chi tiết Lab 5
├── Docs/
│   ├── 1250080121_Tran_Nguyen_Lab5.docx      # Bản lưu trữ báo cáo Word
│   └── Bai_6_Quan_ly_cong_ty_du_lich.docx    # Đề bài gốc Bài 6 của giảng viên
└── So_do/
    ├── So_do_Class_Diagram_Lab5.drawio       # Sơ đồ Class Diagram (Câu 2)
    ├── So_do_Use_Case_Lab5.drawio            # Sơ đồ Use Case tổng quát (Câu 3)
    ├── So_do_Use_Case_Phan_Ra_Cau4.drawio    # Sơ đồ Use Case phân rã hành trình (Câu 4)
    ├── So_do_Activity_Diagram_Cau5.drawio    # Sơ đồ Activity Diagram (Câu 5)
    └── So_do_Sequence_Diagram_Cau6.drawio    # Sơ đồ Sequence Diagram (Câu 6)
```

---

### 4. Hướng dẫn mở và xem các mô hình
1. Mở phần mềm Draw.io Desktop hoặc truy cập trực tuyến tại địa chỉ https://app.diagrams.net.
2. Chọn Open Existing Diagram và trỏ đến các file trong thư mục `LAB5/So_do/`.
3. Toàn bộ các sơ đồ đều được định dạng font chữ Times New Roman chuẩn báo cáo khoa học, các nhãn mô hình đều có thể phóng to, thu nhỏ và tùy biến dễ dàng.
