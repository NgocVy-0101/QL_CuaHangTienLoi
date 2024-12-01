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
            dgvLoaiSP.DataSource = null;
            dgvLoaiSP.DataSource = ds;
            // Đổi tên các cột theo ý muốn sau khi đã gán dữ liệu
            dgvLoaiSP.Columns["MaLoaiSanPham"].HeaderText = "Mã loại sản phẩm";
            dgvLoaiSP.Columns["TenLoaiSanPham"].HeaderText = "Tên loại sản phẩm";
        }

        private void frmQLLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadLoaiSP();
        }

        private void btn_Addnew_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiSanPham.Text == "" || txt_MaLoaiSanPham.Text == "")
                return;
            LoaiSanPhamDTO sp = new LoaiSanPhamDTO(txt_MaLoaiSanPham.Text, txt_TenLoaiSanPham.Text);
            if (l.Them(sp))
                MessageBox.Show("Đã thêm thành công");
            else
                MessageBox.Show("Xảy ra lỗi");
            LoadLoaiSP();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiSanPham.Text == "" || txt_MaLoaiSanPham.Text == "")
                return;
            LoaiSanPhamDTO sp = new LoaiSanPhamDTO(txt_MaLoaiSanPham.Text, txt_TenLoaiSanPham.Text);
            if (l.Sua(sp))
                MessageBox.Show("Đã sửa thành công");
            else
                MessageBox.Show("Xảy ra lỗi");
            LoadLoaiSP();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiSanPham.Text == "" || txt_MaLoaiSanPham.Text == "")
                return;
            LoaiSanPhamDTO sp = new LoaiSanPhamDTO(txt_MaLoaiSanPham.Text, txt_TenLoaiSanPham.Text);
            if (l.Xoa(sp))
                MessageBox.Show("Đã xóa thành công");
            else
                MessageBox.Show("Xảy ra lỗi");
            LoadLoaiSP();
        }

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLoaiSanPham.Text = dgvLoaiSP.SelectedRows[0].Cells[1].Value.ToString();
            txt_TenLoaiSanPham.Text = dgvLoaiSP.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btn_ViewwData_Click(object sender, EventArgs e)
        {
            txt_MaLoaiSanPham.Clear();
            txt_TenLoaiSanPham.Clear();
            LoadLoaiSP();
        }
    }
}
