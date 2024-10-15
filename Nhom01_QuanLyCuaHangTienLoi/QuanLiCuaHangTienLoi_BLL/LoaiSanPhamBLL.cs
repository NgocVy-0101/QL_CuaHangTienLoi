using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DAL;
using QuanLiCuaHangTienLoi_DTO;

namespace QuanLiCuaHangTienLoi_BLL
{
    public class LoaiSanPhamBLL
    {
        LoaiSanPhamDAL l = new LoaiSanPhamDAL();
        public List<LoaiSanPhamDTO> LoaiSP()
        {
            return l.LoaiSP();
        }
    }
}
