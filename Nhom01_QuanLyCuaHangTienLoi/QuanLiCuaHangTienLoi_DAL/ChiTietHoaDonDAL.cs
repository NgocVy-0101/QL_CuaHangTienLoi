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
    public class ChiTietHoaDonDAL
    {
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter adap;
        public ChiTietHoaDonDAL()
        {
            string s = KetNoi.conn;
            conn = new SqlConnection(s);
        }
        public List<ChiTietHoaDonDTO> ChiTiet()
        {
            List<ChiTietHoaDonDTO> k = new List<ChiTietHoaDonDTO>();
            string sql = "select * from ChiTietHoaDon";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(ds, "ChiTietHoaDon");

            ////Thêm khóa chính
            //DataColumn[] key = new DataColumn[1];
            //key[0] = ds.Tables["HoaDon"].Columns[0];
            //ds.Tables["HoaDon"].PrimaryKey = key;

            foreach (DataRow i in ds.Tables["ChiTietHoaDon"].Rows)
            {
                string ma = i[0].ToString();
                string ten = i[1].ToString();
                int sl = int.Parse(i[2].ToString());
                float tt = float.Parse(i[3].ToString());
                ChiTietHoaDonDTO o = new ChiTietHoaDonDTO(ma,ten,sl,tt);
                k.Add(o);
            }

            return k;
        }

        public void Them(ChiTietHoaDonDTO ct)
        {
            foreach (DataRow i in ds.Tables[0].Rows)
            {
                if (i[0].ToString() == ct.MaHoaDon && i[1].ToString() == ct.MaSanPham)
                {
                    return;
                }
            }

            DataRow d = ds.Tables[0].NewRow();
            d["MaHoaDon"] = ct.MaHoaDon;
            d["MaSanPham"] = ct.MaSanPham;
            d["SoLuong"] = ct.SoLuong;
            d["ThanhTien"] = ct.ThanhTien;

            ds.Tables[0].Rows.Add(d);

            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
        }

        public int SoLuongSanPhamDaban()
        {
            int sl = 0;
            sl = ds.Tables[0].Rows.Count;
            return sl;
        }
    }
}
