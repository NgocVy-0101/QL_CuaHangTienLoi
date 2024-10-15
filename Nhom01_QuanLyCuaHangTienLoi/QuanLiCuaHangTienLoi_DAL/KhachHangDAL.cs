using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DTO;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiCuaHangTienLoi_DAL
{
    public class KhachHangDAL
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter adap;
        public KhachHangDAL()
        {
            string s = @"Data Source=LAPTOP-SF87IO3T\PHAMVU;Initial Catalog=QLCHTL;Integrated Security=True";
            conn = new SqlConnection(s);
        }
        public List<KhacHangDTO> KhachHang()
        {
            List<KhacHangDTO> k = new List<KhacHangDTO>();
            string sql = "select * from KhachHang";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(ds, "KhachHang");

            //Thêm khóa chính
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["KhachHang"].Columns[0];
            ds.Tables["KhachHang"].PrimaryKey = key;

            foreach (DataRow i in ds.Tables["KhachHang"].Rows)
            {
                string m = i["MaKhach"].ToString();
                string t = i["TenKhach"].ToString();
                string dt = i["DienThoai"].ToString();
                int di = (int)i["Diem"];
                KhacHangDTO o = new KhacHangDTO(m, t, dt, di);
                k.Add(o);
            }

            return k;
        }
    }
}
