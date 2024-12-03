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
            string s = KetNoi.conn;
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
                string mloai = i["MaLoaiSanPham"].ToString();
                string mncc = i["MaNCC"].ToString();
                string gi = i["GhiChu"].ToString();
                DateTime nsx = (DateTime)i["NgaySanXuat"];
                DateTime nhh = (DateTime)i["NgayHetHan"];
                string xx = i["XuatXu"].ToString();
                SanPhamDTO o = new SanPhamDTO(ma,ten,sl,gn,gb,nsx,nhh,xx,mloai,mncc,gi);
                k.Add(o);
            }

            return k;
        }
        public bool Them(SanPhamDTO sp)
        {
            DataRow dr = ds.Tables[0].Rows.Find(sp.MaSanPham);
            if (dr != null)
                return false;

            DataRow n = ds.Tables[0].NewRow();
            n["MaSanPham"] = sp.MaSanPham;
            n["TenSanPham"] = sp.TenSanPham;
            n["SoLuongCon"] = sp.SoLuongCon;
            n["GiaNhap"] = sp.GiaNhap;
            n["GiaBan"] = sp.GiaBan;
            n["NgaySanXuat"] = sp.NgaySanXuat;
            n["NgayHetHan"] = sp.NgayHetHan;
            n["XuatXu"] = sp.XuatXu;
            n["MaLoaiSanPham"] = sp.MaLoaiSanPham;
            n["MaNCC"] = sp.MaNCC;
            n["GhiChu"] = sp.GhiChu;

            ds.Tables[0].Rows.Add(n);//Them dong vua roi vao dataset

            SqlCommandBuilder cb = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);//Luu lại xuống database
            return true;
        }
        public bool Sua(SanPhamDTO sp)
        {
            DataRow n = ds.Tables[0].Rows.Find(sp.MaSanPham);
            if (n == null)
                return false;

            n["TenSanPham"] = sp.TenSanPham;
            n["SoLuongCon"] = sp.SoLuongCon;
            n["GiaNhap"] = sp.GiaNhap;
            n["GiaBan"] = sp.GiaBan;
            n["NgaySanXuat"] = sp.NgaySanXuat;
            n["NgayHetHan"] = sp.NgayHetHan;
            n["XuatXu"] = sp.XuatXu;
            n["MaLoaiSanPham"] = sp.MaLoaiSanPham;
            n["MaNCC"] = sp.MaNCC;
            n["GhiChu"] = sp.GhiChu;

            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
            return true;
        }
        public bool Xoa(SanPhamDTO sp)
        {
            DataRow d = ds.Tables[0].Rows.Find(sp.MaSanPham);
            if (d == null)
                return false;

            d.Delete();

            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
            return true;
        }

        public void CapNhatSoLuong(string ma, int sl)
        {
            DataRow d = ds.Tables[0].Rows.Find(ma);
            if (d != null)
            {
                int cn = int.Parse(d["SoLuongCon"].ToString()) - sl;
                d["SoLuongCon"] = cn;
            }
            SqlCommandBuilder c = new SqlCommandBuilder(adap);
            adap.Update(ds.Tables[0]);
        }

        public string MaSP()
        {
            string ma = "";

            var HD = ds.Tables[0].AsEnumerable()
                .Where(row => row[0].ToString().StartsWith("SP"))
                .Select(row => row[0].ToString())
                .ToList();

            int invoiceNumber = 1;
            if (HD.Count > 0)
            {
                var lastInvoice = HD.Max();
                var lastNumber = int.Parse(lastInvoice.Substring(lastInvoice.Length - 3));
                invoiceNumber = lastNumber + 1;
            }

            ma = "SP" + invoiceNumber.ToString("D3");

            return ma;
        }

        public List<SanPhamDTO> TopSP()
        {
            List<SanPhamDTO> lst = new List<SanPhamDTO>();
            string query = @"SELECT sp.*, 
                   SUM(ct.ThanhTien) AS TongThanhTien
            FROM ChiTietHoaDon ct
            JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham
            GROUP BY sp.MaSanPham, sp.TenSanPham, sp.SoLuongCon, sp.GiaNhap, sp.GiaBan, 
                     sp.NgaySanXuat, sp.NgayHetHan, sp.XuatXu, sp.MaLoaiSanPham, 
                     sp.MaNCC, sp.GhiChu
            ORDER BY TongThanhTien DESC;";
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow i in dt.Rows)
            {
                string ma = i["MaSanPham"].ToString();
                string ten = i["TenSanPham"].ToString();
                int sl = (int)i["SoLuongCon"];
                float gn = Convert.ToSingle(i["GiaNhap"]);
                float gb = Convert.ToSingle(i["GiaBan"]);
                string mloai = i["MaLoaiSanPham"].ToString();
                string mncc = i["MaNCC"].ToString();
                string gi = i["GhiChu"].ToString();
                DateTime nsx = (DateTime)i["NgaySanXuat"];
                DateTime nhh = (DateTime)i["NgayHetHan"];
                string xx = i["XuatXu"].ToString();
                SanPhamDTO o = new SanPhamDTO(ma, ten, sl, gn, gb, nsx, nhh, xx, mloai, mncc, gi);
                lst.Add(o);
            }
            conn.Close();
            return lst;
        }
    }
}
