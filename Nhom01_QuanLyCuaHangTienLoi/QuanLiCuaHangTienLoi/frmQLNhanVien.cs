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
            LoadNV();
        }
    }
}
