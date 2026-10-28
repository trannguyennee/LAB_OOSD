# LAB 1: PHÂN TÍCH VÀ THIẾT KẾ HƯỚNG ĐỐI TƯỢNG (OOAD)

### Thông tin sinh viên & đề tài
- **Sinh viên thực hiện:** Trần Nguyên
- **Mã số sinh viên (MSSV):** 1250080121
- **Lớp:** 12_ĐH_CNPM2
- **Trường:** Đại học Công nghệ TP.HCM (HUTECH)
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng (OOSD)
- **Giảng viên hướng dẫn:** ThS. Phạm Trọng Huynh

---

### Danh mục tài liệu báo cáo
1. **Bài 1: Xây dựng hệ thống thư viện trực tuyến**
   - Tập tin: `LAB1_BAI_1_1250080121_Tran_Nguyen_12CNPM2.docx`
   - Khảo sát các phân hệ: Độc giả (Sinh viên, Giảng viên), Thủ thư và Hệ thống tự động.
   - Bảng đặc tả chi tiết 14 Use Cases kèm sơ đồ Activity Diagram và Use Case Diagram.

2. **Bài 2: Hệ thống quản lý cửa hàng nước giải khát**
   - Tập tin: `LAB1_BAI_2_1250080121_Tran_Nguyen_12CNPM2.docx`
   - **Tóm tắt phân tích hệ thống (5 mục trọng tâm):**
     1. *Yêu cầu hệ thống (System Requirements):* Mục tiêu tin học hóa quy trình mua bán, nhập hàng, quản lý kho, công nợ và giao hàng nhiều đợt.
     2. *Mô hình Đầu vào – Xử lý – Đầu ra (IPO):* Phân tích rõ luồng dữ liệu đầu vào, các quy trình nghiệp vụ và chứng từ đầu ra.
     3. *Tác nhân & Hệ thống ngoài:* Khách hàng (Khách quen, Khách vãng lai), Nhân viên cửa hàng, Nhà cung ứng NGK.
     4. *Quy tắc nghiệp vụ & Quyết định phát triển:* Mỗi loại NGK chỉ nhập từ 1 NCC; mỗi ĐĐH giao tối đa 3 đợt; kiểm tra tồn kho xuất ngay hoặc hẹn giao nhiều đợt cho khách quen; khách vãng lai thanh toán 100% tại quầy, chỉ khách quen mới được phép trả chậm (lập phiếu ghi nợ).
     5. *Yêu cầu chức năng (FR) và Yêu cầu phi chức năng (NFR):* Đặc tả 11 Use Cases tổng quát, 12 Use Cases phân rã, độ sẵn sàng, tính toàn vẹn và bảo mật.
   - **Chi tiết các câu hỏi:**
     - Câu 1: Xác định Actor & Use Case Diagram tổng quát (11 Use Cases).
     - Câu 2: Xác định 13 Class với đầy đủ thuộc tính, phương thức và khóa định danh.
     - Câu 3: Class Diagram thiết kế chi tiết với bản số quan hệ (Multiplicity) chuẩn mực.
     - Câu 4: Use Case Diagram phân rã chi tiết quy trình mua bán (12 Use Cases).
     - Câu 5: Activity Diagram 4 làn bơi (Khách hàng, Nhân viên, Kho/Giao hàng, Hệ thống).
     - Câu 6: Sequence Diagram nghiệp vụ Lập phiếu ghi nợ cho khách quen.
   - **Ma trận truy vết yêu cầu (Traceability Matrix):** Truy vết từ Yêu cầu -> UML -> Form/Service -> Bảng CSDL -> Test Case phục vụ trực tiếp cho Lab 8.
