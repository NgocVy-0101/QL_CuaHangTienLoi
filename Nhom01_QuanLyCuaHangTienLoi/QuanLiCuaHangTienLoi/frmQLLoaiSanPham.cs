using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCuaHangTienLoi_DTO;
using QuanLiCuaHangTienLoi_BLL;

namespace QuanLiCuaHangTienLoi
{
    public partial class frmQLLoaiSanPham : Form
    {
        LoaiSanPhamBLL l = new LoaiSanPhamBLL();
        public frmQLLoaiSanPham()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadLoaiSP()
        {
            List<LoaiSanPhamDTO> ds = new List<LoaiSanPhamDTO>();
            ds = l.LoaiSP();
            dgvLoaiSP.DataSource = ds;
            // Đổi tên các cột theo ý muốn sau khi đã gán dữ liệu
            dgvLoaiSP.Columns["MaLoaiSanPham"].HeaderText = "Mã loại sản phẩm";
            dgvLoaiSP.Columns["TenLoaiSanPham"].HeaderText = "Tên loại sản phẩm";
        }

        private void frmQLLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadLoaiSP();
        }

    }
}
