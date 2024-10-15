using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHangTienLoi_DTO;
using QuanLiCuaHangTienLoi_DAL;

namespace QuanLiCuaHangTienLoi_BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL ncc = new NhaCungCapDAL();
        public List<NhaCungCapDTO> NhaCungCap()
        {
            return ncc.NhaCungCap();
        }
    }
}
