using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmBangLuongHDV : Form
    {
        private LuongKhaoSatService service = new LuongKhaoSatService();
        private DieuHanhHDVService hdvService = new DieuHanhHDVService();

        public FrmBangLuongHDV()
        {
            InitializeComponent();
        }

        private void FrmBangLuongHDV_Load(object sender, EventArgs e)
        {
            cboThangNam.Items.Clear();
            cboThangNam.Items.AddRange(new object[] { "10/2026", "11/2026", "12/2026" });
            cboThangNam.SelectedIndex = 0;

            cboHDV.DataSource = hdvService.GetAllHDV();
            cboHDV.DisplayMember = "HoTen";
            cboHDV.ValueMember = "MaNV";

            LoadData();
        }

        private void cboThangNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string thangNam = cboThangNam.Text.Trim();
            dgvLuong.DataSource = service.GetBangLuongByThang(thangNam);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaBangLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã Bảng Lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maBL = txtMaBangLuong.Text.Trim();
                string maNV = cboHDV.SelectedValue.ToString();
                string thangNam = cboThangNam.Text.Trim();
                decimal phuCap = decimal.Parse(txtPhuCap.Text.Replace(",", "").Replace(".", ""));

                if (service.TinhLuongHDV(maBL, maNV, thangNam, phuCap))
                {
                    MessageBox.Show("Tính bảng lương Hướng dẫn viên thành công (Lương CB + Lương các tour trong tháng)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính lương: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiLuong_Click(object sender, EventArgs e)
        {
            if (dgvLuong.CurrentRow != null && dgvLuong.CurrentRow.Cells["MaBangLuong"].Value != null)
            {
                string maBL = dgvLuong.CurrentRow.Cells["MaBangLuong"].Value.ToString();
                if (service.XacNhanChiLuong(maBL))
                {
                    MessageBox.Show($"Xác nhận đã thanh toán lương cho bảng lương {maBL}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
