using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLiCuaHangTienLoi_BLL;
using QuanLiCuaHangTienLoi_DTO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

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
        KhachHangBLL kh = new KhachHangBLL();
        List<KhachHangDTO> lkh = new List<KhachHangDTO>();
        NhanVienDTO nvien;

        public frmTaoHoaDon()
        {
            InitializeComponent();
        }

        public frmTaoHoaDon(NhanVienDTO nv)
        {
            InitializeComponent();
            nvien = nv;
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
            groupChiTiet.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float thanhTienTong = lct.Sum(x => x.ThanhTien) - float.Parse(txtGiamGia.Text);
            hdto = new HoaDonDTO(txtMa.Text, "NV001", txtMaKH.Text, float.Parse(txtGiamGia.Text), dateNhap.Value, thanhTienTong);
            hd.Them(hdto);
            foreach (ChiTietHoaDonDTO i in lct)
            {
                ct.Them(i);
                sp.CapNhatSoLuong(i.MaSanPham, i.SoLuong);
            }
            if (ckbGiamGia.Checked)
                kh.TichDiem(txtMaKH.Text, 1);
            else
                kh.TichDiem(txtMaKH.Text, 0);


            MessageBox.Show("Thêm hóa đơn thành công");
            // Hiển thị hộp thoại Yes/No
            DialogResult result = MessageBox.Show(
                "Bạn có muốn in hóa đơn?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    //// Đường dẫn tới file .rpt 
                    string reportPath = @"D:\HOCTAP\CongNgheNet\DoAn2\CongNgheNet\Nhom01_QuanLyCuaHangTienLoi\QuanLiCuaHangTienLoi\crystalReportViewer.rpt";
                    //// Hiển thị báo cáo
                    frmReport reportForm = new frmReport(txtMa.Text);
                    reportForm.LoadReport2(reportPath);
                    reportForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi in hóa đơn: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
            button1_Click(sender, e);
            Loadfrm();
        }

        public void Loadfrm()
        {
            List<HoaDonDTO> dshd = hd.HoaDon();
            List<NhaCungCapDTO> ds = ncc.NhaCungCap();
            cboNCC.DataSource = ds;
            cboNCC.ValueMember = "MaNCC";
            cboNCC.DisplayMember = "TenNCC";

            List<SanPhamDTO> ds2 = sp.SanPham();
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = ds2;
            dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns["SoLuongCon"].HeaderText = "Số lượng còn";
            dgvSanPham.Columns["GiaNhap"].Visible = false;
            dgvSanPham.Columns["GiaBan"].HeaderText = "Giá bán";
            dgvSanPham.Columns["MaLoaiSanPham"].Visible = false;
            dgvSanPham.Columns["MaNCC"].Visible = false;
            dgvSanPham.Columns["GhiChu"].Visible = false;
            dgvSanPham.Columns["NgaySanXuat"].Visible = false;
            dgvSanPham.Columns["NgayHetHan"].Visible = false;
            dgvSanPham.Columns["XuatXu"].Visible = false;

            dsct = ct.ChiTiet();
            dgvChiTiet.DataSource = null;
            dgvChiTiet.DataSource = dsct;


        }

        private void frmTaoHoaDon_Load(object sender, EventArgs e)
        {
            Loadfrm();
            lblNV.Text += nvien.TenNhanVien;
            lkh = kh.KhachHang();
            cboKH.DataSource = null;
            cboKH.DataSource = lkh;
            cboKH.DisplayMember = "TenKhach";
            cboKH.ValueMember = "MaKhach";
            cboKH.SelectedIndex = 0;
            txtMaKH.Text = cboKH.SelectedValue.ToString();
            txtGiamGia.Text = "0";

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

            // Chỉ tính thành tiền nếu số lượng không trống
            if (!string.IsNullOrEmpty(txtSL.Text))
            {
                int soLuong;
                if (int.TryParse(txtSL.Text, out soLuong))
                {
                    float donGia = float.Parse(s3);
                    float tt = soLuong * donGia;
                    txtThanhT.Text = tt.ToString();
                }
                else
                {
                    MessageBox.Show("Số lượng phải là một số hợp lệ.");
                }
            }

            ckbGiamGia_CheckedChanged(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
                return;
            }
            var xoa = lct.FirstOrDefault(t => t.MaSanPham == txtMaSP.Text && t.MaHoaDon == txtMa.Text);
            if (xoa != null)
            {
                MessageBox.Show("Hóa đơn này đã tồn tại sản phẩm này");
                return;
            }

            int soLuong;
            if (int.TryParse(txtSL.Text, out soLuong))
            {
                if (soLuong > int.Parse(dgvSanPham.SelectedRows[0].Cells["SoLuongCon"].Value.ToString()))
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ cho hóa đơn này");
                    return;
                }
                float donGia = float.Parse(txtDonGia.Text);
                float tt = soLuong * donGia;

                ChiTietHoaDonDTO ctsp = new ChiTietHoaDonDTO(txtMa.Text, txtMaSP.Text, soLuong, tt);
                lct.Add(ctsp);
                dsct.Add(ctsp);

                dgvChiTiet.DataSource = null;
                dgvChiTiet.DataSource = dsct;

                ckbGiamGia_CheckedChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Số lượng phải là một số hợp lệ.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và hóa đơn hợp lệ để xóa.");
                return;
            }

            var xoa = lct.FirstOrDefault(t => t.MaSanPham == dgvChiTiet.SelectedRows[0].Cells[1].Value.ToString() && t.MaHoaDon == dgvChiTiet.SelectedRows[0].Cells[0].Value.ToString());
            if (xoa != null)
            {
                lct.Remove(xoa);
                dsct.Remove(xoa);

                dgvChiTiet.DataSource = null;
                dgvChiTiet.DataSource = dsct;

                ckbGiamGia_CheckedChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Không thể xóa sản phẩm từ hóa đơn khác");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                //// Đường dẫn tới file .rpt 
                string reportPath = @"D:\HOCTAP\CongNgheNet\DoAn2\CongNgheNet\Nhom01_QuanLyCuaHangTienLoi\QuanLiCuaHangTienLoi\crystalReportViewer.rpt";
                string mahd = dgvChiTiet.SelectedRows[0].Cells["MaHoaDon"].Value.ToString();
                //// Hiển thị báo cáo
                frmReport reportForm = new frmReport(mahd);
                reportForm.LoadReport2(reportPath);
                reportForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi in hóa đơn: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void ckbGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGiamGia.Checked == true)
            {
                float sum = lct.Where(t => t.MaHoaDon == txtMa.Text).Sum(t => t.ThanhTien);
                float gg = hd.GiamGia(txtMaKH.Text);
                float tt = sum - gg * sum;
                txtThanhTien.Text = tt.ToString();
                txtGiamGia.Text = (gg * tt).ToString();
            }
            if (ckbGiamGia.Checked == false)
            {
                float sum = lct.Where(t => t.MaHoaDon == txtMa.Text).Sum(t => t.ThanhTien);
                txtThanhTien.Text = sum.ToString();
                txtGiamGia.Text = "0";
            }
        }

        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaKH.Text = cboKH.SelectedValue.ToString();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
    }
}
