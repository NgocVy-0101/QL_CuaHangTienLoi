using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DTO;
using QuanLiCuaHangTienLoi_DAL;

namespace QuanLiCuaHangTienLoi_BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hd = new HoaDonDAL();
        public List<HoaDonDTO> HoaDon()
        {
            return hd.HoaDon();
        }
        public string MaHoaDon()
        {
            return hd.MaHoaDon();
        }
        public void Them(HoaDonDTO h)
        {
            hd.Them(h);
        }
        public float GiamGia(string ma)
        {
            return hd.GiamGia(ma);
        }
    }
}
