using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DAL;
using QuanLiCuaHangTienLoi_DTO;

namespace QuanLiCuaHangTienLoi_BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nv = new NhanVienDAL();
        public List<NhanVienDTO> NhanVien()
        {
            return nv.NhanVien();
        }
    }
}
