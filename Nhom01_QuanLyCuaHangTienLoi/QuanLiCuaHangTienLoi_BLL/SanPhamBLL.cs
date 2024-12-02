using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DAL;
using QuanLiCuaHangTienLoi_DTO;

namespace QuanLiCuaHangTienLoi_BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL sp = new SanPhamDAL();
        public List<SanPhamDTO> SanPham()
        {
            return sp.SanPham();
        }
        public bool Them(SanPhamDTO s)
        {
            return sp.Them(s);
        }
        public bool Sua(SanPhamDTO s)
        {
            return sp.Sua(s);
        }
        public bool Xoa(SanPhamDTO s)
        {
            return sp.Xoa(s);
        }
        public void CapNhatSoLuong(string ma, int sl)
        {
            sp.CapNhatSoLuong(ma, sl);
        }

        public string MaSP()
        {
            return sp.MaSP();
        }    
    }
}
