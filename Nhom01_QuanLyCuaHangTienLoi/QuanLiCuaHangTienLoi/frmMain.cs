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
    public partial class frmMain : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        HoaDonBLL hd = new HoaDonBLL();
        ChiTietHoaDonBLL ct = new ChiTietHoaDonBLL();
        // Khai báo một danh sách để lưu các form con
        List<Form> openForms = new List<Form>();

        public frmMain()
        {
            InitializeComponent();
        }
        NhanVienDTO nvien;
        public frmMain(NhanVienDTO nv)
        {
            InitializeComponent();
            nvien = nv;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadSP()
        {
            List<SanPhamDTO> ds = new List<SanPhamDTO>();
            ds = sp.TopSP();
            List<HoaDonDTO> h = new List<HoaDonDTO>();
            h = hd.HoaDon();
            List<ChiTietHoaDonDTO> c = new List<ChiTietHoaDonDTO>();
            c = ct.ChiTiet();

            int KH = h.Count();
            float DT = h.Sum(t => t.TongTien);
            int SP = 0;
            SP = c.Sum(t => t.SoLuong);

            txtDT.Text = DT.ToString();
            txtKH.Text = KH.ToString();
            txtSP.Text = SP.ToString();

            dgvTop10.DataSource = null;
            dgvTop10.DataSource = ds;
            dgvTop10.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            dgvTop10.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvTop10.Columns["SoLuongCon"].HeaderText = "Số lượng còn";
            dgvTop10.Columns["GiaNhap"].Visible = false;
            dgvTop10.Columns["GiaBan"].HeaderText = "Giá bán";
            dgvTop10.Columns["MaLoaiSanPham"].Visible = false;
            dgvTop10.Columns["MaNCC"].Visible = false;
            dgvTop10.Columns["GhiChu"].Visible = false;
            dgvTop10.Columns["NgaySanXuat"].Visible = false;
            dgvTop10.Columns["NgayHetHan"].Visible = false;
            dgvTop10.Columns["XuatXu"].Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSP();
            if(nvien.Quyen=="NhanVien")
            {
                btnLoaiSP.Enabled = false;
                btnNCC.Enabled = false;
                btnThongKe.Enabled = false;
                btnNhanVien.Enabled = false;
            }    
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmTaoHoaDon frmHD = new frmTaoHoaDon(nvien);
            frmHD.Show();
            openForms.Add(frmHD); // Thêm form vào danh sách
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frmNhanVien = new frmQLNhanVien();
            frmNhanVien.Show();
            openForms.Add(frmNhanVien); // Thêm form vào danh sách
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmQLSanPham frmSanPham = new frmQLSanPham();
            frmSanPham.Show();
            openForms.Add(frmSanPham); // Thêm form vào danh sách
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            frmQLLoaiSanPham frmLoai = new frmQLLoaiSanPham();
            frmLoai.Show();
            openForms.Add(frmLoai); // Thêm form vào danh sách
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            frmQLKhachHang frmKhach = new frmQLKhachHang();
            frmKhach.Show();
            openForms.Add(frmKhach); // Thêm form vào danh sách
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmQLNhaCungCap frmNCC = new frmQLNhaCungCap();
            frmNCC.Show();
            openForms.Add(frmNCC); // Thêm form vào danh sách
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frmNCC = new frmThongKe();
            frmNCC.Show();
            openForms.Add(frmNCC); // Thêm form vào danh sách
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSP();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            // Đóng tất cả các form con đang mở
            foreach (var form in openForms)
            {
                form.Close();
            }

            // Quay lại form đăng nhập (ví dụ: mở lại frmLogin)
            frmDangNhap loginForm = new frmDangNhap();
            loginForm.Show();

            // Đóng form chính
            this.Close();
        }

        // Hàm đóng tất cả các form con
        private void CloseAllForms()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f != this)  // Kiểm tra tránh đóng FormMain
                {
                    f.Close();  // Đóng form
                }
            }
        }
    }
}
