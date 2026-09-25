using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDichVu : Form
    {
        readonly DichVuService s = new DichVuService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            DinhDangLuoi();

            cboLuot.DisplayMember = "SoPhieuDat";
            cboLuot.ValueMember = "SoPhieuDat";
            DataTable dtDangO = s.LayPhieuDangO();
            cboLuot.DataSource = dtDangO;

            cboDV.DisplayMember = "TenDV";
            cboDV.ValueMember = "MaDV";
            cboDV.DataSource = s.LayDichVu();

            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";
            cboNV.DataSource = dm.LayNhanVien();

            dtNgay.Value = DateTime.Now;
            numSL.Value = 2;

            if (dtDangO != null && dtDangO.Rows.Count > 0)
            {
                cboLuot.SelectedIndex = 0;
                txtPhong.Text = Convert.ToString(dtDangO.Rows[0]["SoPhong"]);
            }
            else
            {
                txtPhong.Text = "";
            }

            Tai();
        }

        private void DinhDangLuoi()
        {
            dgvLichSu.EnableHeadersVisualStyles = false;
            dgvLichSu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(215, 235, 255);
            dgvLichSu.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvLichSu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgvLichSu.ColumnHeadersHeight = 32;
            dgvLichSu.RowTemplate.Height = 28;
            dgvLichSu.BackgroundColor = Color.White;
            dgvLichSu.BorderStyle = BorderStyle.Fixed3D;
            dgvLichSu.GridColor = Color.FromArgb(220, 220, 220);
            dgvLichSu.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgvLichSu.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        void Tai()
        {
            if (cboLuot.SelectedValue != null)
            {
                dgvLichSu.DataSource = s.LayLichSu(cboLuot.SelectedValue.ToString());
                DinhDangCotLichSu();
            }
            else
            {
                dgvLichSu.DataSource = null;
            }
        }

        private void DinhDangCotLichSu()
        {
            // 7 cột đúng chuẩn ảnh Thầy: Số phiếu | Phòng | Ngày | Dịch vụ | Số lượng | Đơn giá | Thành tiền
            if (dgvLichSu.Columns["SoPhieuSDDV"] != null)
                dgvLichSu.Columns["SoPhieuSDDV"].HeaderText = "Số phiếu";
            if (dgvLichSu.Columns["SoPhong"] != null)
                dgvLichSu.Columns["SoPhong"].HeaderText = "Phòng";
            if (dgvLichSu.Columns["NgaySuDung"] != null)
            {
                dgvLichSu.Columns["NgaySuDung"].HeaderText = "Ngày";
                dgvLichSu.Columns["NgaySuDung"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvLichSu.Columns["TenDV"] != null)
                dgvLichSu.Columns["TenDV"].HeaderText = "Dịch vụ";
            if (dgvLichSu.Columns["SoLuong"] != null)
                dgvLichSu.Columns["SoLuong"].HeaderText = "Số lượng";
            if (dgvLichSu.Columns["DonGia"] != null)
            {
                dgvLichSu.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvLichSu.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            }
            if (dgvLichSu.Columns["ThanhTien"] != null)
            {
                dgvLichSu.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvLichSu.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            }
        }

        string V(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        private void cboLuot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuot.SelectedItem is DataRowView r)
            {
                txtPhong.Text = Convert.ToString(r["SoPhong"]);
            }
            Tai();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string maNV = V(cboNV);
            if (string.IsNullOrEmpty(maNV)) maNV = "NV01";

            var k = s.GhiNhan(V(cboLuot), txtPhong.Text.Trim(), dtNgay.Value, maNV, V(cboDV), (int)numSL.Value);
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, 
                k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong)
            {
                Tai();
            }
        }
    }
}
