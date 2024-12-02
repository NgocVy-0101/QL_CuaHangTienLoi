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
        public bool Them(NhaCungCapDTO sp)
        {
            return ncc.Them(sp);
        }
        public bool Sua(NhaCungCapDTO sp)
        {
            return ncc.Sua(sp);
        }
        public bool Xoa(NhaCungCapDTO sp)
        {
            return ncc.Xoa(sp);
        }
        public string MaNCC()
        {
            return ncc.MaNCC();
        }    
    }
}
