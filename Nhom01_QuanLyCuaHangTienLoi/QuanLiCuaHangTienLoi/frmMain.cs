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
            ds = sp.SanPham();
            dgvTop10.Columns.Add("Id", "Mã Sản Phẩm");
            dgvTop10.Columns.Add("TenSanPham", "Tên Sản Phẩm");
            foreach (SanPhamDTO item in ds)
            {
                dgvTop10.Rows.Add(item.MaSanPham, item.TenSanPham);
            }    
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
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frmNhanVien = new frmQLNhanVien();
            frmNhanVien.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmQLSanPham frmSanPham = new frmQLSanPham();
            frmSanPham.Show();
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            frmQLLoaiSanPham frmLoai = new frmQLLoaiSanPham();
            frmLoai.Show();
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            frmQLKhachHang frmKhach = new frmQLKhachHang();
            frmKhach.Show();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmQLNhaCungCap frmNCC = new frmQLNhaCungCap();
            frmNCC.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frmNCC = new frmThongKe();
            frmNCC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
