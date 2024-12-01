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
            dgvNCC.DataSource = null;
            dgvNCC.DataSource = ds;
            // Đổi tên các cột theo ý muốn sau khi đã gán dữ liệu         
            dgvNCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dgvNCC.Columns["MaNCC"].HeaderText = "Nhà cung cấp";
            dgvNCC.Columns["DiaChi"].HeaderText = "Địa chỉ";

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadNCC();
        }
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvNCC.SelectedRows[0].Cells[2].Value.ToString();
            txtTen.Text = dgvNCC.SelectedRows[0].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNCC.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btn_Addnew_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO c = new NhaCungCapDTO(txtMa.Text, txtTen.Text, txtDiaChi.Text);
            if (ncc.Them(c))
                MessageBox.Show("Them thanh cong");
            else
                MessageBox.Show("Xay ra lõi");
            LoadNCC();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO c = new NhaCungCapDTO(txtMa.Text, txtTen.Text, txtDiaChi.Text);
            if (ncc.Sua(c))
                MessageBox.Show("Sửa thanh cong");
            else
                MessageBox.Show("Xay ra lõi");
            LoadNCC();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO c = new NhaCungCapDTO(txtMa.Text, txtTen.Text, txtDiaChi.Text);
            if (ncc.Xoa(c))
                MessageBox.Show("Xóa thanh cong");
            else
                MessageBox.Show("Xay ra lõi");
            LoadNCC();
        }

        private void btn_ViewwData_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtMa.Clear();
            txtTen.Clear();
            LoadNCC();
        }
    }
}
