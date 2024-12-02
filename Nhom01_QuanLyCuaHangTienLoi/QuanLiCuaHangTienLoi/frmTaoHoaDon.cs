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
            float thanhTienTong = lct.Sum(x => x.ThanhTien); 
            hdto = new HoaDonDTO(txtMa.Text, "NV0029", "KHTT0012245", 0, dateNhap.Value, thanhTienTong);
            hd.Them(hdto);
            foreach (ChiTietHoaDonDTO i in lct)
            {
                ct.Them(i);
            }
        }

        public void Loadfrm()
        {
            List<HoaDonDTO> dshd = hd.HoaDon();
            List<NhaCungCapDTO> ds = ncc.NhaCungCap();
            cboNCC.DataSource = ds;
            cboNCC.ValueMember = "MaNCC";
            cboNCC.DisplayMember = "TenNCC";

            List<SanPhamDTO> ds2 = sp.SanPham();
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

            // Chỉ tính thành tiền nếu số lượng không trống
            if (!string.IsNullOrEmpty(txtSL.Text))
            {
                int soLuong;
                if (int.TryParse(txtSL.Text, out soLuong))
                {
                    float donGia = float.Parse(s3);
                    float tt = soLuong * donGia;
                    txtThanhTien.Text = tt.ToString();
                }
                else
                {
                    MessageBox.Show("Số lượng phải là một số hợp lệ.");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int soLuong;
            if (int.TryParse(txtSL.Text, out soLuong))
            {
                float donGia = float.Parse(txtDonGia.Text);
                float tt = soLuong * donGia;

                ChiTietHoaDonDTO ctsp = new ChiTietHoaDonDTO(txtMa.Text, txtMaSP.Text, soLuong, tt);
                lct.Add(ctsp);
                dsct.Add(ctsp);

                dgvChiTiet.DataSource = null;
                dgvChiTiet.DataSource = dsct;

                // Tính tổng thành tiền và cập nhật ô txtThanhTien
                float thanhTienTong = lct.Sum(x => x.ThanhTien);
                txtThanhTien.Text = thanhTienTong.ToString();
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

            var xoa = lct.FirstOrDefault(t => t.MaSanPham == txtMaSP.Text && t.MaHoaDon == txtMa.Text);
            if (xoa != null)
            {
                lct.Remove(xoa);
                dsct.Remove(xoa);

                dgvChiTiet.DataSource = null;
                dgvChiTiet.DataSource = dsct;

                // Tính tổng thành tiền và cập nhật ô txtThanhTien
                float thanhTienTong = lct.Sum(x => x.ThanhTien);
                txtThanhTien.Text = thanhTienTong.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm với mã sản phẩm và mã hóa đơn này.");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra danh sách chi tiết hóa đơn
                if (lct == null || lct.Count == 0)
                {
                    MessageBox.Show("Danh sách chi tiết hóa đơn rỗng.");
                    return;
                }

                // Tạo DataTable từ danh sách chi tiết hóa đơn
                DataTable dtSelectedProducts = new DataTable();
                dtSelectedProducts.Columns.Add("MaHoaDon");
                dtSelectedProducts.Columns.Add("MaSanPham");
                dtSelectedProducts.Columns.Add("SoLuong");
                dtSelectedProducts.Columns.Add("ThanhTien");

                foreach (var item in lct)
                {
                    DataRow row = dtSelectedProducts.NewRow();
                    row["MaHoaDon"] = item.MaHoaDon;
                    row["MaSanPham"] = item.MaSanPham;
                    row["SoLuong"] = item.SoLuong;
                    row["ThanhTien"] = item.ThanhTien;
                    dtSelectedProducts.Rows.Add(row);
                }

                // Đường dẫn tới file .rpt 
                string reportPath = @"D:\HK1_2024\CÔNG NGHỆ. NET\ĐỒ ÁN\CongNgheNet-main(1)\CongNgheNet-main\Nhom01_QuanLyCuaHangTienLoi\QuanLiCuaHangTienLoi\crystalReportViewer.rpt";

                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(reportPath);

                
                reportDocument.SetDataSource(dtSelectedProducts);

                
                reportDocument.SetDatabaseLogon("sa", "010104");

                // Hiển thị báo cáo
                frmReport reportForm = new frmReport();
                reportForm.LoadReport(reportPath, dtSelectedProducts);
                reportForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi in hóa đơn: " + ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
