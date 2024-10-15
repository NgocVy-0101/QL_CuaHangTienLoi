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
    public partial class frmQLNhaCungCap : Form
    {
        NhaCungCapBLL ncc = new NhaCungCapBLL();
        public frmQLNhaCungCap()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadNCC()
        {
            List<NhaCungCapDTO> ds = new List<NhaCungCapDTO>();
            ds = ncc.NhaCungCap();
            dgvNCC.DataSource = ds;
            // Đổi tên các cột theo ý muốn sau khi đã gán dữ liệu
            dgvNCC.Columns["MaNCC"].HeaderText = "Nhà cung cấp";
            dgvNCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadNCC();
        }
    }
}
