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
    public class NhaCungCapDAL
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter adap;
        public NhaCungCapDAL()
        {
            string s = @"Data Source=LAPTOP-SF87IO3T\PHAMVU;Initial Catalog=QLCHTL;Integrated Security=True";
            conn = new SqlConnection(s);
        }
        public List<NhaCungCapDTO> NhaCungCap()
        {
            List<NhaCungCapDTO> k = new List<NhaCungCapDTO>();
            string sql = "select * from NhaCungCap";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(ds, "NhaCungCap");

            //Thêm khóa chính
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["NhaCungCap"].Columns[0];
            ds.Tables["NhaCungCap"].PrimaryKey = key;

            foreach (DataRow i in ds.Tables["NhaCungCap"].Rows)
            {
                string m = i["MaNCC"].ToString();
                string t = i["TenNCC"].ToString();
                string dc = i["DiaChi"].ToString();
                NhaCungCapDTO o = new NhaCungCapDTO(m, t, dc);
                k.Add(o);
            }

            return k;
        }
        public bool Them(NhaCungCapDTO sp)
        {
            DataRow dr = ds.Tables[0].Rows.Find(sp.MaNCC);
            if (dr != null)
                return false;

            DataRow d = ds.Tables[0].NewRow();
            d[0] = sp.MaNCC;
            d[1] = sp.TenNCC;
            d[2] = sp.DiaChi;

            ds.Tables[0].Rows.Add(d);

            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
            return true;
        }
        public bool Sua(NhaCungCapDTO sp)
        {
            DataRow d = ds.Tables[0].Rows.Find(sp.MaNCC);
            if (d == null)
                return false;

            d[1] = sp.TenNCC;
            d[2] = sp.DiaChi;

            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
            return true;
        }
        public bool Xoa(NhaCungCapDTO sp)
        {
            DataRow d = ds.Tables[0].Rows.Find(sp.MaNCC);
            if (d == null)
                return false;

            d.Delete();

            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
            return true;
        }
    }
}
