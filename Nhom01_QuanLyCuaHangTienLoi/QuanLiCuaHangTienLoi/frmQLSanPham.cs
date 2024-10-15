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
    public partial class frmQLSanPham : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        public frmQLSanPham()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void LoadSP()
        {
            List<SanPhamDTO> ds = new List<SanPhamDTO>();
            ds = sp.SanPham();
            dgvSanPham.DataSource = ds;
            // Đổi tên các cột theo ý muốn sau khi đã gán dữ liệu
            dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns["SoLuongCon"].HeaderText = "Số lượng còn";
            dgvSanPham.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dgvSanPham.Columns["GiaBan"].HeaderText = "Giá bán";
            dgvSanPham.Columns["HinhAnh"].HeaderText = "Hình ảnh";
            dgvSanPham.Columns["MaLoaiSanPham"].HeaderText = "Loại sản phẩm";
            dgvSanPham.Columns["MaNCC"].HeaderText = "Nhà cung cấp";
            dgvSanPham.Columns["GhiChu"].HeaderText = "Ghi chú";
        }

        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Addnew_Click(object sender, EventArgs e)
        {

        }
    }
}
