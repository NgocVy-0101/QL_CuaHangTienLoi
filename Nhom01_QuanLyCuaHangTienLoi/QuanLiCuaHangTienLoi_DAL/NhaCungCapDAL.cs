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
    }
}
