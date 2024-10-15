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
      
    }
}
