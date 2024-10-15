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
            string s = @"Data Source=LAPTOP-SF87IO3T\PHAMVU;Initial Catalog=QLCHTL;Integrated Security=True";
            conn = new SqlConnection(s);
        }
        public List<HoaDonDTO> HoaDon()
        {
            List<HoaDonDTO> k = new List<HoaDonDTO>();
            string sql = "select hd.MaHoaDon, hd.MaNhanVien, hd.MaKhach, ct.MaSanPham, ct.SoLuong, hd.NgayBan, ct.ThanhTien, hd.TongTien from HoaDon hd,ChiTietHoaDon ct where hd.MaHoaDon = ct.MaHoaDon";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(ds, "HoaDon");

            ////Thêm khóa chính
            //DataColumn[] key = new DataColumn[1];
            //key[0] = ds.Tables["HoaDon"].Columns[0];
            //ds.Tables["HoaDon"].PrimaryKey = key;

            foreach (DataRow i in ds.Tables["HoaDon"].Rows)
            {
                string mhd = i["MaHoaDon"].ToString();
                string mnv = i["MaNhanVien"].ToString();
                string mk = i["MaKhach"].ToString();
                string msp = i["MaSanPham"].ToString();
                int sl = (int)i["SoLuong"];
                DateTime nb = (DateTime)i["NgayBan"];
                float tt = Convert.ToSingle(i["ThanhTien"]);
                float tong = Convert.ToSingle(i["TongTien"]);
                HoaDonDTO o = new HoaDonDTO(mhd,mnv,mk,msp,sl,nb,tt,tong);
                k.Add(o);
            }

            return k;
        }
    }
}
