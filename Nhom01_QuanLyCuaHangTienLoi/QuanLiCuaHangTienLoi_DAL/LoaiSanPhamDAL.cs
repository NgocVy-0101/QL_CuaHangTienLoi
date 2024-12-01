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
    public class LoaiSanPhamDAL
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter adap;
        public LoaiSanPhamDAL()
        {
            string s = @"Data Source=LAPTOP-SF87IO3T\PHAMVU;Initial Catalog=QLCHTL;Integrated Security=True";
            conn = new SqlConnection(s);
        }
        public List<LoaiSanPhamDTO> LoaiSP()
        {
            List<LoaiSanPhamDTO> k = new List<LoaiSanPhamDTO>();
            string sql = "select * from LoaiSanPham";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(ds, "LoaiSanPham");

            //Thêm khóa chính
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["LoaiSanPham"].Columns[0];
            ds.Tables["LoaiSanPham"].PrimaryKey = key;

            foreach (DataRow i in ds.Tables["LoaiSanPham"].Rows)
            {
                string m = i["MaLoaiSanPham"].ToString();
                string t = i["TenLoaiSanPham"].ToString();
                LoaiSanPhamDTO o = new LoaiSanPhamDTO(m, t);
                k.Add(o);
            }

            return k;
        }
        public bool Them(LoaiSanPhamDTO sp)
        {
            DataRow dr = ds.Tables[0].Rows.Find(sp.MaLoaiSanPham);
            if (dr != null)
                return false;

            DataRow d = ds.Tables[0].NewRow();
            d[0] = sp.MaLoaiSanPham;
            d[1] = sp.TenLoaiSanPham;

            ds.Tables[0].Rows.Add(d);

            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
            return true;
        }
        public bool Sua(LoaiSanPhamDTO sp)
        {
            DataRow dr = ds.Tables[0].Rows.Find(sp.MaLoaiSanPham);
            if (dr == null)
                return false;

            dr[1] = sp.TenLoaiSanPham;

            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
            return true;
        }
        public bool Xoa(LoaiSanPhamDTO sp)
        {
            DataRow dr = ds.Tables[0].Rows.Find(sp.MaLoaiSanPham);
            if (dr == null)
                return false;

            dr.Delete();

            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
            return true;
        }
    }
}
