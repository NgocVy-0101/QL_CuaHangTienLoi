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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        NhanVienBLL nv = new NhanVienBLL();

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(txt_MatKhau.Text==""|| txt_TenDangNhap.Text=="")
            {
                MessageBox.Show("Nhập đầy dủ thông tin");
                return;
            }    

            if(nv.DanNhap(txt_TenDangNhap.Text,txt_MatKhau.Text))
            {
                NhanVienDTO nvien = nv.NV(txt_TenDangNhap.Text);
                frmMain frmMain = new frmMain(nvien);
                frmMain.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            List<NhanVienDTO> n = nv.NhanVien();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
