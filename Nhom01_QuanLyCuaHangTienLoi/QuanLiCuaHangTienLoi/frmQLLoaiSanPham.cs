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

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLoaiSanPham.Text = dgvLoaiSP.SelectedRows[0].Cells[0].Value.ToString();
            txt_TenLoaiSanPham.Text = dgvLoaiSP.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            txt_MaLoaiSanPham.Text = l.MaLSP();
        }

        private void btn_Addnew_Click(object sender, EventArgs e)
        {
            LoaiSanPhamDTO ls = new LoaiSanPhamDTO(txt_MaLoaiSanPham.Text, txt_TenLoaiSanPham.Text);
            if (l.Them(ls))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            LoadLoaiSP();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiSanPhamDTO ls = new LoaiSanPhamDTO(txt_MaLoaiSanPham.Text, txt_TenLoaiSanPham.Text);
            if (l.Sua(ls))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            LoadLoaiSP();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            LoaiSanPhamDTO ls = new LoaiSanPhamDTO(txt_MaLoaiSanPham.Text, txt_TenLoaiSanPham.Text);
            if (l.Xoa(ls))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            LoadLoaiSP();
        }
    }
}
