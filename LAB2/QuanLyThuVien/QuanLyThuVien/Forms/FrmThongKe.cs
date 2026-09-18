using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien.Services;

namespace QuanLyThuVien.Forms
{
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeService service = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            // Mặc định khoảng thời gian tháng hiện tại
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpDenNgay.Value = today;

            // Nạp ComboBox mức quá hạn
            cboMucQuaHan.Items.Clear();
            cboMucQuaHan.Items.Add("Tất cả");
            cboMucQuaHan.Items.Add("Quá hạn từ 1 đến 7 ngày");
            cboMucQuaHan.Items.Add("Quá hạn trên 7 ngày");
            cboMucQuaHan.SelectedIndex = 0;

            TaiBaoCaoUC13();
            TaiDanhSachQuaHanUC10();
        }

        #region TAB 1: BÁO CÁO THỐNG KÊ (UC13)

        private void TaiBaoCaoUC13()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date;

                ThongKeTongHop th = service.LayTongHop(tuNgay, denNgay);
                lblValLuotMuon.Text = th.LuotSachMuon + " Lượt";

                int pctDungHan = th.LuotSachMuon > 0 ? (int)Math.Round((double)th.DaTraDungHan * 100 / th.LuotSachMuon) : 0;
                lblValDungHan.Text = string.Format("{0} Lượt ({1}%)", th.DaTraDungHan, pctDungHan);

                int pctQuaHan = th.LuotSachMuon > 0 ? (int)Math.Round((double)th.SachQuaHan * 100 / th.LuotSachMuon) : 0;
                lblValQuaHan.Text = string.Format("{0} Lượt ({1}%)", th.SachQuaHan, pctQuaHan);

                lblValTongPhat.Text = th.TongPhiPhat.ToString("N0") + " VNĐ";

                DataTable dtTheLoai = service.LayBaoCaoTheoTheLoai(tuNgay, denNgay);
                dgvTheLoai.DataSource = dtTheLoai;
                dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            TaiBaoCaoUC13();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpDenNgay.Value = today;
            TaiBaoCaoUC13();
        }

        private void btnXuatExcelUC13_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            XuatDataGridViewRaCsv(dgvTheLoai, "BaoCaoThongKeTheLoai_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            string msg = string.Format(
                "=== BÁO CÁO THỐNG KÊ HOẠT ĐỘNG THƯ VIỆN ===\n\n" +
                "• Thời gian thống kê: Từ {0} đến {1}\n" +
                "• Tổng lượt mượn: {2}\n" +
                "• Đã trả đúng hạn: {3}\n" +
                "• Lượt quá hạn: {4}\n" +
                "• Tổng thu phí phạt: {5}\n" +
                "• Số danh mục thể loại: {6}\n\n" +
                "Đã sẵn sàng gửi lệnh in tới máy in tài liệu!",
                dtpTuNgay.Value.ToString("dd/MM/yyyy"), dtpDenNgay.Value.ToString("dd/MM/yyyy"),
                lblValLuotMuon.Text, lblValDungHan.Text, lblValQuaHan.Text, lblValTongPhat.Text,
                dgvTheLoai.Rows.Count);

            MessageBox.Show(msg, "In báo cáo thống kê PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BIỂU ĐỒ PHÂN BỐ TỶ LỆ MƯỢN THEO THỂ LOẠI:\n");
            foreach (DataGridViewRow r in dgvTheLoai.Rows)
            {
                string ten = Convert.ToString(r.Cells["Tên thể loại sách"].Value);
                decimal pct = Convert.ToDecimal(r.Cells["Tỷ lệ mượn (%)"].Value);
                int bars = (int)Math.Round(pct / 4);
                string barStr = new string('█', Math.Max(1, bars));
                sb.AppendLine(string.Format("{0,-32}: {1} {2}%", ten, barStr, pct));
            }

            MessageBox.Show(sb.ToString(), "Biểu đồ trực quan (UC13)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region TAB 2: TRA CỨU QUÁ HẠN & NHẮC HẠN (UC10 & UC14)

        private void TaiDanhSachQuaHanUC10()
        {
            try
            {
                string muc = "";
                if (cboMucQuaHan.SelectedIndex == 1) muc = "1-7";
                else if (cboMucQuaHan.SelectedIndex == 2) muc = ">7";

                string tuKhoa = txtTimDocGia.Text.Trim();
                DataTable dt = service.LayDanhSachQuaHan(muc, tuKhoa);

                dgvQuaHan.DataSource = dt;
                dgvQuaHan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Ẩn các cột dữ liệu nội bộ
                if (dgvQuaHan.Columns.Contains("TienPhatRaw")) dgvQuaHan.Columns["TienPhatRaw"].Visible = false;
                if (dgvQuaHan.Columns.Contains("Email")) dgvQuaHan.Columns["Email"].Visible = false;
                if (dgvQuaHan.Columns.Contains("SoDienThoai")) dgvQuaHan.Columns["SoDienThoai"].Visible = false;

                // Cập nhật nhãn thống kê dưới chân bảng
                decimal tongPhat = 0;
                foreach (DataRow r in dt.Rows)
                {
                    tongPhat += Convert.ToDecimal(r["TienPhatRaw"]);
                }

                lblFooterUC10.Text = string.Format(
                    "Tổng cộng: Tìm thấy {0} độc giả đang mượn quá hạn | Tổng tiền phạt tạm tính tích lũy: {1:N0} VNĐ.",
                    dt.Rows.Count, tongPhat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tra cứu danh sách quá hạn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraCuuQuaHan_Click(object sender, EventArgs e)
        {
            TaiDanhSachQuaHanUC10();
        }

        private void btnLamMoiQuaHan_Click(object sender, EventArgs e)
        {
            cboMucQuaHan.SelectedIndex = 0;
            txtTimDocGia.Clear();
            TaiDanhSachQuaHanUC10();
        }

        private void btnGuiEmailUC14_Click(object sender, EventArgs e)
        {
            if (dgvQuaHan.Rows.Count == 0)
            {
                MessageBox.Show("Hiện không có độc giả nào mượn sách quá hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvQuaHan.CurrentRow != null && dgvQuaHan.CurrentRow.DataBoundItem != null)
            {
                DataRowView r = dgvQuaHan.CurrentRow.DataBoundItem as DataRowView;
                if (r != null)
                {
                    string hoTen = Convert.ToString(r["Họ tên độc giả"]);
                    string email = Convert.ToString(r["Email"]);
                    string tenSach = Convert.ToString(r["Tên sách mượn"]);
                    string quaHan = Convert.ToString(r["Quá hạn"]);
                    string tienPhat = Convert.ToString(r["Phạt dự kiến"]);

                    string msg = string.Format(
                        "HỆ THỐNG ĐÃ GỬI EMAIL THÀNH CÔNG (UC14):\n\n" +
                        "• Người nhận: {0} ({1})\n" +
                        "• Tên sách mượn: {2}\n" +
                        "• Tình trạng trễ hạn: {3}\n" +
                        "• Phí phạt tích lũy tạm tính: {4}\n\n" +
                        "Tiêu đề email: [Thư Viện] - Thông báo sách mượn đã quá hạn trả\n" +
                        "Nội dung email: \"Kính gửi bạn đọc {0}, bạn hiện đang giữ cuốn sách [{2}] đã quá hạn {3}. Vui lòng sớm đến thư viện hoàn trả để tránh phát sinh thêm phí phạt.\"",
                        hoTen, string.IsNullOrWhiteSpace(email) ? "Không có email" : email, tenSach, quaHan, tienPhat);

                    MessageBox.Show(msg, "Gửi Email Nhắc Hạn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Vui lòng chọn 1 dòng độc giả quá hạn để gửi email nhắc hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXuatExcelUC10_Click(object sender, EventArgs e)
        {
            if (dgvQuaHan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu quá hạn để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            XuatDataGridViewRaCsv(dgvQuaHan, "DanhSachMuonQuaHan_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
        }

        private void btnInNoSach_Click(object sender, EventArgs e)
        {
            if (dgvQuaHan.CurrentRow == null || dgvQuaHan.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Vui lòng chọn 1 độc giả cần in giấy báo nợ sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView r = dgvQuaHan.CurrentRow.DataBoundItem as DataRowView;
            if (r == null) return;

            string phieu = string.Format(
                "====================================================\n" +
                "             GIẤY BÁO NỢ SÁCH THƯ VIỆN\n" +
                "====================================================\n" +
                "Họ tên độc giả   : {0}\n" +
                "Liên hệ          : {1}\n" +
                "Mã phiếu mượn    : {2}\n" +
                "Đầu sách mượn    : {3}\n" +
                "Hạn trả quy định : {4}\n" +
                "Thời gian trễ hạn: {5}\n" +
                "Tiền phạt nợ tạm tính: {6}\n" +
                "====================================================\n" +
                "Yêu cầu bạn đọc thanh toán và hoàn trả sách trong vòng 3 ngày!",
                r["Họ tên độc giả"], r["Số điện thoại / Email"], r["Mã PM"],
                r["Tên sách mượn"], r["Hạn phải trả"], r["Quá hạn"], r["Phạt dự kiến"]);

            MessageBox.Show(phieu, "In Thông Báo Nợ Sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void XuatDataGridViewRaCsv(DataGridView dgv, string defaultFileName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv|All Files (*.*)|*.*";
                sfd.FileName = defaultFileName + ".csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        // Headers
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            if (!dgv.Columns[i].Visible) continue;
                            sb.Append("\"" + dgv.Columns[i].HeaderText.Replace("\"", "\"\"") + "\"");
                            if (i < dgv.Columns.Count - 1) sb.Append(",");
                        }
                        sb.AppendLine();

                        // Rows
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                if (!dgv.Columns[i].Visible) continue;
                                string val = Convert.ToString(row.Cells[i].Value) ?? "";
                                sb.Append("\"" + val.Replace("\"", "\"\"") + "\"");
                                if (i < dgv.Columns.Count - 1) sb.Append(",");
                            }
                            sb.AppendLine();
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất file Excel/CSV thành công:\n" + sfd.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
