using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DAL;
using QuanLiCuaHangTienLoi_DTO;

namespace QuanLiCuaHangTienLoi_BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL dal = new KhachHangDAL();
        public List<KhachHangDTO> KhachHang()
        {
            return dal.KhachHang();
        }

        public bool ThemKhachHang(KhachHangDTO kh)
        {
            return dal.ThemKhachHang(kh);
        }

        public bool CapNhatKhachHang(KhachHangDTO kh)
        {
            return dal.CapNhatKhachHang(kh);
        }

        public bool XoaKhachHang(string maKhach)
        {
            return dal.XoaKhachHang(maKhach);
        }
        public void TichDiem(string ma,int x)
        {
            dal.TichDiem(ma,x);
        }
        public string MaKH()
        {
            return dal.MaKH();
        }
    }
}
