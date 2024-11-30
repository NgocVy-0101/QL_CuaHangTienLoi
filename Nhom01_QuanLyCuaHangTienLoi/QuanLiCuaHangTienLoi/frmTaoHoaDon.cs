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
    public partial class frmTaoHoaDon : Form
    {
        HoaDonBLL hd = new HoaDonBLL();
        NhaCungCapBLL ncc = new NhaCungCapBLL();
        SanPhamBLL sp = new SanPhamBLL();
        ChiTietHoaDonBLL ct = new ChiTietHoaDonBLL();
        List<ChiTietHoaDonDTO> lct = new List<ChiTietHoaDonDTO>();
        List<ChiTietHoaDonDTO> dsct = new List<ChiTietHoaDonDTO>();
        HoaDonDTO hdto;

        public frmTaoHoaDon()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMa.Text = hd.MaHoaDon();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            hdto = new HoaDonDTO(txtMa.Text, "NV0029", "KHTT0012245", 0, dateNhap.Value, float.Parse(txtThanhTien.Text));
            hd.Them(hdto);
            foreach(ChiTietHoaDonDTO i in lct)
            {
                ct.Them(i);
            }    
        }

        public void Loadfrm()
        {
            List<HoaDonDTO> dshd = hd.HoaDon();

            List<NhaCungCapDTO> ds = new List<NhaCungCapDTO>();
            ds = ncc.NhaCungCap();
            cboNCC.DataSource = ds;
            cboNCC.ValueMember = "MaNCC";
            cboNCC.DisplayMember = "TenNCC";

            List<SanPhamDTO> ds2 = new List<SanPhamDTO>();
            ds2 = sp.SanPham();
            dgvSanPham.DataSource = ds2;
            dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns["SoLuongCon"].HeaderText = "Số lượng còn";
            dgvSanPham.Columns["GiaNhap"].Visible = false;
            dgvSanPham.Columns["GiaBan"].HeaderText = "Giá bán";
            dgvSanPham.Columns["HinhAnh"].Visible = false;
            dgvSanPham.Columns["MaLoaiSanPham"].Visible = false;
            dgvSanPham.Columns["MaNCC"].Visible = false;
            dgvSanPham.Columns["GhiChu"].Visible = false;
            dgvSanPham.Columns["NgaySanXuat"].Visible = false;
            dgvSanPham.Columns["NgayHetHan"].Visible = false;
            dgvSanPham.Columns["XuatXu"].Visible = false;


            dsct = ct.ChiTiet();
            dgvChiTiet.DataSource = dsct;
        }

        private void frmTaoHoaDon_Load(object sender, EventArgs e)
        {
            Loadfrm();
        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string s1 = dgvSanPham.SelectedRows[0].Cells["TenSanPham"].Value.ToString();
            string s2 = dgvSanPham.SelectedRows[0].Cells["MaSanPham"].Value.ToString();
            string s3 = dgvSanPham.SelectedRows[0].Cells["GiaBan"].Value.ToString();

            txtTenSP.Text = s1;
            txtMaSP.Text = s2;
            txtDonGia.Text = s3;
            float tt = int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text);
            txtThanhTien.Text = tt.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float tt = int.Parse(txtSL.Text) * float.Parse(txtDonGia.Text);
            ChiTietHoaDonDTO ctsp = new ChiTietHoaDonDTO(txtMa.Text, txtMaSP.Text, int.Parse(txtSL.Text), tt);
            lct.Add(ctsp);
            dsct.Add(ctsp);
            dgvChiTiet.DataSource = null;
            dgvChiTiet.DataSource = dsct;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var xoa = lct.FirstOrDefault(t => t.MaSanPham == txtMaSP.Text && t.MaHoaDon == txtMa.Text);
            if(xoa!=null)
            {
                lct.Remove(xoa);
                dsct.Remove(xoa);
            }

            dgvChiTiet.DataSource = null;
            dgvChiTiet.DataSource = dsct;
        }
    }
}
