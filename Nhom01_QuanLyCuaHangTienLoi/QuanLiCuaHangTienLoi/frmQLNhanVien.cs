using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCuaHangTienLoi_BLL;
using QuanLiCuaHangTienLoi_DTO;

namespace QuanLiCuaHangTienLoi
{
    public partial class frmQLNhanVien : Form
    {
        NhanVienBLL nv = new NhanVienBLL();
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void LoadNV()
        {
            List<NhanVienDTO> ds = new List<NhanVienDTO>();
            ds = nv.NhanVien();
            dgvNhanVien.DataSource = ds;
            // Đổi tên các cột theo ý muốn sau khi đã gán dữ liệu
            dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            cboQuyen.Items.Add("NhanVien");
            cboQuyen.Items.Add("QuanLy");
            cboQuyen.SelectedIndex = 0;
            LoadNV();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            string gt;
            if (rdoNam.Checked)
                gt = "Nam";
            else
                gt = "Nu";
            NhanVienDTO n = new NhanVienDTO(txtMa.Text, txtTen.Text, gt, dateNS.Value,txtSDT.Text,txtDiaChi.Text,txtMK.Text,cboQuyen.Text);
            if (nv.ThemNhanVien(n))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            LoadNV();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            txtTen.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.SelectedRows[0].Cells[3].Value.ToString();

            if (dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString() == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;
            txtSDT.Text = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            txtMK.Text = dgvNhanVien.SelectedRows[0].Cells[6].Value.ToString();
            dateNS.Value = Convert.ToDateTime(dgvNhanVien.SelectedRows[0].Cells[5].Value);
            cboQuyen.SelectedItem = dgvNhanVien.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMa.Text = nv.MaNV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gt;
            if (rdoNam.Checked)
                gt = "Nam";
            else
                gt = "Nu";
            NhanVienDTO n = new NhanVienDTO(txtMa.Text, txtTen.Text, gt, dateNS.Value, txtSDT.Text, txtDiaChi.Text, txtMK.Text, cboQuyen.Text);
            if (nv.CapNhatNhanVien(n))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            LoadNV();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string gt;
            if (rdoNam.Checked)
                gt = "Nam";
            else
                gt = "Nu";
            NhanVienDTO n = new NhanVienDTO(txtMa.Text, txtTen.Text, gt, dateNS.Value, txtSDT.Text, txtDiaChi.Text, txtMK.Text, cboQuyen.Text);
            if (nv.XoaNhanVien(n.MaNhanVien))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            LoadNV();
        }
    }
}
