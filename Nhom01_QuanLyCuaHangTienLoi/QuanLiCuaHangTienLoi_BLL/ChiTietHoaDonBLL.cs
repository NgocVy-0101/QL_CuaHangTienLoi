using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DTO;
using QuanLiCuaHangTienLoi_DAL;

namespace QuanLiCuaHangTienLoi_BLL
{
    public class ChiTietHoaDonBLL
    {
        ChiTietHoaDonDAL ct = new ChiTietHoaDonDAL();
        public List<ChiTietHoaDonDTO> ChiTiet()
        {
            return ct.ChiTiet();
        }
        public void Them(ChiTietHoaDonDTO c)
        {
            ct.Them(c);
        }
        public int SoLuongSanPhamDaban()
        {
            return ct.SoLuongSanPhamDaban();
        }
    }
}
