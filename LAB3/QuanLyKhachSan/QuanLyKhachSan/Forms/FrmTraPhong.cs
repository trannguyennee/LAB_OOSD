using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmTraPhong : Form
    {
        readonly TraPhongService s = new TraPhongService();
        readonly DanhMucService dm = new DanhMucService();
        readonly BindingList<DenBuItem> db = new BindingList<DenBuItem>();

        public FrmTraPhong()
        {
            InitializeComponent();
        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            DinhDangLuoi(dgvPhong);
            DinhDangLuoi(dgvTN);
            DinhDangLuoi(dgvDBChon);
            DinhDangLuoi(dgvHD);

            cboDat.DisplayMember = "SoPhieuDat";
            cboDat.ValueMember = "SoPhieuDat";
            cboDat.DataSource = s.LayPhieuDangO();

            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";
            cboNV.DataSource = dm.LayNhanVien();

            cboNV2.DisplayMember = "HoTen";
            cboNV2.ValueMember = "MaNV";
            cboNV2.DataSource = dm.LayNhanVien();

            cboHT.Items.Clear();
            cboHT.Items.AddRange(new object[] { "Thẻ", "Tiền mặt", "Chuyển khoản", "Ví điện tử" });
            cboHT.SelectedIndex = 0; // Mặc định Thẻ giống ảnh Thầy

            dgvDBChon.DataSource = db;
            DinhDangCotDBChon();

            txtSoDB.Text = "DB001";
            cboMucDo.Text = "Hư hỏng nhẹ";
            numDenBu.Value = 500000;

            txtSoHD.Text = "HD001";
            numSoNgay.Value = 2;
            numTienTT.Value = 1200000;

            // Nhấp đúp vào tiện nghi để thêm vào đền bù
            dgvTN.CellDoubleClick += (s1, e1) => ThemDenBu();
            // Nhấp đúp vào danh sách đền bù để xóa
            dgvDBChon.CellDoubleClick += (s1, e1) => XoaDenBu();

            Tai();
        }

        private void DinhDangLuoi(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(215, 235, 255);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgv.ColumnHeadersHeight = 28;
            dgv.RowTemplate.Height = 24;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.GridColor = Color.FromArgb(220, 220, 220);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void DinhDangCotPhong()
        {
            if (dgvPhong.Columns["SoPhong"] != null)
                dgvPhong.Columns["SoPhong"].HeaderText = "Phòng";
            if (dgvPhong.Columns["DonGiaNgay"] != null)
            {
                dgvPhong.Columns["DonGiaNgay"].HeaderText = "Đơn giá/ngày";
                dgvPhong.Columns["DonGiaNgay"].DefaultCellStyle.Format = "N0";
            }
        }

        private void DinhDangCotTN()
        {
            if (dgvTN.Columns["MaTienNghi"] != null)
                dgvTN.Columns["MaTienNghi"].HeaderText = "Tiện nghi";
            if (dgvTN.Columns["TenLoaiTN"] != null)
                dgvTN.Columns["TenLoaiTN"].HeaderText = "Loại";
            if (dgvTN.Columns["TinhTrangHienTai"] != null)
                dgvTN.Columns["TinhTrangHienTai"].HeaderText = "Tình trạng";
        }

        private void DinhDangCotDBChon()
        {
            if (dgvDBChon.Columns["MaTienNghi"] != null)
                dgvDBChon.Columns["MaTienNghi"].HeaderText = "Tiện nghi đền bù";
            if (dgvDBChon.Columns["MucDoThietHai"] != null)
                dgvDBChon.Columns["MucDoThietHai"].HeaderText = "Mức độ";
            if (dgvDBChon.Columns["SoTien"] != null)
            {
                dgvDBChon.Columns["SoTien"].HeaderText = "Số tiền";
                dgvDBChon.Columns["SoTien"].DefaultCellStyle.Format = "N0";
            }
            if (dgvDBChon.Columns["TenLoaiTN"] != null)
                dgvDBChon.Columns["TenLoaiTN"].Visible = false;
        }

        private void DinhDangCotHD()
        {
            // 6 cột chuẩn ảnh Thầy: Hóa đơn | Phiếu đặt | Tiền phòng | Tiền dịch vụ | Tổng tiền | Trạng thái
            if (dgvHD.Columns["SoHoaDon"] != null)
                dgvHD.Columns["SoHoaDon"].HeaderText = "Hóa đơn";
            if (dgvHD.Columns["SoPhieuDat"] != null)
                dgvHD.Columns["SoPhieuDat"].HeaderText = "Phiếu đặt";
            if (dgvHD.Columns["TienPhong"] != null)
            {
                dgvHD.Columns["TienPhong"].HeaderText = "Tiền phòng";
                dgvHD.Columns["TienPhong"].DefaultCellStyle.Format = "N0";
            }
            if (dgvHD.Columns["TienDichVu"] != null)
            {
                dgvHD.Columns["TienDichVu"].HeaderText = "Tiền dịch vụ";
                dgvHD.Columns["TienDichVu"].DefaultCellStyle.Format = "N0";
            }
            if (dgvHD.Columns["TongTien"] != null)
            {
                dgvHD.Columns["TongTien"].HeaderText = "Tổng tiền";
                dgvHD.Columns["TongTien"].DefaultCellStyle.Format = "N0";
            }
            if (dgvHD.Columns["TrangThai"] != null)
                dgvHD.Columns["TrangThai"].HeaderText = "Trạng thái";

            if (dgvHD.Columns["NgayLap"] != null)
                dgvHD.Columns["NgayLap"].Visible = false;
            if (dgvHD.Columns["HoTen"] != null)
                dgvHD.Columns["HoTen"].Visible = false;
        }

        string V(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        void Tai()
        {
            if (cboDat.SelectedValue != null)
            {
                string so = V(cboDat);
                dgvPhong.DataSource = s.LayPhongTheoPhieu(so);
                DinhDangCotPhong();
            }
            else
            {
                dgvPhong.DataSource = null;
                dgvTN.DataSource = null;
            }

            dgvHD.DataSource = s.LayHoaDon();
            DinhDangCotHD();
        }

        private void cboDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tai();
        }

        private void dgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;
            txtPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);
            dgvTN.DataSource = s.LayTienNghiPhong(txtPhong.Text);
            DinhDangCotTN();
        }

        private void ThemDenBu()
        {
            if (dgvTN.CurrentRow == null) return;
            string ma = Convert.ToString(dgvTN.CurrentRow.Cells["MaTienNghi"].Value);
            string ten = Convert.ToString(dgvTN.CurrentRow.Cells["TenLoaiTN"].Value);
            foreach (var x in db)
            {
                if (x.MaTienNghi == ma)
                {
                    MessageBox.Show("Tiện nghi này đã có trong danh sách đền bù.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            db.Add(new DenBuItem
            {
                MaTienNghi = ma,
                TenLoaiTN = ten,
                MucDoThietHai = cboMucDo.Text.Trim(),
                SoTien = numDenBu.Value
            });
        }

        private void XoaDenBu()
        {
            if (dgvDBChon.CurrentRow != null && dgvDBChon.CurrentRow.Index >= 0 && dgvDBChon.CurrentRow.Index < db.Count)
            {
                db.RemoveAt(dgvDBChon.CurrentRow.Index);
            }
        }

        private void btnLapDB_Click(object sender, EventArgs e)
        {
            if (db.Count == 0)
            {
                ThemDenBu();
            }

            string maNV = V(cboNV);
            if (string.IsNullOrEmpty(maNV)) maNV = "NV01";

            var k = s.LapPhieuDenBu(txtSoDB.Text.Trim(), V(cboDat), txtPhong.Text.Trim(), DateTime.Now, maNV, new List<DenBuItem>(db));
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, 
                k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong)
            {
                db.Clear();
            }
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            string maNV = V(cboNV2);
            if (string.IsNullOrEmpty(maNV)) maNV = "NV03";

            var k = s.LapHoaDon(txtSoHD.Text.Trim(), V(cboDat), DateTime.Now, maNV, (int)numSoNgay.Value);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, 
                k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            Tai();
        }

        private void dgvHD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHD.CurrentRow == null) return;
            txtHDChon.Text = Convert.ToString(dgvHD.CurrentRow.Cells["SoHoaDon"].Value);
            if (dgvHD.CurrentRow.Cells["TongTien"] != null && dgvHD.CurrentRow.Cells["TongTien"].Value != DBNull.Value)
            {
                numTienTT.Value = Convert.ToDecimal(dgvHD.CurrentRow.Cells["TongTien"].Value);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHDChon.Text))
            {
                if (dgvHD.CurrentRow != null)
                {
                    txtHDChon.Text = Convert.ToString(dgvHD.CurrentRow.Cells["SoHoaDon"].Value);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn từ bảng để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string maTT = txtMaTT.Text.Trim();
            if (string.IsNullOrEmpty(maTT))
            {
                maTT = "TT" + DateTime.Now.ToString("ddHHmmss");
            }

            var k = s.ThanhToan(maTT, txtHDChon.Text.Trim(), DateTime.Now, cboHT.Text, numTienTT.Value);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, 
                k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            Tai();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            var k = s.TraPhong(V(cboDat), DateTime.Now);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, 
                k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong)
            {
                cboDat.DataSource = s.LayPhieuDangO();
                Tai();
            }
        }
    }
}
