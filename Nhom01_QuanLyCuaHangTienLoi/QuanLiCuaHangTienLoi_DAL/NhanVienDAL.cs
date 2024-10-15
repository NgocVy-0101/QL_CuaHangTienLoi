using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiCuaHangTienLoi_DAL
{
    public class NhanVienDAL
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter adap;
        public NhanVienDAL()
        {
            string s = @"Data Source=LAPTOP-SF87IO3T\PHAMVU;Initial Catalog=QLCHTL;Integrated Security=True";
            conn = new SqlConnection(s);
        }
        public List<NhanVienDTO> NhanVien()
        {
            List<NhanVienDTO> k = new List<NhanVienDTO>();
            string sql = "select * from NhanVien";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(ds, "NhanVien");

            //Thêm khóa chính
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["NhanVien"].Columns[0];
            ds.Tables["NhanVien"].PrimaryKey = key;

            foreach (DataRow i in ds.Tables["NhanVien"].Rows)
            {
                string m = i["MaNhanVien"].ToString();
                string t = i["TenNhanVien"].ToString();
                string gt = i["GioiTinh"].ToString();
                DateTime ns = (DateTime)i["NgaySinh"];
                string dt = i["DienThoai"].ToString();
                string dc = i["DiaChi"].ToString();
                string mk = i["MatKhau"].ToString();
                NhanVienDTO o = new NhanVienDTO(m,t,gt,ns,dt,dc,mk);
                k.Add(o);
            }

            return k;
        }
    }
}
