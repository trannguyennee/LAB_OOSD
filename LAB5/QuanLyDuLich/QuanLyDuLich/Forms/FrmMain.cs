using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyDuLich.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            new FrmTourLichTrinh().ShowDialog();
        }

        private void btnChuyenDi_Click(object sender, EventArgs e)
        {
            new FrmChuyenDiVeLe().ShowDialog();
        }

        private void btnDoan_Click(object sender, EventArgs e)
        {
            new FrmDangKyDoan().ShowDialog();
        }

        private void btnHDV_Click(object sender, EventArgs e)
        {
            new FrmPhanCongHDV().ShowDialog();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            new FrmBangLuongHDV().ShowDialog();
        }

        private void btnKhaoSat_Click(object sender, EventArgs e)
        {
            new FrmPhieuKhaoSat().ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
