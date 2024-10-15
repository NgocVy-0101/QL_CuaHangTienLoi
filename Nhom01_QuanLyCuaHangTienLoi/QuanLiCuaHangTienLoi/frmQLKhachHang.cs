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
            List<KhacHangDTO> ds = new List<KhacHangDTO>();
            ds = kh.KhachHang();
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
    }
}
