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
    public partial class frmQLKhachHang : Form
    {
        KhachHangBLL kh = new KhachHangBLL();

        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        public void LoadKH()
        {
            List<KhachHangDTO> ds = new List<KhachHangDTO>();
            ds = kh.KhachHang();
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = ds;
            // Đổi tên các cột theo ý muốn sau khi đã gán dữ liệu
            dgvKhachHang.Columns["MaKhach"].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns["TenKhach"].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvKhachHang.Columns["Diem"].HeaderText = "Điểm";
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString();
            txtTen.Text = dgvKhachHang.SelectedRows[0].Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachHang.SelectedRows[0].Cells[2].Value.ToString();
            txtDiem.Text = dgvKhachHang.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            txtMa.Text = kh.MaKH();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "")
                return;
            KhachHangDTO k = new KhachHangDTO(txtMa.Text, txtTen.Text, txtSDT.Text, int.Parse(txtDiem.Text));
            if (kh.ThemKhachHang(k))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            LoadKH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "")
                return;
            KhachHangDTO k = new KhachHangDTO(txtMa.Text, txtTen.Text, txtSDT.Text, int.Parse(txtDiem.Text));
            if (kh.CapNhatKhachHang(k))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            LoadKH();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "")
                return;
            if (kh.XoaKhachHang(txtMa.Text))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            LoadKH();
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void btn_ViewData_Click(object sender, EventArgs e)
        {
            LoadKH();
        }
    }
}
