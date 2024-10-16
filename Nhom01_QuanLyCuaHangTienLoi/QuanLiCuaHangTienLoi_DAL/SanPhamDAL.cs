using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLiCuaHangTienLoi_DTO;

namespace QuanLiCuaHangTienLoi_DAL
{
    public class SanPhamDAL
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter adap;
        public SanPhamDAL()
        {
            string s = @"Data Source=LAPTOP-SF87IO3T\PHAMVU;Initial Catalog=QLCHTL;Integrated Security=True";
            conn = new SqlConnection(s);
        }
        public List<SanPhamDTO> SanPham()
        {
            List<SanPhamDTO> k = new List<SanPhamDTO>();
            string sql = "select * from SanPham";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(ds, "SanPham");

            //Thêm khóa chính
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["SanPham"].Columns[0];
            ds.Tables["SanPham"].PrimaryKey = key;

            foreach (DataRow i in ds.Tables["SanPham"].Rows)
            {
                string ma = i["MaSanPham"].ToString();
                string ten = i["TenSanPham"].ToString();
                int sl = (int)i["SoLuongCon"];
                float gn = Convert.ToSingle(i["GiaNhap"]);
                float gb = Convert.ToSingle(i["GiaBan"]);
                string hi = i["HinhAnh"].ToString();
                string mloai = i["MaLoaiSanPham"].ToString();
                string mncc = i["MaNCC"].ToString();
                string gi = i["GhiChu"].ToString();
                DateTime nsx = (DateTime)i["NgaySanXuat"];
                DateTime nhh = (DateTime)i["NgayHetHan"];
                string xx = i["XuatXu"].ToString();
                SanPhamDTO o = new SanPhamDTO(ma,ten,sl,gn,gb,hi,nsx,nhh,xx,mloai,mncc,gi);
                k.Add(o);
            }

            return k;
        }

       
    }
}
