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
        SqlCommand cmd;
        public KhachHangDAL()
        {
            string s = KetNoi.conn;
            conn = new SqlConnection(s);
        }
        public List<KhachHangDTO> KhachHang()
        {
            List<KhachHangDTO> k = new List<KhachHangDTO>();
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
                KhachHangDTO o = new KhachHangDTO(m, t, dt, di);
                k.Add(o);
            }

            return k;
        }

        public bool ThemKhachHang(KhachHangDTO kh)
        {
            try
            {
                string sql = "INSERT INTO KhachHang (MaKhach, TenKhach, DienThoai, Diem) VALUES (@MaKhach, @TenKhach, @DienThoai, @Diem)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhach", kh.MaKhach);
                cmd.Parameters.AddWithValue("@TenKhach", kh.TenKhach);
                cmd.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
                cmd.Parameters.AddWithValue("@Diem", kh.Diem);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        // Cập nhật khách hàng
        public bool CapNhatKhachHang(KhachHangDTO kh)
        {
            try
            {
                string sql = "UPDATE KhachHang SET TenKhach = @TenKhach, DienThoai = @DienThoai, Diem = @Diem WHERE MaKhach = @MaKhach";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhach", kh.MaKhach);
                cmd.Parameters.AddWithValue("@TenKhach", kh.TenKhach);
                cmd.Parameters.AddWithValue("@DienThoai", kh.DienThoai);
                cmd.Parameters.AddWithValue("@Diem", kh.Diem);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        // Xóa khách hàng
        public bool XoaKhachHang(string maKhach)
        {
            try
            {
                string sql = "DELETE FROM KhachHang WHERE MaKhach = @MaKhach";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaKhach", maKhach);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public void TichDiem(string ma, int x)
        {
            DataRow d = ds.Tables[0].Rows.Find(ma);
            if(d!=null)
            {
                if(x==1 && int.Parse(d["Diem"].ToString()) >= 50)
                    d["Diem"] = int.Parse(d["Diem"].ToString()) - 50;
                else
                    d["Diem"] = int.Parse(d["Diem"].ToString()) + 10;
            }    
            
            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
        }

        public string MaKH()
        {
            string ma = "";

            var HD = ds.Tables[0].AsEnumerable()
                .Where(row => row[0].ToString().StartsWith("KH"))
                .Select(row => row[0].ToString())
                .ToList();

            int invoiceNumber = 1;
            if (HD.Count > 0)
            {
                var lastInvoice = HD.Max();
                var lastNumber = int.Parse(lastInvoice.Substring(lastInvoice.Length - 3));
                invoiceNumber = lastNumber + 1;
            }

            ma = "KH" + invoiceNumber.ToString("D3");

            return ma;
        }
    }
}
