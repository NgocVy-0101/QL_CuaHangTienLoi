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
    public partial class frmQLHoaDon : Form
    {
        HoaDonBLL hd = new HoaDonBLL();
        public frmQLHoaDon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadHD()
        {
            List<HoaDonDTO> ds = new List<HoaDonDTO>();
            ds = hd.HoaDon();
            dgvHoaDon.DataSource = ds;
            // Đổi tên các cột theo ý muốn sau khi đã gán dữ liệu
            dgvHoaDon.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dgvHoaDon.Columns["MaKhach"].HeaderText = "Mã khách hàng";
            dgvHoaDon.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            dgvHoaDon.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvHoaDon.Columns["NgayBan"].HeaderText = "Ngày bán";
            dgvHoaDon.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
        }

        private void frmQLHoaDon_Load(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
