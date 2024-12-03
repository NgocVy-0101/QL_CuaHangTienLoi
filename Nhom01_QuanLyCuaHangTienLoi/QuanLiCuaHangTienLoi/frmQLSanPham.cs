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
        NhaCungCapBLL ncc = new NhaCungCapBLL();
        LoaiSanPhamBLL lsp = new LoaiSanPhamBLL();
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
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = ds;
            // Đổi tên các cột theo ý muốn sau khi đã gán dữ liệu
            dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns["SoLuongCon"].HeaderText = "Số lượng còn";
            dgvSanPham.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dgvSanPham.Columns["GiaBan"].HeaderText = "Giá bán";
            dgvSanPham.Columns["MaLoaiSanPham"].HeaderText = "Loại sản phẩm";
            dgvSanPham.Columns["MaNCC"].HeaderText = "Nhà cung cấp";
            dgvSanPham.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvSanPham.Columns["NgaySanXuat"].HeaderText = "Ngày sản xuất";
            dgvSanPham.Columns["NgayHetHan"].HeaderText = "Hạn sử dụng";
            dgvSanPham.Columns["XuatXu"].HeaderText = "Xuất xứ";


            List<LoaiSanPhamDTO> Llsp = lsp.LoaiSP();
            cboLSP.DataSource = null;
            cboLSP.DataSource = Llsp;
            cboLSP.DisplayMember = "TenLoaiSanPham";
            cboLSP.ValueMember = "MaLoaiSanPham";

            List<NhaCungCapDTO> lncc = ncc.NhaCungCap();
            cboNCC.DataSource = null;
            cboNCC.DataSource = lncc;
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
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
            if (txtMa.Text == "" || txtTen.Text == "" || txtGiaBan.Text == "" || txtGiaNhap.Text == "" || txtXX.Text == "" || txtSL.Text == "" || txtGhiChu.Text == "")
                return;
            SanPhamDTO s1 = new SanPhamDTO(txtMa.Text, txtTen.Text, int.Parse(txtSL.Text), float.Parse(txtGiaNhap.Text), float.Parse(txtGiaBan.Text), dateSX.Value, dateHan.Value, txtXX.Text, cboLSP.SelectedValue.ToString(), cboNCC.SelectedValue.ToString(), txtGhiChu.Text);
            if (sp.Them(s1))
                MessageBox.Show("Them thanh cong");
            else
                MessageBox.Show("Xay ra lõi");
            LoadSP();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvSanPham.SelectedRows[0].Cells[0].Value.ToString();
            txtTen.Text = dgvSanPham.SelectedRows[0].Cells[1].Value.ToString();
            cboNCC.SelectedValue = dgvSanPham.SelectedRows[0].Cells[5].Value.ToString();
            cboLSP.SelectedValue = dgvSanPham.SelectedRows[0].Cells[6].Value.ToString();
            txtSL.Text = dgvSanPham.SelectedRows[0].Cells[2].Value.ToString();
            txtGiaBan.Text = dgvSanPham.SelectedRows[0].Cells[3].Value.ToString();
            txtGiaNhap.Text = dgvSanPham.SelectedRows[0].Cells[4].Value.ToString();
            dateSX.Value = Convert.ToDateTime(dgvSanPham.SelectedRows[0].Cells[7].Value);
            dateHan.Value = Convert.ToDateTime(dgvSanPham.SelectedRows[0].Cells[8].Value);
            txtXX.Text = dgvSanPham.SelectedRows[0].Cells[9].Value.ToString();
            txtGhiChu.Text = dgvSanPham.SelectedRows[0].Cells[10].Value.ToString();

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ViewwData_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSL.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtGhiChu.Clear();
            txtXX.Clear();

            LoadSP();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMa.Text = sp.MaSP();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtGiaBan.Text == "" || txtGiaNhap.Text == "" || txtXX.Text == "" || txtSL.Text == "" || txtGhiChu.Text == "")
                return;
            SanPhamDTO s1 = new SanPhamDTO(txtMa.Text, txtTen.Text, int.Parse(txtSL.Text), float.Parse(txtGiaNhap.Text), float.Parse(txtGiaBan.Text), dateSX.Value, dateHan.Value, txtXX.Text, cboLSP.SelectedValue.ToString(), cboNCC.SelectedValue.ToString(), txtGhiChu.Text);
            if (sp.Sua(s1))
                MessageBox.Show("Sửa thanh cong");
            else
                MessageBox.Show("Sửa thất bại");
            LoadSP();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtGiaBan.Text == "" || txtGiaNhap.Text == "" || txtXX.Text == "" || txtSL.Text == "" || txtGhiChu.Text == "")
                return;
            SanPhamDTO s1 = new SanPhamDTO(txtMa.Text, txtTen.Text, int.Parse(txtSL.Text), float.Parse(txtGiaNhap.Text), float.Parse(txtGiaBan.Text), dateSX.Value, dateHan.Value, txtXX.Text, cboLSP.SelectedValue.ToString(), cboNCC.SelectedValue.ToString(), txtGhiChu.Text);
            if (sp.Xoa(s1))
                MessageBox.Show("Xóa thanh cong");
            else
                MessageBox.Show("Xóa thất bại");
            LoadSP();
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
    }
}