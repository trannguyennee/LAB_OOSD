using System;
using System.Data;
using System.Windows.Forms;
using QuanLyDuLich.Services;

namespace QuanLyDuLich.Forms
{
    public partial class FrmTourLichTrinh : Form
    {
        private TourLichTrinhService service = new TourLichTrinhService();

        public FrmTourLichTrinh()
        {
            InitializeComponent();
        }

        private void FrmTourLichTrinh_Load(object sender, EventArgs e)
        {
            LoadTourList();
        }

        private void LoadTourList()
        {
            dgvTour.DataSource = service.GetAllTour();
            if (dgvTour.Rows.Count > 0)
            {
                dgvTour.Rows[0].Selected = true;
                LoadDetails(dgvTour.Rows[0].Cells["MaTour"].Value.ToString());
            }
        }

        private void dgvTour_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTour.CurrentRow != null && dgvTour.CurrentRow.Cells["MaTour"].Value != null)
            {
                string maTour = dgvTour.CurrentRow.Cells["MaTour"].Value.ToString();
                txtMaTour.Text = maTour;
                txtTenTour.Text = dgvTour.CurrentRow.Cells["TenTour"].Value.ToString();
                nudSoNgay.Value = Convert.ToDecimal(dgvTour.CurrentRow.Cells["SoNgay"].Value);
                nudSoDem.Value = Convert.ToDecimal(dgvTour.CurrentRow.Cells["SoDem"].Value);
                txtDonGia.Text = Convert.ToDecimal(dgvTour.CurrentRow.Cells["DonGiaKhach"].Value).ToString("N0");
                LoadDetails(maTour);
            }
        }

        private void LoadDetails(string maTour)
        {
            dgvNoiDungChan.DataSource = service.GetNoiDungChan(maTour);
            dgvDiemThamQuan.DataSource = service.GetDiemThamQuan(maTour);
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaTour.Text) || string.IsNullOrWhiteSpace(txtTenTour.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã Tour và Tên Tour!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal donGia = decimal.Parse(txtDonGia.Text.Replace(",", "").Replace(".", ""));
                if (service.InsertTour(txtMaTour.Text.Trim(), txtTenTour.Text.Trim(), (int)nudSoNgay.Value, (int)nudSoDem.Value, donGia, "Chương trình tour du lịch chất lượng cao"))
                {
                    MessageBox.Show("Thêm Tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTourList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
