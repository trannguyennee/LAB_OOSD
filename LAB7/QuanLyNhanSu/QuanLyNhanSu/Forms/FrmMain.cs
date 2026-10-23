using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class FrmMain : Form
    {
        private Form activeForm = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhanVien());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text.ToUpper();
        }

        private void btnNhanVien_Click(object sender, EventArgs e) => OpenChildForm(new FrmNhanVien());
        private void btnHopDong_Click(object sender, EventArgs e) => OpenChildForm(new FrmHopDongBaoHiem());
        private void btnPhanCa_Click(object sender, EventArgs e) => OpenChildForm(new FrmPhanCaPhuTroi());
        private void btnChamCong_Click(object sender, EventArgs e) => OpenChildForm(new FrmChamCong());
        private void btnKhenThuong_Click(object sender, EventArgs e) => OpenChildForm(new FrmKhenThuongKyLuat());
        private void btnBangLuong_Click(object sender, EventArgs e) => OpenChildForm(new FrmBangLuong());

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi Hệ thống Quản lý Nhân sự & Tiền lương Sơn Đông Á?", 
                "Xác nhận thoát chương trình", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
