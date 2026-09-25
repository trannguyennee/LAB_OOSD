using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDatPhong : Form
    {
        readonly DatPhongService s = new DatPhongService();
        readonly DanhMucService dm = new DanhMucService();
        readonly BindingList<PhongDatItem> chon = new BindingList<PhongDatItem>();

        public FrmDatPhong()
        {
            InitializeComponent();
        }

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            DinhDangLuoi(dgvKhach);
            DinhDangLuoi(dgvPhong);
            DinhDangLuoi(dgvChon);
            DinhDangLuoi(dgvPhieu);
            DinhDangLuoi(dgvCT);
            DinhDangLuoi(dgvNguoi);

            NapDuLieuCombobox();

            cboKenh.Items.Clear();
            cboKenh.Items.AddRange(new object[] { "Website", "Điện thoại", "Trực tiếp" });
            cboKenh.SelectedIndex = 0; // Mặc định Website giống ảnh thầy

            txtSoPhieu.Text = "DP001";
            numCoc.Value = 500000;

            dtLap.Value = DateTime.Now;
            dtNhan.Value = DateTime.Now;
            dtTra.Value = DateTime.Now.AddDays(1);

            dgvChon.DataSource = chon;
            DinhDangCotChon();

            dgvPhong.CellDoubleClick += (s1, e1) => btnThemPhong_Click(s1, e1);
            dgvChon.CellDoubleClick += (s1, e1) => btnBoPhong_Click(s1, e1);

            Tai();
        }

        private void NapDuLieuCombobox()
        {
            cboKhach.DisplayMember = "HoTen";
            cboKhach.ValueMember = "MaKhach";
            cboKhach.DataSource = s.LayKhach();

            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";
            cboNV.DataSource = dm.LayNhanVien();
        }

        private void DinhDangLuoi(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(215, 235, 255);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgv.ColumnHeadersHeight = 30;
            dgv.RowTemplate.Height = 26;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.GridColor = Color.FromArgb(220, 220, 220);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void DinhDangCotChon()
        {
            if (dgvChon.Columns["SoPhong"] != null)
                dgvChon.Columns["SoPhong"].HeaderText = "Phòng chọn";
            if (dgvChon.Columns["SoNguoi"] != null)
                dgvChon.Columns["SoNguoi"].HeaderText = "Số người";
            if (dgvChon.Columns["DonGiaNgay"] != null)
            {
                dgvChon.Columns["DonGiaNgay"].HeaderText = "Đơn giá/ngày";
                dgvChon.Columns["DonGiaNgay"].DefaultCellStyle.Format = "N0";
            }
        }

        void Tai()
        {
            dgvKhach.DataSource = s.LayKhach();
            DinhDangCotKhach();

            dgvPhong.DataSource = s.LayPhong();
            DinhDangCotPhong();

            dgvPhieu.DataSource = s.LayPhieuDat();
            DinhDangCotPhieu();
        }

        private void DinhDangCotKhach()
        {
            if (dgvKhach.Columns["MaKhach"] != null) dgvKhach.Columns["MaKhach"].HeaderText = "Mã khách";
            if (dgvKhach.Columns["HoTen"] != null) dgvKhach.Columns["HoTen"].HeaderText = "Họ tên";
            if (dgvKhach.Columns["SoCMND"] != null) dgvKhach.Columns["SoCMND"].HeaderText = "CMND/CCCD";
            if (dgvKhach.Columns["QuocTich"] != null) dgvKhach.Columns["QuocTich"].HeaderText = "Quốc tịch";
            if (dgvKhach.Columns["SoDienThoai"] != null) dgvKhach.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
        }

        private void DinhDangCotPhong()
        {
            // Cột giống ảnh thầy: Phòng | Khu | Sức chứa | Đơn giá
            if (dgvPhong.Columns["SoPhong"] != null) dgvPhong.Columns["SoPhong"].HeaderText = "Phòng";
            if (dgvPhong.Columns["TenKhuVuc"] != null) dgvPhong.Columns["TenKhuVuc"].HeaderText = "Khu";
            if (dgvPhong.Columns["SoNguoiToiDa"] != null) dgvPhong.Columns["SoNguoiToiDa"].HeaderText = "Sức chứa";
            if (dgvPhong.Columns["DonGiaNgay"] != null)
            {
                dgvPhong.Columns["DonGiaNgay"].HeaderText = "Đơn giá";
                dgvPhong.Columns["DonGiaNgay"].DefaultCellStyle.Format = "N0";
            }
            if (dgvPhong.Columns["TrangThai"] != null) dgvPhong.Columns["TrangThai"].Visible = false;
            if (dgvPhong.Columns["MaKhuVuc"] != null) dgvPhong.Columns["MaKhuVuc"].Visible = false;
        }

        private void DinhDangCotPhieu()
        {
            // Cột giống ảnh thầy: Số phiếu | Khách | Ngày nhận | Ngày trả dự kiến | Cọc | Kênh | Trạng thái
            if (dgvPhieu.Columns["SoPhieuDat"] != null) dgvPhieu.Columns["SoPhieuDat"].HeaderText = "Số phiếu";
            if (dgvPhieu.Columns["TenKhach"] != null) dgvPhieu.Columns["TenKhach"].HeaderText = "Khách";
            if (dgvPhieu.Columns["NgayNhan"] != null)
            {
                dgvPhieu.Columns["NgayNhan"].HeaderText = "Ngày nhận";
                dgvPhieu.Columns["NgayNhan"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvPhieu.Columns["NgayTraDuKien"] != null)
            {
                dgvPhieu.Columns["NgayTraDuKien"].HeaderText = "Ngày trả dự kiến";
                dgvPhieu.Columns["NgayTraDuKien"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvPhieu.Columns["TienCoc"] != null)
            {
                dgvPhieu.Columns["TienCoc"].HeaderText = "Cọc";
                dgvPhieu.Columns["TienCoc"].DefaultCellStyle.Format = "N0";
            }
            if (dgvPhieu.Columns["KenhDat"] != null) dgvPhieu.Columns["KenhDat"].HeaderText = "Kênh";
            if (dgvPhieu.Columns["TrangThai"] != null) dgvPhieu.Columns["TrangThai"].HeaderText = "Trạng thái";

            if (dgvPhieu.Columns["MaNVLeTan"] != null) dgvPhieu.Columns["MaNVLeTan"].Visible = false;
            if (dgvPhieu.Columns["MaKhach"] != null) dgvPhieu.Columns["MaKhach"].Visible = false;
            if (dgvPhieu.Columns["NgayLap"] != null) dgvPhieu.Columns["NgayLap"].Visible = false;
        }

        private void DinhDangCotChiTiet()
        {
            if (dgvCT.Columns["SoPhieuDat"] != null) dgvCT.Columns["SoPhieuDat"].HeaderText = "Số phiếu";
            if (dgvCT.Columns["SoPhong"] != null) dgvCT.Columns["SoPhong"].HeaderText = "Số phòng";
            if (dgvCT.Columns["SoNguoi"] != null) dgvCT.Columns["SoNguoi"].HeaderText = "Số người";
            if (dgvCT.Columns["SoNguoiToiDa"] != null) dgvCT.Columns["SoNguoiToiDa"].HeaderText = "Sức chứa";
            if (dgvCT.Columns["DonGiaNgay"] != null)
            {
                dgvCT.Columns["DonGiaNgay"].HeaderText = "Đơn giá";
                dgvCT.Columns["DonGiaNgay"].DefaultCellStyle.Format = "N0";
            }
        }

        private void DinhDangCotNguoi()
        {
            if (dgvNguoi.Columns["MaNguoiLT"] != null) dgvNguoi.Columns["MaNguoiLT"].HeaderText = "Mã người";
            if (dgvNguoi.Columns["SoPhong"] != null) dgvNguoi.Columns["SoPhong"].HeaderText = "Phòng";
            if (dgvNguoi.Columns["HoTen"] != null) dgvNguoi.Columns["HoTen"].HeaderText = "Họ tên";
            if (dgvNguoi.Columns["SoCMND"] != null) dgvNguoi.Columns["SoCMND"].HeaderText = "CMND/CCCD";
            if (dgvNguoi.Columns["QuocTich"] != null) dgvNguoi.Columns["QuocTich"].HeaderText = "Quốc tịch";
            if (dgvNguoi.Columns["SoPhieuDat"] != null) dgvNguoi.Columns["SoPhieuDat"].Visible = false;
        }

        string V(ComboBox c)
        {
            return c.SelectedValue == null ? "" : c.SelectedValue.ToString();
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, 
                k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong)
            {
                Tai();
                NapDuLieuCombobox();
            }
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            H(s.ThemKhach(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtCMND.Text.Trim(), txtQT.Text.Trim(), txtSDT.Text.Trim()));
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;
            string p = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);
            foreach (var x in chon)
            {
                if (x.SoPhong == p)
                {
                    MessageBox.Show("Phòng đã có trong phiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            int n = 2;
            if (dgvPhong.CurrentRow.Cells["SoNguoiToiDa"] != null && dgvPhong.CurrentRow.Cells["SoNguoiToiDa"].Value != DBNull.Value)
            {
                n = Convert.ToInt32(dgvPhong.CurrentRow.Cells["SoNguoiToiDa"].Value);
            }
            decimal g = Convert.ToDecimal(dgvPhong.CurrentRow.Cells["DonGiaNgay"].Value);
            chon.Add(new PhongDatItem { SoPhong = p, SoNguoi = n, DonGiaNgay = g });
        }

        private void btnBoPhong_Click(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow != null && dgvChon.CurrentRow.Index >= 0 && dgvChon.CurrentRow.Index < chon.Count)
            {
                chon.RemoveAt(dgvChon.CurrentRow.Index);
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            string maNV = V(cboNV);
            if (string.IsNullOrEmpty(maNV)) maNV = "NV01";
            DateTime lap = dtLap.Value;
            DateTime nhan = dtNhan.Value;
            DateTime tra = dtTra.Value;
            H(s.TaoDatPhong(txtSoPhieu.Text.Trim(), V(cboKhach), maNV, lap, nhan, tra, numCoc.Value, cboKenh.Text, new List<PhongDatItem>(chon)));
            if (chon.Count > 0) chon.Clear();
        }

        private void dgvPhieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow == null) return;
            string so = Convert.ToString(dgvPhieu.CurrentRow.Cells["SoPhieuDat"].Value);
            txtPhieuChon.Text = so;
            dgvCT.DataSource = s.LayChiTiet(so);
            DinhDangCotChiTiet();
            dgvNguoi.DataSource = s.LayNguoiLuuTru(so);
            DinhDangCotNguoi();
        }

        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            H(s.ThemNguoiLuuTru(txtPhieuChon.Text.Trim(), txtNguoiPhong.Text.Trim(), txtNguoiTen.Text.Trim(), txtNguoiCMND.Text.Trim(), txtNguoiQT.Text.Trim()));
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            H(s.NhanPhong(txtPhieuChon.Text.Trim(), DateTime.Now));
        }

        private void btnNoShow_Click(object sender, EventArgs e)
        {
            H(s.DanhDauNoShow(txtPhieuChon.Text.Trim()));
        }
    }
}
