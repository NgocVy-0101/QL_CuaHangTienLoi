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
    public partial class frmQLNhaCungCap : Form
    {
        NhaCungCapBLL ncc = new NhaCungCapBLL();
        public frmQLNhaCungCap()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadNCC()
        {
            List<NhaCungCapDTO> ds = new List<NhaCungCapDTO>();
            ds = ncc.NhaCungCap();
            dgvNCC.DataSource = ds;
            // Đổi tên các cột theo ý muốn sau khi đã gán dữ liệu
            dgvNCC.Columns["MaNCC"].HeaderText = "Nhà cung cấp";
            dgvNCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadNCC();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            txtMa.Text = ncc.MaNCC();
        }

        private void btn_Addnew_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO n = new NhaCungCapDTO(txtMa.Text, txtTen.Text, txtDiaChi.Text);
            if (ncc.Them(n))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            LoadNCC();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO n = new NhaCungCapDTO(txtMa.Text, txtTen.Text, txtDiaChi.Text);
            if (ncc.Sua(n))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            LoadNCC();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvNCC.SelectedRows[0].Cells[0].Value.ToString();
            txtTen.Text = dgvNCC.SelectedRows[0].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNCC.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO n = new NhaCungCapDTO(txtMa.Text, txtTen.Text, txtDiaChi.Text);
            if (ncc.Xoa(n))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            LoadNCC();
        }
    }
}
