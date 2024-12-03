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
    public class HoaDonDAL
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter adap;
        public HoaDonDAL()
        {
            string s = KetNoi.conn;
            conn = new SqlConnection(s);
        }
        public List<HoaDonDTO> HoaDon()
        {
            List<HoaDonDTO> k = new List<HoaDonDTO>();
            string sql = "select * from HoaDon";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(ds, "HoaDon");

            //Thêm khóa chính
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["HoaDon"].Columns[0];
            ds.Tables["HoaDon"].PrimaryKey = key;

            foreach (DataRow i in ds.Tables["HoaDon"].Rows)
            {
                string mhd = i["MaHoaDon"].ToString();
                string mnv = i["MaNhanVien"].ToString();
                string mk = i["MaKhach"].ToString();

                float gg = Convert.ToSingle(i["GiamGia"]);
                DateTime nb = (DateTime)i["NgayBan"];
                float tt = Convert.ToSingle(i["GiamGia"]);
                float tong = Convert.ToSingle(i["TongTien"]);
                HoaDonDTO o = new HoaDonDTO(mhd,mnv,mk,gg,nb,tong);
                k.Add(o);
            }

            return k;
        }

        public string MaHoaDon()
        {
            string ma = "";
            string NgayNhap= DateTime.Now.ToString("ddMMyyyy");

            var HD = ds.Tables[0].AsEnumerable()
                .Where(row => row["MaHoaDon"].ToString().StartsWith("HD" + NgayNhap))
                .Select(row => row["MaHoaDon"].ToString())
                .ToList();

            // Kiểm tra số lượng mã hóa đơn đã có
            int invoiceNumber = 1;
            if (HD.Count > 0)
            {
                // Lấy số cuối của mã hóa đơn hiện tại và cộng thêm 1
                var lastInvoice = HD.Max();
                var lastNumber = int.Parse(lastInvoice.Substring(lastInvoice.Length - 3));
                invoiceNumber = lastNumber + 1;
            }

            ma = "HD" + NgayNhap + invoiceNumber.ToString("D3");

            return ma;
        }
        public void Them(HoaDonDTO ct)
        {
            foreach (DataRow i in ds.Tables[0].Rows)
            {
                if (i[0].ToString() == ct.MaHoaDon)
                {
                    return;
                }
            }

            DataRow d = ds.Tables[0].NewRow();

            d["MaHoaDon"] = ct.MaHoaDon;
            d["MaNhanVien"] = ct.MaNhanVien;
            d["MaKhach"] = ct.MaKhach;
            d["NgayBan"] = ct.NgayBan;
            d["GiamGia"] = ct.GiamGia;
            d["TongTien"] = ct.TongTien;

            ds.Tables[0].Rows.Add(d);

            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
        }
        
        public float GiamGia(string ma)
        {
            string q = "select Diem from KhachHang where KhachHang.MaKhach='" + ma + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(q, conn);
            int diem = (int)cmd.ExecuteScalar();
            conn.Close();
            if (diem < 50)
                return 0;
            else
                return (float)0.1;
        }

        public int SoLuongKH()
        {
            return ds.Tables[0].Rows.Count;
        }

    }
}
