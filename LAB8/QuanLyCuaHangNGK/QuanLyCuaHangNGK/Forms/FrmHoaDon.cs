using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangNGK.Services;

namespace QuanLyCuaHangNGK.Forms
{
    public partial class FrmHoaDon : Form
    {
        private HoaDonService _hdService = new HoaDonService();
        private NuocGiaiKhatService _ngkService = new NuocGiaiKhatService();
        private List<ChiTietBanDto> _gioHang = new List<ChiTietBanDto>();

        public FrmHoaDon()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataTable dtKH = _hdService.GetKhachHangList();
                cboKhachHang.DataSource = dtKH;
                cboKhachHang.DisplayMember = "TenKH";
                cboKhachHang.ValueMember = "MaKH";

                DataTable dtNV = _hdService.GetNhanVienList();
                cboNhanVien.DataSource = dtNV;
                cboNhanVien.DisplayMember = "HoTen";
                cboNhanVien.ValueMember = "MaNV";

                cboNGK.DataSource = _ngkService.GetAllNGK();
                cboNGK.DisplayMember = "TenNGK";
                cboNGK.ValueMember = "MaNGK";

                dgvHoaDon.DataSource = _hdService.GetAllHoaDon();
                CapNhatThongTinKH();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongTinKH();
        }

        private void CapNhatThongTinKH()
        {
            if (cboKhachHang.SelectedItem != null)
            {
                DataRowView row = cboKhachHang.SelectedItem as DataRowView;
                if (row != null)
                {
                    string loai = row["LoaiKH"].ToString();
                    decimal no = Convert.ToDecimal(row["TongNo"]);

                    lblLoaiKH.Text = loai == "KhachQuen" ? "KHÁCH QUEN (Được phép hẹn đợt & ghi nợ)" : "KHÁCH VÃNG LAI (Chỉ giao ngay, không ghi nợ)";
                    lblLoaiKH.ForeColor = loai == "KhachQuen" ? Color.DarkGreen : Color.DarkRed;
                    lblNoHienTai.Text = "Công nợ hiện tại: " + no.ToString("N0") + " VNĐ";

                    // Nếu là khách vãng lai, khóa tùy chọn ghi nợ
                    if (loai == "KhachVangLai")
                    {
                        chkGhiNo.Checked = false;
                        chkGhiNo.Enabled = false;
                        pnlGhiNo.Visible = false;
                    }
                    else
                    {
                        chkGhiNo.Enabled = true;
                    }
                }
            }
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (cboNGK.SelectedItem == null) return;

            DataRowView row = cboNGK.SelectedItem as DataRowView;
            string ma = row["MaNGK"].ToString();
            string ten = row["TenNGK"].ToString();
            decimal gia = Convert.ToDecimal(row["DonGiaBan"]);
            int slMua = (int)nudSLMua.Value;

            // Kiểm tra mặt hàng đã có trong giỏ chưa
            var existing = _gioHang.Find(x => x.MaNGK == ma);
            if (existing != null)
            {
                existing.SoLuongMua += slMua;
            }
            else
            {
                _gioHang.Add(new ChiTietBanDto
                {
                    MaNGK = ma,
                    TenNGK = ten,
                    SoLuongMua = slMua,
                    DonGia = gia,
                    SoLuongGiaoNgay = slMua,
                    SoLuongHenGiao = 0
                });
            }

            CapNhatBangGioHang();
        }

        private void CapNhatBangGioHang()
        {
            dgvGioHang.Rows.Clear();
            decimal tongTien = 0;

            foreach (var item in _gioHang)
            {
                int ton;
                _ngkService.KiemTraTonKho(item.MaNGK, item.SoLuongMua, out ton);

                decimal tt = item.SoLuongMua * item.DonGia;
                tongTien += tt;

                string tinhTrang = ton >= item.SoLuongMua ? "ĐỦ HÀNG" : "THIẾU HÀNG (Tồn: " + ton + ")";
                dgvGioHang.Rows.Add(item.MaNGK, item.TenNGK, item.SoLuongMua, ton, item.DonGia.ToString("N0"), tt.ToString("N0"), tinhTrang);
            }

            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            nudSoTienNo.Value = tongTien;
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            _gioHang.Clear();
            CapNhatBangGioHang();
            lblKetQuaKT.Text = "Giỏ hàng trống.";
            lblKetQuaKT.ForeColor = Color.Black;
            pnlPhieuHen.Visible = false;
        }

        // Kiểm tra tồn kho và đánh giá nghiệp vụ theo đề bài
        private void btnKiemTraKho_Click(object sender, EventArgs e)
        {
            if (_gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn nước giải khát.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowKH = cboKhachHang.SelectedItem as DataRowView;
            string loaiKH = rowKH != null ? rowKH["LoaiKH"].ToString() : "KhachVangLai";

            bool coThieuHang = false;
            string chiTietThieu = "";

            foreach (var item in _gioHang)
            {
                int ton;
                if (!_ngkService.KiemTraTonKho(item.MaNGK, item.SoLuongMua, out ton))
                {
                    coThieuHang = true;
                    int thieu = item.SoLuongMua - ton;
                    chiTietThieu += "- " + item.TenNGK + ": Đặt " + item.SoLuongMua + ", Kho chỉ còn " + ton + " (Thiếu " + thieu + ")\n";

                    item.SoLuongGiaoNgay = ton > 0 ? ton : 0;
                    item.SoLuongHenGiao = thieu;
                }
                else
                {
                    item.SoLuongGiaoNgay = item.SoLuongMua;
                    item.SoLuongHenGiao = 0;
                }
            }

            if (!coThieuHang)
            {
                lblKetQuaKT.Text = "KHO ĐỦ HÀNG! Sẵn sàng xuất giao ngay cùng hóa đơn tính tiền.";
                lblKetQuaKT.ForeColor = Color.DarkGreen;
                pnlPhieuHen.Visible = false;
                btnXuatHoaDon.Enabled = true;
            }
            else
            {
                if (loaiKH == "KhachVangLai")
                {
                    // Ràng buộc nghiệp vụ đối với khách vãng lai
                    lblKetQuaKT.Text = "CẢNH BÁO (Test Case 02): Kho không đủ hàng! Khách vãng lai KHÔNG ĐƯỢC HẸN ĐỢT GIAO.";
                    lblKetQuaKT.ForeColor = Color.Red;
                    pnlPhieuHen.Visible = false;
                    btnXuatHoaDon.Enabled = false;

                    MessageBox.Show("RÀNG BUỘC NGHIỆP VỤ BỊ TỪ CHỐI (Test Case 02):\n" + chiTietThieu + "\nĐối với khách vãng lai, hệ thống chỉ cho phép thanh toán và giao hàng ngay tại quầy khi có đủ hàng. Cửa hàng không áp dụng hẹn đợt giao hoặc ghi nợ cho khách vãng lai! Vui lòng giảm số lượng đặt hoặc chọn loại NGK khác.", "Thiếu hàng - Khách vãng lai", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    // Khách quen: Cho phép hẹn giao hàng nhiều đợt bằng các phiếu hẹn
                    lblKetQuaKT.Text = "THIẾU HÀNG - KHÁCH QUEN (Test Case 03): Cho phép lập Hóa đơn và tạo Phiếu hẹn giao nhiều đợt!";
                    lblKetQuaKT.ForeColor = Color.Blue;
                    pnlPhieuHen.Visible = true;
                    btnXuatHoaDon.Enabled = true;

                    txtHenDot1.Text = "Đợt 1 (Giao ngay): " + _gioHang[0].SoLuongGiaoNgay + " đơn vị";
                    txtHenDot2.Text = "Đợt 2 (Hẹn giao): " + _gioHang[0].SoLuongHenGiao + " đơn vị vào ngày " + dtpHenGiao.Value.ToString("dd/MM/yyyy");

                    MessageBox.Show("CHÍNH SÁCH KHÁCH QUEN (Test Case 03):\n" + chiTietThieu + "\nVì đây là Khách quen, hệ thống kích hoạt chức năng LẬP PHIẾU HẸN GIAO HÀNG NHIỀU ĐỢT theo hóa đơn!", "Hẹn đợt giao hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void chkGhiNo_CheckedChanged(object sender, EventArgs e)
        {
            pnlGhiNo.Visible = chkGhiNo.Checked;
        }

        // Lập hóa đơn và xử lý lưu DB
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (_gioHang.Count == 0) return;

            string soHD = txtSoHD.Text.Trim();
            if (string.IsNullOrEmpty(soHD))
            {
                MessageBox.Show("Vui lòng nhập Số hóa đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = cboKhachHang.SelectedValue.ToString();
            string maNV = cboNhanVien.SelectedValue.ToString();
            DataRowView rowKH = cboKhachHang.SelectedItem as DataRowView;
            string loaiKH = rowKH != null ? rowKH["LoaiKH"].ToString() : "KhachVangLai";

            decimal tongTien = 0;
            foreach (var item in _gioHang) tongTien += (item.SoLuongMua * item.DonGia);

            bool daThanhToan = !chkGhiNo.Checked;
            string hinhThucTT = chkGhiNo.Checked ? "Ghi nợ" : "Tiền mặt";

            // Danh sách phiếu hẹn nếu khách quen thiếu hàng
            List<PhieuHenDto> phieuHens = null;
            if (pnlPhieuHen.Visible && loaiKH == "KhachQuen")
            {
                phieuHens = new List<PhieuHenDto>();
                int dotIdx = 1;
                foreach (var item in _gioHang)
                {
                    if (item.SoLuongHenGiao > 0)
                    {
                        phieuHens.Add(new PhieuHenDto
                        {
                            SoPH = "PH_" + DateTime.Now.ToString("MMdd_HHmmss") + "_" + dotIdx,
                            NgayHenGiao = dtpHenGiao.Value,
                            DotGiaoHen = dotIdx,
                            SoLuongHen = item.SoLuongHenGiao,
                            MaNGK = item.MaNGK
                        });
                        dotIdx++;
                    }
                }
            }

            // Phiếu ghi nợ nếu khách quen trả chậm
            PhieuGhiNoDto pgn = null;
            if (chkGhiNo.Checked && loaiKH == "KhachQuen")
            {
                pgn = new PhieuGhiNoDto
                {
                    SoPGN = "PGN_" + DateTime.Now.ToString("MMdd_HHmmss"),
                    SoTienNo = nudSoTienNo.Value,
                    NgayDuKienTra = dtpHanTra.Value,
                    LyDoNo = txtLyDoNo.Text.Trim()
                };
            }

            try
            {
                _hdService.LapHoaDon(soHD, maKH, maNV, hinhThucTT, daThanhToan, tongTien, _gioHang, phieuHens, pgn);

                string thongBao = "LẬP HÓA ĐƠN THÀNH CÔNG!\n- Số HĐ: " + soHD + "\n- Tổng tiền: " + tongTien.ToString("N0") + " VNĐ\n- Hình thức: " + hinhThucTT;
                if (phieuHens != null && phieuHens.Count > 0)
                {
                    thongBao += "\n- Đã phát sinh " + phieuHens.Count + " Phiếu hẹn giao theo đợt cho Khách quen.";
                }
                if (pgn != null)
                {
                    thongBao += "\n- Đã lập Phiếu ghi nợ " + pgn.SoTienNo.ToString("N0") + " VNĐ cho Khách quen (Cộng vào tổng nợ).";
                }

                MessageBox.Show(thongBao, "Giao dịch hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Dọn giỏ hàng & tải lại
                _gioHang.Clear();
                CapNhatBangGioHang();
                pnlPhieuHen.Visible = false;
                pnlGhiNo.Visible = false;
                chkGhiNo.Checked = false;
                txtSoHD.Text = "HD_" + DateTime.Now.ToString("MMdd_HHmmss");

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xử lý hóa đơn: " + ex.Message, "Lỗi nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string soHD = dgvHoaDon.Rows[e.RowIndex].Cells["SoHD"].Value.ToString();
                dgvCTHD.DataSource = _hdService.GetChiTietHoaDon(soHD);
            }
        }
    }
}
